using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// the subject class holds the subject name, subject description and language of subject as well, there is also a primary key 
; namespace CompetitonMerit_MVC.Models
{
    public class Subject
    {
        public int Id { get; set; }
        [Required]
        public string Subject_Name { get; set; }
        [Required]
        public string Subject_description { get; set; }
        public string Subject_language { get; set; }

    }
}
