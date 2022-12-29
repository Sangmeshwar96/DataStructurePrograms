using DataStructurePrograms;
using System;
using System.IO;

namespace OrderedLinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nImplementation of Data structure Programs");
            Console.WriteLine("***Ordered List***\n");
            SortedLinkedList<string> ordered = new SortedLinkedList<string>();
            string filePath1 = @"C:\Users\hp\source\repos\OrderedLinkedList\OrderedLinkedList\OrderedWordFile.txt";
            string text1 = File.ReadAllText(filePath1);
            string[] textArray1 = text1.Split(" ");
            for (int i = 0; i < textArray1.Length; i++)
            {
                ordered.Add(textArray1[i]);
            }
            Console.WriteLine("Enter the word to be searched:");
            string word1 = Console.ReadLine();
            int found1 = ordered.SearchNode(word1);
            if (found1 == 1)
            {
                ordered.Remove(word1);
            }
            else
            {
                ordered.Add(word1);
            }
            string newText1 = ordered.DisplayList();
            File.WriteAllText(filePath1, newText1);
        }
    }
}

