using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WPF_TimeTracker_2._0_.Model;

public class ApiService
{
    private static readonly HttpClient client = new HttpClient();

    public async Task<List<CategoryModel>> GetCategoriesAsync()
    {
        HttpResponseMessage response = await client.GetAsync("http://localhost:3000/api/categories");
        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<CategoryModel>>(responseBody);
        }
        return null;
    }

    public async Task AddCategoryAsync(CategoryModel category)
    {
        string json = JsonConvert.SerializeObject(category);
        StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
        HttpResponseMessage response = await client.PostAsync("http://localhost:3000/api/categories", content);
        response.EnsureSuccessStatusCode();
    }

    public async Task DeleteCategoryAsync(string categoryId)
    {
        HttpResponseMessage response = await client.DeleteAsync($"http://localhost:3000/api/categories/{categoryId}");
        response.EnsureSuccessStatusCode();
    }
}
