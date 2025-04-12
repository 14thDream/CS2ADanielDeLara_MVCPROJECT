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

        public IActionResult EditStudent(int id)
        {
            var student = _studentService.GetById(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult AddStudent(tblStudent student)
        {
            try
            {
                bool result = _studentService.Add(student);
                return Json(new { success = result, message = result ? "Student added successfully" : "Failed to add student" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding student");
                return Json(new { success = false, message = "An error occurred" });
            }
        }

        [HttpPost]
        public IActionResult EditStudent(tblStudent student)
        {
            try
            {
                bool result = _studentService.Update(student);
                return Json(new { success = result, message = result ? "Student updated successfully" : "Failed to update student" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating student");
                return Json(new { success = false, message = "An error occurred" });
            }
        }
    }
}
