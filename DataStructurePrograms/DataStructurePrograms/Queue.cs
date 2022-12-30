using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class Queue<T>
    {
        public Node<T> head = null;
        /// This Method Is For Enqueing Elements
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into Queue", newNode.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is inserted into Queue", newNode.data);
            }
        }
        /// This Method Is For Dequeing Elements
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nQueue is Empty,Deletion is Not Possible");
                return;
            }
            else
            {
                this.head = this.head.next;
            }
        }
        /// This Method Is For Displaying Who Are In The Queue
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nQueue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}