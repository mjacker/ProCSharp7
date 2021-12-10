using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProC7.CH03
{
    class ErrorCode
    {
        // ### Note we are now returnig an int, rether than void ###
        // -------------------------------------------------------//
        public static int Main()
        {
            // Display a message and wait for Enter key to be pressed.
            Console.WriteLine("Wainting you press Enter key...");
            Console.ReadLine();

            //Return an arbitrary error code.
            return -1;
        }
    }
}