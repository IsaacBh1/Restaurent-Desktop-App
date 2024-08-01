using System.Linq;
namespace ResturantManagemantSys
{
    public class Person
    {
        protected static int Id = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string GetFullName() => FirstName + " " + LastName;


        public Person(string FirstName, string LastName, string Email, string PhoneNumber, string UserName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.UserName = UserName;
            Id++;
        }

    }
}
