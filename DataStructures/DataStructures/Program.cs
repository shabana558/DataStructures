﻿using System;
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
            // linkedList.AddLast(56);
            // linkedList.AddLast(30);
            // linkedList.AddLast(70);
            // linkedList.AddFirst(70);
            //linkedList.AddFirst(30);
            //linkedList.AddFirst(56);
           linkedList.Display();
           // linkedList.Append();
          //linkedlist.Append(56);
          //  linkedlist.Append(30);
           // linkedlist.Append(70);
          // Linkedlist.Display();
            linkedList.DeleteFirstNode();
                  Console.ReadLine();




        }
    }
}
