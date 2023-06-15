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

      public static List<BtcComment> GetBtcComments(string currency, int start) 
    {
      var apiCallTask = ApiHelper.GetAllForCurrency(currency, start);
      var result = apiCallTask.Result;

var jsonResponse = JsonConvert.DeserializeObject<dynamic>(result);

List<BtcComment> BtcCommentList = null;
if (jsonResponse != null && jsonResponse["data"] != null)
{
    BtcCommentList = JsonConvert.DeserializeObject<List<BtcComment>>(jsonResponse["data"].ToString());
}

Console.WriteLine(result); // Console log the raw JSON response

return BtcCommentList;
      return BtcCommentList;
    }
  }
}


