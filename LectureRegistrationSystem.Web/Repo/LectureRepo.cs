using LectureRegistrationSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Repo
{
    public class LectureRepo
    {
        public ICollection<Lecture> GetAllStudyProgramLectures(int studyProgramId)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Lectures.Where(l => l.StudyProgramId == studyProgramId).ToList();
            }
        }

        public Lecture GetLecturesById(int id)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.Lectures.FirstOrDefault(i => i.Id == id);
            }
        }
    }
}