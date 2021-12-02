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

    public static List<AdaComment> GetAdaComments(string currency, int start)
    {
      var apiCallTask = ApiHelper.GetAllForCurrency(currency, start);
      var result = apiCallTask.Result;
      // JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      // List<AdaComment> AdaCommentList = JsonConvert.DeserializeObject<List<AdaComment>>(jsonResponse["data"].ToString());
      var jsonResponse = JsonConvert.DeserializeObject<dynamic>(result);
      List<AdaComment> AdaCommentList = JsonConvert.DeserializeObject<List<AdaComment>>(jsonResponse["data"].ToString());
      return AdaCommentList;
    }
    
  }
}
