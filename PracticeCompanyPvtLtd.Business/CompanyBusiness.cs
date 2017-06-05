using System.Collections.Generic;
using PracticeCompanyPvtLtd.Data;
using PracticeCompanyPvtLtd.Models;

namespace PracticeCompanyPvtLtd.Business
{
    public class CompanyBusiness : ICompanyBusiness
    {
        private readonly IEmployees _employees;
        private readonly IDepartments _departments;

        public CompanyBusiness(IEmployees employees, IDepartments departments )
        {
            _employees = employees;
            _departments = departments;
        }
        
        public List<Employee> GetAllEmployees()
        {
            var allEmployees = _employees.GetAllEmployees();
            return allEmployees;
        }

        public Employee GetEmployee(int empId)
        {
            var employee = _employees.GetEmployee(empId);
            return employee;
        }

        public List<Department> GetAllDepartments()
        {
            var departments = _departments.GetAllDepartments();
            return departments;
        }

        public Department GetDepartment(int deptId)
        {
            var department = _departments.GetDepartment(deptId);
            return department;
        }

        public List<EmployeeDeptRelationship> GetAllEmployeeDeptRelationships()
        {
            var lstEmpDeptRelationships = _employees.GetAllEmployeesWithTheirDepartments();
            return lstEmpDeptRelationships;
        }

        public EmployeeDeptRelationship GetEmployeeDeptRelationship(int empId)
        {
            var empDeptRelationship = _employees.GetEmployeeDeptRelationship(empId);
            return empDeptRelationship;
        }
    }
}
