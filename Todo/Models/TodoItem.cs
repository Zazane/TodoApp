using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description of the task")]
        public string Task { get; set; } = string.Empty;

        public bool Completed { get; set; } = false;
    }
}
