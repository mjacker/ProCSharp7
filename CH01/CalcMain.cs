using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01
{
    class CalcMain
    {
        public void Main()
        {
            Calc c = new Calc();
            int ans = c.Add(10, 84);
            Console.WriteLine("10 + 84444 is {0}.", ans);
            //Wait for the user to press the Enter key before shutting down.
            Console.ReadLine();
        }
    }

    // The C# calculator.
    class Calc
    {
        public int Add(int x, int y)
        {   return x + y;   }
    }
}
