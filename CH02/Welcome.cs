using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProC7.CH02
{
    class Welcome
    {
        public static void Main()
        {
            // Set Conso UI (CUI)
            Console.Title = "This is a title: Welcome";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*************************************");
            Console.WriteLine("*****   Welcome to MJProC#7    *****");
            Console.WriteLine("*************************************");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Press enter to open a test Dialog Box.");
            Console.ReadLine();
            MessageBox.Show("All done!!");
        }

    }
}
