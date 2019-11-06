using System;

namespace Pengulangan_dan_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1 = 10;
            int w2;
            int dw;

            Console.WriteLine("Pengulangan For Membentuk Segitiga");
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadLine();

            Console.WriteLine("Pengulangan While Membentuk Segitiga");
            while (w1 > 0)
            {
                w2 = w1 - 1;
                while (w2 > 0)
                {
                    Console.Write("*");
                    w2--;
                }
                Console.WriteLine("*");
                w1--;
            }
            Console.ReadLine();

            Console.WriteLine("Pengulangan Do While");
            Console.WriteLine("Masukan angka 0 untuk mengakhiri pengulangan");
            do
            {
                dw = int.Parse(Console.ReadLine());
            }
            while (dw != 0);
            Console.WriteLine("Pengulangan berhenti");
            Console.ReadLine();
        }
    }
}
