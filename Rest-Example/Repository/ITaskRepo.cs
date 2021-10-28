using System.Collections.Generic;
using Rest_Example.Model;

namespace Rest_Example.Repository
{
    public interface ITaskRepo
    {
        IEnumerable<Task> GetAllTasks();
        Task GetTaskById(int id);

        void CreateTask(Task task);
        void UpdateTask(Task task);
        bool SaveChanges();
    }
}