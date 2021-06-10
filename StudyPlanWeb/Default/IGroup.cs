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
    public delegate void AddStudentEventHandler(object sender, AddStudentEventArgs e);
    public class AddStudentEventArgs : EventArgs
    {
        public Student Student { get; set; }
    }

    interface IGroupView : IView
    {
        string Name { set; }

        List<Student> Students { set; }
        Student CurrentStudent { get; }

        List<Course> Courses { set; }
        Course CurrentCourse { get; }

        List<StudySubject> Subjects { set; }
        List<StudySubject> OtherSubjects { set; }
        StudySubject CurrentSubject { get; }

        List<Teacher> Teachers { set; }
        Teacher CurrentTeacher { get; }

        event AddStudentEventHandler AddStudent;
        event Action RemoveStudent;
        event Action AddGroupStudySubject;
        event Action OtherSubjectChanged;
        event Action ChangeCourse;
    }

    interface IGroupService
    {
        Group GetGroup(int groupId);
        string AddStudent(Group group, Student student);
        string AddGroupStudySubject(Group group, Teacher teacher, StudySubject studySubject);
        string RemoveStudent(Group group, Student student);
    }
}