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
        //initialise doubly linked list and value
        DoublyLinkedList DLL;
        bool firstValue = true;

        //add value button click
        private void addBtn_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(input.Text);
            input.Text = "";
            Console.WriteLine("//-------------------------");
            Console.WriteLine("Adding value: {0}", value);

            //check if first value inputed to set up the doubly linked list and make other buttons visible
            if (firstValue)
            {
                DLL = new DoublyLinkedList(value);
                Console.WriteLine("{0} is the first link", value);
                addBtn.Text = "Input";
                firstValue = false;
                searchBtn.Visible = true;
                deleteBtn.Visible = true;
                editBtn.Visible = true;
                editLabel.Visible = true;
                inputEdit.Visible = true;
                travseBtn.Visible = true;
            }
            else
            {
                DLL.DoubleLinkStart(value, "add", 0);
            }
        }

        //search button click
        private void searchBtn_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(input.Text);
            input.Text = "";
            Console.WriteLine("//-------------------------");
            Console.WriteLine("Searching for value: {0}", value);

            DLL.DoubleLinkStart(value, "search", 0);
        }

        //edit button click
        private void editBtn_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(input.Text);
            int editValue = Int32.Parse(inputEdit.Text);
            input.Text = "";
            Console.WriteLine("//-------------------------");
            Console.WriteLine("Searching and Editing value: {0} with value: {1}", value, editValue);

            DLL.DoubleLinkStart(value, "edit", editValue);
        }

        //delete button click
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int value = Int32.Parse(input.Text);
            input.Text = "";
            Console.WriteLine("//-------------------------");
            Console.WriteLine("Deleting value: {0}", value);

            DLL.DoubleLinkStart(value, "delete", 0);
        }

        //traverse button click
        private void travseBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("//-------------------------");
            Console.WriteLine("Traversing Doubly Linked List");
            DLL.DoubleLinkStart(0, "traverse", 0);
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

        //start call for doubly linked list go to to recursing calls of add, delete, search, edit or traverse
        public void DoubleLinkStart(int value, String type, int newValue)
        {
            switch(type)
            {
                case "add":
                    Add(ref firstLink, value);
                    break;
                case "delete":
                    Delete(ref firstLink, value);
                    break;
                case "edit":
                    Search(ref firstLink, value, newValue, "edit");
                    break;
                case "traverse":
                    Traverse(ref firstLink, "f");
                    break;
                default:
                    Search(ref firstLink, value, 0, "search");
                    break;
            }
        }

        //ADD
        private void Add(ref DoubleLink currentLink, int value)
        {
            Console.WriteLine("Traversing list forwards, current value is: {0}", currentLink.value);
            //if current node is null then add value to that node
            if (currentLink.nextLink == null)
            {
                Console.WriteLine("Current node doesnt have a next link, adding node here");
                //create new link node and put in next link to chain them up
                DoubleLink newNode = new DoubleLink(value, currentLink);
                currentLink.nextLink = newNode;
                Console.WriteLine("created Node with value: {0}", value);
                return;
            } else
            {
                //recursively call add
                Add(ref currentLink.nextLink, value);
            }
        }

        //DELETE
        private void Delete(ref DoubleLink currentLink, int value)
        {
            Console.WriteLine("Traversing list forwards, current value is: {0}", currentLink.value);

            //if value is found print to console and go to deletion case
            if (currentLink.value == value)
            {
                Console.WriteLine("Current node with value: {0}, found! Preparing to delete.", currentLink.value);

                //if previous and next nodes are not null, make current node equal next nodes link
                //hope that makes sense
                if (currentLink.previousLink != null && currentLink.nextLink != null)
                {
                    Console.WriteLine("making next node link to previous link, and remove current node");
                    currentLink = currentLink.nextLink;
                    return;
                }
                //if current link's next node is null then just make this link null
                //and remove reference to this link in the previous link
                else if (currentLink.nextLink == null)
                {
                    Console.WriteLine("there is no reference to a next node, removing current node");
                    currentLink.previousLink.nextLink = null;
                    currentLink = null;
                    return;
                }
                //if previous link is is null (probably means its the first node
                //then make next node this node
                else if (currentLink.previousLink == null)
                {
                    Console.WriteLine("there is no reference to a previous node making next node this node");
                    currentLink = currentLink.nextLink;
                    return;
                }
            }
                //if next node is null then value cannot be deleted
                if (currentLink.nextLink == null)
            {
                Console.WriteLine("{0} not found, cannot delete!", value);
                return;
            }
            else
            {
                Delete(ref currentLink.nextLink, value);
            }
        }

        //SEARCH && EDIT
        private void Search(ref DoubleLink currentLink, int value, int newValue, String type)
        {
            Console.WriteLine("Traversing list forwards, current value is: {0}", currentLink.value);

            //if search type is search and value is found display it and return
            if (type == "search" && currentLink.value == value)
            {
                Console.WriteLine("Found value: {0}", currentLink.value);
                return;
            } else if (type == "edit" && currentLink.value == value)
            {
                //if search type is edit and value is found replace it with new value and return
                Console.WriteLine("Found value: {0}", currentLink.value);
                currentLink.value = newValue;
                Console.WriteLine("Current nodes value is now: {0}", currentLink.value);
                return;
            }
            //if current node is null then searched value doesnt exist
            if (currentLink.nextLink == null)
            {
                Console.WriteLine("{0} not found!", value);
                return;
            }
            else
            {
                //recursivly search list
                Search(ref currentLink.nextLink, value, newValue, type);
            }
        }

        //Traverse DLL forwards and then backwards 1, 2, 3, 2, 1
        private void Traverse(ref DoubleLink currentLink, String direction)
        {
            //display value of current links value
            Console.WriteLine("Current Value: {0}", currentLink.value);

            //if direction is fowards and there is a next link traverse forwards
            if (direction == "f" && currentLink.nextLink != null)
            {
                Console.WriteLine("Traversing FORWARDS");
                Traverse(ref currentLink.nextLink, "f");
                return;
            //if there is a previous link go backwards, and direction is b so doesnt call direction forwards next..
            } else if (currentLink.previousLink != null)
            {
                Console.WriteLine("Traversing BACKWARDS");
                Traverse(ref currentLink.previousLink, "b");
                return;
            } else
            {
                //if no more backwards displayed whole list
                Console.WriteLine("Traversed whole doubly linked list.");
                return;
            }
        }
    }
}
