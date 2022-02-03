using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builtin");
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddFirst(30);
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }
            list.RemoveFirst();
            foreach (int element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            Console.WriteLine("After removing 1st node");
            list.RemoveFirst();
            foreach (int element in list)
            {
                Console.WriteLine("element");
            }
                Console.WriteLine("custom");
                CustomLinkedList linkedList = new CustomLinkedList();
            //linkedList.AddLast(56);
            //linkedList.AddLast(30);
            //linkedList.AddLast(70);
            //linkedList.AddFirst(70);
            //linkedList.AddFirst(30);
            //linkedList.AddFirst(56);
            //linkedList.Display();
            //linkedList.Append();
            //linkedlist.Append(56);
            //linkedlist.Append(30);
            //linkedlist.Append(70);
            //LinWkedlist.Display();
            //int res = linkedList.DeleteFirstNode();
            //if (res != 0)
            //    Console.WriteLine("\n{0} is deleted from linkedList", res);
            //linkedList.Display();


            ////  linkedList.DeleteLastNode();
            //Console.WriteLine();
            //int searchData = linkedList.search(30);
            //if (searchData != 0)
            //    Console.WriteLine("\n{0} is present in the linked list", searchData);

            //// Console.ReadLine();
            //LinkedList list= new LinkedList();
            list.AddLast(56);
            list.AddLast(70);
            list.Display();

            list.InsertAtParticularPosition(2, 30);


        }
    }
}
