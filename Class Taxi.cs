using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        // Properties  
        public string Nama { get; set; }
        public string Duty { get; set; }
        public int Penumpang { get; set; }

        // Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", Nama);
            Console.WriteLine("OnDuty : {0}", Duty);
            Console.WriteLine("Number of Passengers : {0}", Penumpang);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} Sedang menjemput penumpang", Nama);
        }

        public void DropOfPassenger()
        {
            Console.WriteLine("{0} Selesai mengantar penumpang", Nama);
        }
    }
}
