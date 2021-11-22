namespace CompositionLab
{
    public class Book : Author
    {
        string isbn;

        string title;

        private Author author;
        public Book(string tempIsbn, string tempTitle, Author tempAuthor)
        {
            isbn = tempIsbn;
            title = tempTitle;
            author = tempAuthor;
        }

        public Book()
        {
            
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public void SetIsbn(string tempIsbn)
        {
            isbn = tempIsbn;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string tempTitle)
        {
            title = tempTitle;
        }

        public Author GetAuthor()
        {
            return author;
        }

        public void SetAuthor(Author tempAuthor)
        {
            author = tempAuthor;
        }

        public override string ToString()
        {
            return "isbn = " + this.GetIsbn() + ", title = " + this.GetTitle() + ", " + this.author.ToString();
        }

    }
}