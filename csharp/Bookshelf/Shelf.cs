using System;
using System.Collections.Generic;
using System.Collections;

namespace Bookshelf
{
    public class Shelf : IEnumerable
    {
        private List<Book> contents;
        public Shelf()
        {
            contents = new List<Book>();
        }
        public bool ReturnFalse()
        {
            return false;
        }
        public int GetContentCount()
        {
            return contents.Count;
        }
        public void Add(String bookTitle)
        {
            if (bookTitle.Trim().Length > 0)
            {
                contents.Add(new Book(bookTitle));
            }
        }
        public void Add(Book book)
        {
            contents.Add(book);
        }
        public void Remove(String bookTitle)
        {
            contents.Remove(new Book(bookTitle));
        }
        public IEnumerator GetEnumerator()
        {
            return contents.GetEnumerator();
        }
        public Book[] GetContents()
        {
            return contents.ToArray();
        }

    }
}