using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;

namespace StudyPlanWeb.Models.Details.Tasks
{
    public class StudyTask
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(32)]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public ICollection<GroupStudySubject> GroupStudySubjects { get; set; }
        public ICollection<TaskRating> Ratings { get; set; }

        public StudyTask()
        {
            GroupStudySubjects = new List<GroupStudySubject>();
            Ratings = new List<TaskRating>();
        }

        public override string ToString()
        {
            return $"Срок сдачи: {EndDate:D}; {Name}";
        }
    }
}