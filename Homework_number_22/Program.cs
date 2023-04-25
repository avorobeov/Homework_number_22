using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 100, 99, 34, 54, 56, 65, 46, 43, 45, 222, 345, 34, 53, 453, 45, 65, 67, 43, 56, 
                                        34, 34, 54, 33, 56, 43, 56, 222, 567, 333, 567};
            int step = 1;
            int backNumber;
            int frontNumber;
            int lastArrayIndex = numbers.Length - 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                frontNumber = i + step;
                backNumber = i - step;

                if (i == 0)
                {
                    if (numbers[i] > numbers[frontNumber])
                    {
                        Console.Write($"{numbers[i]},");
                    }
                }
                else if (i == lastArrayIndex)
                {
                    if (numbers[i] > numbers[backNumber])
                    {
                        Console.Write(numbers[i]);
                    }
                }
                else if (numbers[i] > numbers[frontNumber] && numbers[i] > numbers[backNumber])
                {
                    Console.Write($"{numbers[i]},");
                }
            }
        }
    }
}
