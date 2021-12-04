using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Just a spontaneous personal testing area. */
/* Last testing: 
 * - How to use List<string>
 * - How to print Lint<sttring>*/

namespace ProC7.MJTest
{
    class MJlist
    {

        public static void Main()
        {
            List<string> m = new List<string>();
            m.Add("Hola");
            m.Add("Chao");
            PrintList(m);
            Console.ReadLine();
        }

        static void PrintList(List<string> m)
        {
            for (int i = 0; i < m.Count; i++)
            {
                Console.WriteLine("\n {0}", m[i]);
            }
        }
    }
}
