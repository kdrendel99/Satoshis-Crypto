using Microsoft.AspNetCore.Mvc;
using SatoshisCrypto.Models;

namespace SatoshisCrypto.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allComments = Comment.GetComments();
            return View(allComments);
        }
    }
}