using System;

namespace Matrix_Operations
{
    public class MatrixOprations
    {
        public string scalarMultiplicationResult = "";
        public string matrixProductResult = "";
        public string matrixAdditionResult = "";
        public string matrixSubstractionResult = "";

        //This scalarMultiplication Method will perform a multiplication between Maxtrix and Scalar Number and display the output 
        public string scalarMultiplication<T>(T[,] array, T scalarNumber)
        {
            scalarMultiplicationResult = "";
            //It will check Type of the given array and scalar number should be int, long, float, double or decimal 
            if (typeCheckForArray<T>(array) && typeCheckForNumber<T>(scalarNumber))
            {
                for (int i = 0; i <= array.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= array.GetUpperBound(1); j++)
                    {
                        var k = (dynamic)(scalarNumber);
                        var d = (dynamic)(array[i, j]);
                        array[i, j] = (T)(k * d);
                        scalarMultiplicationResult += (double)(k * d) + ",";
                    }
                }
                Console.WriteLine("The result of the Scalar Multiplication is shown below:");
                return displayMatrix<T>(array);
            }
            else
            {
                Console.WriteLine("Please enter a valid arguments...");
                return "";
            }
        }

        //This matrixProduct Method will perform a multiplication between two Matrix and display the output 
        public string matrixProduct<T>(T[,] firstArray, T[,] secondArray)
        {
            try
            {
                matrixProductResult = "";
                int m1, n1, m2, n2;
                m1 = firstArray.GetUpperBound(0) + 1;
                n1 = firstArray.GetUpperBound(1) + 1;
                m2 = secondArray.GetUpperBound(0) + 1;
                n2 = secondArray.GetUpperBound(1) + 1;
                T[,] result = new T[m1, n2];

                //It will check both Matrix type should be int, long, float, double or decimal
                if (typeCheckForArray<T>(firstArray) && typeCheckForArray<T>(secondArray))
                {
                    if (n1 != m2)
                    {
                        Console.WriteLine("Product of Matrix is not possible");
                        return "";
                    }
                    else
                    {
                        for (int i = 0; i < m1; i++)
                        {
                            for (int j = 0; j < n2; j++)
                            {
                                result[i, j] = (T)(dynamic)(0);
                                for (int k = 0; k < n2; k++)
                                {
                                    var d1 = (dynamic)firstArray[i, k];
                                    var d2 = (dynamic)secondArray[k, j];
                                    var temp = (dynamic)(result[i, j]);
                                    result[i, j] = (T)(temp + d1 * d2);
                                    matrixProductResult += (T)(temp + d1 * d2) + ",";
                                }
                            }
                        }
                        Console.WriteLine("The result of the Matrix Product is shown below:");
                        return displayMatrix<T>(result);
                    }
                }
                else
                {
                    Console.WriteLine("Array types are not valid");
                    return "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //This matrixAddition Method will perform a addition between two Matrix and display the output 
        public string matrixAddition<T>(T[,] firstArray, T[,] secondArray)
        {
            matrixAdditionResult = "";
            int m1, n1, m2, n2;
            m1 = firstArray.GetUpperBound(0) + 1;
            n1 = firstArray.GetUpperBound(1) + 1;
            m2 = secondArray.GetUpperBound(0) + 1;
            n2 = secondArray.GetUpperBound(1) + 1;
            T[,] result = new T[m1, n1];

            if (typeCheckForArray<T>(firstArray) && typeCheckForArray<T>(secondArray))
            {
                //if both matrix don't have same no of coloumn or row then addition is not possible
                if (m1 != m2 || n1 != n2)
                {
                    Console.WriteLine("Matrix addition is not possible because no. of rows or columns in both Matrix are different");
                    return "";
                }
                else
                {
                    for (int i = 0; i < m1; i++)
                    {
                        for (int j = 0; j < n1; j++)
                        {

                            var d1 = (dynamic)firstArray[i, j];
                            var d2 = (dynamic)secondArray[i, j];
                            result[i, j] = (T)(d1 + d2);
                            matrixAdditionResult += (T)(d1 + d2) + ",";
                        }
                    }
                    Console.WriteLine("The result of the Matrix Addition is shown below");
                    return displayMatrix<T>(result);
                }
            }
            else
            {
                Console.WriteLine("Array types are not valid");
                return "";
            }
        }

        //This matrixSubstraction Method will perform a substraction between two Matrix and display the output 
        public string matrixSubstraction<T>(T[,] firstArray, T[,] secondArray)
        {
            matrixSubstractionResult = "";
            int m1, n1, m2, n2;
            m1 = firstArray.GetUpperBound(0) + 1;
            n1 = firstArray.GetUpperBound(1) + 1;
            m2 = secondArray.GetUpperBound(0) + 1;
            n2 = secondArray.GetUpperBound(1) + 1;
            T[,] result = new T[m1, n1];

            if (typeCheckForArray<T>(firstArray) && typeCheckForArray<T>(secondArray) && typeCheckForArray<T>(firstArray) == typeCheckForArray<T>(secondArray))
            {
                //if both matrix don't have same no of coloumn or row then substraction is not possible
                if (m1 != m2 || n1 != n2)
                {
                    Console.WriteLine("Matrix substraction is not possible because no. of rows or columns in both Matrix are different");
                    return null;
                }
                else
                {
                    for (int i = 0; i < m1; i++)
                    {
                        for (int j = 0; j < n1; j++)
                        {

                            var d1 = (dynamic)firstArray[i, j];
                            var d2 = (dynamic)secondArray[i, j];
                            result[i, j] = (T)(d1 - d2);
                            matrixSubstractionResult += (T)(d1 - d2) + ",";
                        }
                    }
                    Console.WriteLine("The result of the Matrix Substraction is shown below");
                    return displayMatrix<T>(result);
                }
            }
            else
            {
                Console.WriteLine("Array types are not valid");
                return null;
            }
        }

        //This method will display the Matrix
        public string displayMatrix<T>(T[,] array)
        {
            string result = "";
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    Console.Write(array[i, j] + "      ");
                    result += array[i, j] + ",";
                }
                Console.WriteLine();
            }
            return result;
        }

        //This method will check the type of given Number and return boolean value according to the type
        public bool typeCheckForNumber<T>(T value)
        {
            Type tp = value.GetType();
            if (tp.Equals(typeof(int)) ||
               tp.Equals(typeof(long)) ||
               tp.Equals(typeof(float)) ||
               tp.Equals(typeof(double)) ||
               tp.Equals(typeof(decimal)))
            {
                return true;
            }
            return false;
        }

        //This method will check the type of array(Matrix) and return boolean value according to the type
        public bool typeCheckForArray<T>(T[,] value)
        {
            Type tp = value.GetType().GetElementType();
            if (tp.Equals(typeof(int)) ||
               tp.Equals(typeof(long)) ||
               tp.Equals(typeof(float)) ||
               tp.Equals(typeof(double)) ||
               tp.Equals(typeof(decimal)))
            {
                return true;
            }
            return false;
        }
    }
}