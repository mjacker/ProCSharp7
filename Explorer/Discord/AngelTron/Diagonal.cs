using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Explorer
{
    class Matriz
    {
        private int[,] mat;
        public int fil, col;
        public void Ingresar()
        {
            Random rnd = new Random();
            string linea;
            Console.Write("Ingrese el número de n:  ");
            linea = Console.ReadLine();
            col = int.Parse(linea);
            fil = col;
            mat = new int[fil, col];
            for (int f = 0; f < fil; f++)
            {
                for (int c = 0; c < col; c++)
                {
                    int r = rnd.Next(1, 10);
                    mat[f, c] = r;
                }
            }
        }
        public void Imprimir()
        {
            for (int f = 0; f < fil; f++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(mat[f, c] + "    ");
                }
                Console.WriteLine();
            }
            //Console.ReadKey();
        }
        public void ComputeD1()
        {
            Console.Write("La Diagonal 1 de la Matriz: ");
            bool bandera = true;
            //for (int f = 0; f < fil; f++)
            //{
                for (int c = 0; c < col; c++)
                {
                    //int r = rnd.Next(1, 10);
                    Console.Write(mat[0, c]);
                    if (isEven(mat[0, c]))
                    {
                        bandera = false;
                        c = col;
                        //f = fil;
                    }
                Console.Write(", ");
                }
            //}

            if (bandera == true)
            {

                Console.Write("Todos los elementos son impares");
            }
            else
            {
                Console.WriteLine("No todos los elementos son impares");
            }
        }

        bool isEven(int n)
        {
            return (n % 2 == 0 ? true : false);
        }

        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.Ingresar();
            ma.Imprimir();
            ma.ComputeD1();
            Console.ReadKey();

        }
    }
}