using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using SchoolMs.BLL.Students;
using SchoolMs.Domain.Models.Students;

namespace SchoolMs.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentServices _student;

        public StudentController(IStudentServices student)
        {
            _student = student;
        }
        public IActionResult Index()
        {
            var tecList = _student.GetAllStudents();
            return View(tecList);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(StudentList student)
        {
            var std = _student.AddStudent(student);
            return View(std);
        }

    }
}
