﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _302pt2
{
    internal class mobil
    {
        public string merek;
        public string warna;

        public void maju()
        {
            Console.WriteLine("mobil dengan bermerek " + this.merek + " Warna nya " + this.warna + " Berjalan Maju");
        }

        static void Main(string[] args)
        {
            string a, b;

            Console.WriteLine("====================");
            Console.WriteLine("Program Input mobil");
            Console.WriteLine("====================\n");

            Console.Write("Masukkan Merek Mobil Anda   : ");
            a = Console.ReadLine();

            Console.Write("Masukkan Warna Mobil Anda   : ");
            b = Console.ReadLine();

            mobil mobil1 = new mobil();
            mobil1.merek = a;
            mobil1.warna = b;

            mobil1.maju();

            Console.ReadKey();
        }
    }
}
