using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ApiFrontend.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiFrontend.Controllers
{

    public class ApiController : Controller
    {
        //INDEX
        private static HttpClient httpClient = new HttpClient();
        public ApiController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }



        // CoinStat
        [HttpGet]
        public async Task<IActionResult> CoinStat_All()
        {
            // httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));
            var response = await httpClient.GetAsync(Configuration.GetValue<string>("coinstat"));
            var content = await response.Content.ReadAsStringAsync();

            var Api = new List<Api>();
            // if (response.Content.Headers.ContentType.MediaType == "application/json")
            // {
            Api = JsonConvert.DeserializeObject<List<Api>>(content);
            // }
            return View(Api);
        }



        // CoinLore
        [HttpGet]
        public async Task<IActionResult> CoinLore_Individual()
        {
            // httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", HttpContext.Session.GetString("token"));
            var response = await httpClient.GetAsync(Configuration.GetValue<string>("coinlore"));
            var content = await response.Content.ReadAsStringAsync();

            var Api = new List<Api>();
            // if (response.Content.Headers.ContentType.MediaType == "application/json")
            // {
            Api = JsonConvert.DeserializeObject<List<Api>>(content);
            // }
            return View(Api);
        }

    }
}
