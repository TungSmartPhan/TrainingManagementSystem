namespace TrainingManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainingStaffTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TrainingStaffInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        TrainingStaffID = c.String(nullable: false),
                        TrainingStaffAccount = c.String(nullable: false),
                        Password = c.String(),
                        TOEICScore = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Location = c.String(nullable: false),
                        Description = c.String(),
                        DateBorn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TrainingStaffInfoes");
        }
    }
}
