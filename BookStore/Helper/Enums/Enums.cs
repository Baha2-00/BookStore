namespace BookStore.Helper.Enums
{
    public class Enums
    {
        public enum PersonType
        {
            Admin = 1,
            Employee = 2,
            Client = 3,
        }
        public enum ContentType
        {
            Book = 1,
            Magazine = 2,
            Manga = 3,
            Comic = 4,
            Poetry = 5
        }
        public enum DepartmentType
        {
            Sales = 1,
            Marketing = 2,
            Inventory = 3,
            CustomerService = 4,
            IT = 5
        }
        public enum SubscriptionType
        {
            Standard = 1,
            Premium = 2,
            Ultimate = 3,
        }
    }
}
