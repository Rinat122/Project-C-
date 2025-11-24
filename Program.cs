using System;
using System.IO;
using LibraryManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "books.txt";
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }

        Manager manager = new Manager();

        while (true)
        {
            Console.WriteLine("\n Library Management System ");
            Console.WriteLine("1. Manager ");
            Console.WriteLine("2. Search a book");
            Console.WriteLine("3. Show all books");
            Console.WriteLine("0. Exit ");
            Console.Write(" Choose actions: ");
            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                if (manager.Login())
                {
                    while (true)
                    {
                        Console.WriteLine("\n Page of the Manager: ");
                        Console.WriteLine("1. Add book");
                        Console.WriteLine("2. Delete book");
                        Console.WriteLine("3. View all books");
                        Console.WriteLine("0. Go to the main menu");
                        Console.Write(" Choose actions: ");
                        string? adminChoice = Console.ReadLine();

                        if (adminChoice == "1") manager.AddBook();
                        else if (adminChoice == "2") manager.DeleteBook();
                        else if (adminChoice == "3") manager.ViewAllBooks();
                        else if (adminChoice == "0") break;
                        else Console.WriteLine(" Wrong choice.");
                    }
                }
            }
            else if (choice == "2")
            {
                Console.Write(" Write name of the book to search: ");
                string? search = Console.ReadLine()?.ToLower();
                bool found = false;

                foreach (string line in File.ReadAllLines(filePath))
                {
                    if (line != null && line.ToLower().Contains(search.ToLower()))
                    {
                        string[] data = line.Split(';');
                        Console.WriteLine($" Book: {data[0]} — {data[1]}");
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine(" The book was not found.");
            }
            else if (choice == "3")
            {
                string[] books = File.ReadAllLines(filePath);
                if (books.Length == 0)
                    Console.WriteLine(" The List is empty.");
                else
                {
                    Console.WriteLine(" All Books:");
                    foreach (string line in books)
                    {
                        if (!string.IsNullOrWhiteSpace(line) && line.Contains(";"))
                        {
                            string[] data = line.Split(';');
                            if (data.Length >= 2)
                                Console.WriteLine($" Name: {data[0]}, Author: {data[1]}");
                        }
                    }
                }
            }
            else if (choice == "0")
            {
                Console.WriteLine(" Exit ");
                break;
            }
            else
            {
                Console.WriteLine(" Wrong choice. ");
            }
        }
    }
}