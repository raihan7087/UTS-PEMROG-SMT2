using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSPEMROGRAMAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan1 krywn = new Karyawan1();

            krywn.nama = "MBAH TEJO";
            krywn.nik = "770841294";
            krywn.gaji = 2000000;

            krywn.nama2 = "BANG KODIR";
            krywn.nik2 = "770841293";
            krywn.gaji2 = 3000000;

            krywn.infoGaji();
            Console.WriteLine();
            krywn.kenaikanGaji();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
