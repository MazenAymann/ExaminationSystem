using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InstructorController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            VerifierViewModel user = InstructorBLL.Verifier(email, password);

            // Wrong Credentials
            if (!user.isLogged)
                return View("../Home/Login", "Wrong E-mail or Password, Please Try Again");

            // Logged in as Instructor
            _httpContextAccessor.HttpContext.Session.SetInt32("UserId", user.instructor.Instructor_ID);
            _httpContextAccessor.HttpContext.Session.SetString("UserName", user.instructor.First_Name);
            return View("Instructor");

        }

        public IActionResult Preview()
        {
            List<Exam_Structure> examStructures = new();
            examStructures = InstructorBLL.GetExams();

            return View("Preview", examStructures);

        }

    }
}
