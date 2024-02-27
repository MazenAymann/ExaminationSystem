using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
	public class ExamStructureController : Controller
	{
		public IActionResult CreateExam(int courseId, int departmentId, int numMcq, int numTf, int duration, DateTime date, TimeOnly time)
		{
			Exam_Structure examStruct = new Exam_Structure();
			examStruct.Course_ID = courseId;
			examStruct.MCQ_Count = numMcq;
			examStruct.TF_Count = numTf;
			examStruct.time = time;
			examStruct.Duration = duration;
			examStruct.Date = date;

			ExamStructureBLL.createExam(courseId, departmentId, numMcq, numTf, duration, date, time);

			return View("../Instructor/Instructor", examStruct);
		}
	}
}
