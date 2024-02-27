using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public static class InstructorBLL
    {
        private static readonly ExaminationSystemContext _context = new();

        public static VerifierViewModel Verifier(string email, string password)
        {
            VerifierViewModel user = new VerifierViewModel();

            // Check If The Credentials are right.
            Instructor instructor = _context.Instructors.FirstOrDefault(inst => inst.Email == email && inst.Password == password);

            // Wrong Credentials
            if (instructor == null)
                user.isLogged = false;

            // Logged in as Instructor
            else
            {
                user.isLogged = true;
                user.instructor = instructor;
            }

            return user;
        }

        public static List<Exam_Structure> GetExams()
        {
            _context.Exam_Structures.Load();
            return _context.Exam_Structures.Local.ToList();
        }
    }
}