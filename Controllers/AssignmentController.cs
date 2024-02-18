using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult List(int access)
        {
            ViewBag.Access = access;
            List<Student> studentList = new List<Student>();

            Student student = new Student();
            student.firstName = "Gabe";
            student.lastName = "Clark";
            student.grade = "A";
            studentList.Add(student);

            student = new Student();
            student.firstName = "Bethany";
            student.lastName = "Michaels";
            student.grade = "B";
            studentList.Add(student);

            student = new Student();
            student.firstName = "Gabriela";
            student.lastName = "Clark";
            student.grade = "A+";
            studentList.Add(student);

            studentList.ToString();
            /*if (access <= 2)
            {
                studentList = null;
            }
            else if((access > 2) && (access < 8))
            {
                studentList = studentList.Select(p => p.firstName).ToList();
            }*/
            return View(studentList);
        }
    }
}
