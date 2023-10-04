using Microsoft.AspNetCore.Mvc;

namespace BestRestaurants.Controllers
{
    public class BestRestaurants : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}