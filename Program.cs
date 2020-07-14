using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = rand.Next(0, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\nЛокальные максимумы:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if((i == 0 && array[i]>array[i+1]) || (i == array.GetLength(0) && array[i] > array[i-1]))
                {
                    Console.Write(array[i] + " ");
                }
                else if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
