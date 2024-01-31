using static BookStore.Helper.Enums.Enums;

namespace BookStore.DTOs.Subscription
{
    public class CreateContentDTO
    {
        public int subscriptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float durationInDays { get; set; }
        public int DownloadedBookAmount { get; set; }
    }
}
