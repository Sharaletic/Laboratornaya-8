using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laboratornaya_8.Transformator;

namespace Laboratornaya_8
{
    public class Customer
    {
        public string FullName { get; set; }
        public byte GentleRate { get; set; }

        public Customer(string FullName, byte GentleRate)
        {
            this.FullName = FullName;
            this.GentleRate = GentleRate;
        }


        //агрегация: один человек, но много телефонов
        public GentleSmartphone gentleSmartphone { get; set; }


        //агрегация:
        public Transformator TransformatorModule { get; set; }

    }
}
