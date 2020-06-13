using System;
using Abstraction.Interface;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Kendaraan kendaraan;


            kendaraan = new Panther();
            kendaraan.Merk();

            Console.WriteLine();
            kendaraan = new Ferrari();
            ikendaraan.Merk();
            Console.ReadKey();
        }
    }
}
