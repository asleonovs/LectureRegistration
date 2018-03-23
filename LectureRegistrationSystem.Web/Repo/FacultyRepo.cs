using LectureRegistrationSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Repo
{
    public class FacultyRepo
    {
        public List<ApplicationUser> GetAllUsers()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Users.ToList();
            }
        }
    }
}