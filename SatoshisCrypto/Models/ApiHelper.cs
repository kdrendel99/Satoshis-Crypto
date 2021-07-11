using System.Threading.Tasks;
using RestSharp;

namespace SatoshisCrypto.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&size=10", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    // public static async Task<string> GetAll4hr()
    // {
    //   RestClient client = new RestClient("https://api.pushshift.io");
    //   RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&size=2@after=4h", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);

    //   return response.Content;
    // }
    // public static async Task<string> GetAll8hr()
    // {
    // RestClient client = new RestClient("https://api.pushshift.io");
    // RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&size=2@after=8h&before=4h", Method.GET);
    // var response = await client.ExecuteTaskAsync(request);

    // return response.Content;
    // }
    // public static async Task<string> GetAll12hr()
    // {
    // RestClient client = new RestClient("https://api.pushshift.io");
    // RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&size=100@after=12h&before=8h", Method.GET);
    // var response = await client.ExecuteTaskAsync(request);

    // return response.Content;
    // }
    // public static async Task<string> GetAll16hr()
    // {
    // RestClient client = new RestClient("https://api.pushshift.io");
    // RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&size=100@after=16h&before=12h", Method.GET);
    // var response = await client.ExecuteTaskAsync(request);

    // return response.Content;
    // }
    // public static async Task<string> GetAll20hr()
    // {
    // RestClient client = new RestClient("https://api.pushshift.io");
    // RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&size=100@after=20h&before=16h", Method.GET);
    // var response = await client.ExecuteTaskAsync(request);

    // return response.Content;
    // }
    // public static async Task<string> GetAll24hr()
    // {
    // RestClient client = new RestClient("https://api.pushshift.io");
    // RestRequest request = new RestRequest($"/reddit/search/comment/?q=BTC&subreddit=cryptocurrency&size=100@after=24h&before=20h", Method.GET);
    // var response = await client.ExecuteTaskAsync(request);

    // return response.Content;
    // }

  }

}