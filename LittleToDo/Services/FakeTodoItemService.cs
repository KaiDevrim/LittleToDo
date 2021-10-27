using System;
using System.Threading.Tasks;
using LittleToDo.Models;

namespace LittleToDo.Services
{
    public class FakeTodoItemService : ITodoItemService
    {
        public Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            var item1 = new TodoItem
            {
                Title = "Do Homework",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };
            var item2 = new TodoItem
            {
                Title = "Literally Nothing",
                DueAt = DateTimeOffset.Now.AddDays(100)
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
