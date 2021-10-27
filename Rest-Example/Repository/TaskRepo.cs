using System.Collections.Generic;
using System.Linq;
using Rest_Example.Model;

namespace Rest_Example.Repository
{
    public class TaskRepo : ITaskRepo
    {
        private readonly TaskContext _context;

        public TaskRepo(TaskContext context)
        {
            _context = context;
        }
        public IEnumerable<Task> GetAllTasks()
        {
            return _context.Tasks.ToList();
        }

        public Task GetTaskById(int id)
        {
            return _context.Tasks.FirstOrDefault(p => p.Id == id);
        }
    }
}