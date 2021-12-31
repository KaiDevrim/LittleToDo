using System;
using System.Threading.Tasks;
using LittleToDo.Models;
using Microsoft.AspNetCore.Identity;

namespace LittleToDo.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser user);
        Task<bool> AddItemAsync(TodoItem newItem, IdentityUser user);
        Task<bool> MarkDoneAsync(Guid id, IdentityUser user);
    }
}
