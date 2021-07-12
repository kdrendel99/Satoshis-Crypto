using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace SatoshisCrypto.Models
{
  public class AdaComment
  {
    public string Body { get; set; }
    public int Created_Utc { get; set; }
    [Key]
    public int AdaCommentId { get; set; }
    public string id { get; set; }
    public List<AdaComment> AdaComments { get; set; }

    public static List<AdaComment> GetAdaComments4hr()
    {
      var apiCallTask = ApiHelper.GetAllAda4hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<AdaComment> AdaCommentList = JsonConvert.DeserializeObject<List<AdaComment>>(jsonResponse["data"].ToString());
      return AdaCommentList;
    }
    public static List<AdaComment> GetAdaComments8hr() 

    {
      var apiCallTask = ApiHelper.GetAllAda8hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<AdaComment> AdaCommentList = JsonConvert.DeserializeObject<List<AdaComment>>(jsonResponse["data"].ToString());
      return AdaCommentList;
    }
    public static List<AdaComment> GetAdaComments12hr() 

    {
      var apiCallTask = ApiHelper.GetAllAda12hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<AdaComment> AdaCommentList = JsonConvert.DeserializeObject<List<AdaComment>>(jsonResponse["data"].ToString());
      return AdaCommentList;
    }
    public static List<AdaComment> GetAdaComments16hr() 

    {
      var apiCallTask = ApiHelper.GetAllAda16hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<AdaComment> AdaCommentList = JsonConvert.DeserializeObject<List<AdaComment>>(jsonResponse["data"].ToString());
      return AdaCommentList;
    }
    public static List<AdaComment> GetAdaComments20hr()

    {
      var apiCallTask = ApiHelper.GetAllAda20hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<AdaComment> AdaCommentList = JsonConvert.DeserializeObject<List<AdaComment>>(jsonResponse["data"].ToString());
      return AdaCommentList;
    }
    public static List<AdaComment> GetAdaComments24hr() 

    {
      var apiCallTask = ApiHelper.GetAllAda24hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<AdaComment> AdaCommentList = JsonConvert.DeserializeObject<List<AdaComment>>(jsonResponse["data"].ToString());
      return AdaCommentList;
    }

  }
}
