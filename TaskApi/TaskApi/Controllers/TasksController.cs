using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
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

        public TasksController(TaskApiDbContext context)
        {
            _context = context;
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

                return Ok(tasks);
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

                return Ok(task);
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

                var taskEntity = new Task
                {
                    Body = taskModel.Body,
                    HasCompleted =  taskModel.HasCompleted,
                    CategoryId =  taskModel.CategoryId
                };
                
                _context.Tasks.Add(taskEntity);
                _context.SaveChanges();

                return CreatedAtRoute(nameof(GetTaskById), new { id = taskEntity.TaskId }, taskModel);
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

                task.Body = taskModel.Body;
                task.CategoryId = taskModel.CategoryId;
                task.HasCompleted = taskModel.HasCompleted;
                task.LastModified = DateTime.Now;
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