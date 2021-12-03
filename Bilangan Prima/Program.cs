using System;

namespace Bilangan_Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan bilangan : ");
            int bil = Convert.ToInt16(Console.ReadLine());
            int jumlah = 0;

            for (int i = 1; i <= bil; i++)
            {
                if (bil % i == 0)
                {
                    jumlah++;
                }
            }
            if (jumlah == 2)
            {
                Console.WriteLine($"Bilangan {bil} adalah bilangan prima");
            }
            else
            {
                Console.WriteLine($"Bilangan {bil} bukan bilangan prima");
            }
        }
    }
}
