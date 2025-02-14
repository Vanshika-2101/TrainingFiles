using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class ConcurrentCollections
    {
        public void CcDictionaryDemo()
        {
            ConcurrentDictionary<string, string> cd = new ConcurrentDictionary<string, string>();
            cd.TryAdd("India", "Delhi");
            cd.TryAdd("USA", "Washington DC");
            cd.TryAdd("UK", "London");
            
            foreach (KeyValuePair<string, string> kvp in cd)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }

            bool a = cd.TryAdd("India", "New Delhi");
            Console.WriteLine(a);

            //Retrieval of pairs using for loop
            Console.WriteLine("Printing using for loop");
            for(int i = 0; i < cd.Count(); i++)
            {
                string key = cd.Keys.ElementAt(i);
                string value = cd.Values.ElementAt(i);  // or cd[key]
                Console.WriteLine(key + " - " + value);
            }

            //Searching if a specific key exists:
            bool exists = cd.ContainsKey("USA");
            Console.WriteLine("Does USA exists as a key? : " + exists);

            string capital = string.Empty;
            bool z = cd.TryRemove("USA", out capital);
            Console.WriteLine(z + " - " + capital);

            z = cd.TryRemove("China", out capital);
            Console.WriteLine(z + " - " + capital);

            cd.AddOrUpdate("Sri Lanka", "Colombo", (k,v) => "New State");
            cd.AddOrUpdate("Sri Lanka", cd["Sri Lanka"], (k, v) => "New State");
            foreach (KeyValuePair<string, string> kvp in cd)
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }
        }

        public void CcStackDemo()
        {
            ConcurrentStack<string> cs = new ConcurrentStack<string>();
            cs.Push("India");
            cs.Push("USA");
            cs.Push("UK");
            cs.Push("Japan");
            //cs.Push(100); //Compile time error

            foreach (var str in cs)
            {
                Console.WriteLine(str);
            }

            string[] data = { "Australia", "Russia" };
            cs.PushRange(data);
            Console.WriteLine("After PushRange: ");
            foreach (var str in cs)
            {
                Console.WriteLine(str);
            }

            string s = string.Empty;
            bool x = cs.TryPop(out s);
            Console.WriteLine(x + " removed " + s);
            foreach (var str in cs)
            {
                Console.WriteLine(str);
            }

            string[] rem = new string[3];
           
            int remsuc = cs.TryPopRange(rem);
            Console.WriteLine(remsuc + " elements removed");
            Console.WriteLine("Array of removed: ");
            foreach(var r in rem)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("Stack now: ");
            foreach (var str in cs)
            {
                Console.WriteLine(str);
            }

            //Viewing top element
            string top = "";
            bool y = cs.TryPeek(out top);
            Console.WriteLine(y + ", Top element in the current stack is : " + top);

            //Copying stack data to array
            string[] array = new string[2];
            cs.CopyTo(array, 0);
            Console.WriteLine("Array of copied stack elements: ");
            foreach( var str in array)
            {
                Console.WriteLine(str);
            }
            //using objects
            ConcurrentStack<ICICICustomer> customer = new ConcurrentStack<ICICICustomer>();
            customer.Push(new ICICICustomer() { Id = 10, Name = "Nikhil", AccType = "Saving", Balance = 1234567f });
            customer.Push(new ICICICustomer() { Id = 20, Name = "Jack", AccType = "Current", Balance = 34567f });
            customer.Push(new ICICICustomer() { Id = 30, Name = "Rose", AccType = "Joint", Balance = 567f });

            foreach (var item in customer)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.AccType} - {item.Balance}");
            }
        }

        public void CcQueueDemo()
        {
            ConcurrentQueue<string> cq = new ConcurrentQueue<string>();
            cq.Enqueue("India");
            cq.Enqueue("USA");
            cq.Enqueue("UK");
            cq.Enqueue("Japan");

            Console.WriteLine("Queue elements: ");
            foreach (var str in cq)
            {
                Console.WriteLine(str);
            }
            
            string s = string.Empty;
            bool x = cq.TryDequeue(out s);
            Console.WriteLine(x + " removed " + s);
            foreach (var str in cq)
            {
                Console.WriteLine(str);
            }

            //Viewing first element
            string top = "";
            bool y = cq.TryPeek(out top);
            Console.WriteLine(y + ", Top element in the current queue is : " + top);

            //Copying queue data to array
            string[] array = new string[5];
            cq.CopyTo(array, 0);
            Console.WriteLine("Array of copied queue elements: ");
            foreach (var str in array)
            {
                Console.WriteLine(str);
            }

            //using objects
            ConcurrentQueue<ICICICustomer> customer = new ConcurrentQueue<ICICICustomer>();
            customer.Enqueue(new ICICICustomer() { Id = 10, Name = "Nikhil", AccType = "Saving", Balance = 1234567f });
            customer.Enqueue(new ICICICustomer() { Id = 20, Name = "Jack", AccType = "Current", Balance = 34567f });
            customer.Enqueue(new ICICICustomer() { Id = 30, Name = "Rose", AccType = "Joint", Balance = 567f });

            foreach (var item in customer)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.AccType} - {item.Balance}");
            }

        }

        public void CcBagDemo()
        {
            // Similar to the working of generic list

            ConcurrentBag<string> cb = new ConcurrentBag<string>() { "Nepal", "China", "Chile"};
            cb.Add("India");
            cb.Add("USA");
            cb.Add("Sri Lanka");
            cb.Add("Japan");

            foreach(var item in cb)
            {
                Console.WriteLine(item);
            }

            string rem = "";
            bool x = cb.TryTake(out rem);

            Console.WriteLine(x + " removed " + rem);
            Console.WriteLine("After removal: ");
            foreach (var item in cb)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Copying list to array: ");

            string[] arr = new string[10];
            cb.CopyTo(arr, 0);
            foreach(var c in cb)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Top element: ");
            string y = "";
            cb.TryPeek(out y);
            Console.WriteLine(y);

        }

    }
}
