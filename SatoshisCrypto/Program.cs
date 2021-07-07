using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

using SatoshisCrypto.Models;

namespace SatoshisCrypto
{
    public class Program
    {
        // public static void Main(string[] args)
        // {
        //     CreateHostBuilder(args).Build().Run();
        // }
        static void Main()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;
            // Console.WriteLine(result);
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            List<Comment> commentList = JsonConvert.DeserializeObject<List<Comment>>(jsonResponse["data"].ToString());

            foreach (Comment comment in commentList)
            {
                Console.WriteLine($"Body: {comment.Body}");
                Console.WriteLine($"Created Time: {comment.CreatedTime}");
                Console.WriteLine($"Created Time2: {comment.Created_Utc}");
            }

        }
        // public static IHostBuilder CreateHostBuilder(string[] args) =>
        //     Host.CreateDefaultBuilder(args)
        //         .ConfigureWebHostDefaults(webBuilder =>
        //         {
        //             webBuilder.UseStartup<Startup>();
        //         });


    }

    class ApiHelper
    {
        public static async Task<string> GetAll()
        {
        RestClient client = new RestClient("https://api.pushshift.io");
        RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&size=10", Method.GET);
        var response = await client.ExecuteTaskAsync(request);

        return response.Content;
        }
    }
}
