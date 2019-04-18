using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Bookshelf
{
    public class Book : IEquatable<Book>
    {
        private String name;
        private String ISBN;
        /*
        * We check that when the title is explicitly set that it is not null or empty.
        */
        public String title
        {
            get {return this.name;} 
            set {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Book title must have at least 1 character.");
                else 
                    this.name = value;
                }
        }
        /*
        * We check that when the ISBN is explicitly set that it is not not null or empty
        */
        public String code
        {
            get {return this.ISBN;} 
            set 
            {
                if (String.IsNullOrEmpty(Regex.Replace(value, "[^0-9]", "")))
                    throw new ArgumentException("The ISBN cannot be null or empty and must contain at least 1 number.");
                else 
                    this.ISBN = value;
            }
        }
        public String author {get; set;}
        /*
        * We allow the creation of empty book objects.
         */
        private Book()
        {
            name = "";
        }
        public Book(String title)
        {
             if (String.IsNullOrEmpty(title))
             {
                    throw new ArgumentException("Book title must have at least 1 character.");
             }
            name = title;
        }

         /*
         * we consider objects equal if the ISBN matches or the title matches.
         If we don't have either of those values, its false. 
          */
        public bool Equals(Book obj)
        {   
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            if (this.ISBN != null && obj.ISBN != null) {
                return this.ISBN == obj.ISBN;
            }
            if (this.name != null && obj.name != null)
            {
                return this.name.Equals(obj.name);
            }
            return false;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // we want to use the ISBN as the hash code if possible, otherwise, get the hash of the title. 
            if (this.ISBN != null)
            {
                // strip all characters that aren't numbers
                String numericString = Regex.Replace(this.ISBN, "[^0-9]", "");
                // must be more than 1 and less than 2,147,483,647. Using 9 digits for saftey
                if (numericString.Length > 0 && numericString.Length <= 9)
                {
                    return Int32.Parse(numericString);
                }
                else
                {
                    if (numericString.Length > 9)
                    {
                        return Int32.Parse(numericString.Substring(0, 10));
                    } else
                    {
                        this.name.GetHashCode();
                    }
                }
            }
            return base.GetHashCode();
        }
        public override String ToString()
        {
            return this.title + ' ' + this.ISBN;
        }
    }
}