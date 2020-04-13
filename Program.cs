using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2610
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan("Muhammad",192610 , 7000000);
            Karyawan karyawan2 = new Karyawan("Agung",192611, 6000);
            Karyawan karyawan3 = new Karyawan("Wicaksonsidi", 192612, 75000);

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.lihatKaryawan();
            Console.WriteLine();
            karyawan2.lihatKaryawan();
            Console.WriteLine();
            karyawan3.lihatKaryawan();

            Console.WriteLine("\n\n Asiqqq kenaikan gaji cuy");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.NaikGaji();
            Console.WriteLine();
            karyawan2.NaikGaji();
            Console.WriteLine();
            karyawan3.NaikGaji();

            Console.ReadKey();
        }
    }
}
