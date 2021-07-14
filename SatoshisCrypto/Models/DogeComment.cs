using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace SatoshisCrypto.Models
{
  public class DogeComment
  {
    public string Body { get; set; }
    public int Created_Utc { get; set; }
    [Key]
    public int DogeCommentId { get; set; }
    public string id { get; set; }
    public List<DogeComment> DogeComments { get; set; }

    public static List<DogeComment> GetDogeComments4hr() 
    {
      var apiCallTask = ApiHelper.GetAllDoge4hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<DogeComment> DogeCommentList = JsonConvert.DeserializeObject<List<DogeComment>>(jsonResponse["data"].ToString());
      return DogeCommentList;
    }
    public static List<DogeComment> GetDogeComments8hr() 

    {
      var apiCallTask = ApiHelper.GetAllDoge8hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<DogeComment> DogeCommentList = JsonConvert.DeserializeObject<List<DogeComment>>(jsonResponse["data"].ToString());
      return DogeCommentList;
    }
    public static List<DogeComment> GetDogeComments12hr() 

    {
      var apiCallTask = ApiHelper.GetAllDoge12hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<DogeComment> DogeCommentList = JsonConvert.DeserializeObject<List<DogeComment>>(jsonResponse["data"].ToString());
      return DogeCommentList;
    }
    public static List<DogeComment> GetDogeComments16hr()

    {
      var apiCallTask = ApiHelper.GetAllDoge16hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<DogeComment> DogeCommentList = JsonConvert.DeserializeObject<List<DogeComment>>(jsonResponse["data"].ToString());
      return DogeCommentList;
    }
    public static List<DogeComment> GetDogeComments20hr()

    {
      var apiCallTask = ApiHelper.GetAllDoge20hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<DogeComment> DogeCommentList = JsonConvert.DeserializeObject<List<DogeComment>>(jsonResponse["data"].ToString());
      return DogeCommentList;
    }
    public static List<DogeComment> GetDogeComments24hr() 

    {
      var apiCallTask = ApiHelper.GetAllDoge24hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<DogeComment> DogeCommentList = JsonConvert.DeserializeObject<List<DogeComment>>(jsonResponse["data"].ToString());
      return DogeCommentList;
    }

  }
}