using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class Node
    {
        private object data; // private member to hold data of current node
        private Node next; // private member hold reference of next node in the list

        // constructor  to create a new node using the given data 
        public Node(object data)
        {
            this.data = data;
            this.next = null;
        }


        // setter method for data member to update data
        public void SetData(object data)
        {
            this.data = data;
        }

        // setter method to update the next node refernce in the list
        public void SetNext(Node next)
        {
            this.next = next;
        }

        // getter method to get the current node data
        public Object GetData()
        {
            return data;
        }

        // getter method to get the next node in list after current node
        public Node GetNext()
        {
            return next;
        }
    }
}
