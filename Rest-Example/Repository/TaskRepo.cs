using System;
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

        public void CreateTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }
            _context.Tasks.Add(task);
        }

        public void UpdateTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }
            _context.Tasks.Update(task);
        }

        public void DeleteTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentException(nameof(task));

            }
            _context.Tasks.Remove(task);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}