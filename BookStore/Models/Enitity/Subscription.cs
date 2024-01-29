﻿using static BookStore.Helper.Enums.Enums;

namespace BookStore.Models.Enitity
{
    public class Subscription
    {
        public int subscriptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int durationInDays { get; set; }
        public int DownloadedBookAmount { get; set; }
        public SubscriptionType SubscriptionType { get; set; }
        public bool IsActive { get; set; }
        public virtual Client Client { get; set; }
        public virtual List<Content> Contents { get; set;}
    }
}
