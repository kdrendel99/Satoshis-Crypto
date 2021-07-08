using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SatoshisCrypto.Models
{
  public class Comment
  {
    public string Body { get; set; }
    public int Created_Utc { get; set; }

    public static List<Comment> GetComments() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint
    {
      var apiCallTask = ApiHelper.GetAll(); 
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Comment> commentList = JsonConvert.DeserializeObject<List<Comment>>(jsonResponse["data"].ToString());
      Console.WriteLine(commentList);
      return commentList;

    }

    
  }
}