using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using dotnettodo.Models;

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

                context.ToDoTasks.AddRange(
                     new ToDoTask
                     {
                         Title = "When Harry Met Sally",
                         Done = false
                     },
                     new ToDoTask
                     {
                         Title = "When Harry Met Sally",
                         Done = false
                     },
                     new ToDoTask
                     {
                         Title = "When Harry Met Sally",
                         Done = false
                     },
                     new ToDoTask
                     {
                         Title = "When Harry Met Sally",
                         Done = false
                     },
                     new ToDoTask
                     {
                         Title = "When Harry Met Sally",
                         Done = false
                     }

                );
                context.SaveChanges();
            }
        }
    }
}