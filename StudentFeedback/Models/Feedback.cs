using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentFeedback.Models
{
    public class Feedback
    {
        public string Name { get; set; }

        public string EnrollmentNo { get; set; }

        public string Subject { get; set; }

        public string Comment { get; set; }
    }
}