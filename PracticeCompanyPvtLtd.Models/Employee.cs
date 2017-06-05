﻿using System;

namespace PracticeCompanyPvtLtd.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}
