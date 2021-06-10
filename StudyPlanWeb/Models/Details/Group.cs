using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyPlanWeb.Models.Details
{
    public class Group
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false), MaxLength(32)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public int DirectionId { get; set; }
        public Direction Direction { get; set; }

        [Required]
        public int AdmisionYear { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<GroupStudySubject> GroupStudySubjects { get; set; }

        public int Course()
        {
            int course = DateTime.Today.Year - AdmisionYear;
            if (DateTime.Today.Month > 6)
                course += 1;
            return course;
        }

        public Group()
        {
            Students = new List<Student>();
            GroupStudySubjects = new List<GroupStudySubject>();
        }
        public Group(Direction dir, int admissionYear, int counter)
        {
            Name = $"{dir.ShortName}-{admissionYear % 100}-{counter}";
            Direction = dir;
            AdmisionYear = admissionYear;
            Students = new List<Student>();
            GroupStudySubjects = new List<GroupStudySubject>();
        }
    }
}