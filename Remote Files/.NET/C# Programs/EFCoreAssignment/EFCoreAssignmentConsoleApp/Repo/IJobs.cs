using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreAssignmentConsoleApp.Repo
{
    public interface IJobs
    {
        public void FetchAllJobs();
        public void FetchJobById(string Id);
        public void AddAJob(string Id, string Title, int MaxSal, int MinSal);
        public void DeleteAJob(string Id);  

    }
}
