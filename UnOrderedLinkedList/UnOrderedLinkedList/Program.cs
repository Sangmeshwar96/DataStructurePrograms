using System;
using System.IO;

namespace UnOrderedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Implementation of Data structure Programs---");
            Console.WriteLine("***UnorderedList***\n");
            UnOrderedLinkedList<string> unOrdered = new UnOrderedLinkedList<string>();
            string filePath = @"C:\Users\hp\source\repos\UnOrderedLinkedList\UnOrderedLinkedList\WordFile.txt";
            string text = File.ReadAllText(filePath);
            string[] textArray = text.Split(" ");
            for (int i = 0; i < textArray.Length; i++)
            {
                unOrdered.AddLast(textArray[i]);
            }
            Console.WriteLine("Enter the word to be searched :");
            string word = Console.ReadLine();
            int found = unOrdered.SearchNode(word);
            if (found == 1)
            {
                unOrdered.DeleteNode(word);
            }
            else
            {
                unOrdered.AddLast(word);
            }
            string newText = unOrdered.DisplayList();
            File.WriteAllText(filePath, newText);
            Console.ReadLine();
        }


    }

}