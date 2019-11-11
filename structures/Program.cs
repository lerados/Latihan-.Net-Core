using System;

namespace structures
{
    struct Pelajar
    {
        public int Pid;
        public string Pnama;
        public double Prata2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            Console.Write("Masukan jumlah record : ");
            Pelajar[] p = new Pelajar[int.Parse(Console.ReadLine())];
            
            for(int i = 0; i < p.Length; i++)
            {
                Console.Write("Masukan id pelajar  : ");
                p[i].Pid = int.Parse(Console.ReadLine());

                Console.Write("Masukan nama pelajar  : ");
                p[i].Pnama = Console.ReadLine();

                Console.Write("Masukan nilai rata-rata  : ");
                p[i].Prata2 = double.Parse(Console.ReadLine());
            }

            foreach(Pelajar f in p)
            {
                Console.WriteLine("Record ke-" + x);
                Console.WriteLine("Id pelajar      : " + f.Pid);
                Console.WriteLine("Nama pelajar    : " + f.Pnama);
                Console.WriteLine("Nilai rata-rata : " + f.Prata2);
                x++;
            }
            Console.ReadLine();
        }
    }
}
