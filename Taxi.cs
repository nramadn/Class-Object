using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Object Taxi
            Taxi taxi = new Taxi();

            // Mengset Nilai Properties objek taxi
            taxi.Nama = "Royan";
            taxi.Duty = "Yes";
            taxi.Penumpang = 13;

            // Memanggil method TaxiInfo, PickUpPassenger, dan DropOfPassenger
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOfPassenger();

            Console.ReadKey();
        }
    }
}
