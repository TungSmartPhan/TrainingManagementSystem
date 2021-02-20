using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrainingManagementSystem.Models
{
    public class TrainingStaffInfo
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Name should not be empty")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Age should not be empty")]
        public int Age { get; set; }


        [Required(ErrorMessage = "TrainingStaff ID should not be empty")]
        public string TrainingStaffID { get; set; }


        [Required(ErrorMessage = "TrainingStaff Account should not be empty")]
        public string TrainingStaffAccount { get; set; }
        public string Password { get; set; }


        public decimal TOEICScore { get; set; }


        [Required(ErrorMessage = "Location should not be empty")]
        public string Location { get; set; }

        public string Description { get; set; }


        [Required(ErrorMessage = "Date of Birth should not be empty")]
        public DateTime DateBorn { get; set; }
    }
}