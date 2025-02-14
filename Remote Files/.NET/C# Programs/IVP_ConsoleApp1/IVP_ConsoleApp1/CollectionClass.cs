using System;
using System.Collections.Generic; //2.0
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //1.0
using System.Collections.Concurrent; //4.0

namespace IVP_ConsoleApp1
{
    internal class CollectionClass
    {
        public void NonGeneric()
        {
            //ArrayList al = new ArrayList();
            //al.Add(1);
            //al.Add(2);
            //al.Add(3);
            //al.Add("Vanshika");
            //al.Add("Abcdef");
            //al.Add(75.000d);
            //al.Add(6654f);
            //al.Add(true);
            //al.Add(false);
            //Console.WriteLine(al.Count);
            //Console.WriteLine(al);
            //Console.WriteLine("capacity: " + al.Capacity);
            //foreach(var item in al)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue("Vanshika");
            //queue.Enqueue(345.67d);

            //Console.WriteLine(queue.ToString());
            //Console.WriteLine(queue.Count);
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //queue.Dequeue();
            //Console.WriteLine(queue.ToString());
            //Console.WriteLine(queue.Count);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push("Vanshika");
            //stack.Push(365.76d);

            //Console.WriteLine(stack.ToString());
            //Console.WriteLine(stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //stack.Pop();
            //Console.WriteLine(stack.ToString());
            //Console.WriteLine(stack.Count);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable ht = new Hashtable(); //contains key-value pairs
            //ht.Add(1, "India");
            //ht.Add(2, "USA");
            //ht.Add(3, "UK");
            //ht.Add("India", "Delhi");
            //ht.Add("Sri Lanka", "Colombo");

            //Console.WriteLine(ht);

            //foreach(DictionaryEntry ele in ht)
            //{
            //    Console.Write("Key: " + ele.Key);
            //    Console.WriteLine(" Value: " + ele.Value);
            //}

            //ht.Remove(1); //Here 1 is key
            //Console.WriteLine(ht + " after removing key 1");

            //foreach (DictionaryEntry ele in ht)
            //{
            //    Console.Write("Key: " + ele.Key);
            //    Console.WriteLine(" Value: " + ele.Value);
            //}
        }

        public void Generic()
        {
            //List<string> list = new List<string>();
            //list.Add("Vanshika");
            //list.Add("Prachi");
            //list.Add("Khumar");
            //list.Add("Rohit");

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> marks = new List<int>() { 80, 75, 40, 65, 90 };
            //Console.WriteLine(marks);
            //Console.WriteLine(marks.Count);
            //foreach (var item in marks)
            //{
            //    Console.WriteLine(item);
            //}
            //marks.Sort();
            //foreach (var item in marks)
            //{
            //    Console.WriteLine(item);
            //}

            //ICICICustomer cust1 = new ICICICustomer()
            //{
            //    Id = 10,
            //    Name = "Nikhil",
            //    AccType = "Saving",
            //    Balance = 10000f
            //};
            //ICICICustomer cust2 = new ICICICustomer()
            //{
            //    Id = 20,
            //    Name = "Jack",
            //    AccType = "Joint",
            //    Balance = 30000f
            //};
            //ICICICustomer cust3 = new ICICICustomer()
            //{
            //    Id = 30, Name = "Rose", AccType = "Current", Balance = 30000f
            //};

            //List<ICICICustomer> customers = new List<ICICICustomer>() { cust1, cust2, cust3};

            //customers.Add(new ICICICustomer() { Id = 40, Name = "Neha", AccType = "Saving", Balance = 10009f});

            //foreach (var c in customers)
            //{
            //    Console.WriteLine($"{c.Id} - {c.Name} - {c.AccType} - {c.Balance}");
            //}

        }
        public void HashSetDemo()
        {
            HashSet<string> list = new HashSet<string>();  //Only one difference from list; doesn't allow duplicates.

            list.Add("Vanshika");
            list.Add("Prachi");
            list.Add("Khumar");
            list.Add("Rohit");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            HashSet<int> marks = new HashSet<int>() { 80, 75, 40, 65, 90 };
            Console.WriteLine(marks);
            Console.WriteLine(marks.Count);
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }

            //for sorting, we use SortedSet.

            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }

            ICICICustomer cust1 = new ICICICustomer()
            {
                Id = 10,
                Name = "Nikhil",
                AccType = "Saving",
                Balance = 10000f
            };
            ICICICustomer cust2 = new ICICICustomer()
            {
                Id = 20,
                Name = "Jack",
                AccType = "Joint",
                Balance = 30000f
            };
            ICICICustomer cust3 = new ICICICustomer()
            {
                Id = 30,
                Name = "Rose",
                AccType = "Current",
                Balance = 30000f
            };

            HashSet<ICICICustomer> customers = new HashSet<ICICICustomer>() { cust1, cust2, cust3 };

            customers.Add(new ICICICustomer() { Id = 40, Name = "Neha", AccType = "Saving", Balance = 10009f });

            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Id} - {c.Name} - {c.AccType} - {c.Balance}");
            }
        }

        public void SortedSetDemo()
        {
            SortedSet<string> list = new SortedSet<string>();

            list.Add("Vanshika");
            list.Add("Prachi");
            list.Add("Khumar");
            list.Add("Rohit");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            SortedSet<int> marks = new SortedSet<int>() { 80, 75, 40, 65, 90 };
            Console.WriteLine(marks);
            Console.WriteLine(marks.Count);
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }

            ICICICustomer cust1 = new ICICICustomer()
            {
                Id = 10,
                Name = "Nikhil",
                AccType = "Saving",
                Balance = 10000f
            };
            ICICICustomer cust2 = new ICICICustomer()
            {
                Id = 20,
                Name = "Jack",
                AccType = "Joint",
                Balance = 30000f
            };
            ICICICustomer cust3 = new ICICICustomer()
            {
                Id = 30,
                Name = "Rose",
                AccType = "Current",
                Balance = 30000f
            };

            SortedSet<ICICICustomer> customers = new SortedSet<ICICICustomer>() { cust1, cust2, cust3 };

            customers.Add(new ICICICustomer() { Id = 40, Name = "Neha", AccType = "Saving", Balance = 10009f });


            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Id} - {c.Name} - {c.AccType} - {c.Balance}");
            }
        }

        public void StackDemo()
        {
            Stack<string> list = new Stack<string>();

            list.Push("Vanshika");
            list.Push("Prachi");
            list.Push("Khumar");
            list.Push("Rohit");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Stack<int> marks = new Stack<int>();
            marks.Push(85);
            marks.Push(90);
            marks.Push(75);
            marks.Push(30);

            Console.WriteLine(marks);
            Console.WriteLine(marks.Count);
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }

            ICICICustomer cust1 = new ICICICustomer()
            {
                Id = 10,
                Name = "Nikhil",
                AccType = "Saving",
                Balance = 10000f
            };
            ICICICustomer cust2 = new ICICICustomer()
            {
                Id = 20,
                Name = "Jack",
                AccType = "Joint",
                Balance = 30000f
            };
            ICICICustomer cust3 = new ICICICustomer()
            {
                Id = 30,
                Name = "Rose",
                AccType = "Current",
                Balance = 30000f
            };

            Stack<ICICICustomer> customers = new Stack<ICICICustomer>();
            customers.Push(cust1);
            customers.Push(cust2);
            customers.Push(cust3);

            customers.Push(new ICICICustomer() { Id = 40, Name = "Neha", AccType = "Saving", Balance = 10009f });


            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Id} - {c.Name} - {c.AccType} - {c.Balance}");
            }
        }


        public void QueueDemo()
        {
            Queue<string> list = new Queue<string>();

            list.Enqueue("Vanshika");
            list.Enqueue("Prachi");
            list.Enqueue("Khumar");
            list.Enqueue("Rohit");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Queue<int> marks = new Queue<int>();
            marks.Enqueue(85);
            marks.Enqueue(90);
            marks.Enqueue(75);
            marks.Enqueue(30);

            Console.WriteLine(marks);
            Console.WriteLine(marks.Count);
            foreach (var item in marks)
            {
                Console.WriteLine(item);
            }

            ICICICustomer cust1 = new ICICICustomer()
            {
                Id = 10,
                Name = "Nikhil",
                AccType = "Saving",
                Balance = 10000f
            };
            ICICICustomer cust2 = new ICICICustomer()
            {
                Id = 20,
                Name = "Jack",
                AccType = "Joint",
                Balance = 30000f
            };
            ICICICustomer cust3 = new ICICICustomer()
            {
                Id = 30,
                Name = "Rose",
                AccType = "Current",
                Balance = 30000f
            };

            Queue<ICICICustomer> customers = new Queue<ICICICustomer>();
            customers.Enqueue(cust1);
            customers.Enqueue(cust2);
            customers.Enqueue(cust3);

            customers.Enqueue(new ICICICustomer() { Id = 40, Name = "Neha", AccType = "Saving", Balance = 10009f });


            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Id} - {c.Name} - {c.AccType} - {c.Balance}");
            }
        }

        public void LinkedListDemo()
        {
            LinkedList<string> companies = new LinkedList<string>();
            companies.AddLast("Nikhil");
            companies.AddLast("Jack");
            companies.AddLast("Rose");
            companies.AddLast("Neha");
            companies.AddFirst("Aaryan");

            foreach (var c in companies)
            {
                Console.WriteLine(c);
            }

            LinkedListNode<string> str = companies.Find("Jack");
            companies.AddBefore(str, "Prachi");
            companies.AddAfter(str, "Rohit");

            foreach (var c in companies)
            {
                Console.WriteLine(c);
            }

        }

        public void DictionaryDemo()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Vanshika");
            dict.Add(2, "Bbbbb");
            dict.Add(3, "Ccccc");
            dict.Add(4, "Ddddd");

            foreach (KeyValuePair<int, string> c in dict)
            {
                Console.WriteLine(c.Key + " : "+ c.Value);
            }

            Dictionary<string, string> dict2 = new Dictionary<string, string>();
            dict2.Add("1a", "Vanshika");
            dict2.Add("2b", "Bbbbb");
            dict2.Add("3c", "Ccccc");
            dict2.Add("4d", "Ddddd");

            foreach (var c in dict2)
            {
                Console.WriteLine(c.Key + " : " + c.Value);
            }

        }

        public void SortedDictionaryDemo()
        {
            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();
            dict.Add(1, "Vanshika");
            dict.Add(2, "Bbbbb");
            dict.Add(3, "Ccccc");
            dict.Add(4, "Ddddd");

            foreach (KeyValuePair<int, string> c in dict)
            {
                Console.WriteLine(c.Key + " : " + c.Value);
            }

            SortedDictionary<string, string> dict2 = new SortedDictionary<string, string>();
            dict2.Add("1a", "Vanshika");
            dict2.Add("2b", "Bbbbb");
            dict2.Add("3c", "Ccccc");
            dict2.Add("4d", "Ddddd");

            foreach (var c in dict2)
            {
                Console.WriteLine(c.Key + " : " + c.Value);
            }

        }


        public void SortedListDemo()
        {
            SortedList<int, string> dict = new SortedList<int, string>();
            dict.Add(1, "Vanshika");
            dict.Add(2, "Bbbbb");
            dict.Add(3, "Ccccc");
            dict.Add(4, "Ddddd");

            foreach (KeyValuePair<int, string> c in dict)
            {
                Console.WriteLine(c.Key + " : " + c.Value);
            }

            SortedList<string, string> dict2 = new SortedList<string, string>();
            dict2.Add("1a", "Vanshika");
            dict2.Add("2b", "Bbbbb");
            dict2.Add("3c", "Ccccc");
            dict2.Add("4d", "Ddddd");

            foreach (var c in dict2)
            {
                Console.WriteLine(c.Key + " : " + c.Value);
            }
        }





    }
}
