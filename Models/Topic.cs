using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrainingManagementSystem.Models
{
    public class Topic
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Topic name should not be empty")]
        public string TopicName { get; set; }
    }
}