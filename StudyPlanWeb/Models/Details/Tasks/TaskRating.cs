using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;

namespace StudyPlanWeb.Models.Details.Tasks
{
    public class TaskRating
    {
        public int Id { get; set; }

        public int Rating { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int StudyTaskId { get; set; }
        public StudyTask StudyTask { get; set; }

        public string TaskName => StudyTask.Name;
    }
}