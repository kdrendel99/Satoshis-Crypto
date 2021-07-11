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

      var allComments = Comment.GetComments();
      // var get8hrComments = Comment.GetComments4hr();
      // var get4hrComments = Comment.GetComments8hr();
      // var allComments = get8hrComments.Concat(get4hrComments).ToList();


      _db.Comments.AddRange(allComments);
      _db.SaveChanges();

      return View(allComments);

    }
  }
}