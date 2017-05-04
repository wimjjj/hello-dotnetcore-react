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
    public class LabelController : Controller{
        private readonly DatabaseContext context;

        public LabelController(DatabaseContext context){
            this.context = context;
        }

        [HttpGetAttribute("/api/labels")]
        public IActionResult index(){
            return new OkObjectResult(context.Labels.ToList());
        }

        [HttpPostAttribute]
        [RouteAttribute("/api/labels")]
        public IActionResult store([FromBodyAttribute] Label label){
            if(!ModelState.IsValid){
                return BadRequest();
            }

            context.Labels.Add(label);
            context.SaveChanges();

            return StatusCode(201);
        }

        [HttpPostAttribute]
        [RouteAttribute("/api/labels/delete/{id}")]
        public IActionResult delete(int id){
            //first remove all the task with this label
            context.ToDoTasks.RemoveRange(context.ToDoTasks.Where(t => t.LabelID == id).ToList());

            
            context.Labels.Remove(context.Labels.Find(id));
            context.SaveChanges();

            return StatusCode(204);
        }
    }
}