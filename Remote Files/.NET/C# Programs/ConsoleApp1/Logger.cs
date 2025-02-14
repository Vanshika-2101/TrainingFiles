using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BankProject
{
    internal static class Logger
    {
        public static void LogMessage(string message)
        {
            string filePath = ConfigurationManager.AppSettings["path"];
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(DateTime.Now.ToString() + " - " + message);
            } 
        }
    }
}
