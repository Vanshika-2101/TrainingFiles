using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment_DataAccess.Data;
using EFCoreAssignment_Models.Models;
using Microsoft.EntityFrameworkCore;


namespace EFCoreAssignmentConsoleApp.Repo
{
    public class JobOperations : IJobs
    {
        public void FetchAllJobs()
        {
            using ApplicationDBContext context = new ApplicationDBContext();
            var jobs = context.Jobs.ToList();
            foreach (var job in jobs)
            {
                Console.WriteLine($"{job.JobId} - {job.JobTitle} - {job.MaxSalary} - {job.MinSalary}");
            }
        }
        public void FetchJobById(string Id)
        {
            using ApplicationDBContext context = new ApplicationDBContext();
            var jobs = context.Jobs.Where(x=> x.JobId == Id).ToList();
            foreach (var job in jobs)
            {
                Console.WriteLine($"{job.JobId} - {job.JobTitle} - {job.MaxSalary} - {job.MinSalary}");
            }
        }
        public void AddAJob(string Id, string Title, int MaxSal, int MinSal)
        {
            using ApplicationDBContext context = new ApplicationDBContext();
            Jobs job = new Jobs();  
            job.JobId = Id;
            job.JobTitle = Title;
            job.MaxSalary = MaxSal;
            job.MinSalary = MinSal;
            context.Jobs.Add(job);
            context.SaveChanges();
            Console.WriteLine($"Added new record in Jobs Table: {Id} ");
        }
        public void DeleteAJob(string Id)
        {
            using ApplicationDBContext context = new ApplicationDBContext();
            var del = context.Jobs.Where(x => x.JobId == Id);
            foreach (var job in del)
            {
                context.Jobs.Remove(job);
                Console.WriteLine("Deleted from Jobs Table Jobs having Id = " +  Id);  
            }
            context.SaveChanges();
        }

    }
}
