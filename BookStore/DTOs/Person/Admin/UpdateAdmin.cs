using static BookStore.Helper.Enums.Enums;

namespace BookStore.DTOs.Person.Admin
{
    public class UpdateAdmin
    {
        public string fullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
