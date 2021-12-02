using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SatoshisCrypto.Models;
using System;

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

      return View();
    }
    public IActionResult Details()
    {

      void bitcoin(){
        var btc4hr = BtcComment.GetBtcComments("btc", 60);
        var btc8hr = BtcComment.GetBtcComments("btc", 64);
        var btc12hr = BtcComment.GetBtcComments("btc", 68);
        var btc16hr = BtcComment.GetBtcComments("btc", 72);
        var btc20hr = BtcComment.GetBtcComments("btc", 76);
        var btc24hr = BtcComment.GetBtcComments("btc", 80);
        var allBtcComments = btc4hr.Concat(btc8hr).Concat(btc12hr).Concat(btc16hr).Concat(btc20hr).Concat(btc24hr).ToList();

        _db.BtcComments.AddRange(allBtcComments);
        _db.SaveChanges();
      }

    void ada(){
      var ada4hr = AdaComment.GetAdaComments("ada", 60);
      var ada8hr = AdaComment.GetAdaComments("ada", 64);
      var ada12hr = AdaComment.GetAdaComments("ada", 68);
      var ada16hr = AdaComment.GetAdaComments("ada", 72);
      var ada20hr = AdaComment.GetAdaComments("ada", 76);
      var ada24hr = AdaComment.GetAdaComments("ada", 80);
      var allAdaComments = ada4hr.Concat(ada8hr).Concat(ada12hr).Concat(ada16hr).Concat(ada20hr).Concat(ada24hr).ToList();

      _db.AdaComments.AddRange(allAdaComments);
      _db.SaveChanges();
    }


    void doge(){
      var doge4hr = DogeComment.GetDogeComments("doge", 60);
      var doge8hr = DogeComment.GetDogeComments("doge", 64);
      var doge12hr = DogeComment.GetDogeComments("doge", 68);
      var doge16hr = DogeComment.GetDogeComments("doge", 72);
      var doge20hr = DogeComment.GetDogeComments("doge", 76);
      var doge24hr = DogeComment.GetDogeComments("doge", 80);
      var allDogeComments = doge4hr.Concat(doge8hr).Concat(doge12hr).Concat(doge16hr).Concat(doge20hr).Concat(doge24hr).ToList();

      _db.DogeComments.AddRange(allDogeComments);
      _db.SaveChanges();
    }

    bitcoin();
    ada();
    doge();


      // var eth4hrComments = EthComment.GetEthComments4hr();
      // var eth8hrComments = EthComment.GetEthComments8hr();
      // var eth12hrComments = EthComment.GetEthComments12hr();
      // var eth16hrComments = EthComment.GetEthComments16hr();
      // var eth20hrComments = EthComment.GetEthComments20hr();
      // var eth24hrComments = EthComment.GetEthComments24hr();
      // var allEthComments = eth4hrComments.Concat(eth8hrComments).Concat(eth12hrComments).Concat(eth16hrComments).Concat(eth20hrComments).Concat(eth24hrComments).ToList();

      // _db.EthComments.AddRange(allEthComments);
      // _db.SaveChanges();


      // var link4hrComments = LinkComment.GetLinkComments4hr();
      // var link8hrComments = LinkComment.GetLinkComments8hr();
      // var link12hrComments = LinkComment.GetLinkComments8hr();
      // var link16hrComments = LinkComment.GetLinkComments16hr();
      // var link20hrComments = LinkComment.GetLinkComments20hr();
      // var link24hrComments = LinkComment.GetLinkComments24hr();
      // var allLinkComments = link4hrComments.Concat(link8hrComments).Concat(link12hrComments).Concat(link16hrComments).Concat(link20hrComments).Concat(link24hrComments).ToList();

      // _db.LinkComments.AddRange(allLinkComments);
      // _db.SaveChanges();
    

          // var ethQuery = _db.EthComments.AsQueryable();
      // int ethCountDistinct = ethQuery.Select(c => c.id)
      //                       .Distinct()
      //                       .Count();

      // var linkQuery = _db.LinkComments.AsQueryable();                     
      // int linkCountDistinct = linkQuery.Select(c => c.id)
      //                       .Distinct()
      //                       .Count();

      var btcQuery = _db.BtcComments.AsQueryable();
      int btcCountDistinct = btcQuery.Select(c => c.id)
        .Distinct()
        .Count();

      var adaQuery = _db.AdaComments.AsQueryable();                     
      int adaCountDistinct = adaQuery.Select(c => c.id)
        .Distinct()
        .Count();

      var dogeQuery = _db.DogeComments.AsQueryable();                     
      int dogeCountDistinct = dogeQuery.Select(c => c.id)
        .Distinct()
        .Count();  

      SortedList<int, string> commentScorecard = new SortedList<int, string> {};
      commentScorecard.Clear();
      commentScorecard.Add(btcCountDistinct, "BTC"); 
      commentScorecard.Add(adaCountDistinct, "ADA"); 
      commentScorecard.Add(dogeCountDistinct, "DOGE"); 
       // commentScorecard.Add(ethCountDistinct, "ETH"); 
       // commentScorecard.Add(linkCountDistinct, "LINK"); 

      var descScorecard = commentScorecard.Reverse();

 
      return View(descScorecard);

    }
  }
}
