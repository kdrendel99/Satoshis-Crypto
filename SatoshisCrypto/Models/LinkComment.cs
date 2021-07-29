using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace SatoshisCrypto.Models
{
  public class LinkComment
  {
    public string Body { get; set; }
    public int Created_Utc { get; set; }
    [Key]
    public int LinkCommentId { get; set; }
    public string id { get; set; }
    public List<LinkComment> LinkComments { get; set; }

    public static List<LinkComment> GetLinkComments4hr() 
    {
      var apiCallTask = ApiHelper.GetAllLink4hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LinkComment> LinkCommentList = JsonConvert.DeserializeObject<List<LinkComment>>(jsonResponse["data"].ToString());
      return LinkCommentList;
    }
    public static List<LinkComment> GetLinkComments8hr() 

    {
      var apiCallTask = ApiHelper.GetAllLink8hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LinkComment> LinkCommentList = JsonConvert.DeserializeObject<List<LinkComment>>(jsonResponse["data"].ToString());
      return LinkCommentList;
    }
    public static List<LinkComment> GetLinkComments12hr() 

    {
      var apiCallTask = ApiHelper.GetAllLink12hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LinkComment> LinkCommentList = JsonConvert.DeserializeObject<List<LinkComment>>(jsonResponse["data"].ToString());
      return LinkCommentList;
    }
    public static List<LinkComment> GetLinkComments16hr()

    {
      var apiCallTask = ApiHelper.GetAllLink16hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LinkComment> LinkCommentList = JsonConvert.DeserializeObject<List<LinkComment>>(jsonResponse["data"].ToString());
      return LinkCommentList;
    }
    public static List<LinkComment> GetLinkComments20hr()

    {
      var apiCallTask = ApiHelper.GetAllLink20hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LinkComment> LinkCommentList = JsonConvert.DeserializeObject<List<LinkComment>>(jsonResponse["data"].ToString());
      return LinkCommentList;
    }
    public static List<LinkComment> GetLinkComments24hr() 

    {
      var apiCallTask = ApiHelper.GetAllLink24hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<LinkComment> LinkCommentList = JsonConvert.DeserializeObject<List<LinkComment>>(jsonResponse["data"].ToString());
      return LinkCommentList;
    }

  }
}
