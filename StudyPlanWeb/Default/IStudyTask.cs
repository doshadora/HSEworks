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
    interface IStudyTaskView : IView
    {
        List<Subject> Subjects { set; }
        Subject CurrentSubject { get; }

        List<GroupStudySubject> Groups { set; }
        GroupStudySubject CurrentGroup { get; }


        List<Student> Students { set; }
        Student CurrentStudent { get; }
        string Rating { get; }
        List<StudyTask> StudyTasks { set; }
        StudyTask CurrentStudyTask { get; }

        string StudyTaskName { get; }
        DateTime StartTime { get; }
        DateTime EndTime { get; }

        event Action AddTask;
        event Action AddRating;
        event Action ChangeSubject;
        event Action ChangeGroup;
        event Action ChangeStudent;
    }

    interface IStudyTaskService
    {
        Teacher GetTeacher(int teacherId);
        string AddTask(GroupStudySubject gpss, string name, DateTime startTime, DateTime endTime);
        string AddRating(StudyTask task, Student student, string rating);
    }
}