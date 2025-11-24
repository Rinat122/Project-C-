using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryManagementSystem
{
    public class Manager
    {
        private const string username = "Rinat";
        private const string password = "1234";
        private string filePath = "books.txt";

        public bool Login()
        {
            Console.Write(" Login: ");
            string? user = Console.ReadLine();
            Console.Write(" Password: ");
            string? pass = Console.ReadLine();

            if (user == username && pass == password)
            {
                Console.WriteLine("\n Welcome!");
                return true;
            }
            else
            {
                Console.WriteLine(" Incorrect login or password! ");
                return false;
            }
        }

        public void AddBook()
        {
            Console.Write(" Write name of the book: ");
            string? title = Console.ReadLine();
            Console.Write(" Write author of the book: ");
            string? author = Console.ReadLine();

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
            {
                File.AppendAllText(filePath, $"{title};{author}\n");
                Console.WriteLine(" The book added succesfully!");
            }
            else
            {
                Console.WriteLine(" Name or Author can not be empty!");
            }
        }

        public void DeleteBook()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine(" The book was not found.");
                return;
            }

            List<string> lines = new List<string>(File.ReadAllLines(filePath));

            Console.Write(" Write name of the book: ");
            string? title = Console.ReadLine();

            bool removed = false;
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].StartsWith(title + ";"))
                {
                    lines.RemoveAt(i);
                    removed = true;
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);
            Console.WriteLine(removed ? " The book is deleted." : " Book not founded.");
        }

        public void ViewAllBooks()
        {
            if (!File.Exists(filePath) || File.ReadAllLines(filePath).Length == 0)
            {
                Console.WriteLine(" List of the books is empty.");
                return;
            }

            Console.WriteLine("\n List of the books:");
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(';');
                Console.WriteLine($" Name: {data[0]}, Author: {data[1]}");
            }
        }
    }
}