using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matrix_Operations;
using System;

namespace Matrix_OperationsTest
{
    [TestClass]
    public class MatrixOperationsTests
    {
        MatrixOprations matrixOprations = new MatrixOprations();

        //Will ensure that output of scalar multiplication of double array with a scalar number should match with expected one
        [TestMethod]
        public void scalarMultiplication_DecimalParams()
        {
            double[,] array = { { 1.5d, 4.3, 2 }, { 2, 5, 1 } };
            double scalarNumber = 2;
            string expected = "3,8.6,4,4,10,2,";

            string actual = matrixOprations.scalarMultiplication(array, scalarNumber);

            Assert.AreEqual(expected, actual);
        }

        //Will check the scalar multiplication of int array with negative integer number should be same as expected result
        [TestMethod]
        public void scalarMultiplication_NegativeIntParams()
        {
            int[,] array = { { 5, 4, 2 }, { 2, -5, 1 } };
            int scalarNumber = -3;
            string expected = "-15,-12,-6,-6,15,-3,";

            string actual = matrixOprations.scalarMultiplication(array, scalarNumber);
            
            Assert.AreEqual(expected, actual);
        }

        //Will perform scalar multiplication of an array (which contains a combination of max and min value of datatype integer) with the int number
		//edge case
        [TestMethod]
        public void scalarMultiplication_MaxMinIntParams()
        {
            int[,] array = { { 2147483647, 8, -2147483648 }, { 2147483646, 15, -2147483647 } };
            int scalarNumber = 2;
            string expected = "-2,16,0,-4,30,2,";

            string actual = matrixOprations.scalarMultiplication(array, scalarNumber);
           
            Assert.AreEqual(expected, actual);
        }

        //Will perform scalar multiplication of an array (which contains a combination of max and min value of datatype integer) with the max int number
        [TestMethod]
        public void scalarMultiplication_MaxScalarNumber()
        {
            int[,] array = { { 10, 18, -2147483648 }, { 80, 15, -2147483647 } };
            int scalarNumber = 2147483647;
            string expected = "-10,-18,-2147483648,-80,2147483633,-1,";

            string actual = matrixOprations.scalarMultiplication(array, scalarNumber);
        
            Assert.AreEqual(expected, actual);
        }

        //Will check if we pass null array then function should throw exception
        [TestMethod]
        [ExpectedException(typeof(Exception), "Object reference not set to an instance of an object.")]
        public void matrixProduct_NullParam_Exception()
        {
            double[,] secondArray = { { 3, 4.5, 2 }, { 3, 5, 7 }, { 1, 2, 1 } };

            matrixOprations.matrixProduct(null, secondArray);
        }

        //Will perform product of two int positive value type matrix
        [TestMethod]
        public void matrixProduct_IntegerParams()
        {
            int[,] firstArray = { { 1, 4, 7 }, { 10, 6, 21 } };
            int[,] secondArray = { { 3, 5, 9 }, { 11, 5, 7 }, { 1, 2, 0 } };

            string expected = "54,39,37,117,122,132,";

            string actual = matrixOprations.matrixProduct(firstArray, secondArray);

            Assert.AreEqual(expected, actual);
        }

        //Will perform product of two int positive and negative value type matrix
        [TestMethod]
        public void matrixProduct_IntegerNegativeParams()
        {
            int[,] firstArray = { { -2, -5, 7 }, { -8, 7, -10 } };
            int[,] secondArray = { { 2, -7, 12 }, { 9, -1, -3 }, { -1, -3, 0 } };

            string expected = "-56,-2,-9,57,79,-117,";

            string actual = matrixOprations.matrixProduct(firstArray, secondArray);

            Assert.AreEqual(expected, actual);
        }

        //Will perform addition of two double type matrix
        [TestMethod]
        public void matrixAddition_DoubleParams()
        {
            double[,] firstArray = { { 1, 4.5d, 2 }, { 2, 5, 1 } };
            double[,] secondArray = { { 3, 4, 2 }, { 3, 5, 7 } };

            string expected = "4,8.5,4,5,10,8,";

            string actual = matrixOprations.matrixAddition(firstArray, secondArray);

            Assert.AreEqual(expected, actual);
        }

        //Will perform addition of two float type matrix
        [TestMethod]
        public void matrixAddition_FloatValue()
        {
            float[,] firstArray = { { 1.5f, 4, 2 }, { 2, 5, 1 } };
            float[,] secondArray = { { 3, 4.5f, 2 }, { 3, 5, 7 } };

            string expected = "4.5,8.5,4,5,10,8,";

            string actual = matrixOprations.matrixAddition(firstArray, secondArray);

            Assert.AreEqual(expected, actual);
        }

        //Will perform substraction of two long type matrix
        [TestMethod]
        public void matrixSubstraction_LongParams()
        {
            long[,] firstArray = { { 922337203685477, -4, 2 }, { 2, 5, 1 } };
            long[,] secondArray = { { -3, 4, 2 }, { 3, 9223372036854, -7 } };

            string expected = "922337203685480,-8,0,-1,-9223372036849,8,";

            string actual = matrixOprations.matrixSubstraction(firstArray, secondArray);

            Assert.AreEqual(expected, actual);
        }

        //Will ensure string type array as a matrix should not perform substraction
        [TestMethod]
        public void matrixSubstraction_StringParams()
        {
            string[,] firstArray = { { "1", "2", "3" }, { "2", "5", "9" } };
            string[,] secondArray = { { "2", "5", "8" }, { "5", "8", "10" } };

            string actual = matrixOprations.matrixSubstraction(firstArray, secondArray);

            Assert.IsNull(actual);
        }
    }
}
