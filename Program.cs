using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProC7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set Conso UI (CUI)
            Console.Title = "MaCroCode";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*************************************");
            Console.WriteLine("*****   Welcome to MaCroCode    *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Press enter to open a test Dialog Box.");
            Console.ReadLine();
            MessageBox.Show("All done!!");
        }

    }
}
