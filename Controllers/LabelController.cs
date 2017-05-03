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
    }
}