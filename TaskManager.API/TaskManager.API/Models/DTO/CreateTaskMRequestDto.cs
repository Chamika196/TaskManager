using System.ComponentModel.DataAnnotations;

namespace TaskManager.API.Models.DTO
{
    public class CreateTaskMRequestDto
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
