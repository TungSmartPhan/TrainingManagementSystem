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


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}