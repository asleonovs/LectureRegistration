namespace LectureRegistrationSystem.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LectureVisitRegisters", "StudyProgramId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LectureVisitRegisters", "StudyProgramId");
        }
    }
}
