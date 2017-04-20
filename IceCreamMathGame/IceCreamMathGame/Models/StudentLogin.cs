using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamMathGame.Models
{
    public class StudentLogin
    {
       [Key]
        public int ID { get; set;}

        [Display (Name = "Student Full Name")]
        public string  StudentName { get; set; }
    }
}
 