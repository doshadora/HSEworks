using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;

namespace StudyPlanWeb.Models.Details.Subjects
{
    public class GroupStudySubject
    {
        public int Id { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public string GroupName => Group.Name;

        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int? StudySubjectId { get; set; }
        public StudySubject StudySubject { get; set; }

        public ICollection<StudyTask> StudyTasks { get; set; }

        public GroupStudySubject()
        {
            StudyTasks = new List<StudyTask>();
        }
    }
}