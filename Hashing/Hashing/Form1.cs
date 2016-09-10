using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Hashing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] sArray = new String[] {"peter", "columbine", "rad", "symmetry", "octogon" };
        Hashtable sTable = new Hashtable();

        public void arrayToHashTable()
        {
            foreach(String item in sArray)
            {
                Console.WriteLine("String: {0}", item);
            }

            sTable.Add(1, sArray[0]);
            sTable.Add(20, sArray[1]);
            sTable.Add(15, sArray[2]);
        }

        public void listHashTable()
        {
            foreach(DictionaryEntry pair in sTable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }
        }

        private void arrayHash_btn_Click(object sender, EventArgs e)
        {
            arrayToHashTable();
        }

        private void listHash_btn_Click(object sender, EventArgs e)
        {
            listHashTable();
        }
    }
}