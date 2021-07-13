using System;
using System.Threading.Tasks;
using RestSharp;

namespace SatoshisCrypto.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllBtc4hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"reddit/comment/search/?q=btc&subreddit=cryptocurrency&after=60h&before=56h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllBtc8hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=btc&subreddit=cryptocurrency&after=64h&before=60h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAllBtc12hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=btc&subreddit=cryptocurrency&after=68h&before=64h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllBtc16hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=btc&subreddit=cryptocurrency&after=72h&before=68h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllBtc20hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=btc&subreddit=cryptocurrency&after=76h&before=72h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllBtc24hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=btc&subreddit=cryptocurrency&after=80h&before=76h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllEth4hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"reddit/comment/search/?q=eth&subreddit=cryptocurrency&after=60h&before=56h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllEth8hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=eth&subreddit=cryptocurrency&after=64h&before=60h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAllEth12hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=eth&subreddit=cryptocurrency&after=68h&before=64h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllEth16hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=eth&subreddit=cryptocurrency&after=72h&before=68h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllEth20hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=eth&subreddit=cryptocurrency&after=76h&before=72h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllEth24hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=eth&subreddit=cryptocurrency&after=80h&before=76h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllAda4hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"reddit/comment/search/?q=ada&subreddit=cryptocurrency&after=60h&before=56h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllAda8hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=ada&subreddit=cryptocurrency&after=64h&before=60h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAllAda12hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=ada&subreddit=cryptocurrency&after=68h&before=64h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllAda16hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=ada&subreddit=cryptocurrency&after=72h&before=68h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllAda20hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=ada&subreddit=cryptocurrency&after=76h&before=72h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllAda24hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=ada&subreddit=cryptocurrency&after=80h&before=76h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }

        public static async Task<string> GetAllLink4hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"reddit/comment/search/?q=link&subreddit=cryptocurrency&after=60h&before=56h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllLink8hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=link&subreddit=cryptocurrency&after=64h&before=60h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAllLink12hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=link&subreddit=cryptocurrency&after=68h&before=64h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllLink16hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=link&subreddit=cryptocurrency&after=72h&before=68h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllLink20hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=link&subreddit=cryptocurrency&after=76h&before=72h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllLink24hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=link&subreddit=cryptocurrency&after=80h&before=76h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }


            public static async Task<string> GetAllDoge4hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"reddit/comment/search/?q=doge&subreddit=cryptocurrency&after=60h&before=56h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllDoge8hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=doge&subreddit=cryptocurrency&after=64h&before=60h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> GetAllDoge12hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=doge&subreddit=cryptocurrency&after=68h&before=64h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllDoge16hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=doge&subreddit=cryptocurrency&after=72h&before=68h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllDoge20hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=doge&subreddit=cryptocurrency&after=76h&before=72h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }
    public static async Task<string> GetAllDoge24hr()
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"/reddit/comment/search/?q=doge&subreddit=cryptocurrency&after=80h&before=76h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }

  }

}






