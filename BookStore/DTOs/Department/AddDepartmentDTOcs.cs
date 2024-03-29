﻿using static BookStore.Helper.Enums.Enums;

namespace BookStore.DTOs.Department
{
    public class AddDepartmentDTOcs
    {
        public int DepartmentId { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
