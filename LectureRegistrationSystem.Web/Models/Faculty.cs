using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string FacultyName { get; set; }
        public ICollection<StudyProgram> StudyPrograms {get;set;}
    }
}