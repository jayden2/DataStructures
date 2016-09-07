using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class BinarySearcher
    {
        //public class to start binary search, input number to search and the array that was sorted from the merge
        public static String BinarySearchInput(int numToSearch, int[] sortedArray)
        {
            //binary search is the number to search, sortedarray, 0 is first value in array, and the array length to..to get the low and high points
            //to start the recursive binary search output (high and low is inserted here because of recusive and to then find mid point)
            return BinarySearch(numToSearch, sortedArray, 0, sortedArray.Length);
        }

        private static String BinarySearch(int numToSearch, int[] sortedArray, Double lowPoint, Double highPoint)
        {
            //output what we're search for and the current high && low points
            Console.WriteLine("Search for value {0} | highPoint: {1} | lowPoint: {2}", numToSearch, highPoint, lowPoint);

            //if high point is less than low point it means the value doesnt exist or hasnt been found..
            if (highPoint < lowPoint)
            {
                Console.WriteLine("Search value not found!");
                return "not found";
            }
            //calc method to get mid point
            int midPoint = calcMidpoint(lowPoint, highPoint);
            //output midpoint
            Console.WriteLine("MidPoint: {0}", midPoint);

            //--if sorted array mid point value is less than number to search
            //make the low point equal midpoint value plus 1
            if (sortedArray[midPoint] < numToSearch)
            {
                lowPoint = midPoint + 1;
            }
            //--if sorted arrays mid point is higher than the number being searched
            //make the high point equal mid point minus 1
            if (sortedArray[midPoint] > numToSearch)
            {
                highPoint = midPoint - 1;
            }

            //if sorted arrays midpoint equals the number you're searching for you found what you were looking for -- good job! :+1:
            if (sortedArray[midPoint] == numToSearch)
            {
                Console.WriteLine("{0} found in the array, it is number {1} in the array", sortedArray[midPoint], midPoint + 1);
                return String.Format("{0} found in the array, it is number {1} in the array", sortedArray[midPoint], midPoint + 1);
            }

            return BinarySearch(numToSearch, sortedArray, lowPoint, highPoint);
        }

        //mid point calcution from high and low point
        private static int calcMidpoint(double lowPoint, double highPoint)
        {
            //round(floor) calcution, so 5.95 = 5, or 5.1 = 5
            //calculation is high + low points and then divide by 2
            return (int)Math.Floor((highPoint + lowPoint) / 2);
        }
    }
}
