using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class BinarySearcher
    {
        public static String BinarySearchInput(int numToSearch, int[] sortedArray)
        {
            return BinarySearch(numToSearch, sortedArray, 1, sortedArray.Length);
        }

        private static String BinarySearch(int numToSearch, int[] sortedArray, Double lowPoint, Double highPoint)
        {
            Console.WriteLine("Search for value {0}", numToSearch);
            if (highPoint < lowPoint)
            {
                Console.WriteLine("Search value not found!");
                return "not found";
            }
            int midPoint = (int)Math.Floor((highPoint + lowPoint) / 2);
            Console.WriteLine("MidPoint: {0}", midPoint);

            if (sortedArray[midPoint] < numToSearch)
            {
                lowPoint = midPoint + 1;
            }

            if (sortedArray[midPoint] > numToSearch)
            {
                highPoint = midPoint - 1;
            }

            if (sortedArray[midPoint] == numToSearch)
            {
                Console.WriteLine("{0} found in the array, it is number {1} in the array", sortedArray[midPoint], midPoint + 1);
                return String.Format("{0} found in the array, it is number {1} in the array", sortedArray[midPoint], midPoint + 1);
            }

            return BinarySearch(numToSearch, sortedArray, lowPoint, highPoint);
        }
    }
}
