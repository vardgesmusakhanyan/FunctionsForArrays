using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsForArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, width;

            int[,] array;
            Console.WriteLine("Please insert the height and width of your array");
            height = Convert.ToInt32(Console.ReadLine());
            width = Convert.ToInt32(Console.ReadLine());


            array = CreateArray(height, width);

            Print(array);

            Console.WriteLine(GetMax(array));

            Console.WriteLine(GetMin(array));

            swap(array);

            Print(array);

            Console.ReadKey();

        }


        /// <summary>
        /// Creates an Array with random numbers in it
        /// </summary>
        /// <param name="height">height of the array</param>
        /// <param name="width"> width of the array</param>
        /// <returns></returns>
        public static int[,] CreateArray(int height, int width) 
        {
            int[,] array = new int[height, width];
            Random rnd = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = rnd.Next(10);
                }
            }
            return array;
        }

        /// <summary>
        /// Gets the max element of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GetMax(int[,] array)
        {
            int max = array[0, 0];
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                        max = array[i, j];
                }
            }
            return max;
        }
        /// <summary>
        /// Gets the min element of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GetMin(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                        min = array[i, j];
                }
            }
            return min;
        }

        /// <summary>
        /// Gets the main diagonal of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] GetDiagonal(int[,] array)
        {
            int[] diagonal = new int[array.Length];
            for(int i = 0; i < array.Length;i++)
            {
                for (int j = 0; j < array.Length; j++)
                    if (i == j)
                        diagonal[i] = array[i, j];
            }
            return diagonal;
        }

        /// <summary>
        /// Swaps min and max elements of the array
        /// </summary>
        /// <param name="array"></param>
        public static void swap(int[,] array)
        {
            int MaxIndex1 = 0, MaxIndex2 = 0;
            int MinIndex1 = 0, MinIndex2 = 0;
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] == GetMax(array))
                    {
                        MaxIndex1 = i;
                        MaxIndex2 = j;
                    }

                    if (array[i,j] == GetMin(array))
                    {
                        MinIndex1 = i;
                        MinIndex2 = j;
                    }

                }
            }

            int temp = array[MaxIndex1, MaxIndex2];
            array[MaxIndex1, MaxIndex2] = array[MinIndex1, MinIndex2];
            array[MinIndex1, MinIndex2] = temp;

        }

        /// <summary>
        /// Prints our array
        /// </summary>
        /// <param name="array"></param>
        public static void Print(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
