using System.Collections.Generic;
using PracticeCompanyPvtLtd.Models;

namespace PracticeCompanyPvtLtd.Data
{
    public interface IEmployees
    {
        List<Employee> GetAllEmployees();

        List<EmployeeDeptRelationship> GetAllEmployeesWithTheirDepartments();

        Employee GetEmployee(int empId);

        EmployeeDeptRelationship GetEmployeeDeptRelationship(int empId);
    }
}
