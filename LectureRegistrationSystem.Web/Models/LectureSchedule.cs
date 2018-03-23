using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Models
{
    public class LectureSchedule
    {
        public int Id { get; set; }
        public int LectureId { get; set; }
        public int StudyProgramId { get; set; }
        public int Group { get; set; }
        public DateTime Date { get; set; }
    }
}