namespace LectureRegistrationSystem.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FacultyName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudyPrograms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudyProgramName = c.String(nullable: false),
                        YearOfStudy = c.Int(nullable: false),
                        Group = c.Int(nullable: false),
                        FacultyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.FacultyId, cascadeDelete: true)
                .Index(t => t.FacultyId);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LectureName = c.String(),
                        StudyProgramId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudyPrograms", t => t.StudyProgramId, cascadeDelete: true)
                .Index(t => t.StudyProgramId);
            
            CreateTable(
                "dbo.LectureSchedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LectureId = c.Int(nullable: false),
                        StudyProgramId = c.Int(nullable: false),
                        Group = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lectures", t => t.LectureId, cascadeDelete: true)
                .Index(t => t.LectureId);
            
            CreateTable(
                "dbo.LectureVisitRegisters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        LectureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lectures", t => t.LectureId, cascadeDelete: true)
                .Index(t => t.LectureId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Surname = c.String(),
                        StudyProgramId = c.Int(nullable: false),
                        Group = c.Int(nullable: false),
                        YearOfStudy = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudyPrograms", t => t.StudyProgramId, cascadeDelete: true)
                .Index(t => t.StudyProgramId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.StudyPrograms", "FacultyId", "dbo.Faculties");
            DropForeignKey("dbo.AspNetUsers", "StudyProgramId", "dbo.StudyPrograms");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Lectures", "StudyProgramId", "dbo.StudyPrograms");
            DropForeignKey("dbo.LectureVisitRegisters", "LectureId", "dbo.Lectures");
            DropForeignKey("dbo.LectureSchedules", "LectureId", "dbo.Lectures");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "StudyProgramId" });
            DropIndex("dbo.LectureVisitRegisters", new[] { "LectureId" });
            DropIndex("dbo.LectureSchedules", new[] { "LectureId" });
            DropIndex("dbo.Lectures", new[] { "StudyProgramId" });
            DropIndex("dbo.StudyPrograms", new[] { "FacultyId" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.LectureVisitRegisters");
            DropTable("dbo.LectureSchedules");
            DropTable("dbo.Lectures");
            DropTable("dbo.StudyPrograms");
            DropTable("dbo.Faculties");
        }
    }
}
