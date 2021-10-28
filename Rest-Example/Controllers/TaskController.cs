using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rest_Example.Repository;
using Microsoft.AspNetCore.JsonPatch;
using System.Linq;
using Rest_Example.DTO;
using Rest_Example.Model;
using System;

namespace Rest_Example.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepo _repository;
        private readonly IMapper _mapper;

        public TaskController(ITaskRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Task>> GetTasks()
        {
            var taskItems = _repository.GetAllTasks();
            return Ok(taskItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Task> GetTaskByID(int id)
        {
            var task = _repository.GetTaskById(id);
            return Ok(task);
        }

        [HttpPost]
        public ActionResult<Task> CreateTask(Task task)
        {
            _repository.CreateTask(task);
            _repository.SaveChanges();
            return Ok(task);
        }

        [HttpPut("{id}")]
        public ActionResult<Task> UpdateTask(int id, Task task)
        {
            if (task == null)
            {
                return NotFound();
            }
            _repository.UpdateTask(task);
            _repository.SaveChanges();

            return NoContent();
        }
    }


}