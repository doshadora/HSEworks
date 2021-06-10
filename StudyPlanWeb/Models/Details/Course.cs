using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;

namespace StudyPlanWeb.Models.Details
{
    public class Course
    {
        public int Id { get; set; }
        public int Counter { get; set; }

        public int DirectionId { get; set; }
        public Direction Direction { get; set; }

        public ICollection<StudySubject> StudySubjects { get; set; }

        public string Name => Counter.ToString();

        public Course()
        {
            StudySubjects = new List<StudySubject>();
        }
    }
}