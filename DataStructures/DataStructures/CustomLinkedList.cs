using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node new_node=new Node(data);
            if(this.head==null)
            {
                this.head = new_node;

            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;

            }
            Console.WriteLine("{0} Node inserted into linkedlist ", new_node.data);


        }
        public Node GetLastNode()
        { 
              Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
                    return temp;
                
            
        }

        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp=temp.next;
                }
                //console.Write ("  "+temp.data);

            } 
        }
        //uc2
        public void AddFront(int new_data)
        {
            //we will create a new node.The next of the node will point to the head of the Linked list.
            Node new_node=new Node(new_data);
            //when we want to add any node at the front, we want the head to point to it.
            new_node.next =this.head;
            //The previous Head node is now the second node of Linked list because the new node is added at the first.
            this.head = new_node;
            Console.WriteLine("{0} Node is inserted into linkedlist",new_node.data);
        }

    }
}
