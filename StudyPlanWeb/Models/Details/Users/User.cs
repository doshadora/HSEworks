using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;

namespace StudyPlanWeb.Models.Details.Users
{
    public class User
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false), MaxLength(32), StringLength(32, MinimumLength = 3)]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false), MaxLength(32), StringLength(32, MinimumLength = 3)]
        public string Family { get; set; }
        [MaxLength(32)]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false), MaxLength(32), StringLength(32, MinimumLength = 5)]
        [Index(IsUnique = true)]
        [Display(Name = "Логин")]
        public string Login { get; set; }
        [Required(AllowEmptyStrings = false), MaxLength(256), StringLength(256, MinimumLength = 8)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false)]
        public DateTime Birthday { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Sex { get; set; }

        public string FullName => $"{Family} {Name} {Patronymic}";

        public void SetPassword(string password)
        {
            Password = password;
        }

        public bool CheckPassword(string password)
        {
            return Password == password;
        }
    }
}