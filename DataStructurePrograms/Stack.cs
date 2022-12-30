using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class Stack<T>
    {
        Node<T> top;
        /// This Method Is For Adding Elements
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("{0} pushed to stack", data);
        }
        /// This Method is For Finding Top Element in Stack
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack doesn't contains any value");
            }
            else
            {
                Console.WriteLine("\n{ 0} is in top of stack", this.top.data);
            }
        }
        /// This Method is For Deleting Elements
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack doesn't contains any value");
            }
            else
            {
                Console.WriteLine("Value Popped is {0}", this.top.data);
                top = top.next;
            }
        }
        /// This Method Is For Displaying Elements in Stack
        public void Display()
        {
            Node<T> temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("\nStack is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        /// This Method Is For Finding Size 
        public int Size()
        {
            int count = 0;
            Node<T> temp = this.top;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
}