namespace TrainingManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTraineeInfoFKToCourseModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TraineeInfoes", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.TraineeInfoes", "CourseId");
            AddForeignKey("dbo.TraineeInfoes", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TraineeInfoes", "CourseId", "dbo.Courses");
            DropIndex("dbo.TraineeInfoes", new[] { "CourseId" });
            DropColumn("dbo.TraineeInfoes", "CourseId");
        }
    }
}
