using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Users;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details;
using System.Web.Mvc;
using System.Collections.Generic;

namespace StudyPlanWeb.Default
{
    interface IDirectionView : IView
    {
        string Name { set; }

        string AdmisionYear { get; }
        List<Group> Groups { set; }
        Group CurrentGroup { get; }

        Course CurrentCourse { get; }
        List<Course> Courses { set; }

        Subject CurrentSubject { get; }
        List<Subject> OtherSubjects { set; }

        List<Subject> CourseSubjects { set; }

        event Action AddSubject;
        event Action ChangeCourse;
        event Action AddGroup;
        event Action EditGroup;
    }

    interface IDirectionService
    {
        Direction LoadDirection(Manager manager);
        List<Subject> GetAllSubjects();
        string AddGroup(Direction dir, string year);
        string AddSubject(Course course, Subject subject);
    }
}