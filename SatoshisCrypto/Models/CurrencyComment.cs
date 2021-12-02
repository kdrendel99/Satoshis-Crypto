using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace SatoshisCrypto.Models
{
  public class CurrencyComment
  {
    public string Body { get; set; }
    public int Created_Utc { get; set; }
    [Key]
    public int CurrencyCommentId { get; set; }
    public string id { get; set; }
    public List<CurrencyComment> CurrencyComments { get; set; }

    public static List<CurrencyComment> GetCurrencyComments(string currency, int start) //this is where the function that makes our API call is written. It refers to API helper for the actual API endpoint
    {
      var apiCallTask = ApiHelper.GetAllForCurrency(currency, start);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<CurrencyComment> CurrencyCommentList = JsonConvert.DeserializeObject<List<CurrencyComment>>(jsonResponse["data"].ToString());
      return CurrencyCommentList;
    }
  }
}
