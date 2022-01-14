using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This is needed for this example.

namespace ProC7.MJTest
{
    class ListToFiles
    {
        public static void Main()
        {
            //## Paths
            string path1 = @"D:\_Jaime\_GIT\04 MJGITs\04 ProC7\MJDef\TargetFile1-withClose.txt";
            string path2 = @"D:\_Jaime\_GIT\04 MJGITs\04 ProC7\MJDef\TargetFile2-withUsing.txt";
            string path3 = @"D:\_Jaime\_GIT\04 MJGITs\04 ProC7\MJDef\TargetFile2-withByte.txt";
            string path4 = @"D:\_Jaime\_GIT\04 MJGITs\04 ProC7\MJDef\listStringtoFile.txt";

            //# WRITING
            //## 1) Method one, using Close.
            FileStream fsw1 = new FileStream(path1, FileMode.Create, FileAccess.Write);
            StreamWriter sw1 = new StreamWriter(fsw1);

            sw1.WriteLine("1) prueba linea uno test 001.");
            sw1.WriteLine("1) prueba linea dos test 002.");
            sw1.WriteLine("1) prueba linea tres test 003.");

            sw1.Close();
            fsw1.Close();

            //## 2) Method two, using "using" statement
            using (FileStream fsw2 = new FileStream(path2, FileMode.Create, FileAccess.Write))
            using (StreamWriter sw2 = new StreamWriter(fsw2))
            {
                sw2.WriteLine("2) prueba linea cuatro test 004");
                sw2.WriteLine("2) prueba linea cinco test 005");
                sw2.WriteLine("2) prueba linea seis test 006");
            }

            //## 3) Method three, using Byte Array
            FileStream fsw3 = new FileStream(path3, FileMode.Create, FileAccess.Write);
            byte[] textData = Encoding.UTF8.GetBytes("3) prueba linea siete test 007");
            fsw3.Write(textData, 0, textData.Length);
            fsw3.Close();

            //## 4) Method three, save List to File
            List<Students> listStudents = new List<Students>();
            listStudents.Add(new Students("Jaime", "Colman", 3.4));
            listStudents.Add(new Students("Martin", "Medina", 4.2));
            listStudents.Add(new Students("Alex", "Ubago", 4.9));
            List<Students> listStudentsLoad = new List<Students>();



            FileStream fsw4 = new FileStream(path4, FileMode.Create, FileAccess.Write);
            using (StreamWriter sw4 = new StreamWriter(fsw4))
            {
                foreach (Students student in listStudents)
                {
                    sw4.WriteLine(student.ToCVS());
                }
            }





            //# READING
            //## 1) Method one, using Close.
            Console.WriteLine("Reading File one: \n-------------");
            FileStream fsr1 = new FileStream(path1, FileMode.Open, FileAccess.Read);
            StreamReader sr1 = new StreamReader(fsr1);
            string s1;
            do
            {
                s1 = sr1.ReadLine();
                Console.WriteLine(s1);
            } while (s1 != null);
            sr1.Close();
            fsr1.Close();

            //## 2) Method two, using "using" testament
            Console.WriteLine("Reading File two: \n-------------");
            using (FileStream fsr2 = new FileStream(path2, FileMode.Open, FileAccess.Read))
            using (StreamReader sr2 = new StreamReader(fsr2))
            {
                string s2;
                do
                {
                    s2 = sr2.ReadLine();
                    Console.WriteLine(s2);
                } while (s2 != null);
            }

            //## 3) Method two, using "using" testament
            //  not example found

            //## 4) Method four, reading list<students> from file
            Console.WriteLine("Reading List<studentds> from File: \n-------------");
            using (FileStream fsr4 = new FileStream(path4, FileMode.Open, FileAccess.Read))
            using (StreamReader sr4 = new StreamReader(fsr4))
            {
                string string4;
                string [] stringArray;
                //List<Students> listStudentsLoad;
                do
                {
                    string4 = sr4.ReadLine();

                    if (string4 != null)
                    {
                    stringArray = string4.Split(';');

                    //Console.WriteLine("Nombre: {0}, Apellido: {1}, Nota: {2}", stringArray[0], stringArray[1], Convert.ToDouble(stringArray[2]));

                        listStudentsLoad.Add(new Students(stringArray[0], stringArray[1], Convert.ToDouble(stringArray[2])));
                        //listStudents.Add(new Students("Alex", "Ubago", 4.9));

                    }
                } while (string4 != null);
            }

            foreach (Students student in listStudentsLoad)
            {
                Console.WriteLine(student.ToString());
            }

            Console.ReadKey();
        }
        public class Students
        {
            private string name;
            private string surname;
            private double note;

            public Students(string namePa, string surnamePa, double notePA)
            {
                name = namePa;
                surname = surnamePa;
                note = notePA;
            }
            public string ToCVS()
            {
                return name + "; " + surname + "; " + note;
            }

            public override string ToString()
            {
                string message = "" +
                    "\nStudent: " + surname + "," + name + 
                    "\nNote: " + note;
                return message;
            }


        }
    }
}

