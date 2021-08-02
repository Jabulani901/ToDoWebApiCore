using Microsoft.EntityFrameworkCore;

namespace MyToDoWebApi.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
          : base(options)
        {
        }

        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}

