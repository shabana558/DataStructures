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
            Node new_node = new Node(data);
            if (this.head == null)
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
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }
                //console.Write ("  "+temp.data);

            }
        }

        //uc7 search to find node with value 30
        public int search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\nNode is present ");
                    return value;
                }
                temp = temp.next;
            }


            Console.WriteLine("\n {0} is not present", value);
            return 0;
        }


    }
}
          
