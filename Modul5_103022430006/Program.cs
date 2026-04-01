//Tanpa membuat file baru (gunakan file yang dibuat saat membuat project):
//1.Buatlah sebuah class bernama “PemrosesData”.
//2. Pada class tersebut, tambahkan sebuah method dengan nama “DapatkanNilaiTerbesar” 
//yang memiliki tiga parameter generic yang sama yaitu “T”. 
//3. Method tersebut dapat melakukan pencarian nilai terbesar dari tiga input/argument yang 
//diberikan pada method tersebut. 
//4. Hint: Gunakan variable sementara dengan tipe data dynamic untuk memungkinkan 
//operasi matematis misalnya penjumlahan.
//5. Hint: Gunakan operator perbandingan untuk menentukan nilai maksimum

using System;

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
    }
}