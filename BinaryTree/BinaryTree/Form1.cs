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
        Boolean firstValue = true;

        //add value button click
        private void addValue_Click(object sender, EventArgs e)
        {
            int num;
            
            //try to convert text input to num
            bool check = Int32.TryParse(numText.Text, out num);

            //if can parse to num add to binary tree
            if (check)
            {
                Console.WriteLine("Adding number: {0}", num);
                //check if its the first value of the tree, if so then put it to the top, otherwise just add it to the tree
                if (firstValue)
                {
                    BTree = new Tree(num);
                }
                else
                {
                    BTree.StartAdd(num);
                }   
            }
            else
            {
                Console.WriteLine("Failed to convert: {0}", numText.Text);
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
        public void StartAdd(int value)
        {
            Add(top, value);
        }

        //recursive add
        private void Add(Node currentNode, int value)
        {
            //if current node is null then add value to that node
            if (currentNode == null)
            {
                Node node = new Node(value);
                currentNode = node;
                return;
            }

            //if value is less than current nodes value, traverse LEFT
            if (value < currentNode.value)
            {
                Add(currentNode.left, value);
                return;
            }

            //if value is more than or equal to current nodes value, traverse RIGHT
            if (value >= currentNode.value)
            {
                Add(currentNode.right, value);
                return;
            }
        }
    }


}
