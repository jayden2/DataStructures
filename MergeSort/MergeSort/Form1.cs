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
        //initialise sorted list
        List<int> sortedList = new List<int>();
        
        //sort button click
        private void sort_btn_Click(object sender, EventArgs e)
        {
            int numInput = 0;
            //parse random int value to int
            int.TryParse(num_input.Value.ToString(), out numInput);
            //call merge sort process
            MergeProcess(numInput);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            int numInput = 0;
            //parse search int
            int.TryParse(search_input.Value.ToString(), out numInput);
            BinarySearcher.BinarySearchInput(numInput, sortedList.ToArray());
        }

        //merge process to generate nums into a list and then sort it
        private void MergeProcess(int numAmount)
        {
            //generate unsorted list of nums and then display it in a label
            List<int> unsortedList = StartGenerateNums(numAmount);
            String unsortedString = BuildString(unsortedList.ToArray());
            unsorted_lbl.Text = unsortedString;

            //sort unsorted list of nums and then display it in a label
            sortedList = MergeSorter.MergeSortInput(unsortedList);
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
    }
}
