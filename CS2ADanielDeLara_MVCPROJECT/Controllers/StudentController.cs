using CS2ADanielDeLara_MVCPROJECT.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace CS2ADanielDeLara_MVCPROJECT.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService = new();
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }
    }
}
