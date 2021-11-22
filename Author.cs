namespace CompositionLab
{
    public class Author
    {
        public Author(string tempName, char tempGender, string tempEmail)
        {
            name = tempName;
            gender = tempGender;
            email = tempEmail;
        }

        public Author()
        {

        }


        private string name;

        private string email;

        private char gender;

        public string GetName()
        {
            return name;
        }
        public void SetName(string tempName)
        {
            name = tempName;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string tempEmail)
        {
            email = tempEmail;
        }

        public char GetGender()
        {
            return gender;
        }

        public void SetGender(char tempGender)
        {
            gender = tempGender;
        }

        public override string ToString()
        {
            return "Name: " + this.GetName() + ", email: " + this.GetEmail() + ", gender: " + this.GetGender() + "\n";
        }
    }
}