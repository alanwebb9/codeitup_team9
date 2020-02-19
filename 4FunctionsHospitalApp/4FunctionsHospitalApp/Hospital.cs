using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4FunctionsHospitalApp
{
    class Hospital
    {
       public string name { get; set; }
       public string address { get; set; }

       public string eircode { get; set; }

       public string county { get; set; }

        public Hospital(string name, string address, string eirode, string county)
        {
            this.name = name;
            this.address = address;
            this.eircode = eircode;
            this.county = county;
        }
        public Hospital(string name)
        {
            this.name = name;
        }
        public void Display(string name)
        {
            Console.WriteLine();
        }

        //public void Display(string name, string address, string eircode, string county)
        //{
        //    Console.WriteLine("(0)";
        //}




    } 
}
