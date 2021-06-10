using System;
using System.Collections.Generic;
using System.Linq;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;
using System.Web;

namespace StudyPlanWeb.Models.Details.Subjects
{
    public class StudySubject
    {
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public string SubjectName => Subject.Name;

        public ICollection<GroupStudySubject> GroupStudySubjects { get; set; }

        public StudySubject()
        {
            GroupStudySubjects = new List<GroupStudySubject>();
        }
    }
}