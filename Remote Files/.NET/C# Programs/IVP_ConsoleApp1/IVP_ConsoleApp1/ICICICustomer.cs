using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVP_ConsoleApp1
{
    internal class ICICICustomer: IComparable<ICICICustomer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AccType { get; set; }
        public float Balance { get; set; }

        public int CompareTo(ICICICustomer? other)
        {
            return this.Id.CompareTo(other.Id);
        }


    }
}
