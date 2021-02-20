using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TrainingManagementSystem.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<TraineeInfo> TraineeDb { get; set; }
        public DbSet<Course> CourseDb { get; set; }
        public DbSet<Category> CategoryDb { get; set; }
        public DbSet<Topic> TopicDb { get; set; }
        public DbSet<TrainingStaffInfo> TrainingStaffDb { get; set; }
        public DbSet<TrainerInfo> TrainerDb { get; set; }



        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}