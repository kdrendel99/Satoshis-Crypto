using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SatoshisCrypto.Models;
using System;
using Microsoft.EntityFrameworkCore;

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
      _db.Comments.AddRange(allComments);
      _db.SaveChanges();

      var query = _db.Comments.AsQueryable();
  
      var commentCount = _db.Comments.Count();
      Console.WriteLine(commentCount); // linq method to return total number of entries in our database 

      var btcCountDistinct = query.Select(c => c.id)
                          .Distinct()
                          .Count();
      Console.WriteLine(btcCountDistinct); // linq method to return number of unique entries in our database

      return View(allComments);

    }
  }
}