using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitydb;

        ParticipentDao participentdb;

        SupervisorDao supervisordb;

        public ActivityService()
        {
            this.activitydb = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activities = activitydb.GetAll();
            return activities;
        }

        // methods for Particepents with activities
        public List<Participent> GetParticipents(int student)
        {
            List<Participent> participents = participentdb.GetAll(student);
            return participents;
        }

        public void RemoveParticipent(int student)
        {
            participentdb.RemoveParticipent(student);
        }

        public void AddParticipent(int student, int activity)
        {
            participentdb.AddParticipent(student, activity);
        }

        // methods for Supervisors with activities

        public List<Supervisor> GetSupervisors(int teacher)
        {
            List<Supervisor> supervisors = supervisordb.GetAll(teacher);
            return supervisors;
        }

        public void RemoveSupervisor(int teacher)
        {
            supervisordb.RemoveSupervisor(teacher);
        }

        public void AddSupervisor(int teacher, int activity)
        {
            supervisordb.AddSupervisor(teacher, activity);
        }
    }
}
