namespace Week8CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableAndRelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Students", "Lesson_ID", c => c.Int());
            CreateIndex("dbo.Students", "Lesson_ID");
            AddForeignKey("dbo.Students", "Lesson_ID", "dbo.Lessons", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Lesson_ID", "dbo.Lessons");
            DropIndex("dbo.Students", new[] { "Lesson_ID" });
            DropColumn("dbo.Students", "Lesson_ID");
            DropTable("dbo.Lessons");
        }
    }
}
