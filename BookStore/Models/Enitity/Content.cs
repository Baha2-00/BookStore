﻿using static BookStore.Helper.Enums.Enums;

namespace BookStore.Models.Enitity
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public float Price { get; set; }
        public DateTime DatePublished { get; set; }
        public ContentType ContentType { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Person> Client { get; set; }
        public virtual Subscription Subscription { get; set; }
    }
}
