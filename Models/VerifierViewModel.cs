using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class VerifierViewModel
    {
        public Student? student { get; set; }
        public Instructor? instructor { get; set; }

        public bool isLogged { get; set; }
    }
}