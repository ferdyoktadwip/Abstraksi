using System;

namespace Abstraction.Abstractclass
{
    public class SayurKalakan : Makanan
    {
        public override void Enak()
        {
            Console.WriteLine("Untuk Menghasilkan Sayur Kalakan yang Enak Harus Menggunakan Ikan yang Segar");
            Console.WriteLine("Sayur Kalakan Merupakan Makanan Khas Pacitan Dengan Bahan Dasar Ikan Hiu");
        }
    }
}