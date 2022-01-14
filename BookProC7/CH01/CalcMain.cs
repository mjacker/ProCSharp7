using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01
{
    public class CalcMain
    {
        public static void Main()
        {
            Calc c = new Calc();
            int ans = c.Add(10, 84);
            Console.WriteLine("10 + 84 is {0}.", ans);
        }
    }

    // The C# calculator.
    class Calc
    {
        public int Add(int x, int y)
        {   return x + y;   }
    }
}
