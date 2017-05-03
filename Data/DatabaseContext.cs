using dotnettodo.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnettodo.Data{

    public class DatabaseContext: DbContext{

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){
        }

        public DbSet<ToDoTask> ToDoTasks { get; set; }
    }
}