using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnettodo.Models{

    public class Label{

        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Color { get; set; }

        public ICollection<ToDoTask> ToDoTasks { get; set; }
    }
}