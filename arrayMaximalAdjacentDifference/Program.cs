using System;

namespace arrayMaximalAdjacentDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter an element: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Array Maximal Adjacent Difference is {arrayMaximalAdjacentDifference(array)}!");
            Console.ReadLine();
        }
        static int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            int dif;
            if (inputArray[0] - inputArray[1] >= 0)
            {
                dif = inputArray[0] - inputArray[1];
            }
            else
            {
                dif = -(inputArray[0] - inputArray[1]);
            }
            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] - inputArray[i + 1] > dif)
                {
                    dif = inputArray[i] - inputArray[i + 1];
                }
                else if(-(inputArray[i] - inputArray[i + 1]) > dif)
                {
                    dif = -(inputArray[i] - inputArray[i + 1]);
                }
            }
            return dif;
        }
    }
}
