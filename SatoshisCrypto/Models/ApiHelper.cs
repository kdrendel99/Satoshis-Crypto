// using System.Threading.Tasks;
// using RestSharp;

// namespace SatoshisCrypto.Models
// {
//   class ApiHelper // this is where the api call is defined
//   {
//     public static async Task<string> GetAll()
//     {
//       RestClient client = new RestClient("https://api.pushshift.io");
//       RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&fields=body&size=10", Method.GET);
//       var response = await client.ExecuteTaskAsync(request);

//       return response.Content;
//     }
//   }
// }
