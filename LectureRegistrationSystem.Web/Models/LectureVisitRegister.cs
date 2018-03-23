using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Models
{
    public class LectureVisitRegister
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LectureId { get; set; }
        public int StudyProgramId { get; set; }
    }
}