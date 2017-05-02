using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGameIceCream5.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int InstructorID { get; set; }

        public ICollection<Score> Scores { get; set; }
    }
}