using System;

namespace DataStructurePrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\nWelcome To DataStructure Programs\n" +
                    "1. UnOrderedList\n" +
                    "2. OrderedList\n" +
                    "3. End");
                Console.Write("Please Select One Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        UnOrderedList<string> unOrderedList = new UnOrderedList<string>();
                        unOrderedList.UnOrderedListOperation();
                        break;
                    case 2:
                        OrderedList<string> orderedList = new OrderedList<string>();
                        orderedList.OrderedListOperation();
                        break;
                    case 3:
                        Console.WriteLine("\nThank you");
                        break;
                }
                if (option == 3)
                    break;
            }

        }
    }
}