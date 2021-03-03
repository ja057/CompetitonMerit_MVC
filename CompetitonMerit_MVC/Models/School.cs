using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitonMerit_MVC.Models
{
    // this class is about school like school name, school address, mobile number and school's website as well
    public class School
    {
        public int Id { get; set; }

        [Required]
        public string School_Name { get; set; }

        [Required]
        public string School_Address { get; set; }

        public string School_Mobile { get; set; }
        public string School_Webite { get; set; }
    }
}
