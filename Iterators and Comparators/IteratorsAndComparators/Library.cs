using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;

        public Library(params Book[] books)
        {
            this.books = new SortedSet<Book>(books, new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int index = -1;
            public LibraryIterator(List<Book> books)
            {
                Books = books;
            }
            public List<Book> Books { get; set; }

            public Book Current => Books[index];

            object IEnumerator.Current => Books[index];

            public void Dispose() { }
            

            public bool MoveNext()
            {
                return ++index < Books.Count;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
