using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;

namespace WebApplication1.Models
{
	public static class ExamStructureBLL
	{
		private static readonly ExaminationSystemContext _context = new();

		public static int createExam(int courseId, int departmentId, int numMcq, int numTf, int duration, DateTime date, TimeOnly time)
		{
			string formattedDate = date.ToString("yyyy-MM-dd");
			string formattedTime = time.ToString("HH:mm:ss");

			Console.WriteLine(departmentId);

			return _context.Database.ExecuteSqlRaw($"EXEC Create_Exams_For_Department {departmentId}, {courseId}, {duration}, {numMcq}, {numTf}, '{formattedDate}', '{formattedTime}'");
		}

	}
}
