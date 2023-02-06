using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 5];

            Random vel = new Random(100);
            AdatokFeltoltese(matrix, vel);
            AdatokKiirasa(matrix, vel);

            int oszlop, sor;

            Console.Write("Melyik sor(0-2): ");
            sor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Melyik sor(0-4): ");
            oszlop = Convert.ToInt32(Console.ReadLine());

            ElemKiirasa(sor, oszlop, matrix);

            






            Console.ReadKey();
        }

        private static void ElemKiirasa(int sor, int oszlop, int[,] matrix)
        {
            Console.WriteLine($"Az adott elem: {matrix[sor, oszlop]}");
        }

        private static void AdatokFeltoltese(int[,] matrix, Random vel)
        {

            for (int sor = 0; sor < 3; sor++)
            {
                for (int oszlop = 0; oszlop < 5; oszlop++)
                {
                    matrix[sor, oszlop] = vel.Next(100);
                }
            }
        }

        private static void AdatokKiirasa(int[,] matrix, Random vel)
        {
            

            for (int sor = 0; sor < 3; sor++)
            {
                for (int oszlop = 0; oszlop < 5; oszlop++)
                {
                    Console.Write($"{matrix[sor, oszlop],-3}");
                }
                Console.WriteLine();
            }
        }
    }
    
}
