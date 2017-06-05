using System.Collections.Generic;
using PracticeCompanyPvtLtd.Models;

namespace PracticeCompanyPvtLtd.Business
{
    public interface ICompanyBusiness
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int empId);
        List<Department> GetAllDepartments();
        Department GetDepartment(int deptId);
        List<EmployeeDeptRelationship> GetAllEmployeeDeptRelationships();
        EmployeeDeptRelationship GetEmployeeDeptRelationship(int empId);
    }
}