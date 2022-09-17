namespace CatWorx.BadgeMaker
{
    class Employee 
    {
       public string FirstName;
        public string LastName;
        public int Id;
        public string PhotoUrl;

        // use PascalCase for public variables and camelCase for private variables

        public Employee(string firstName, string lastName, int id, string photoUrl) {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        public string GetFullName() {
            return FirstName + " " + LastName;
        }

    }
}