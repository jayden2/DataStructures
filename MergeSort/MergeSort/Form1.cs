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
        

        private void sort_btn_Click(object sender, EventArgs e)
        {
            int numInput = 0;
            int.TryParse(num_input.Value.ToString(), out numInput);
            MergeProcess(numInput);
        }

        private void MergeProcess(int numAmount)
        {
            int[] unsrotedArray = startGenerateNums(numAmount);
            String unsortedString = BuildString(unsrotedArray);
            unsorted_lbl.Text = unsortedString;
        }
        
        private String BuildString(int[] array)
        {
            String result = string.Join(",", array);
            return result;
        }

        private int[] startGenerateNums(int numAmount)
        {
            int[] unsortedArray = new int[numAmount];
            Random rnd = new Random();
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = rnd.Next(100);
            }
            return unsortedArray;
        }
    }
}
