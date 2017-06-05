using System;
using System.Collections.Generic;
using System.Linq;
using PracticeCompanyPvtLtd.Models;

namespace PracticeCompanyPvtLtd.Data
{
    public class Employees : IEmployees
    {
        private readonly List<Employee> _allEmployees;
        private readonly List<EmployeeDeptRelationship> _allEmployeesAndDeptRelationships;

        public Employees()
        {
            _allEmployees = CreateAllEmployees();
            _allEmployeesAndDeptRelationships = CreateAllEmployeesAndDeptRelationships();
        }

        public List<Employee> GetAllEmployees()
        {
            return _allEmployees;
        }

        public List<EmployeeDeptRelationship> GetAllEmployeesWithTheirDepartments()
        {
            return _allEmployeesAndDeptRelationships;
        }

        public Employee GetEmployee(int empId)
        {
            var emp = (from employee in _allEmployees
                where employee.Id == empId
                select new Employee
                {
                    Address = employee.Address,
                    Dob = employee.Dob,
                    IsActive = employee.IsActive,
                    Name = employee.Name,
                    Id = employee.Id
                }).FirstOrDefault();

            return emp;
        }

        public EmployeeDeptRelationship GetEmployeeDeptRelationship(int empId)
        {
            var empDeptment = (from empDept in _allEmployeesAndDeptRelationships
                           where empDept.EmpId == empId
                           select new EmployeeDeptRelationship
                           {
                                  DeptIsActive = empDept.DeptIsActive,
                                  DeptId = empDept.DeptId,
                                  EmpId = empDept.EmpId,
                                  DeptName = empDept.DeptName,
                                  EmpAddress = empDept.EmpAddress,
                                  EmpDob = empDept.EmpDob,
                                  EmpIsActive = empDept.EmpIsActive,
                                  EmpName = empDept.EmpName
                           }).FirstOrDefault();
            return empDeptment;
        }

        private List<EmployeeDeptRelationship> CreateAllEmployeesAndDeptRelationships()
        {
            List<EmployeeDeptRelationship> allEmployeesAndTheirDepartments = new List<EmployeeDeptRelationship>();
            int deptCounter = 1;
            for (int i = 0; i < 50; i++)
            {
                allEmployeesAndTheirDepartments.Add(new EmployeeDeptRelationship { EmpId = i, EmpIsActive = true, EmpName = "Employee" + i, EmpAddress = "Address" + i, EmpDob = DateTime.Now.AddDays(i - 30), DeptIsActive = true, DeptName = "Department" + deptCounter, DeptId = deptCounter });

                if (deptCounter > 4)
                    deptCounter = 1;
                else
                    deptCounter++;
            }
            return allEmployeesAndTheirDepartments;
        }

        private List<Employee> CreateAllEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();
            for (int i = 0; i < 50; i++)
            {
                allEmployees.Add(new Employee { Id = i, IsActive = true, Name = "Employee" + i, Address = "Address" + i, Dob = DateTime.Now.AddDays(i - 30) });
            }
            return allEmployees;
        }
    }
}