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

        //arry of string to hash
        String[] sArray = new String[] {"peter", "columbine", "rad", "symmetry", "octogon", "f", "2" };
        //storage hash table key = hash, value = string
        Hashtable sTable = new Hashtable();

        //array to values to to hash table method
        public void arrayToHashTable()
        {
            //for each loop of items in array
            foreach(String item in sArray)
            {
                //sTable add, call xor hash to store as key and item/string as value
                Console.WriteLine("Storing String: {0}, in hashtable", item, item.GetHashCode());
                sTable.Add(XORhash(item), item);
            }
        }

        //list hash table method
        public void ListHashTable()
        {
            //for each loop through hash table
            //dictionaryEntry gets both the key and value from the hash table
            foreach(DictionaryEntry pair in sTable)
            {
                //log it to the console with pair's Key and Value
                Console.WriteLine("Key: {0}, Value: {1}", pair.Key, pair.Value);
            }
        }

        //XOR hash method
        public String XORhash(string value)
        {
            //hash storage to continiously fold bytes together
            int hash = 0;

            //loop through length of string
            for(int i = 0; i < value.Length; i++)
            {
                //iterate through characters in array
                char c = value[i];
                //xor operator of character located in previous line
                hash ^= c;
            }
            //return xor hashed string
            return hash.ToString();
        }

        private void arrayHash_btn_Click(object sender, EventArgs e)
        {
            arrayToHashTable();
        }

        private void listHash_btn_Click(object sender, EventArgs e)
        {
            ListHashTable();
        }
    }
}