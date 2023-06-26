using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int [,] MatrixIniciale() {
            int[,] array = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                     array[i, j] = input;
                }
            }
            Console.Write("array result: ");
            foreach (int number in array)
            {
                Console.Write(number + ",");
            }
            Console.WriteLine();
            return array;
        }

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
    }
}
