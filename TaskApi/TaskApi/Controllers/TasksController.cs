using Microsoft.AspNetCore.Mvc;
using TaskApi.Data.Entities;

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
        public IActionResult GetTask()
        {
            return Ok("it works");
        }
    }
}