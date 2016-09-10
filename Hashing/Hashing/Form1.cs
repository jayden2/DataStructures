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
                Console.WriteLine("Storing String: {0}, in hashtable", item, item.GetHashCode());
                sTable.Add(item.GetHashCode(), item);
            }
        }

        public void listHashTable()
        {
            foreach(DictionaryEntry pair in sTable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
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