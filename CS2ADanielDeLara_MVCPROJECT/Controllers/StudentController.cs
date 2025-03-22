using CS2ADanielDeLara_MVCPROJECT.BusLogic.Model;
using CS2ADanielDeLara_MVCPROJECT.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace CS2ADanielDeLara_MVCPROJECT.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly StudentService _studentService = new();

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
            _studentService = new StudentService();
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }

        public IActionResult AddNewStudent()
        {
            return View();
        }


    }
}
