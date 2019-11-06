using System;

namespace else_if_arrays_dan_pengulangan_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int max;
            int no = 1;

            Console.Write("Masukan jumlah array (maksimal 10): ");
            max = int.Parse(Console.ReadLine());
            if (max <= 10 && max > 0)
            {
                a = new int[max];

                for (int i = 1; i <= a.Length; i++)
                {
                    Console.Write("Masukan angka ke-" + i + " : ");
                    a[i-1] = int.Parse(Console.ReadLine());
                }

                foreach (int f in a)
                {
                    Console.WriteLine("Angka ke-" + no + " = " + f);
                    no++;
                }
            }
            else if(max <= 0)
            {
                Console.WriteLine("Jumlah array tidak boleh kurang dari 0");
            }
            else
            {
                Console.WriteLine("Jumlah array maksimal 10");
            }
            Console.ReadLine();
        }
    }
}
