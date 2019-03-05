using NUnit.Framework;
using Bookshelf;
using System;
using System.Collections;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestShelfIsEmptyOnCreation()
        {
            Shelf shelf = new Shelf();
            Assert.AreEqual(shelf.getContentCount(), 0);

        }
        [Test]
        public void TestShelfHasItemAfterAdd()
        {
            Shelf shelf = new Shelf();
            shelf.add("Book1");
            Assert.AreEqual(shelf.getContentCount(), 1);
        }
        [Test]
        public void TestShelfDoesntAllowBlankTitles()
        {
            Shelf shelf = new Shelf();
            shelf.add("");
            Assert.AreEqual(shelf.getContentCount(), 0);
        }
        [Test]
        public void TestShelfHasNoItmesAfterRemoval()
        {
            Shelf shelf = new Shelf();
            shelf.add("Book1");
            shelf.remove("Book1");
            Assert.AreEqual(shelf.getContentCount(), 0);
        }
        [Test]
        public void TestShelfWontAllowRemovalOfNonexistantBook()
        {
            Shelf shelf = new Shelf();
            shelf.add("Book1");
            shelf.remove("Book2");
            Assert.AreEqual(shelf.getContentCount(), 1);
        }
        [Test]
        public void TestShelfAcceptsBookObject()
        {
            Shelf shelf = new Shelf();
            shelf.add(new Book());
            Assert.AreEqual(shelf.getContentCount(), 1);
        }
        [Test]
        public void TestCreateBookHashCode()
        {
            Book b = new Book();
            Assert.GreaterOrEqual(b.GetHashCode(), 0);
        }
        [Test]
        public void TestCreateBookWithISBN()
        {
            Book b = new Book();
            b.code = "1234-567-890";
            Assert.AreEqual(1234567890, b.GetHashCode());
        }
        [Test]
        public void TestCreateBookWithBadISBN()
        {
            Book b = new Book();

            var ex = Assert.Throws<ArgumentException>(() => b.code = "XX");
            Assert.AreEqual(ex.Message, "The ISBN cannot be null or empty and must contain at least 1 number.");

        }
        [Test]
        public void TestCreateBookwithBadTitle()
        {
            Book b = new Book();
            var ex = Assert.Throws<ArgumentException>(() => b.title = "");
            Assert.AreEqual(ex.Message, "Book title must have at least 1 character.");
        }
        [Test]
        public void TestBooksAreEqual()
        {
            Book b1 = new Book("Book1");
            Book b2 = new Book("Book1");
            Assert.AreEqual(b1, b2);
            b1.code = "1234";
            b2.code = "1234";
            Assert.AreEqual(b1, b2);
            b1.code = "4567";
            Assert.AreNotEqual(b1, b2);
        }
        [Test]
        public void TestGetEnumerator()
        {
            Shelf s = new Shelf();
            Assert.IsNotNull(s.GetEnumerator());
        }
        [Test]
        public void TestGetBookArray()
        {
            Shelf  s = new Shelf();
            Book b = new Book("Book1");
            s.add(b);
            Book[] books = s.getContents();
            Assert.IsNotEmpty(books);
        }
         

    }
}