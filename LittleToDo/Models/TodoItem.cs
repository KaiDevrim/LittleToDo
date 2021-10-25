using System;
using System.ComponentModel.DataAnnotations;

namespace LittleToDo.Models
{
    public class TodoItem
    {
        public Guid id { get; set; }
        public bool isDone { get; set; }

        [Required]

    }
}
