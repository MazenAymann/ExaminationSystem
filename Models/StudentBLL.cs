using WebApplication1.Context;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
	public static class StudentBLL
	{
		private static readonly ExaminationSystemContext _context = new();

		public static VerifierViewModel Verifier(string email, string password)
		{
			VerifierViewModel user = new VerifierViewModel();

			// Check If The Credentials are right.
			Student student = _context.Students.FirstOrDefault(stud => stud.Email == email && stud.Password == password);

			// Wrong Credentials
			if (student == null)
				user.isLogged = false;
			// Logged in as Student
			else
			{
				user.isLogged = true;
				user.student = student;
			}

			return user;
		}
	}
}
