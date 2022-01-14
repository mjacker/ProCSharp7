using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProC7.Explorer.Discord.phreakphreak
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator.Main();
        }

        static class Creator
        {
            static int ObtainDaysByMonth(int year, int month) => DateTime.DaysInMonth(year, month);

            static MyVector<DateTime> CreateVector(int year, int month, int size)
            {
                var vector = new MyVector<DateTime>(size);
                for (int i = 0; i < vector.Length; i++)
                {
                    vector[i] = new DateTime(year, month: month, day: i + 1);

                }

                return vector;
            }

            static MyVector<MyVector<DateTime>> CreateVectorMonths()
            {
                int year = DateTime.Now.Year;
                int numberOfMonths = 12;
                var vectorMonths = new MyVector<MyVector<DateTime>>(numberOfMonths);

                for (int i = 0; i < vectorMonths.Length; i++)
                {
                    var currentMonth = i + 1;
                    vectorMonths[i] = CreateVector(year, currentMonth, ObtainDaysByMonth(year, i + 1));
                }

                return vectorMonths;
            }

            static Func<string> readInput = () => Console.ReadLine();

            static Action<string> writeOutput = (string s) => Console.WriteLine(s);

            public static void Main()
            {
                try
                {
                    var vector = CreateVectorMonths();
                    writeOutput("Enter the month: ");
                    var month = int.Parse(readInput());
                    writeOutput("Enter the day of the month: ");
                    var day = int.Parse(readInput());

                    var daySelected = vector[month][day];
                    int acc = 0;

                    for (int m = month; m <= vector.Length; m++)
                    {
                        acc += m == month ? Math.Abs(daySelected.Date.Day - vector[m].Length) : vector[m].Length;
                    }


                    writeOutput($"The chosen day is {daySelected.ToString("dddd, dd MMMM yyyy")} there are {acc} days until the end of the year");
                    readInput();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error:{e.Message}");
                }
            }

            public class MyVector<T>
            {
                public T[] vector;


                public MyVector(int size)
                {
                    vector = new T[size];
                }

                public int Length
                {
                    get { return vector.Length; }
                }


                public T this[int index]
                {
                    get { return vector[index - 1]; }
                    set { vector[index] = value; }
                }
            }
        }
    }
}
