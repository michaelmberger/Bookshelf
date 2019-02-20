using System;
namespace Bookshelf
{
    public class Book : IEquatable<Book>
    {
        private String name {get; set;}
        private String ISBN {get; set;}
        private String author {get; set;}

         // override object.Equals
        public bool Equals(Book obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            // TODO: write your implementation of Equals() here
            throw new System.NotImplementedException();
            return base.Equals (obj);
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
            return base.GetHashCode();
        }
    }
}