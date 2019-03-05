using System;

namespace Bookshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shelf s = new Shelf();
            s.add(new Book("Gulivers travels"));
            Console.WriteLine();
        }
    }
}
