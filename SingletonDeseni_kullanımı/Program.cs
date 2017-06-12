using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDeseni_kullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDeseni nesne1 = SingletonDeseni.Nesne;
            SingletonDeseni_v2 nesne2 = SingletonDeseni_v2.Get();
            SingletonDeseni_v3 nesne3 = SingletonDeseni_v3.Nesne();
            Console.WriteLine(nesne1.a * nesne1.b);
            Console.ReadKey();
        }
    }
}
