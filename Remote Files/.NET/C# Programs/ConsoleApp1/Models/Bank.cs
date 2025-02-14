using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject.Models
{
    internal class Bank
    {
        public int CID { get; set; }
        public string CNAME { get; set; }
        public string ACCTYPE { get; set; }
        public float BALANCE { get; set; }
        public string COUNTRY { get; set; }
    }
}
