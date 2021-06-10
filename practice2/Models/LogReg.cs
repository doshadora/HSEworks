using practice2.DAL;
using System;
using System.ComponentModel.DataAnnotations;

namespace practice2.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Логин")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class RegisterModelCust
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 100 символов")]
        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Длина строки должна быть 11 символов")]
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Длина строки должна быть от 8 до 50 символов")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BDay { get; set; }
    }
}