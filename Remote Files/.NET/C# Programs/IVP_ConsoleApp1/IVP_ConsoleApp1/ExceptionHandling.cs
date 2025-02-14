using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;

namespace IVP_ConsoleApp1
{
    internal class ExceptionHandling
    {
        public void Divide(int a, int b)
        {
            int c = 0;
            try
            {
                c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Zero se divide mat karo.....");
            }
            finally
            {
                Console.WriteLine($"Quotient : {c}");
            } 
        }

        public void ArrayAddition(int[] arr)
        {
            int sum = 0;
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Last element will be at N-1 index position");
            }
            finally
            {
                Console.WriteLine($"Addition of all values : {sum}");
            }
        }
        int SID, data, value;
        string name;
        float marks;
        public void GetStudentDetails()
        {
            
            Console.WriteLine("Please Enter Student Details: ");
            try
            {
                SID = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                marks = Convert.ToSingle(Console.ReadLine());
                data = int.Parse(Console.ReadLine());
                value = (int)marks / data;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Enter the detail in correct format");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"Student Details: {SID} - {name} - {marks} - {value}");
            } 
        }

        public void Voting()
        {
            int age = 17;
            if ( age < 18 )
            {
                throw new AgeException("Age cannot be less than 18");
            }
            else
            {
                Console.WriteLine("You're eligible for voting");
            }
        }
        FileStream fs;
        StreamReader sr;
        public void FileCreation()
        {
            try
            {
                fs = new FileStream("C:\\MyIVPFiles\\Data.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(SystemException ex)
            {
                Console.WriteLine(ex.Message);  
            }
            finally
            {
                if(sr != null && fs != null)
                {
                    sr.Close();
                    fs.Close();
                    sr.Dispose(); //Destroying the objects
                    fs.Dispose();
                }
            } 
        }

        
    }
}
