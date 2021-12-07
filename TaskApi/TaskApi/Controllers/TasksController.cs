using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskApi.Data.Entities;
using TaskApi.Data.Models;

namespace TaskApi.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly TaskApiDbContext _context;
        private readonly IMapper _mapper;

        public TasksController(TaskApiDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        
        
        [HttpGet]
        public IActionResult GetTask([FromQuery] string category)
        {
            try
            {
                var query = _context.Tasks
                    .AsNoTracking()
                    .Include(t => t.Category)
                    .AsQueryable();

                if (!string.IsNullOrEmpty(category))
                    query = query.Where(t => t.Category.Name.ToLower() == category.ToLower());
                
                var tasks = query.ToList();

                
                return Ok(_mapper.Map<IEnumerable<Task>, IEnumerable<TaskModel>>(tasks));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        
        [HttpGet("{id:int}", Name="GetTaskById")]
        public IActionResult GetTaskById(int id)
        {
            try
            {
                var task = _context.Tasks
                    .AsNoTracking()
                    .Include(t => t.Category)
                    .FirstOrDefault(t => t.TaskId == id);

                if (task is null)
                    return NotFound();

                return Ok(_mapper.Map<TaskModel>(task));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        
        
        [HttpDelete("{id:int}")]
        public IActionResult DeleteTask(int id)
        {
            try
            {
                var task = _context.Tasks.FirstOrDefault(t => t.TaskId == id);

                if (task == null)
                    return NotFound();

                _context.Tasks.Remove(task);
                _context.SaveChanges();

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        
        [HttpPost]
        public IActionResult CreateTask([FromBody] TaskForCreationModel taskModel)
        {
            try
            {
                if (taskModel == null)
                    return BadRequest("Task object cannot be null");

                var taskEntity = _mapper.Map<Task>(taskModel);

                _context.Tasks.Add(taskEntity);
                _context.SaveChanges();

                var results = _mapper.Map<TaskModel>(taskEntity);

                return CreatedAtRoute(nameof(GetTaskById), new { id = results.Id }, results);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        
        [HttpPut("{id:int}")]
        public IActionResult UpdateTask(int id, [FromBody] TaskForUpdateModel taskModel)
        {
            try
            {
                if (taskModel == null)
                    return BadRequest();

                var task = _context.Tasks.Find(id);
                if (task == null)
                    return NotFound();

                _mapper.Map<TaskForUpdateModel, Task>(taskModel, task);
                _context.SaveChanges();
                
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPatch("{id:int}")]
        public IActionResult PartialUpdateTask(int id, [FromBody] JsonPatchDocument<TaskForUpdateModel> patchDoc)
        {
            try
            {
                if (patchDoc == null)
                    return BadRequest("patch object cannot be null");

                var task = _context.Tasks.Find(id);

                if (task == null)
                    return NotFound();

                var taskUpdateModel = _mapper.Map<TaskForUpdateModel>(task);
                
                
                patchDoc.ApplyTo(taskUpdateModel);

                _mapper.Map<TaskForUpdateModel, Task>(taskUpdateModel, task);

                _context.SaveChanges();

                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}