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
        [Route("Assignment/List/{id?}")] //Routing pattern that connects to this IActionResult
        [HttpPost]
        public IActionResult List()
        {
            //ViewBag.Access = access;
            List<Student> studentList = new List<Student>();

            Student student = new Student();
            Student beth = new Student();
            Student gabriela = new Student();
            student.firstName = "Gabe";
            student.lastName = "Clark";
            student.grade = "A";
            studentList.Add(student);
            
            beth.firstName = "Bethany";
            beth.lastName = "Michaels";
            beth.grade = "B";
            studentList.Add(beth);

            gabriela.firstName = "Gabriela";
            gabriela.lastName = "Clark";
            gabriela.grade = "A+";
            studentList.Add(gabriela);

            studentList.ToString();
            //Creates three students and adds them to a List
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
