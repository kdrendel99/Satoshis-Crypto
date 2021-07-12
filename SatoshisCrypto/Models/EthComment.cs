using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace SatoshisCrypto.Models
{
  public class EthComment
  {
    public string Body { get; set; }
    public int Created_Utc { get; set; }
    [Key]
    public int EthCommentId { get; set; }
    public string id { get; set; }
    public List<EthComment> EthComments { get; set; }

    public static List<EthComment> GetEthComments4hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint
    {
      var apiCallTask = ApiHelper.GetAllEth4hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<EthComment> EthCommentList = JsonConvert.DeserializeObject<List<EthComment>>(jsonResponse["data"].ToString());
      return EthCommentList;
    }
    public static List<EthComment> GetEthComments8hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint

    {
      var apiCallTask = ApiHelper.GetAllEth8hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<EthComment> EthCommentList = JsonConvert.DeserializeObject<List<EthComment>>(jsonResponse["data"].ToString());
      return EthCommentList;
    }
    public static List<EthComment> GetEthComments12hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint

    {
      var apiCallTask = ApiHelper.GetAllEth12hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<EthComment> EthCommentList = JsonConvert.DeserializeObject<List<EthComment>>(jsonResponse["data"].ToString());
      return EthCommentList;
    }
    public static List<EthComment> GetEthComments16hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint

    {
      var apiCallTask = ApiHelper.GetAllEth16hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<EthComment> EthCommentList = JsonConvert.DeserializeObject<List<EthComment>>(jsonResponse["data"].ToString());
      return EthCommentList;
    }
    public static List<EthComment> GetEthComments20hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint

    {
      var apiCallTask = ApiHelper.GetAllEth20hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<EthComment> EthCommentList = JsonConvert.DeserializeObject<List<EthComment>>(jsonResponse["data"].ToString());
      return EthCommentList;
    }
    public static List<EthComment> GetEthComments24hr() //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint

    {
      var apiCallTask = ApiHelper.GetAllEth24hr();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<EthComment> EthCommentList = JsonConvert.DeserializeObject<List<EthComment>>(jsonResponse["data"].ToString());
      return EthCommentList;
    }

  }
}
