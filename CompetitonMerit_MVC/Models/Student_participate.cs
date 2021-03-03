using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitonMerit_MVC.Models
{
    //the class holds the info about the students who participated in the exams and info like student name, age, mobile number and student address
    public class Student_participate
    {
        public int Id { get; set; }

        [Required]
        public string Student_Name { get; set; }
        [Required]

        public int Student_age { get; set; }

        [Required]
        public string Mobile_Number { get; set; }

        [Required]
        public string Student_Address { get; set; }

        [Required]
        public string Father_Name { get; set; }
    }
}
