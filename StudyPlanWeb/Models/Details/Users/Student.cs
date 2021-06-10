using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;
using System.Collections.Generic;

namespace StudyPlanWeb.Models.Details.Users
{
    [Table("Students")]
    public class Student : User
    {
        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<TaskRating> Ratings { get; set; }
        public Student()
        {
            Ratings = new List<TaskRating>();
        }
    }
}