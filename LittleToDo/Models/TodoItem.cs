using System;
using System.ComponentModel.DataAnnotations;

namespace LittleToDo.Models
{
    public class TodoItem
    {
        public Guid id { get; set; }
        public bool isDone { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
        public string UserId { get; set; } 

    }
}
