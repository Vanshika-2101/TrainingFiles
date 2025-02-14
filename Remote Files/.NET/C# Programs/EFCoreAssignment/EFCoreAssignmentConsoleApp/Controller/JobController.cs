using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignmentConsoleApp.Repo;

namespace EFCoreAssignmentConsoleApp.Controller
{
    public class JobController
    {
        IJobs _job;
        public JobController(IJobs job)
        {
            _job = job;
        }

        public void FetchJobs()
        {
            _job.FetchAllJobs();
        }

        public void FetchJobId(string Id)
        {
            _job.FetchJobById(Id);
        }

        public void DeleteJob(string Id)
        {
            _job.DeleteAJob(Id);
        }

        public void AddJob(string Id, string Title, int MaxSal, int MinSal)
        {
            _job.AddAJob(Id, Title, MaxSal, MinSal);
        }

    }
}
