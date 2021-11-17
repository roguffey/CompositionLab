namespace CompositionLab
{
    public class Book : Author
    {
        string isbn;

        string title;
        public Book(string isbn, string title)
        {

        }

        public Book()
        {
            
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        // public string GetAuthor()
        // {
        //     Author.GetName();
        //     Author.GetGender();
        //     Author.GetEmail();
        // }

        public void SetAuthor(string name, char gender, string email)
        {
            this.name = name;
            this.gender = gender;
            this.email = email;
        }

        public override string ToString()
        {
            return "isbn = " + isbn + ", title = " + title + ", " + Author.ToString();
        }

    }
}