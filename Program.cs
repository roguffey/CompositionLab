using System;

namespace CompositionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Reid Guffey", 'm', "roguffey@crimson.ua.edu");
            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());

            Console.WriteLine(myBook.GetAuthor().ToString());

            Book yourBook = new Book("4321", "The Pantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            Console.WriteLine(yourBook.ToString());

            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(yourBook.ToString());
        }
    }
}
