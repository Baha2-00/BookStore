using static BookStore.Helper.Enums.Enums;

namespace BookStore.Models.Enitity

{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string fullName {  get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Specialization { get; set; }
        public string Gender { get; set; }
        public DateOnly birthDate { get; set; }
        public PersonType personType { get; set; }
        public bool IsActive { get; set; }
    }
    public class Admin : Person
    {

    }
    public class Employee : Person
    {
        public virtual Department Department { get; set; }
    }
    public class Client : Person
    {
        public virtual Content Content { get; set; }
        public virtual Subscription Subscrip { get; set; }
    }

}
