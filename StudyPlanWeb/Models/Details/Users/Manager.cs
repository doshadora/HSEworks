using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;

namespace StudyPlanWeb.Models.Details.Users
{
    [Table("Manager")]
    public class Manager : User
    {
        public Manager() : base() { }
        public Manager(User user, Direction direction) : base()
        {
            Family = user.Family;
            Name = user.Name;
            Patronymic = user.Patronymic;
            Login = user.Login;
            Password = user.Password;
            Birthday = user.Birthday;
            Sex = user.Sex;
            Direction = direction;
        }

        public int DirectionId { get; set; }
        public Direction Direction { get; set; }
    }
}