using Microsoft.AspNetCore.Mvc;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class StudentController : Controller
	{
		private readonly ILogger<StudentController> _logger;
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly ExaminationSystemContext _context;

		public StudentController(ILogger<StudentController> logger, IHttpContextAccessor httpContextAccessor, ExaminationSystemContext context)
		{
			_logger = logger;
			_httpContextAccessor = httpContextAccessor;
			_context = context;
		}

		[HttpPost]
		public IActionResult Login(string email, string password)
		{
			VerifierViewModel user = StudentBLL.Verifier(email, password);

			// Wrong Credentials
			if (!user.isLogged)
				return View("../Home/Login", "Wrong E-mail or Password, Please Try Again");

			// Logged in as Student
			_httpContextAccessor.HttpContext.Session.SetInt32("UserId", user.student.Student_ID);
			_httpContextAccessor.HttpContext.Session.SetString("UserName", user.student.First_Name);

			var Exams = _context.GetStudentsFromStoredProcedure(user.student.Student_ID);
			return View("../Student/Index", Exams);

		}

		public IActionResult Index()
		{
			var Exams = _context.GetStudentsFromStoredProcedure((int)_httpContextAccessor.HttpContext.Session.GetInt32("UserId"));
			return View("../Exam/DisplayExamQuestions", Exams);
		}



	}
}