using System;

namespace Operasi_Aritmatika_dan_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            double c;

            Console.WriteLine("Masukan Angka Pertama :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukan Angka Kedua :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Masukan Angka Antara 1 sampai 4 Untuk Memilih :");
            Console.WriteLine("1. Penambahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian");
            int sw = int.Parse(Console.ReadLine());

            switch (sw)
            {
                case 1:
                    c = (double)a + b;
                    Console.WriteLine("Hasil Penambahan adalah : {0} + {1} = {2}", a, b, c);
                    Console.ReadLine();
                    break;

                case 2:
                    c = (double)a - b;
                    Console.WriteLine("Hasil Pengurangan adalah : {0} - {1} = {2}", a, b, c);
                    Console.ReadLine();
                    break;

                case 3:
                    c = (double)a * b;
                    Console.WriteLine("Hasil Perkalian adalah : {0} * {1} = {2}", a, b, c);
                    Console.ReadLine();
                    break;

                case 4:
                    c = (double)a / b;
                    Console.WriteLine("Hasil Pembagian adalah : {0} / {1} = {2}", a, b, c);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Angka Salah");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
