using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProC7.MJTest
{
    class MJEnum
    {
        public static void Main()
        {
            Console.WriteLine(Opciones.a);
        }
        enum Opciones
        {
            a = 100,
            b = 200,
            c = 300,
        }
    }
}

