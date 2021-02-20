using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.ViewModels
{
    public class TraineeCourseViewModel
    {
        public TraineeInfo TRAINEEINFO { get; set; }
        public IEnumerable<Course> COURSE { get; set; }

        
    }
}