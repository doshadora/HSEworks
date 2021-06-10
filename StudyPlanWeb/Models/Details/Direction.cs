using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyPlanWeb.Models.Details
{
    public class Direction
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(64)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false), MaxLength(4)]
        public string ShortName { get; set; }


        public ICollection<Group> Groups { get; set; }
        public ICollection<Manager> Managers { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Direction()
        {
            Groups = new List<Group>();
            Managers = new List<Manager>();
            Courses = new List<Course>();
        }
    }
}