using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //sort button click
        private void sort_btn_Click(object sender, EventArgs e)
        {
            int numInput = 0;
            //parse random int value to int
            int.TryParse(num_input.Value.ToString(), out numInput);
            //call merge sort process
            MergeProcess(numInput);
        }

        //merge process to generate nums into a list and then sort it
        private void MergeProcess(int numAmount)
        {
            //generate unsorted list of nums and then display it in a label
            List<int> unsortedList = StartGenerateNums(numAmount);
            String unsortedString = BuildString(unsortedList.ToArray());
            unsorted_lbl.Text = unsortedString;

            //sort unsorted list of nums and then display it in a label
            List<int> sortedList = MergeSort(unsortedList);
            String sortedString = BuildString(sortedList.ToArray());
            sorted_lbl.Text = sortedString;
        }
        
        //build string from num array so it displays as: 1,2,3
        private String BuildString(int[] array)
        {
            String result = string.Join(",", array);
            return result;
        }

        //Random number generator
        private List<int> StartGenerateNums(int numAmount)
        {
            List<int> unsortedArray = new List<int>();
            Random rnd = new Random();
            //Generate random numbers for how many the num amount is (this is inputted in the form)
            for (int i = 0; i < numAmount; i++)
            {
                unsortedArray.Add(rnd.Next(101)); //generate a number between 0 and 100
                Console.WriteLine("Random Num: " + unsortedArray.Last().ToString());
            }
            return unsortedArray;
        }

        //Merge sort
        private List<int> MergeSort(List<int> unsortedList)
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
        private List<int> Merge(List<int> left, List<int> right)
        {
            Console.WriteLine("Merge Result Call, Sorting Nums");
            List<int> result = new List<int>();

            //if left and right still have values then compare them
            while(left.Count > 0 && right.Count > 0)
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
            while(left.Count > 0)
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
        private bool IsOdd(int num)
        {
            return (num % 2 != 0);
        }
    }
}
