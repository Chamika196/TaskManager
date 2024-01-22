using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Models.Domain;
using TaskManager.API.Models.DTO;
using TaskManager.API.Repositories.Interface;


namespace TaskManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskMsController : ControllerBase
    {
        private readonly ITaskMRepository taskMRepository;

        public TaskMsController(ITaskMRepository taskMRepository)
        {
            this.taskMRepository = taskMRepository;
        }


        /// Creates a new TaskM.
        //https://localhost:7278/api/TaskMs
        [HttpPost]
        public async Task<IActionResult> CreateTaskM([FromBody] CreateTaskMRequestDto request)
        {
            try
            {
                // Map DTO to Domain Model
                var taskM = new TaskM
                {
                    Title = request.Title,
                    Description = request.Description,
                    DueDate = request.DueDate,
                };

                await taskMRepository.CreateAsync(taskM);

                // Map Domain model to DTO
                var response = new TaskMDto
                {
                    Id = taskM.Id,
                    Description = taskM.Description,
                    DueDate = taskM.DueDate,
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }


        /// Retrieves a list of all TaskMs.
        //https://localhost:7278/api/TaskMs
        [HttpGet]
        public async Task<IActionResult> GetAllTaskM()
        {
            try
            {
                var taskMs = await taskMRepository.GetAllAsync();

                // Return an empty list if no tasks are found
                if (taskMs == null || !taskMs.Any())
                {
                    return Ok(new List<TaskMDto>());
                }

                // Map Domain model to DTO
                var response = new List<TaskMDto>();
                foreach (var taskM in taskMs)
                {
                    response.Add(new TaskMDto
                    {
                        Id = taskM.Id,
                        Title = taskM.Title,
                        Description = taskM.Description,
                        DueDate = taskM.DueDate.Date,
                    });
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }


        /// Retrieves a TaskM by its ID.
        //https://localhost:7278/api/TaskMs/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetTaskMById([FromRoute] int id)
        {
            try
            {
                var existingTaskM = await taskMRepository.GetById(id);
                if (existingTaskM == null)
                {
                    return NotFound();
                }

                // Map Domain model to DTO
                var response = new TaskMDto
                {
                    Id = existingTaskM.Id,
                    Title = existingTaskM.Title,
                    Description = existingTaskM.Description,
                    DueDate = existingTaskM.DueDate,
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }


        /// Updates an existing TaskM by its ID.
        //https://localhost:7278/api/TaskMs/{id}
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> EditTaskM([FromRoute] int id, UpdateTaskMRequestDto request)
        {
            try
            {
                // Map DTO to Domain Model
                var taskM = new TaskM
                {
                    Id = id,
                    Title = request.Title,
                    Description = request.Description,
                    DueDate = request.DueDate.Date,
                };

                taskM = await taskMRepository.UpdateAsync(taskM);

                if (taskM == null)
                {
                    return NotFound();
                }

                // Convert Domain model to DTO
                var response = new TaskMDto
                {
                    Id = taskM.Id,
                    Title = taskM.Title,
                    Description = taskM.Description,
                    DueDate = taskM.DueDate.Date,
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }


        /// Deletes a TaskM by its ID.
        //https://localhost:7278/api/TaskMs/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteTaskM([FromRoute] int id)
        {
            try
            {
                var taskM = await taskMRepository.DeleteAsync(id);
                if (taskM == null)
                {
                    return NotFound();
                }

                // Convert Domain model to DTO
                var response = new TaskMDto
                {
                    Id = taskM.Id,
                    Title = taskM.Title,
                    Description = taskM.Description,
                    DueDate = taskM.DueDate.Date,
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
    }
}
