﻿using static BookStore.Helper.Enums.Enums;

namespace BookStore.Models.Enitity
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public DepartmentNameEN EnglishName { get; set; }
        public DepartmentNameAR ArabicName { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Person> Employees { get; set; }
    }
}
