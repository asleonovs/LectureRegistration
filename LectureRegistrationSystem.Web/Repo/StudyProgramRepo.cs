using LectureRegistrationSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Repo
{
    public class StudyProgramRepo
    {
        public List<StudyProgram> GetAllStudyPrograms()
        {
            using (var db = new ApplicationDbContext())
            {
                return db.StudyPrograms.ToList();
            }
        }
        public List<StudyProgram> GetAllStudyProgramsByFacultyId(int facultyId)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.StudyPrograms.Where(f => f.FacultyId == facultyId).ToList();
            }
        }
    }
}