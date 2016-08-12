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
        public void startAdd(int value)
        {
            Add(top, value);
        }

        //recursive add
        public void Add(Node currentNode, int value)
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
