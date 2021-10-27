using System;
using System.Threading.Tasks;
using LittleToDo.Models;

namespace LittleToDo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}
