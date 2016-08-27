using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublyLinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    }

    //double link class
    class DoubleLink
    {
        //link constructor
        public int value;
        public DoubleLink previousLink;
        public DoubleLink nextLink;

        //link constructor method to input value;
        public DoubleLink(int v)
        {
            value = v;
            previousLink = null;
            nextLink = null;
        }
        //link constructor method to input value and prev;
        public DoubleLink(int v, DoubleLink prev)
        {
            value = v;
            previousLink = prev;
            nextLink = null;
        }
    }

    //doubly linked list
    public class DoublyLinkedList
    {
        //first value to start the linked list
        DoubleLink firstLink;

        //constructor method for linked list without input
        public DoublyLinkedList()
        {
            firstLink = null;
        }

        //constructor method for linked list inc input
        public DoublyLinkedList(int value)
        {
            //calls double link to create and insert value
            firstLink = new DoubleLink(value);
        }

        public void DoubleLinkFunction(int value, String type)
        {
            switch(type)
            {
                case "add":
                    Add();
                    break;
                case "delete":
                    Delete();
                    break;
                default:
                    Search();
                    break;
            }
        }

        //ADD
        private void Add(int value, int position)
        {

        }

        //DELETE
        private void Delete()
        {

        }

        //SEARCH
        private void Search()
        {

        }
    }
}
