using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 2];
            Input(matrix1);

            int[,] matrix2 = new int[2, 2];
            Input(matrix2);

            //matrix2[0, 0] = 5;
            //matrix2[0, 1] = 6;
            //matrix2[1, 0] = 7;
            //matrix2[1, 1] = 8;
            
            Output(Multiply(matrix1, matrix2));


            Console.ReadKey();

        }

        static void Input(int[,] dst)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Enter value for matrix position [{0}{1}]:", i, j);
                    dst[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //int[,] matrix1 = new int[2, 2];
            //matrix1[0, 0] = 1;
            //matrix1[0, 1] = 2;
            //matrix1[1, 0] = 3;
            //matrix1[1, 1] = 4;
        }

        static int[,] Multiply(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[2, 2];
            //result[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
            //result[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
            //result[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
            //result[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];
            for(int i=0; i < matrix1.GetLength(0); i++)
            {
                for(int j=0; j < matrix2.GetLength(i); j++)
                {
                    result[i, j] += matrix1[i, 0] * matrix2[0, j] + matrix1[i, 1] * matrix2[1, j];
                }
            }
            return result;
        }

        static void Output(int[,] resultMatris)
        {
            for(int i = 0; i < resultMatris.GetLength(0); i++)
            {   
                //optemized
                for(int j = 0; j < resultMatris.GetLength(i); j++)
                {
                    Console.Write(resultMatris[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
