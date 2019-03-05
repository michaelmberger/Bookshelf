using System;

namespace Bookshelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shelf s = new Shelf();
            s.Add(new Book("Gulivers travels"));
            Console.WriteLine(s.GetContents()[0]);
        }
    }
}
