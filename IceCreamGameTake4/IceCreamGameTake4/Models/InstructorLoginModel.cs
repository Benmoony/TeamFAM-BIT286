﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamGameTake4.Models
{
    public class InstructorLoginModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="Please enter User Name")]
        [Display(Name ="User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Please Enter Password")]
        public string Password { get; set; }
    }

    public class InstructorRegisterModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter User Name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
    }
}
