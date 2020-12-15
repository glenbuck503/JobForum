using Microsoft.AspNetCore.Mvc;

namespace JobForum.Controllers 
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
