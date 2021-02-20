namespace TrainingManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryFKToTopicModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "TopicId", c => c.Int(nullable: false));
            CreateIndex("dbo.Categories", "TopicId");
            AddForeignKey("dbo.Categories", "TopicId", "dbo.Topics", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "TopicId", "dbo.Topics");
            DropIndex("dbo.Categories", new[] { "TopicId" });
            DropColumn("dbo.Categories", "TopicId");
        }
    }
}
