using StudyPlanWeb.Models;
using StudyPlanWeb.Models.Details;
using StudyPlanWeb.Models.Details.Subjects;
using StudyPlanWeb.Models.Details.Tasks;
using StudyPlanWeb.Models.Details.Users;
using System;
using System.Data.Entity;

namespace StudyPlanWeb.Controllers
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("DbConnection")
        { }


        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Manager> Managers { get; set; }

        public DbSet<Direction> Directions { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudySubject> StudySubjects { get; set; }
        public DbSet<GroupStudySubject> GroupStudySubjects { get; set; }

        public DbSet<StudyTask> StudyTasks { get; set; }
        public DbSet<TaskRating> TaskRatings { get; set; }


        public void RollBack()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        entry.Reload();
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        public string TrySave()
        {
            try
            {
                SaveChanges(); return "";
            }
            catch (Exception e)
            {
                RollBack();
                return e.Message;
            }
        }
    }
}