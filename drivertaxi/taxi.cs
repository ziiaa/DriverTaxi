using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drivertaxi
{
    public class taxi
    {
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public string NumPassenger { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("Nama Driver : {0}", DriverName);
            Console.WriteLine("Pick Up Passenger : {0}", OnDuty);
            Console.WriteLine("Drop Off Passenger : {0}", NumPassenger);
            Console.WriteLine("\nSedang Menjemput Penumpang");
        }
        public void Taxi()
        {
            Console.WriteLine("{0} Selesai Mengantar Penumpang\n", DriverName);
        }
    }
}



