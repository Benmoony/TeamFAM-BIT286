using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamMathGame.Models
{
    public class InstructorLogin
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="User Name")]
        public string UserName { get; set; }

        public string Password { get; set; }

    }
}
