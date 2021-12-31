using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LittleToDo.Data;
using LittleToDo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LittleToDo.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ApplicationDbContext _context;

        public TodoItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem[]> GetIncompleteItemsAsync(IdentityUser user)
        {
            return await _context.Items
                .Where(x => x.isDone == false && x.UserId == user.Id)
                .ToArrayAsync();
        }

        public async Task<bool> AddItemAsync(TodoItem newItem, IdentityUser user)
        {
            newItem.id = Guid.NewGuid();
            // newItem.DueAt = DateTimeOffset.Now.AddDays(3);
            newItem.isDone = false;
            newItem.UserId = user.Id;

            _context.Items.Add(newItem);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

        public async Task<bool> MarkDoneAsync(Guid id, IdentityUser user)
        {
            var item = await _context.Items
                .Where(x => x.id == id && x.UserId == user.Id)
                .SingleOrDefaultAsync();

            if (item == null) return false;
            item.isDone = true;

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}
