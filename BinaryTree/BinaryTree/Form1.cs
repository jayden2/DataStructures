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
                String data = dataText.Text;
                numText.Text = "";
                dataText.Text = "";
                Console.WriteLine("//-------------------------");
                Console.WriteLine("Adding number: {0} with data: {1}", num, data);
                //check if its the first value of the tree, if so then put it to the top, otherwise just add it to the tree
                if (firstValue)
                {
                    BTree = new Tree(num, data);
                    Console.WriteLine("{0} is now the top node with data: {1}", num, data);
                    addValue.Text = "Add Value";
                    firstValue = false;
                    searchValue.Visible = true;
                    deleteValue.Visible = true;
                    searchEdit.Visible = true;
                }
                else
                {
                    //if the tree has a top value start traversing if to then add the value to the tree
                    BTree.StartTraverse(num, "add", data);
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
                String data = dataText.Text;
                numText.Text = "";
                dataText.Text = "";
                Console.WriteLine("Searching for number: {0}", num);
                //Strart traversal
                BTree.StartTraverse(num, "search", data);
            }
        }

        //delete value button click
        private void deleteValue_Click(object sender, EventArgs e)
        {
            if (CheckParse(numText.Text))
            {
                //Because check parse return true below parse will work
                int num = Int32.Parse(numText.Text);
                String data = dataText.Text;
                numText.Text = "";
                dataText.Text = "";
                Console.WriteLine("Deleting number: {0}", num);
                //Strart traversal
                BTree.StartTraverse(num, "delete", data);
            }
        }

        //search for value and then edit data
        private void searchEdit_Click(object sender, EventArgs e)
        {
            if (CheckParse(numText.Text))
            {
                //Because check parse return true below parse will work
                int num = Int32.Parse(numText.Text);
                String data = dataText.Text;
                numText.Text = "";
                dataText.Text = "";
                Console.WriteLine("Editing number: {0} with new data: {1}", num, data);
                //Strart traversal
                BTree.StartTraverse(num, "edit", data);
            }
        }

        //check parsing of inputted value is an int
        private bool CheckParse(string text)
        {
            int num;
            Console.WriteLine("//-------------------------");
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
        public string data;
        public Node left;
        public Node right;

        //node constructor value with input value
        public Node(int i, String d)
        {
            value = i;
            left = null;
            right = null;
            data = d;
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
        public Tree(int baseValue, String data)
        {
            //calls node class with method to create/add node with a starting value
            top = new Node(baseValue, data);
        }

        //enter value to start node traversal
        public void StartTraverse(int value, String type, String data)
        {
            switch(type)
            {
                case "add":
                    Add(ref top, value, data);
                    break;
                case "delete":
                    Delete(ref top, value, data);
                    break;
                case "edit":
                    Search(ref top, value, data, "edit");
                    break;
                default:
                    Search(ref top, value, data, "search");
                    break;
            }
            
        }
        //recursive delete
        private void Delete(ref Node currentNode, int value, String data)
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
                Console.WriteLine("Found {0} with data: {1}. Preparing to delete", value, currentNode.data);

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
                    Console.WriteLine("{0} is now replaced with {1}", value, currentNode.value);
                    return;
                }
                //case of if current node has only one child on left
                if (currentNode.right == null && currentNode.left != null)
                {
                    Console.WriteLine("Current node has child on left, moving left child to current node", value);
                    currentNode = currentNode.left;
                    Console.WriteLine("{0} is now replaced with {1}", value, currentNode.value);
                    return;
                }
                //case of if current node has two children
                if (currentNode.left != null && currentNode.right != null)
                {
                    Console.WriteLine("Current node has children on left and right");
                    currentNode.value = DeleteChilrenTraversal(ref currentNode.right);
                    Console.WriteLine("{0} is now replaced with {1}", value, currentNode.value);
                    return;
                }
            }

            //if value is less than current nodes value, traverse LEFT
            if (value < currentNode.value)
            {
                Console.WriteLine("{0} < {1}, going left", value, currentNode.value);
                Delete(ref currentNode.left, value, data);
                return;
            }

            //if value is more than or equal to current nodes value, traverse RIGHT
            if (value >= currentNode.value)
            {
                Console.WriteLine("{0} >= {1}, going right", value, currentNode.value);
                Delete(ref currentNode.right, value, data);
                return;
            }
        }

        //part of delete, method is called for deleteion when there are two chilren
        //deletion insersts right side of the nodes child
        private int DeleteChilrenTraversal(ref Node currentNode)
        {
            if (currentNode.left == null)
            {
                //if left does equal null hold it
                Console.WriteLine("{0} found with no left child!", currentNode.value);
                Node currentNodeHolder = currentNode;
                
                //if  the right side of this current node has a child, make it that
                if (currentNode.right != null)
                {
                    Console.WriteLine("{0} has a right child, replacing this node with right child", currentNode.value);
                    currentNode = currentNode.right;
                }
                else
                {
                    //otherwise just make this node null
                    Console.WriteLine("Found node is now empty");
                    currentNode = null;
                }
                //return value to replace the deleted value
                return currentNodeHolder.value;
            }
            else
            {
                //traverse down the left side of the tree if it isnt null to find the highest minimum value
                Console.WriteLine("{0} has a child on the left, going left", currentNode.value);
                return DeleteChilrenTraversal(ref currentNode.left);
            }           
        }


        //recurcisve search
        private void Search(ref Node currentNode, int value, String data, String type)
        {
            //if current node is null then searched value doesnt exist
            if (currentNode == null)
            {
                Console.WriteLine("{0} not found!", value);
                return;
            }

            //if current node's value is equal to what you were looking and your just searching, value found and return
            if (type == "search" && currentNode.value == value)
            {
                Console.WriteLine("Found {0}! with data: {1}", value, currentNode.data);
                return;
            } else if (type == "edit" && currentNode.value == value)
            {
                //if you found the value with edit, then current node with data is logged, then data is replaced and then data displayed
                Console.WriteLine("Found {0}! with data: {1}", value, currentNode.data);
                currentNode.data = data;
                Console.WriteLine("{0} edited with new data: {1}", value, currentNode.data);
                return;
            }

                //if value is less than current nodes value, traverse LEFT
                if (value < currentNode.value)
            {
                Console.WriteLine("{0} < {1}, going left", value, currentNode.value);
                Search(ref currentNode.left, value, data, type);
                return;
            }

            //if value is more than or equal to current nodes value, traverse RIGHT
            if (value >= currentNode.value)
            {
                Console.WriteLine("{0} >= {1}, going right", value, currentNode.value);
                Search(ref currentNode.right, value, data, type);
                return;
            }
        }

        //recursive add
        private void Add(ref Node currentNode, int value, String data)
        {
            //if current node is null then add value to that node
            if (currentNode == null)
            {
                Node node = new Node(value, data);
                currentNode = node;
                Console.WriteLine("Current node is empty adding {0} with data: {1} here", value, data);
                return;
            }

            //if value is less than current nodes value, traverse LEFT
            if (value < currentNode.value)
            {
                Console.WriteLine("{0} < {1}, going left", value, currentNode.value);
                Add(ref currentNode.left, value, data);
                return;
            }

            //if value is more than or equal to current nodes value, traverse RIGHT
            if (value >= currentNode.value)
            {
                Console.WriteLine("{0} >= {1}, going right", value, currentNode.value);
                Add(ref currentNode.right, value, data);
                return;
            }
        }
    }
}
