using Microsoft.EntityFrameworkCore;
using Rest_Example.Model;

namespace Rest_Example.Repository
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> opt) : base(opt)
        {

        }

        public DbSet<Task> Tasks { get; set; }
    }
}