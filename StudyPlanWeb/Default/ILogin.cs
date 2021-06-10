using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;
using System.Web.Mvc;

namespace StudyPlanWeb.Default
{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }
        event Action Login;
    }

    public interface ILoginService
    {
        User Login(string username, string password);
    }
}