using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WinShoeStore.Models;

namespace WinShoeStore.Controllers
{
    public class ArticlesController
    {
        private static readonly HttpClient client = new HttpClient();

        //public async Task<Articles> GetArticlesAsync()
        public async Task<List<Article>> GetArticlesAsync()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:44307/api/Articles");

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                List<Article> articles = JsonConvert.DeserializeObject<List<Article>>(responseBody);

                return articles;
                //Articles articles = new Articles();
                //HttpResponseMessage response = await client.GetAsync("https://localhost:44307/api/Articles"); 

                //response.EnsureSuccessStatusCode();

                // string responseBody = await response.Content.ReadAsStringAsync();

                //articles = JsonConvert.DeserializeObject<Articles>(responseBody);

                //return articles;

                //var response = await client.GetStringAsync("http://localhost:5000/api/articles");
                //return JsonConvert.DeserializeObject<List<Article>>(response) ?? new List<Article>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> AddArticleAsync(Article article)
        {
            var json = JsonConvert.SerializeObject(article);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://localhost:5000/api/articles", content);
            return response.IsSuccessStatusCode;
        }

    }
}