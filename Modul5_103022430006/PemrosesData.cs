
using Modul5_103022430006;
using System;
using System.IO.Pipelines;

namespace Modul5_103022430006
{
    public class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T a, T b, T c) where T : IComparable<T>
        {
            dynamic max = a; // Menggunakan dynamic untuk memungkinkan operasi matematis
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }
        public static void Main(string[] args)
        {
            PemrosesData pemrosesData = new PemrosesData();
            Console.WriteLine("Nilai terbesar dari 10, 20, dan 15 adalah: " + pemrosesData.DapatkanNilaiTerbesar(10, 20, 15));

        }
    }
}

