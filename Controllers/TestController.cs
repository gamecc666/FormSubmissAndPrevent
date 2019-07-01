using Microsoft.AspNetCore.Mvc;

namespace FormSubmissAndPrevent.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(string name,string gender)
        {         
            return Content(name + " || " + gender);
        }
    }
}