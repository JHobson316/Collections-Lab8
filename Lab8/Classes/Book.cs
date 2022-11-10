using System;
using System.Collections.Generic;
using System.Linq;

namespace Books{
    class Book{
        public string Title {get; set;}
        public string AuthorFirstName {get; set;}
        public string AuthorLastName {get; set;}
        public int NumberofPages {get; set;}
        public Book(string title, string authFirst, string authLast, int pages){
            Title = title;
            AuthorFirstName = authFirst;
            AuthorLastName = authLast;
            NumberofPages = pages;
        }
    }
}