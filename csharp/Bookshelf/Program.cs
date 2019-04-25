using System;

namespace Bookshelf
{
    class Program
    {
        static Shelf s;
        static void Main(string[] args)
        {
            s = new Shelf();
            while(true)
                StartMenuLoop();
        }
        static void PrintMenu()
        {
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. Remove a book");
            Console.WriteLine("3. List all books");
            Console.WriteLine("4. Quit");
            
        }
        static void StartMenuLoop()
        {
            PrintMenu();
            String optionString = Console.ReadLine();
            try{
                short option = Int16.Parse(optionString);
                switch (option)
                {
                    case 1:
                        AddABook();
                        break;
                    case 2:
                        DeleteABook();
                        break;
                    case 3:
                        ListAllBooks();
                        break;
                    case 4:
                       System.Environment.Exit(1); 
                       break;
                    default:
                       throw new Exception();
                } 
            } catch (Exception)
            {
                Console.WriteLine("Option is invalid. Please try again.");
            }
        }
        static void AddABook()
        {
            bool acceptable = false;
            // Give our book a default name. We will have to give it a vaild name later.
            Book b = new Book("NULL");
            while (!acceptable)
            {
                Console.WriteLine("Enter the book title");
                String title = Console.ReadLine();
                try{
                    b.title = title;
                    acceptable = true;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    acceptable = false;
                }
            }
            acceptable = false;
            while (!acceptable)
            {
                Console.WriteLine("Enter the author");
                String author = Console.ReadLine();
                try
                {
                    b.author = author;
                    acceptable = true;
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    acceptable = false;
                }
            }
            acceptable = false;
            while (!acceptable)
            {
                try{
                    Console.WriteLine("Enter the ISBN");
                    String ISBN = Console.ReadLine();
                    b.code = ISBN;
                    acceptable = true;
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    acceptable = false;
                }
            }
            s.Add(b);
        }
        static void DeleteABook()
        {
            Console.WriteLine("Enter the exact title you want to delete");
            String title = Console.ReadLine();
            s.Remove(title);
        }
        static void ListAllBooks()
        {
            Console.WriteLine("The books currently on your bookshelf:");
            foreach(Book b in s)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine();
        }
    }
}
