using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MatrixOperations;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MatrixOprations operations = new MatrixOprations();

            //scalarMultiplication
            double[,] a = {{1.5d, 4, 2}, {2, 5, 1}};
            operations.scalarMultiplication<double>(a, 2);

            //matrixProduct
            /*double[,] a = {{1.5, 4, 2}, {2, 5, 1}};
            double[,] b = {{3, 4.5, 2}, {3, 5, 7}, {1, 2, 1}};
            operations.matrixProduct<double>(a, b);*/
            /*
            float[,] x = {{1.5f, 4, 2}, {2, 5, 1}};
            float[,] y = {{3, 4.5f, 2}, {3, 5, 7}, {1, 2, 1}};
            operations.displayMatrix(operations.matrixProduct(x, y));

            int[,] c = {{15, 4, 2}, {2, 5, 1}};
            int[,] d = {{3, 45, 2}, {3, 5, 7}, {1, 2, 1}};
            operations.displayMatrix(operations.matrixProduct(c, d));*/

            //addition
            /*double[,] a = {{1, 4.5d, 2}, {2, 5, 1}};
            double[,] b = {{3, 4, 2}, {3, 5, 7}};
            operations.matrixAddition<double>(a, b);*/

            /*string[,] a = { { "1", "2", "3" }, { "2", "5", "9" } };
            string[,] b = { { "2", "5", "8" }, { "5", "8", "10" } };
            operations.matrixAddition<string>(a, b);*/


            //Substraction 
            //int[,] a = { { 1, 4, 2 }, { 2, 5, 1 } };
            //int[,] b = { { 3, 4, 2 }, { 3, 5, 7 } };
            //operations.matrixSubstraction<int>(a, b);

        }
    }
}
