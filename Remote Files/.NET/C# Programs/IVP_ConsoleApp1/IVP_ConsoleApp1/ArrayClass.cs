using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class ArrayClass
    {
        int[] marks = new int[5] { 10, 50, 30, 70, 40 };
        string[] company = { "IVP", "AYT", "LTI", "TCS" };
        char[] data = new char[] { '$', '%', '#', '*' };

        int[] eid = new int[10];

        public void Test(params object[] data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public void Info(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        public void CopyData()
        {
            //int i = 0;
            //foreach (int item in marks)
            //{
            //    eid[i++] = item;
            //}

            //marks.CopyTo(eid, 0);

            //Array.Copy(marks, 0, eid, 0, 5);
            Array.Copy(marks, 0, eid, 2, 5);

            foreach (int item in eid)
            {
                Console.WriteLine(item);
            }
        }

        public void sortArrayAsc()
        {
            Array.Sort(marks);

            foreach (int item in marks)
            {
                Console.WriteLine(item);
            }
        }

        public void sortArrayDesc()
        {
            Array.Sort(marks);
            Array.Reverse(marks);

            foreach (int item in marks)
            {
                Console.WriteLine(item);
            }
        }

        public void GetArray()
        {
            Console.WriteLine(marks[0]);
            Console.WriteLine(marks[1]);
            Console.WriteLine(marks[2]);
            Console.WriteLine(marks[3]);
            Console.WriteLine(marks[4]);
        }

        public void GetArrayUsingLoop()
        {
            //for(int i=0; i<marks.Length; i++)
            //{
            //    Console.WriteLine(marks[i]);
            //}

            //foreach(int x in marks) {
            //    Console.WriteLine(x);
            //}

            for (int i = 0; i < company.Length; i++)
            {
                Console.WriteLine(company[i]);
            }

            foreach (string item in company)
            {
                Console.WriteLine(item);
            }

            foreach (char x in data)
            {
                Console.WriteLine(x);
            }

            foreach (int x in eid)
            {
                Console.WriteLine(x);
            }
        }
    }
}