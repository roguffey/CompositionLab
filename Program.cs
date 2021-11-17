using System;

namespace CompositionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Reid Guffey", 'm', "roguffey@crimson.ua.edu");
            Console.WriteLine(myAuthor.ToString());
        }
    }
}
