using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_SquaresAndCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn Your Squares and Roots!");

            bool run = true;
            int num;

            Console.Write("Enter an integer: ");

            do
            {
                //put the code here.
                
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("Number Squared Cubed\n ======    =====    =====");

                for (int i = 1; i <= num; i++)
                {
                    //square = Math.Pow(i, 2);
                    //cube = Math.Pow(i, 3);

                    //Format grid for the printing of numbers, squares, and cubes.  Second argument is padding.
                    Console.WriteLine("{0,0}{1,10}{2,11}", i, SquareInput(i), CubeInput(i));
                }

                //ask user if they want to continue
                Console.WriteLine("Do you want to continue?");

                string input = Console.ReadLine();
                if (input.ToLower() == "no")
                    run = false;

            } while (run);
        }

        //Method for square retrieval.
        public static int SquareInput(int n)
        {
            int square = n * n;
            return square;
        }

        //Method for cube retrieval.
        public static int CubeInput(int n)
        {
            int cube = n * n * n;
            return cube;
        }
    }
}
