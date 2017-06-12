using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDeseni_kullanımı
{
    class SingletonDeseni_v2
    {
        private static SingletonDeseni_v2 nesne = new SingletonDeseni_v2();
        SingletonDeseni_v2() { 
        
        }
        public static SingletonDeseni_v2 Get() {
            return nesne;
        }
    }
}
