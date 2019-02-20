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
        public void Test1()
        {
            Shelf bs = new Shelf();
            Assert.IsFalse(bs.returnFalse());

        }
    }
}