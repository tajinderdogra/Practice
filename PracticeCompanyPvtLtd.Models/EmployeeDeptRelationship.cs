using System;

namespace PracticeCompanyPvtLtd.Models
{
    public class EmployeeDeptRelationship
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime EmpDob { get; set; }
        public string EmpAddress { get; set; }
        public bool EmpIsActive { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public bool DeptIsActive { get; set; }
    }
}