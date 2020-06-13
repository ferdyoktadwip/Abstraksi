using System;
using Abstraction.Abstractclass;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Makanan  makanan;

            makanan SayurKalakan();
            makanan.Enak();

            Console.ReadKey();
        }
    }
}
