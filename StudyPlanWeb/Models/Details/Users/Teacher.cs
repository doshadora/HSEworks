using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;

namespace StudyPlanWeb.Models.Details.Users
{
    public class Teacher : User
    {
        public Teacher(User user)
        {
            Family = user.Family;
            Name = user.Name;
            Patronymic = user.Patronymic;
            Login = user.Login;
            Password = user.Password;
            Birthday = user.Birthday;
            Sex = user.Sex;
            GroupStudySubjects = new List<GroupStudySubject>();
            Subjects = new List<Subject>();
        }

        public ICollection<GroupStudySubject> GroupStudySubjects { get; set; }
        public ICollection<Subject> Subjects { get; set; }

        public Teacher()
        {
            GroupStudySubjects = new List<GroupStudySubject>();
            Subjects = new List<Subject>();
        }
    }
}