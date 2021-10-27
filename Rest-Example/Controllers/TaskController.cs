using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rest_Example.Repository;
using Microsoft.AspNetCore.JsonPatch;
using System.Linq;
using System.Threading.Tasks;
using Rest_Example.DTO;

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
            // return Ok(_mapper.Map<IEnumerable<Task>>(taskItems));
            return Ok(taskItems);
        }
    }


}