using System;
using System.Collections.Generic;
using System.Collections;

namespace Bookshelf
{
    public class Shelf
    {
        private List<Book> contents;
        public Shelf()
        {
            contents = new List<Book>();
        }
        public bool returnFalse()
        {
            return false;
        }
        public int getContentCount()
        {
            return contents.Count;
        }
        public void add(String bookTitle)
        {
            if (bookTitle.Trim().Length > 0)
            {
                contents.Add(new Book(bookTitle));
            }
        }
        public void add(Book book)
        {
            contents.Add(book);
        }
        public void remove(String bookTitle)
        {
            contents.Remove(new Book(bookTitle));
        }
        public Book getFirst()
        {
            var enumerator = contents.GetEnumerator();
            bool hasNext = enumerator.MoveNext();
            if (hasNext)
                return enumerator.Current;
            else 
                throw new EmptyCollectionException("Collection is empty");
        }
    }
}