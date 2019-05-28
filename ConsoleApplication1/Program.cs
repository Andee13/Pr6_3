using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Library l = new Library();
            l.add(new Book("Jack London", "Matrin Iden", 2342,
                new DateTime(1888, 3, 4), 204, "roman"));
            l.add(new Book("Decameron", "Bokacho", 2354,
                new DateTime(1488, 3, 4), 234, "roman"));
            l.add(new Book("Mike", "alksjfl", 112,
                new DateTime(1888, 3, 4), 204, "roman"));
            l.add(new Book("kal", "fin", 2342,
                new DateTime(1888, 3, 4), 204, "roman"));
            l.add(new Book("Jem Smith", "Matrinasfasen", 2342,
                new DateTime(1888, 3, 4), 204, "roman"));
            Book b = l.getBookbyName("Jack London");
            if (b != null)
            {
                Console.WriteLine(b.ToString());
            }

        }
    }
}