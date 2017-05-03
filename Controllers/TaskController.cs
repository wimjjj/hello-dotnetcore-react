using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnettodo.Data;
using dotnettodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnettodo.Controllers
{
    public class TaskController : Controller
    {
        private readonly DatabaseContext context;

        public TaskController(DatabaseContext context){
            this.context = context;
        }

        [HttpGetAttribute("/api/tasks")]
        public IActionResult Index()
        {
            List<ToDoTask> tasks = context.ToDoTasks.Include(t => t.label).ToList();
            return new ObjectResult(tasks);
        }

        [HttpPostAttribute]
        [RouteAttribute("/api/tasks")]
        public IActionResult store([FromBodyAttribute] ToDoTask task){
            if(!ModelState.IsValid){
                return BadRequest();
            }

            context.ToDoTasks.Add(task);
            context.SaveChanges();

            return StatusCode(201);
        }

        [HttpPostAttribute]
        [RouteAttribute("/api/tasks/{id}")]
        public IActionResult update(int id, [FromBodyAttribute] ToDoTask task){
            if(!ModelState.IsValid || task.ID != id){
                return BadRequest();
            }

            context.Update(task);
            context.SaveChanges();

            return Ok();
        }

        [HttpPostAttribute]
        [RouteAttribute("/api/tasks/delete/{id}")]
        public IActionResult delete(int id){
            context.ToDoTasks.Remove(context.ToDoTasks.Find(id));
            context.SaveChanges();
            return StatusCode(204);
        }
    }
}
