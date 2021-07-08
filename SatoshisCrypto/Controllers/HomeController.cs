using System.Collections.Generic;
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
            var allComments = Comment.GetComments();
            
            // _db.Comments.Add("hello world");
            
            return View(allComments);
            
        }
    }
}