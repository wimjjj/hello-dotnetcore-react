using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using dotnettodo.Models;
using System.Collections.Generic;

namespace dotnettodo.Data{

    public class SeedData{
         public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DatabaseContext(
                serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                // Look for any movies.
                if (context.ToDoTasks.Any())
                {
                    return;   // DB has been seeded
                }

                var label1 = new Label { Title = "School", Color = "lightgreen", ToDoTasks = new List<ToDoTask>() };
                var label2 = new Label { Title = "Work", Color = "lightblue", ToDoTasks = new List<ToDoTask>() };
                var label3 = new Label { Title = "Private", Color = "lightcoral", ToDoTasks = new List<ToDoTask>() };

                context.Labels.Add(label1);
                context.Labels.Add(label2);
                context.Labels.Add(label3);

                var task1 = new ToDoTask { Title = "Read Book", Done = false, LabelID = 1 };
                var task2 = new ToDoTask { Title = "Learn Stuff", Done = false, LabelID = 1 };
                var task3 = new ToDoTask { Title = "Make the Things", Done = false, LabelID = 1 };
                var task4 = new ToDoTask { Title = "Do Stuff", Done = false, LabelID = 2 };
                var task5 = new ToDoTask { Title = "Be Awesome", Done = false, LabelID = 3 };

                context.ToDoTasks.Add(task1);
                context.ToDoTasks.Add(task2);
                context.ToDoTasks.Add(task3);
                context.ToDoTasks.Add(task4);
                context.ToDoTasks.Add(task5);

                context.SaveChanges();
            }
        }
    }
}