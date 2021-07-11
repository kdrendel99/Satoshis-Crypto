using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace SatoshisCrypto.Models
{
  public class Comment
  {
    public string Body { get; set; }
    public int Created_Utc { get; set; }
    [Key]
    public int CommentId { get; set; }
    public string id { get; set; }   
    public List<Comment> Comments { get; set; }


    public static List<Comment> GetComments() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Comment> commentList = JsonConvert.DeserializeObject<List<Comment>>(jsonResponse["data"].ToString());
      return commentList;
    }
    // public static List<Comment> GetComments4hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint
    // {
    //   var apiCallTask = ApiHelper.GetAll4hr();
    //   var result = apiCallTask.Result;
    //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //   List<Comment> commentList = JsonConvert.DeserializeObject<List<Comment>>(jsonResponse["data"].ToString());
    //   return commentList;
    // }
    // public static List<Comment> GetComments8hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint

    // {
    //   var apiCallTask = ApiHelper.GetAll8hr();
    //   var result = apiCallTask.Result;
    //   JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    //   List<Comment> commentList = JsonConvert.DeserializeObject<List<Comment>>(jsonResponse["data"].ToString());
    //   return commentList;
    // }



  }
}