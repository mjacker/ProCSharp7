using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Processing Command-Line Arguments 
namespace ProC7.CH03
{
    class LineArguments
    {
        static int Main(string[] args)
        {
            // Process any incoming args.
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine("Arg: {0}", args[i]);
            Console.ReadLine();
            return 0;
        }
    }
}
