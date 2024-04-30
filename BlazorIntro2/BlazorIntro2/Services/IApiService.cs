using BlazorIntro2.Models;

namespace BlazorIntro2.Services
{
    public interface IApiService
    {
        public Task<TodoItem[]> GetTodos();
    }
}
