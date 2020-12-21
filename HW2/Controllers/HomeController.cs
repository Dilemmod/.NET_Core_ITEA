using Microsoft.AspNetCore.Mvc;


namespace HW2.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
