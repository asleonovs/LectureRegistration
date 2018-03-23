using LectureRegistrationSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Repo
{
    public class StudentRepo
    {
        public int GetApplicationUserStudyProgramId(string studentId)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Users.FirstOrDefault(u => u.Id.Equals(studentId)).StudyProgramId;
            }
        }
    }
}