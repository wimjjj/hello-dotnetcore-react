using System;
using System.ComponentModel.DataAnnotations;

namespace dotnettodo.Models{

    public class ToDoTask{

        public int ID { set; get ; }

        [Required]
        public string Title { get; set; }
       
        [Required]
        public Boolean Done {get; set; }
    }
}