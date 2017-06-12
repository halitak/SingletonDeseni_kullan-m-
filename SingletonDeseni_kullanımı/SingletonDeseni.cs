using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDeseni_kullanımı
{
    class SingletonDeseni
    {
        static private SingletonDeseni nesne=new SingletonDeseni();
        public int a;
        public int b;
        private SingletonDeseni() {
            a = 4;
            b = 5;
        }
        public static SingletonDeseni Nesne {
            get{
            return nesne;
            }
        }
    }
}
