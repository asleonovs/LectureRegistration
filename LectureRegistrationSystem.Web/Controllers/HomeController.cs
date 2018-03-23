using LectureRegistrationSystem.Web.Models;
using LectureRegistrationSystem.Web.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace LectureRegistrationSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            var lectureScheduleRepo = new LectureScheduleRepo();
            var studentRepo = new StudentRepo();
            var model = new StudyProgram();
            var studyProgramId = studentRepo.GetApplicationUserStudyProgramId(this.User.Identity.GetUserId());
            var lectureIdList = lectureScheduleRepo.GetAllStudyProgramLectures(DateTime.Today, studyProgramId);
            var lectureRepo = new LectureRepo();
            var lectureList = new List<Lecture>();
            for (int i = 0; i < lectureIdList.Count; i++)
            {
                lectureList.Add(lectureRepo.GetLecturesById(lectureIdList[i]));
            }
            model.Lectures = lectureList;
            return View(model.Lectures);
        }

        [Authorize]
        public ActionResult ShowLectures()
        {
            var studentRepo = new StudentRepo();
            var lectureRepo = new LectureRepo();
            var model = new StudyProgram();
            var studyProgramId = studentRepo.GetApplicationUserStudyProgramId(this.User.Identity.GetUserId());
            model.Lectures = lectureRepo.GetAllStudyProgramLectures(studyProgramId);
            return View(model.Lectures);
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}