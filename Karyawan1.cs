﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSPEMROGRAMAN
{
    class Karyawan1
    {
        public string nama { get; set; }
        public string nik { get; set; }
        public int gaji { get; set; }
        public string nama2 { get; set; }
        public string nik2 { get; set; }
        public int gaji2 { get; set; }
        public void infoGaji()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     Gaji anda bulan ini :");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("No    Nik              Nama               Total Gaji ");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1    {0}       {1}            {2}    ", nik, nama, gaji);
            Console.WriteLine("2    {0}       {1}           {2}    ", nik2, nama2, gaji2);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
        }
        public void kenaikanGaji()
        {
            if (gaji < 0)
            {
                gaji = 0;
            }
            else if (gaji2 < 0)
            {
                gaji2 = 0;
            }
            Console.WriteLine("     Gaji anda setelah mendapat Bonus :");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("No    Nik            Nama                Gaji + Bonus  ");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1     {0}      {1}            {2}      ", nik, nama, gaji + (gaji * 0.1));
            Console.WriteLine("2     {0}      {1}           {2}      ", nik2, nama2, gaji2 + (gaji2 * 0.1));
            Console.WriteLine("--------------------------------------------------------");
        }

    }
}
