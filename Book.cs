using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceFundamentals
{
    internal class Book
    {
        public string Author { get; private set; }

        public string Title { get; private set; }

        public Book(string author = "Unknown", string title = "Untitled")
        {
            Author = author;
            Title = title;
        }

        public virtual string Stringify()
        {
            return "This is a Book object!";
        }
    }
}
