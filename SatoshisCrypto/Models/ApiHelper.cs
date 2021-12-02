using System;
using System.Threading.Tasks;
using RestSharp;

namespace SatoshisCrypto.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAllForCurrency(string currency, int start)
    {
      RestClient client = new RestClient("https://api.pushshift.io");
      RestRequest request = new RestRequest($"reddit/comment/search/?q={currency}&subreddit=cryptocurrency&after={start}h&before={(start-4)}h&size=100", Method.GET);
      var response = await client.ExecuteTaskAsync(request);

      return response.Content;
    }


  }

}

    // public static async Task<string> GetAllEth(string currency, int start)
    // {
    //   RestClient client = new RestClient("https://api.pushshift.io");
    //   RestRequest request = new RestRequest($"reddit/comment/search/?q={currency}&subreddit=cryptocurrency&after={start}h&before={(start-4)}h&size=100", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);

    //   return response.Content;
    // }



//     public static async Task<string> GetAllAda4hr()
//     {
//       RestClient client = new RestClient("https://api.pushshift.io");
//       RestRequest request = new RestRequest($"reddit/comment/search/?q=ada&subreddit=cryptocurrency&after=60h&before=56h&size=100", Method.GET);
//       var response = await client.ExecuteTaskAsync(request);

//       return response.Content;
//     }



//         public static async Task<string> GetAllLink4hr()
//     {
//       RestClient client = new RestClient("https://api.pushshift.io");
//       RestRequest request = new RestRequest($"reddit/comment/search/?q=link&subreddit=cryptocurrency&after=60h&before=56h&size=100", Method.GET);
//       var response = await client.ExecuteTaskAsync(request);

//       return response.Content;
//     }
//    


//     public static async Task<string> GetAllDoge4hr()
//     {
//       RestClient client = new RestClient("https://api.pushshift.io");
//       RestRequest request = new RestRequest($"reddit/comment/search/?q=doge&subreddit=cryptocurrency&after=60h&before=56h&size=100", Method.GET);
//       var response = await client.ExecuteTaskAsync(request);

//       return response.Content;
//     }
//   

//   }

// }}