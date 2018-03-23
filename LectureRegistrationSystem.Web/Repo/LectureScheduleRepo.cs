using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LectureRegistrationSystem.Web.Models;
using WebGrease.Css.Extensions;

namespace LectureRegistrationSystem.Web.Repo
{
    public class LectureScheduleRepo
    {
        public List<int> GetAllStudyProgramLectures(DateTime date, int studyProgramId)
        {
            using (var db = new ApplicationDbContext())
            {
                return db.LectureSchedules.Where(l => l.StudyProgramId == l.StudyProgramId && l.Date == date).Select(p => p.LectureId).ToList();
            }
        }
    }
}