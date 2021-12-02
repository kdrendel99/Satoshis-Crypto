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

    public static List<DogeComment> GetDogeComments(string currency, int start) 
    {
      var apiCallTask = ApiHelper.GetAllForCurrency(currency, start);
      var result = apiCallTask.Result;
      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // List<DogeComment> DogeCommentList = JsonConvert.DeserializeObject<List<DogeComment>>(jsonResponse["data"].ToString());
      var jsonResponse = JsonConvert.DeserializeObject<dynamic>(result);
      List<DogeComment> DogeCommentList = JsonConvert.DeserializeObject<List<DogeComment>>(jsonResponse["data"].ToString());
      return DogeCommentList;
    }

  }
}