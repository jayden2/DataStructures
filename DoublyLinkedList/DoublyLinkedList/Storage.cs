using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Storage
    {
        private bool firstValue;

        public Storage(bool firstval)
        {
            this.firstValue = firstval;
        }

        public bool _FirstValue
        {
            get { return this.firstValue; }
            set { this.firstValue = value; }
        }
        
    }
}