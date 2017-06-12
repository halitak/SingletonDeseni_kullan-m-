using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDeseni_kullanımı
{
    class SingletonDeseni_v3
    {
        private static SingletonDeseni_v3 nesne;
        SingletonDeseni_v3() { }
        public static SingletonDeseni_v3 Nesne() {
            if (nesne==null)
            {
                nesne = new SingletonDeseni_v3();
            }
            return nesne;
        }
    }
}
