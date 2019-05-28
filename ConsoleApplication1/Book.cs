using System;

namespace ConsoleApplication1
{
    public class Book
    {
        private String authorNAme;
        private String bookName;
        private int code;
        private DateTime year;
        private int numberOfPages;
        private String genre;

        public Book(String authorNAme, String bookName, int code, DateTime year, int numberOfPages, String genre)
        {
            this.authorNAme = authorNAme;
            this.bookName = bookName;
            this.code = code;
            this.year = year;
            this.numberOfPages = numberOfPages;
            this.genre = genre;
        }

        public Book()
        {
        }

        public bool compareByName(String name)
        {
            return string.Equals(authorNAme, name);
        }
        
        public bool compare(Book other)
        {
            return string.Equals(authorNAme, other.authorNAme);
        }

        public override string ToString()
        {
            return $"{nameof(authorNAme)}: {authorNAme}, {nameof(bookName)}: {bookName}, {nameof(code)}: {code}, {nameof(year)}: {year}, {nameof(numberOfPages)}: {numberOfPages}, {nameof(genre)}: {genre}";
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Book) obj);
        }

        public override int GetHashCode()
        {
            return (authorNAme != null ? authorNAme.GetHashCode() : 0);
        }

        public String AuthorNAme
        {
            get => authorNAme;
            private set => authorNAme = value;
        }

        public String BookName
        {
            get => bookName;
            private set => bookName = value;
        }

        public int Code
        {
            get => code;
            set => code = value;
        }

        public DateTime Year
        {
            get => year;
            set => year = value;
        }

        public int NumberOfPages
        {
            get => numberOfPages;
            set => numberOfPages = value;
        }

        public String Genre
        {
            get => genre;
            set => genre = value;
        }
    }
}