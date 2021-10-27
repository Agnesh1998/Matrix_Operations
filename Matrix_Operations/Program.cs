using System;
namespace Matrix_Operations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MatrixOprations operations = new MatrixOprations();

            //scalarMultiplication
            int[,] a = { { 1, 4, 2 }, { 2, 5, 1 } };
            operations.scalarMultiplication<int>(a, 2);
            Console.WriteLine("---------------------------------------");

            //matrixProduct
            double[,] a1 = {{1.5, 4, 2}, {2, 5, 1}};
            double[,] b1 = {{3, 4.5, 2}, {3, 5, 7}, {1, 2, 1}};
            operations.matrixProduct<double>(a1, b1);
            Console.WriteLine("---------------------------------------");

            //addition
            float[,] a2 = { { 1.5f, 4, 2 }, { 2, 5, 1 } };
            float[,] b2 = { { 3, 4.5f, 2 }, { 3, 5, 7 } };
            operations.matrixAddition<float>(a2, b2);
            Console.WriteLine("---------------------------------------");

            string[,] a3 = { { "1", "2", "3" }, { "2", "5", "9" } };
            string[,] b3 = { { "2", "5", "8" }, { "5", "8", "10" } };
            operations.matrixAddition<string>(a3, b3);
            Console.WriteLine("---------------------------------------");

            //Substraction 
            long[,] a4 = { { 922337203685477, -4, 2 }, { 2, 5, 1 } };
            long[,] b4 = { { -3, 4, 2 }, { 3, 9223372036854, -7 } };
            operations.matrixSubstraction<long>(a4, b4);
            Console.WriteLine("---------------------------------------");

        }
    }
}
