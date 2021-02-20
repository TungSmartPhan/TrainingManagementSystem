using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrainingManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Course Name should not be empty")]
        public string CourseName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}