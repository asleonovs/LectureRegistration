using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LectureRegistrationSystem.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int StudyProgramId { get; set; }
        public int Group { get; set; }
        public int YearOfStudy { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("LectureRegistrationSystem", throwIfV1Schema: false)
        {
        }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<StudyProgram> StudyPrograms { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<LectureSchedule> LectureSchedules { get; set; }
        public DbSet<LectureVisitRegister> LectureVisitsRegister { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}