﻿namespace BookStore.DTOs.Subscription
{
    public class GetSubDTO
    {
        public int subscriptionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float durationInDays { get; set; }
        public int DownloadedBookAmount { get; set; }
    }
}
