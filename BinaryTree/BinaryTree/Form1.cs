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

        //non recursive add
        public void Add(int value)
        {
            //if top is null then add node to top as the base node
            if (top == null)
            {
                Node node = new Node(value);
                top = node;
                return;
            }

            //
            Node currentNode = top;
            bool traverseTree = true;

            //loop traversal if node is not added
            while(traverseTree)
            {
                //traverse LEFT of the tree if value is less than current node
                if (value < currentNode.value)
                {
                    //add node to LEFT if left is null
                    if (currentNode.left == null)
                    {
                        Node node = new Node(value);
                        currentNode.left = node;
                        traverseTree = false;
                    }
                    else
                    {
                        //otherwise make current node the LEFT value to continue searching to add node
                        currentNode = currentNode.left;
                    }
                }

                //traverse RIGHT of the tree if value is more than or equal to current node
                if (value >= currentNode.value)
                {
                    //add node to RIGHT if right is null
                    if (currentNode.right == null)
                    {
                        Node node = new Node(value);
                        currentNode.right = node;
                        traverseTree = false;
                    }
                    else
                    {
                        //otherwise make current node the RIGHT value to continue searching to add node
                        currentNode = currentNode.right;
                    }
                }
            }
        }
    }


}
