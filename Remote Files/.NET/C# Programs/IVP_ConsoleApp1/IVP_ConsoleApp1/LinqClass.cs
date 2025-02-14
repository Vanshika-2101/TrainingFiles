using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class LinqClass
    {
        public void LinqMethods()
        {
            List<IVPStudent> list = new List<IVPStudent>()
            {
                new IVPStudent() { ID = 10, Name = "Nikhil", Marks = 90 },
                new IVPStudent() { ID = 20, Name = "Nikhil", Marks = 80 },
                new IVPStudent() { ID = 30, Name = "Rose", Marks = 95 },
                new IVPStudent() { ID = 40, Name = "Jack", Marks = 92 }
            };

            List<IVPStudent> nStuds = list.Where(a => a.Name.StartsWith("N")).ToList();
            foreach (var s in nStuds)
            {
                Console.WriteLine(s.Name);
            }

            List<Branch> subject = new List<Branch>()
            {
                new Branch() { ID = 10, BranchName = "Electrical"},
                new Branch() { ID = 20, BranchName = "CS"},
                new Branch() { ID = 30, BranchName = "IT"},
                new Branch() { ID = 40, BranchName = "IT"}
            };

            //Method syntax

            //Console.WriteLine("Method syntax");
            //var data1 = list.Join(subject, l => l.ID, s => s.ID, (l, s) => new { l.ID , l.Name , s.BranchName , l.Marks });
            
            //foreach (var student in data1)
            //{
            //    Console.WriteLine($"{student.ID} - {student.Name} - {student.BranchName} - {student.ID}");
            //}


            //var std = list.Where(m => m.Marks > 80);
            //var std1 = list.Where(m => m.Marks >= 80 && m.Marks <= 90);
            //var std = list.Where(m => m.Marks > 80).Where(m => m.Marks <= 90);
            //var std = list.OrderBy(x => x.Name);
            //var std = list.OrderByDescending(x => x.Name);
            //var std = list.OrderBy(x => x.Name).ThenByDescending(x => x.Marks);
            //var SumMarks = list.Sum(x => x.Marks);
            //var AvgMarks = list.Average(x => x.Marks);
            //var MinMarks = list.Min(x => x.Marks);
            //var MaxMarks = list.Max(x => x.Marks);
            //var std1 = list.Find(s => s.ID == 10);
            //Console.WriteLine(std1.ID + " - " + std1.Name + " - " + std1.Marks);



            //foreach (var student in std)
            //{
            //    Console.WriteLine(student.ID + " - " + student.Name + " - " + student.Marks);
            //}

            Console.WriteLine();

            //Query syntax (not generally used)

            Console.WriteLine("Query syntax");

            //var info = from s in list
            //           where s.Name == "Nikhil"
            //           select s;

            //var info = from s in list
            //           where s.Marks > 80
            //           where s.Marks <= 90
            //           select s;

            //var info = from s in list
            //           orderby s.Name ascending
            //           select s;

            //var info = from s in list
            //           orderby s.Name descending
            //           select s;

            //var info = from s in list
            //           orderby s.Name ascending, s.Marks descending
            //           select s;

            //var info = from s in list
            //           orderby s.Name ascending, s.Marks descending
            //           select new { s.ID, s.Name, s.Marks };

            //foreach (var student in info)
            //{
            //    Console.WriteLine(student.ID + " - " + student.Name + " - " + student.Marks);
            //}



            //var data = from s in list
            //           from m in subject
            //           where s.ID == m.ID
            //           select new {s.ID, s.Name, m.BranchName, s.Marks};

            //foreach (var student in data)
            //{
            //    Console.WriteLine($"{student.ID} - {student.Name} - {student.BranchName} - {student.ID}");
            //}

        }


    }
}
