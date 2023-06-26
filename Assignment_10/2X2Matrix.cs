using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class Matrix
    {
        private int[,] _array;

        public int[,] Array { get; set; }

        public Matrix(int[,] array)
        {
            _array = array;
        }
        //matrix iniciale
        public static int [,] MatrixIniciale() {
            int[,] array = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                     array[i, j] = input;
                    Console.WriteLine("Number: " + array[i,j]);
                }
            }
            return array;
        }

        // + operator
        public static Matrix operator + (Matrix matrix1, Matrix matrix2)
        {
            int[,] tempArray = new int[2, 2];
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tempArray[i, j] = matrix1._array[i, j] + matrix2._array[i, j];
                }
            }
            return new Matrix(tempArray);
        }
        // - operator
        public static Matrix operator - (Matrix matrix1, Matrix matrix2)
        {
            int[,] tempArray = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tempArray[i, j] = matrix1._array[i, j] - matrix2._array[i, j];
                }
            }
            return new Matrix(tempArray);
        }
        // * operator
        public static Matrix operator * (Matrix matrix1, Matrix matrix2)
        {
            int[,] tempArray = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tempArray[i, j] = matrix1._array[i, j] * matrix2._array[i, j];
                }
            }
            return new Matrix(tempArray);
        }
        // უნარული გამოკლება (-)
        public static Matrix operator - (Matrix matrix)
        {
            int[,] tempArray = new int[2, 2];
            
            int determinant = 1 / (matrix._array[0, 0] * matrix._array[1, 1]) - (matrix._array[0, 1] * matrix._array[1, 0]);

            int temp = matrix._array[0, 0];
            matrix._array[0, 0] = matrix._array[1, 1];
            matrix._array[1, 1] = temp;
            matrix._array[0, 1] = matrix._array[0, 1] * -1;
            matrix._array[1, 0] = matrix._array[1, 0] * -1;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tempArray[i, j] = determinant * matrix._array[i, j];
                }
            }
            return new Matrix(tempArray);
        }
        // ToString
        public override string ToString()
        {
            Console.WriteLine("Your Matrix Is: ");
            string matrixString = "";

            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    matrixString +=_array[i, j] + " ";
                }

                matrixString += Environment.NewLine;
            }

            return matrixString;
        }
        public override bool Equals(object obj)
        {
            Matrix matrix = (Matrix)obj ;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    _array[i, j] = matrix._array[i, j];
                    return true;
                }
            }
            return false;
        }

    }
    
}
