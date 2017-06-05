using System.Collections.Generic;
using PracticeCompanyPvtLtd.Models;

namespace PracticeCompanyPvtLtd.Data
{
    public class Departments : IDepartments
    {
        private readonly List<Department> _allDepartments;

        public Departments()
        {
            _allDepartments = CreateAllDepartments();
        }

        public List<Department> GetAllDepartments()
        {
            return _allDepartments;
        }

        public Department GetDepartment(int deptId)
        {
            throw new System.NotImplementedException();
        }

        private List<Department> CreateAllDepartments()
        {
            List<Department> allDepartments = new List<Department>();
            for (int i = 0; i < 4; i++)
            {
                allDepartments.Add(new Department { Id = i, IsActive = true, Name = "Department" + i });
            }
            return allDepartments;
        }
    }
}