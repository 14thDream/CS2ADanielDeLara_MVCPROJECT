using Microsoft.AspNetCore.Mvc;

namespace CS2ADanielDeLara_MVCPROJECT.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
