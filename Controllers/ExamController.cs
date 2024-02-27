using Microsoft.AspNetCore.Mvc;
using WebApplication1.Context;

public class ExamController : Controller
{
	private readonly ExaminationSystemContext _Context;
	private readonly IHttpContextAccessor _httpContextAccessor;


	public ExamController(ExaminationSystemContext Context, IHttpContextAccessor httpContextAccessor)
	{
		_Context = Context;
		_httpContextAccessor = httpContextAccessor;
	}

	public ActionResult DisplayExamQuestions(int examId)
	{
		ViewBag.examId = examId;

		//examDetails->Dictionary
		var examDetails = _Context.GetExamDetails(examId);

		// Set ViewBag values based on the exam details
		ViewBag.ExamDate = examDetails["ExamDate"];
		ViewBag.ExamTime = examDetails["ExamTime"];
		ViewBag.ExamDuration = examDetails["ExamDuration"];

		Console.WriteLine($"Exam ID: {examId}");
		_Context.ExamGeneration(examId);
		var examQuestions = _Context.Select_Exam_Question(examId);
		return View(examQuestions);
	}


	[HttpPost]
	public IActionResult SubmitExam(int student_ID, int exam_ID, string[] answers)

	{
		// Print the values in the console
		Console.WriteLine($"Student ID: {student_ID}");
		Console.WriteLine($"Exam ID: {exam_ID}");
		Console.WriteLine("Student's Answers:");
		if (answers.Length < 10)
		{
			// Create a new array with length 10
			string[] extendedAnswers = new string[10];

			// Copy existing answers to the new array
			for (int i = 0; i < answers.Length; i++)
			{
				extendedAnswers[i] = answers[i];
			}

			// Fill the rest of the array with default values 'z'
			for (int i = answers.Length; i < extendedAnswers.Length; i++)
			{
				extendedAnswers[i] = "z";
			}

			// Update answers to use the extended array
			answers = extendedAnswers;
		}


		for (int i = 0; i < answers.Length; i++)
		{
			Console.WriteLine(answers[i]);
		}
		// Call the ExamAnswers method with the provided parameters
		_Context.ExamAnswers(student_ID, exam_ID, answers[0], answers[1], answers[2], answers[3], answers[4], answers[5], answers[6], answers[7], answers[8], answers[9]);

		// Call the ExamCorrection method
		_Context.ExamCorrection(student_ID, exam_ID);

		var Exams = _Context.GetStudentsFromStoredProcedure((int)_httpContextAccessor.HttpContext.Session.GetInt32("UserId"));
		return View("../Student/Index", Exams);
	}

}
