using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //initialise
        Tree BTree;
        bool firstValue = true;

        //add value button click
        private void addValue_Click(object sender, EventArgs e)
        {
            //Check parse if value can be converted
            if (CheckParse(numText.Text))
            {
                //Because check parse return true below parse will work
                int num = Int32.Parse(numText.Text);
                numText.Text = "";
                Console.WriteLine("//-------------------------");
                Console.WriteLine("Adding number: {0}", num);
                //check if its the first value of the tree, if so then put it to the top, otherwise just add it to the tree
                if (firstValue)
                {
                    BTree = new Tree(num);
                    Console.WriteLine("{0} is now the top node", num);
                    firstValue = false;
                    searchValue.Visible = true;
                    deleteValue.Visible = true;
                }
                else
                {
                    //if the tree has a top value start traversing if to then add the value to the tree
                    BTree.StartTraverse(num, "add");
                }
            }
        }

        //search value button click
        private void searchValue_Click(object sender, EventArgs e)
        {
            if (CheckParse(numText.Text))
            {
                //Because check parse return true below parse will work
                int num = Int32.Parse(numText.Text);
                numText.Text = "";
                Console.WriteLine("//-------------------------");
                Console.WriteLine("Searching for number: {0}", num);
                //Strart traversal
                BTree.StartTraverse(num, "search");
            }
        }

        //delete value button click
        private void deleteValue_Click(object sender, EventArgs e)
        {
            if (CheckParse(numText.Text))
            {
                //Because check parse return true below parse will work
                int num = Int32.Parse(numText.Text);
                numText.Text = "";
                Console.WriteLine("//-------------------------");
                Console.WriteLine("Deleting number: {0}", num);
                //Strart traversal
                BTree.StartTraverse(num, "delete");
            }
        }

        //check parsing of inputted value is an int
        private bool CheckParse(string text)
        {
            int num;
            //try to convert text input to num
            bool check = Int32.TryParse(text, out num);
            if (check)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Failed to convert: {0}", text);
                return false;
            }
        }
    }

    //create class node
    class Node
    {
        //node contructor variables
        public int value;
        public Node left;
        public Node right;

        //node constructor value with input value
        public Node(int input)
        {
            value = input;
            left = null;
            right = null;
        }
    }

    //create class tree
    class Tree
    {
        //tree type node for top of binary tree (first value)
        Node top;

        //tree with creation of top with no input, so top will be null
        public Tree()
        {
            top = null;
        }

        //tree constructior that has input value, so top has value (replacing null)
        public Tree(int baseValue)
        {
            //calls node class with method to create/add node with a starting value
            top = new Node(baseValue);
        }

        //enter value to start node traversal
        public void StartTraverse(int value, String type)
        {
            switch(type)
            {
                case "add":
                    Add(ref top, value);
                    break;
                case "delete":
                    Delete(ref top, value);
                    break;
                default:
                    Search(ref top, value);
                    break;
            }
            
        }
        //recursive delete
        private void Delete(ref Node currentNode, int value)
        {
            //if current node is null then add value to that node
            if (currentNode == null)
            {
                Console.WriteLine("cannot remove {0} as it wasnt found!", value);
                return;
            }

            //if current node's value is equal to what you were looking, value found
            if (currentNode.value == value)
            {
                Console.WriteLine("Found {0}! Preparing to delete", value);

                //case of if current node doesnt have a left or right value then remove if
                if (currentNode.left == null && currentNode.right == null)
                {
                    currentNode = null;
                    Console.WriteLine("Leaf node of value {0} removed", value);
                    return;
                }                
                //case of if current node has only one child on right
                if (currentNode.left == null && currentNode.right != null)
                {
                    Console.WriteLine("Current node has child on right, moving right child to current node", value);
                    currentNode = currentNode.right;
                    return;
                }
                //case of if current node has only one child on left
                if (currentNode.right == null && currentNode.left != null)
                {
                    Console.WriteLine("Current node has child on left, moving left child to current node", value);
                    currentNode = currentNode.left;
                    return;
                }
            }

            //if value is less than current nodes value, traverse LEFT
            if (value < currentNode.value)
            {
                Console.WriteLine("{0} < {1}, going left", value, currentNode.value);
                Delete(ref currentNode.left, value);
                return;
            }

            //if value is more than or equal to current nodes value, traverse RIGHT
            if (value >= currentNode.value)
            {
                Console.WriteLine("{0} >= {1}, going right", value, currentNode.value);
                Delete(ref currentNode.right, value);
                return;
            }
        }

        //recurcisve search
        private void Search(ref Node currentNode, int value)
        {
            //if current node is null then searched value doesnt exist
            if (currentNode == null)
            {
                Console.WriteLine("{0} not found!", value);
                return;
            }

            //if current node's value is equal to what you were looking, value found
            if (currentNode.value == value)
            {
                Console.WriteLine("Found {0}!", value);
                return;
            }

            //if value is less than current nodes value, traverse LEFT
            if (value < currentNode.value)
            {
                Console.WriteLine("{0} < {1}, going left", value, currentNode.value);
                Search(ref currentNode.left, value);
                return;
            }

            //if value is more than or equal to current nodes value, traverse RIGHT
            if (value >= currentNode.value)
            {
                Console.WriteLine("{0} >= {1}, going right", value, currentNode.value);
                Search(ref currentNode.right, value);
                return;
            }
        }

        //recursive add
        private void Add(ref Node currentNode, int value)
        {
            //if current node is null then add value to that node
            if (currentNode == null)
            {
                Node node = new Node(value);
                currentNode = node;
                Console.WriteLine("Current node is empty adding {0} here", value);
                return;
            }

            //if value is less than current nodes value, traverse LEFT
            if (value < currentNode.value)
            {
                Console.WriteLine("{0} < {1}, going left", value, currentNode.value);
                Add(ref currentNode.left, value);
                return;
            }

            //if value is more than or equal to current nodes value, traverse RIGHT
            if (value >= currentNode.value)
            {
                Console.WriteLine("{0} >= {1}, going right", value, currentNode.value);
                Add(ref currentNode.right, value);
                return;
            }
        }
    }
}
