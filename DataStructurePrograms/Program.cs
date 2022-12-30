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
                    "2. End");
                Console.Write("Please Select One Option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        UnOrderedList<string> unOrderedList = new UnOrderedList<string>();
                        unOrderedList.UnOrderedListOperation();
                        break;
                    case 2:
                        Console.WriteLine("\nThank you");
                        break;
                }
                if (option == 2)
                    break;
            }

        }
    }
}