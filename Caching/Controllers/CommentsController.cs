using Caching.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Caching.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CommentsController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public CommentsController()
    {
        _httpClient = new HttpClient();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        string apiUrl = "https://jsonplaceholder.typicode.com/comments";
        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string responseBodyStr = await response.Content.ReadAsStringAsync();
            var responseBody = JsonConvert.DeserializeObject<List<Comment>>(responseBodyStr);
            return Ok(responseBody);
        }
        else
        {
            return StatusCode((int)response.StatusCode);
        }
    }
}
