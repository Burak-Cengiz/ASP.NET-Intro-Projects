using BlazorIntro2.Models;
using System.Net.Http.Json;
using static BlazorIntro2.Pages.Todo;

namespace BlazorIntro2.Services
{
    public class JsonPlaceHolderApi:IApiService
    {
        private HttpClient _http;
        
        public JsonPlaceHolderApi(HttpClient http)
        {
            _http = http;
        }
        public Task<TodoItem[]> GetTodos()
        {
            return _http.GetFromJsonAsync<TodoItem[]>("https://jsonplaceholder.typicode.com/todos");
        }
    }
}
