using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IVP_ConsoleApp1
{
    internal class FileHandling
    {
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        FileInfo fi;
        DirectoryInfo di;
        
        //File creation
        public void FileCreate()
        {   
            //prefixing with @ removes the need to give escape sequence in path string
            fs = new FileStream(@"C:\MyIVPFiles\MyData1.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine("Welcome to file handling class");
            sw.WriteLine("This is IVP data");
            sw.Flush(); // clear buffer in memory
            sw.Close();
            fs.Close();
            Console.WriteLine("Done");
        }

        //File read and write
        public void FileRead()
        {
            //prefixing with @ removes the need to give escape sequence in path string
            fs = new FileStream(@"C:\MyIVPFiles\MyData1.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs.Close();
        }

        //DirectoryInfo

        public void DirectoryDetails()
        {
            di = new DirectoryInfo("C:\\Users\\vaaggarwal\\Desktop");
            DirectoryInfo[] dirs = di.GetDirectories();
            //foreach (DirectoryInfo dir in dirs)
            //{
            //    Console.WriteLine(dir.Name + " " + dir.CreationTime);
            //}
            //FileInfo[] files = di.GetFiles();
            //foreach (FileInfo file in files)
            //{
            //    Console.WriteLine(file.Name + " " + file.LastWriteTime + " " + file.Extension);
            //}
            foreach (DirectoryInfo dir in dirs)
            {
                Console.WriteLine(dir.Name);
                FileInfo[] dirfiles = dir.GetFiles();
                foreach (FileInfo file in dirfiles)
                {
                    Console.WriteLine(file.Name + " " + file.LastWriteTime + " " + file.Extension);
                }
            }
        }

        public void DirectoryMethods()
        {
            //di = new DirectoryInfo("C:\\Users\\vaaggarwal\\Desktop\\MCABatch");
            //Creating Directory
            //di.Create();
            //Console.WriteLine("Created");

            //DirectoryInfo subdir = di.CreateSubdirectory("MCABatchSubDir");
            //Console.WriteLine(subdir.Name + " Subdirectory Created");

            //Move a directory
            //subdir.MoveTo("C:\\Users\\vaaggarwal\\Desktop");

            //deleting
            //di.Delete();
            //First you need to delete the subdir in it
            //subdir.Delete();
            //di.Delete();
            //Console.WriteLine("Deleted");
        }

        public void FileInfoMethods()
        {
            fi = new FileInfo(@"C:\MyIVPFiles\MCAData.txt");
            //fi.Create();
            //Console.WriteLine(fi.Name + " Created");


            //sw = fi.CreateText(); 
            //// It creates a streamWriter to write the text into the file
            //sw.WriteLine("SQL completed, \nC# in progress, \nADO.NET pending");
            //sw.Close ();

            sw = fi.AppendText();
            // It creates a streamWriter to write the text into the file
            sw.WriteLine("SQL completed, \nC# in progress, \nADO.NET pending");
            sw.Close();


            sr = fi.OpenText();
            string s = "";
            while((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            // null indicates end of the file here.

            //fi.Delete();

        }

        //BinaryWriter Class
        public void BinaryFileHandling()
        {
            //fs = File.Open(@"C:\MyIVPFiles\Student.bin", FileMode.Create);
            //BinaryWriter bw = new BinaryWriter(fs);
            //bw.Write(10);
            //bw.Write("Vanshika");
            //bw.Write("Electrical");
            //bw.Write(78.5f);
            //bw.Write(true);
            //bw.Close();
            //fs.Close();

            fs = File.Open(@"C:\MyIVPFiles\Student.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine("Student id: " + br.ReadInt32());
            Console.WriteLine("Student name: " + br.ReadString());
            Console.WriteLine("Student branch: " + br.ReadString());
            Console.WriteLine("Student marks: " + br.ReadSingle());
            Console.WriteLine("Student in college?: " + br.ReadBoolean());
            br.Close();
            fs.Close();
        }

        public void FileMethods()
        {
            if (File.Exists(@"C:\MyIVPFiles\MCAData.txt"))
            {
                Console.WriteLine("File exists");
                string[] lines = File.ReadAllLines(@"C:\MyIVPFiles\MCAData.txt");
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
                string text = File.ReadAllText(@"C:\MyIVPFiles\MCAData.txt");
                Console.WriteLine("Text ====== " + text);
            }
            else
            {
                Console.WriteLine("Please create the file");
            }
        }

        public void TestFile()
        {
            fs = new FileStream(@"C:\MyIVPFiles\Test.txt", FileMode.Create, FileAccess.Write);
            sw = new StreamWriter(fs);
            int i = 65;
            while (i != 91)
            {
                sw.Write(Convert.ToChar(i++));
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }

    }
}
 