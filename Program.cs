using System;
using System.Linq;

namespace Finder_duplicate_integers
{
    class Program
    {
        const int smolestNumber = 1;
        const int bigestNumber = 100;

        static public void FindeDuplicate(int[] array, int arraySize)
        {
            // print all array
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            //print duplicate integers
            Console.WriteLine("Duplicate numbers: " + string.Join(" ", array.Where(x => array.Count(y => x == y) > 1).Distinct()));
        }

        static public void CreateRandomArray(int arraySize)
        {
            Random random = new Random();
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(smolestNumber, bigestNumber);
            }

            FindeDuplicate(array, arraySize);
        }

        static void Main(string[] args)
        {
            int arraySize;
            while (true)
            {
                Console.Write("Enter amount numbers: ");
                arraySize = Convert.ToInt32(Console.ReadLine());
                CreateRandomArray(arraySize);
            }
        }
    }
}
