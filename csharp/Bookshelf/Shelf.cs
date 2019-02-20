using System;
using System.Collections.Generic;

namespace Bookshelf
{
    public class Shelf
    {
        private List<String> contents;
        public Shelf()
        {
            contents = new List<String>();
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
            contents.Add(bookTitle);
        }
    }
}