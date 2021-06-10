using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyPlanWeb.Models.Details.Subjects
{
    public class Subject
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(64)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public ICollection<StudySubject> StudySubjects { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

        public Subject()
        {
            StudySubjects = new List<StudySubject>();
            Teachers = new List<Teacher>();
        }
    }
}