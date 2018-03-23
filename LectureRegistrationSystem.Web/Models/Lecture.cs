using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Models
{
    public class Lecture
    {
        public int Id { get; set; }
        [Display(Name = "Lekcijas nosaukums")]
        public string LectureName { get; set; }
        public int StudyProgramId { get; set; }
        public ICollection<LectureSchedule> LectureSchedules { get; set; }
        public ICollection<LectureVisitRegister> LectureVisitRegister { get; set; }
    }
}