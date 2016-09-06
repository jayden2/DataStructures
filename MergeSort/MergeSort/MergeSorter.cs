using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSorter
    {
        public static List<int> MergeSortInput(List<int> unsortedList)
        {
            return MergeSort(unsortedList);
        }

        //Merge sort
        private static List<int> MergeSort(List<int> unsortedList)
        {
            Console.WriteLine("Merge Sort, Splitting List Further");
            // if unsorted list is less than or equal to 1 then return..otherwise keep spitting the list to eventually on need to compare 2 numbers and then join the list together again
            if (unsortedList.Count <= 1)
            {
                return unsortedList;
            }
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            //interate through unsorted list, and if i is even or odd split into left and right pile
            for (int i = 0; i < unsortedList.Count; i++)
            {
                if (IsOdd(i))
                {
                    Console.WriteLine(i.ToString() + " is odd.");
                    left.Add(unsortedList[i]);
                }
                else
                {
                    Console.WriteLine(i.ToString() + " is even.");
                    right.Add(unsortedList[i]);
                }
            }

            //recursive call of left and right to keep continue splitting left and then right
            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        //Merge nums, so stop splitting and now compare and join to result
        private static List<int> Merge(List<int> left, List<int> right)
        {
            Console.WriteLine("Merge Result Call, Sorting Nums");
            List<int> result = new List<int>();

            //if left and right still have values then compare them
            while (left.Count > 0 && right.Count > 0)
            {
                // if left is less than or equal to add to it to result and remove it from the list
                if (left.First() <= right.First())
                {
                    Console.WriteLine(left.First().ToString() + " is than that or equal to " + right.First().ToString());
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else
                {
                    //otherwise if right is more than left value than add it to the result and remove it from the list
                    Console.WriteLine(right.First().ToString() + " is more than " + left.First().ToString());
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            //if there are anymore values in the left box then add it to the result until there are no more
            while (left.Count > 0)
            {
                Console.WriteLine("Left still has value to add: " + left.First().ToString());
                result.Add(left.First());
                left.RemoveAt(0);
            }
            //if there are anymore values in the right box then add it to the result until there are no more
            while (right.Count > 0)
            {
                Console.WriteLine("Right still has value to add: " + right.First().ToString());
                result.Add(right.First());
                right.RemoveAt(0);
            }
            //return result to display
            return result;
        }

        //is odd method to check if a value is odd or not to return true or false (odd = true)
        private static bool IsOdd(int num)
        {
            return (num % 2 != 0);
        }
    }
}
