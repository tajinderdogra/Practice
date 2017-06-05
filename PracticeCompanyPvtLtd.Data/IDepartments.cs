using System.Collections.Generic;
using PracticeCompanyPvtLtd.Models;

namespace PracticeCompanyPvtLtd.Data
{
    public interface IDepartments
    {
        List<Department> GetAllDepartments();
        Department GetDepartment(int deptId);
    }
}