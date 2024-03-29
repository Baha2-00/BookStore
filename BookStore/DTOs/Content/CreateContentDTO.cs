﻿namespace BookStore.DTOs.Content
{
    public class CreateContentDTO
    {
        public int ContentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public string ContentType { get; set; }
    }
}
