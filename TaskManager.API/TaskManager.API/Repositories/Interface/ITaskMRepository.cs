using TaskManager.API.Models.Domain;
using TaskManager.API.Models.DTO;

namespace TaskManager.API.Repositories.Interface
{
    public interface ITaskMRepository
    {
        
        Task<TaskM> CreateAsync(TaskM task);
        Task<IEnumerable<TaskM>> GetAllAsync();
        Task<TaskM?> GetById (int id);
        Task<TaskM?> UpdateAsync (TaskM taskM);
        Task<TaskM?> DeleteAsync(int id);
        //Task<TaskMDto> UpdateAsync(TaskMDto taskM);
    }
}
