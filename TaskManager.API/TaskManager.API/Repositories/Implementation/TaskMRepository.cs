using Microsoft.EntityFrameworkCore;
using TaskManager.API.Data;
using TaskManager.API.Models.Domain;
using TaskManager.API.Repositories.Interface;

namespace TaskManager.API.Repositories.Implementation
{
    public class TaskMRepository : ITaskMRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TaskMRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<TaskM> CreateAsync(TaskM taskm)
        {
            await dbContext.TaskMs.AddAsync(taskm);
            await dbContext.SaveChangesAsync();

            return taskm;
        }

        public async Task<TaskM?> DeleteAsync(int id)
        {
            var existingTaskM = await dbContext.TaskMs.FirstOrDefaultAsync(x => x.Id == id); 
            if (existingTaskM is null)
            {
                return null;
            }

            dbContext.TaskMs.Remove(existingTaskM);
            await dbContext.SaveChangesAsync();
            return existingTaskM;
        }

        public async Task<IEnumerable<TaskM>> GetAllAsync()
        {
            return await dbContext.TaskMs.ToListAsync();
        }

        public async Task<TaskM?> GetById(int id)
        {
            return await dbContext.TaskMs.FirstOrDefaultAsync(x=>x.Id == id); 
        }

        public async Task<TaskM?> UpdateAsync(TaskM taskM)
        {
            var existingTaskM = await dbContext.TaskMs.FirstOrDefaultAsync(x => x.Id == taskM.Id);

            if(existingTaskM != null)
            {
                dbContext.Entry(existingTaskM).CurrentValues.SetValues(taskM);
                await dbContext.SaveChangesAsync();
                return taskM;
            }

            return null;
        }
    }
}
