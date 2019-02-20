using NUnit.Framework;
using Bookshelf;

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

    }
}