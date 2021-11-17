namespace CompositionLab
{
    public class Author
    {
        public Author(string name, char gender, string email)
        {

        }


        public string name;

        public string email;

        public char gender;

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public char GetGender()
        {
            return gender;
        }

        public void SetGender(char gender)
        {
            this.gender = gender;
        }

        public override string ToString()
        {
            return "Name: " + name + ", gender: " + gender + ", email: " + email;
        }
    }
}