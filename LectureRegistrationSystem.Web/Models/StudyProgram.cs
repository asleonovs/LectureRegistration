using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LectureRegistrationSystem.Web.Models
{
    public class StudyProgram
    {
        public int Id { get; set; }
        [Required]
        public string StudyProgramName { get; set; }
        public int YearOfStudy { get; set; }
        public int Group { get; set; }
        public int FacultyId { get; set; }
        public ICollection<ApplicationUser> Students { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
    }
}