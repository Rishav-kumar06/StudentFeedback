using System;
using System.Collections.Generic;
using System.Web.Mvc;
using StudentFeedback.Models;

namespace StudentFeedback.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (string.IsNullOrWhiteSpace(feedback.Name))
                ModelState.AddModelError("Name", "Name is required");

            if (string.IsNullOrWhiteSpace(feedback.EnrollmentNo))
                ModelState.AddModelError("EnrollmentNo", "Enrollment No is required");

            if (string.IsNullOrWhiteSpace(feedback.Subject))
                ModelState.AddModelError("Subject", "Subject is required");

            if (string.IsNullOrWhiteSpace(feedback.Comment))
                ModelState.AddModelError("Comment", "Comment is required");

            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);
                return RedirectToAction("List");
            }

            return View(feedback);
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}