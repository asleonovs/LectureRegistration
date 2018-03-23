namespace LectureRegistrationSystem.Web.Migrations
{
    using LectureRegistrationSystem.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LectureRegistrationSystem.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LectureRegistrationSystem.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Faculties.AddOrUpdate(
                new Faculty { Id = 1, FacultyName = "Arhitektūras fakultāte" },
                new Faculty { Id = 2, FacultyName = "Būvniecības inženierzinātņu fakultāte" },
                new Faculty { Id = 3, FacultyName = "Datorzinātnes un informācijas tehnoloģijas fakultāte" },
                new Faculty { Id = 4, FacultyName = "E-studiju tehnoloģiju un humanitāro zinātņu fakultāte" },
                new Faculty { Id = 5, FacultyName = "Elektronikas un telekomunikāciju fakultāte" },
                new Faculty { Id = 6, FacultyName = "Enerģētikas un elektrotehnikas fakultāte" },
                new Faculty { Id = 7, FacultyName = "Inženierekonomikas un vadības fakultāte" },
                new Faculty { Id = 8, FacultyName = "Mašīnzinību, transporta un aeronautikas fakultāte" },
                new Faculty { Id = 9, FacultyName = "Materiālzinātnes un lietišķās ķīmijas fakultāte" }
                );

            context.StudyPrograms.AddOrUpdate(
                new StudyProgram { Id = 1, StudyProgramName = "Automātika un datortehnika", FacultyId = 3, Group = 1, YearOfStudy = 1 },
                new StudyProgram { Id = 2, StudyProgramName = "Datorsistēmas", FacultyId = 3, Group = 1, YearOfStudy = 1 },
                new StudyProgram { Id = 3, StudyProgramName = "Automatika", FacultyId = 3, Group = 1, YearOfStudy = 1 },
                new StudyProgram { Id = 4, StudyProgramName = "Informācijas tehnoloģija", FacultyId = 3, Group = 1, YearOfStudy = 1 },
                new StudyProgram { Id = 5, StudyProgramName = "Biznesa informātika (angļu valodā)", FacultyId = 3, Group = 2, YearOfStudy = 1 },
                new StudyProgram { Id = 6, StudyProgramName = "Elektronika", FacultyId = 5, Group = 2, YearOfStudy = 1 },
                new StudyProgram { Id = 7, StudyProgramName = "Telekomunikācijas", FacultyId = 5, Group = 1, YearOfStudy = 3 },
                new StudyProgram { Id = 8, StudyProgramName = "Vides zinātne", FacultyId = 6, Group = 5, YearOfStudy = 2 },
                new StudyProgram { Id = 9, StudyProgramName = "Enerģētika un elektrotehnika", FacultyId = 6, Group = 3, YearOfStudy = 4 }
                );

            context.Lectures.AddOrUpdate(
                new Lecture { Id = 1, LectureName = "Ievads ģenētiskos algoritmos", StudyProgramId = 4 },
                new Lecture { Id = 2, LectureName = "Informācijas sistēmu pārvaldība", StudyProgramId = 4 },
                new Lecture { Id = 3, LectureName = "Programmatūras inženierija", StudyProgramId = 4 },
                new Lecture { Id = 4, LectureName = "Ievads ģenētiskos algoritmos", StudyProgramId = 4 },
                new Lecture { Id = 5, LectureName = "Projektēšanas laboratorija", StudyProgramId = 4 },
                new Lecture { Id = 6, LectureName = "Politoloģija", StudyProgramId = 4 },
                new Lecture { Id = 7, LectureName = "Informācijas tehnoloģija", StudyProgramId = 4 },
                new Lecture { Id = 8, LectureName = "Apvienotā Eiropa un Latvija", StudyProgramId = 4 }
                );

            context.LectureSchedules.AddOrUpdate(
                new LectureSchedule { Id = 1, LectureId = 1, Date = new DateTime(2018, 3, 23), Group = 1, StudyProgramId = 4 },
                new LectureSchedule { Id = 2, LectureId = 1, Date = new DateTime(2018, 3, 23), Group = 1, StudyProgramId = 4 },
                new LectureSchedule { Id = 3, LectureId = 7, Date = new DateTime(2018, 3, 23), Group = 1, StudyProgramId = 4 },
                new LectureSchedule { Id = 4, LectureId = 4, Date = new DateTime(2018, 3, 23), Group = 1, StudyProgramId = 4 },
                new LectureSchedule { Id = 5, LectureId = 1, Date = new DateTime(2018, 3, 22), Group = 1, StudyProgramId = 4 },
                new LectureSchedule { Id = 6, LectureId = 1, Date = new DateTime(2018, 3, 22), Group = 1, StudyProgramId = 4 },
                new LectureSchedule { Id = 7, LectureId = 1, Date = new DateTime(2018, 3, 22), Group = 1, StudyProgramId = 4 },
                new LectureSchedule { Id = 8, LectureId = 1, Date = new DateTime(2018, 3, 22), Group = 1, StudyProgramId = 4 }
                );
        }
    }
}
