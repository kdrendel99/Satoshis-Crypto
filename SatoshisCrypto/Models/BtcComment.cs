using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace SatoshisCrypto.Models
{
  public class BtcComment
  {
    public string Body { get; set; }
    public int Created_Utc { get; set; }
    [Key]
    public int BtcCommentId { get; set; }
    public string id { get; set; }
    public List<BtcComment> BtcComments { get; set; }

    public static List<BtcComment> GetBtcComments4hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint
    {
      var apiCallTask = ApiHelper.GetAllBtc4hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<BtcComment> BtcCommentList = JsonConvert.DeserializeObject<List<BtcComment>>(jsonResponse["data"].ToString());
      return BtcCommentList;
    }
    public static List<BtcComment> GetBtcComments8hr()

    {
      var apiCallTask = ApiHelper.GetAllBtc8hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<BtcComment> BtcCommentList = JsonConvert.DeserializeObject<List<BtcComment>>(jsonResponse["data"].ToString());
      return BtcCommentList;
    }
    public static List<BtcComment> GetBtcComments12hr() 

    {
      var apiCallTask = ApiHelper.GetAllBtc12hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<BtcComment> BtcCommentList = JsonConvert.DeserializeObject<List<BtcComment>>(jsonResponse["data"].ToString());
      return BtcCommentList;
    }
    public static List<BtcComment> GetBtcComments16hr() 

    {
      var apiCallTask = ApiHelper.GetAllBtc16hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<BtcComment> BtcCommentList = JsonConvert.DeserializeObject<List<BtcComment>>(jsonResponse["data"].ToString());
      return BtcCommentList;
    }
    public static List<BtcComment> GetBtcComments20hr() 

    {
      var apiCallTask = ApiHelper.GetAllBtc20hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<BtcComment> BtcCommentList = JsonConvert.DeserializeObject<List<BtcComment>>(jsonResponse["data"].ToString());
      return BtcCommentList;
    }
    public static List<BtcComment> GetBtcComments24hr() 

    {
      var apiCallTask = ApiHelper.GetAllBtc24hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<BtcComment> BtcCommentList = JsonConvert.DeserializeObject<List<BtcComment>>(jsonResponse["data"].ToString());
      return BtcCommentList;
    }

  }
}
