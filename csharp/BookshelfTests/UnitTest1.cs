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
    }
}