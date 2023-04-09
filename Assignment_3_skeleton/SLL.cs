using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private int size = 0; // number of nodes available in the list
        private Node head = new Node(new object()); // heade node of the linked list

        // implementation of Append method
        public void Append(object data)
        {   
            Node newnode = new Node(data); // create new node that is to be added in the list
            Node curr = head.GetNext(); // get reference of first node in the list
            if (curr == null)
            {
                head.SetNext(newnode); // set first node in the list
            } else
            {
                 // loop until the end of list
                while (curr.GetNext() != null) 
                {
                    curr = curr.GetNext(); // move onto next node
                }
                curr.SetNext(newnode); // set 2nd last node to refer to newly created node
            }
            size++; // increment size of list 
        }
            
        // implementation of Clear method
        public void Clear()
        {
            if (head.GetNext() == null) // check if list is already empty
                return;
            head.SetNext(null); // set next node reference for head, (remaining node in the list will be garbage collected)
            size = 0; // reset number of available nodes
        }

        // implementation of Contains method
        public bool Contains(object data)
        {
            Node curr = head.GetNext(); // get reference of first node 
            while (curr != null) // loop until the end of list
            {
                if (curr.GetData() == data) // check if current node has same data we are looking for
                    return true; // data found 
                curr = curr.GetNext(); // move onto next node in list
            }
            return false; // data was not found
        }

        // implementation of Delete method
        public void Delete(int index)
        {
            if (index < 0 || index >= size) // check if an invalid index is given
                return;
            Node curr = head.GetNext(); // get reference of first node 
            Node prev = null; // prev node to track parent of the curr Node
            int count = 0; // count until index is matched
            while (curr != null) // loop until end of list
            {
                if (count == index) // check if current node index is equal to index given
                {
                    prev.SetNext(curr.GetNext()); // set parent node reference to next node refered by current node
                    size--; // reduce size of list by 1
                    return;
                }
                prev = curr; // update current node parent
                curr = curr.GetNext(); // get next node in list
                count++; // update count until index is found
            }
        }

        // implementation of Delete method
        public int IndexOf(object data)
        {
            Node curr = head.GetNext(); //get reference of first node in list
            int index = 0; // initalize a counter to calculate the index of the node
            while (curr != null) //loop until list end
            {
                if (curr.GetData() == data) // check if data is found
                    return index; // return data
                curr = curr.GetNext(); // get next node in list 
                index++; // update index until index is not found
            }
            return -1; // data was not found in any node of list
        }

        // implementation of Insert method
        public void Insert(object data, int index)
        {
            if (index >=0 && index < size) // check if index is in current list size range
            {
                Node curr = head.GetNext(); // get reference of first node of list 
                int count = 0; // count until the specified index is find
                while (curr != null) // loop until the end of list
                {
                    if (count == index - 1) // check if index is found
                    {
                        Node newNode = new Node(data); // create new node to be added
                        newNode.SetNext(curr.GetNext()); // set reference of next node to be refered by new node
                        curr.SetNext(newNode); // update parent node reference
                        size++; // update size of list
                        return; // node is added so need to loop furthur
                    }
                    count++; // updated until index is not matched
                    curr = curr.GetNext(); // get next node in list
                }
            } 
            else
            {
                for (int i = size; i < index - size - 1; i++) // loop until index is found
                { 
                    Append(null); // add dummy node
                }
                Append(data); // add node at given index
            }
        }

        // implementation of IsEmpty method
        public bool IsEmpty()
        {
            return size == 0; // if size of list is zero it is empty
        }

        // implementation of Prepend method
        public void Prepend(object data)
        {
            Node newNode = new Node(data); // create new node to  be added in list
            newNode.SetNext(head.GetNext()); // set refernce of node to be referd b new node
            head.SetNext(newNode); // set new node as first node
            size++; // update size of list
        }

        // implementation of Replace method
        public void Replace(object data, int index)
        {
            if (index < 0 || index >= size) // check if a valid index is given
                return;
            Node curr = head.GetNext(); // get reference of first node in list
            int count = 0; // counter to increment till index is found
            while (curr != null) // loop until the end of the list
            {
                if (count == index) // check if index is reached
                {
                    curr.SetData(data); // update data of node
                    break; // no need to loop until end of list
                }
                count++; // cupdate counter to match index
                curr = curr.GetNext(); // get next node in list
            }
        }

        // implementation of Retrive method
        public object Retrieve(int index)
        {
            if (index < 0 || index >= size) // check if a valid index is found 
                return null;
            Node curr = head.GetNext(); // get reference of first node in list
            int count = 0; // initialize a counter to update until index value
            while (curr != null) // lopp until the end of list
            {
                if (count == index) // check if index is reached
                    return curr.GetData(); // return current node data
                count++; // update count to match index
                curr = curr.GetNext(); // get next node in list
            }
            return null; // data was not found
        }

        // implementation of Size method
        public int Size()
        {
            return size; //return current list size
        }
    }
}
