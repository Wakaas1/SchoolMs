using Microsoft.AspNetCore.Mvc;
using SchoolMs.BLL.Teacher;
using SchoolMs.Domain.Models.Teachers;

namespace SchoolMs.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherServices _teacher;

        public TeacherController(ITeacherServices teacher)
        {
            _teacher = teacher;
        }
        public IActionResult Index()
        {
            var tecList = _teacher.GetAllTeachers();
            return View(tecList);
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            return View();
        }
        [HttpPost]
      
        public IActionResult AddTeacher(Teachers teachers)
        {
            var tec = _teacher.AddTeacher(teachers);
            return View(tec);
        }
    }
}
