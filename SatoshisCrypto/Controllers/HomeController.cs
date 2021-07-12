using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SatoshisCrypto.Models;

namespace SatoshisCrypto.Controllers
{
  public class HomeController : Controller
  {
    private readonly SatoshisCryptoContext _db;
    public HomeController(SatoshisCryptoContext db)
    {
      _db = db;
    }

    public IActionResult Index()
    {

      var get4hrComments = BtcComment.GetBtcComments4hr();
      var get8hrComments = BtcComment.GetBtcComments8hr();
      var get12hrComments = BtcComment.GetBtcComments12hr();
      var get16hrComments = BtcComment.GetBtcComments16hr();
      var get20hrComments = BtcComment.GetBtcComments20hr();
      var get24hrComments = BtcComment.GetBtcComments24hr();
      var allBtcComments = get4hrComments.Concat(get8hrComments).Concat(get12hrComments).Concat(get16hrComments).Concat(get20hrComments).Concat(get24hrComments).ToList();

      _db.BtcComments.AddRange(allBtcComments);
      _db.SaveChanges();

      var eth4hrComments = EthComment.GetEthComments4hr();
      var eth8hrComments = EthComment.GetEthComments8hr();
      var eth12hrComments = EthComment.GetEthComments12hr();
      var eth16hrComments = EthComment.GetEthComments16hr();
      var eth20hrComments = EthComment.GetEthComments20hr();
      var eth24hrComments = EthComment.GetEthComments24hr();
      var allEthComments = eth4hrComments.Concat(eth8hrComments).Concat(eth12hrComments).Concat(eth16hrComments).Concat(eth20hrComments).Concat(eth24hrComments).ToList();

      _db.EthComments.AddRange(allEthComments);
      _db.SaveChanges();

      var ada4hrComments = AdaComment.GetAdaComments4hr();
      var ada8hrComments = AdaComment.GetAdaComments8hr();
      var ada12hrComments = AdaComment.GetAdaComments8hr();
      var ada16hrComments = AdaComment.GetAdaComments16hr();
      var ada20hrComments = AdaComment.GetAdaComments20hr();
      var ada24hrComments = AdaComment.GetAdaComments24hr();
      var allAdaComments = ada4hrComments.Concat(ada8hrComments).Concat(ada12hrComments).Concat(ada16hrComments).Concat(ada20hrComments).Concat(ada24hrComments).ToList();

      _db.AdaComments.AddRange(allAdaComments);
      _db.SaveChanges();




      var btcQuery = _db.BtcComments.AsQueryable();

      var btcCountDistinct = btcQuery.Select(c => c.id)
                            .Distinct()
                            .Count();

      var ethQuery = _db.EthComments.AsQueryable();
      var ethCountDistinct = ethQuery.Select(c => c.id)
                            .Distinct()
                            .Count();

      var adaQuery = _db.AdaComments.AsQueryable();                     
      var adaCountDistinct = adaQuery.Select(c => c.id)
                            .Distinct()
                            .Count();


      return View(allEthComments);


    }
  }
}