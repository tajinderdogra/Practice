using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using PracticeCompanyPvtLtd.Data;
using PracticeCompanyPvtLtd.Models;

namespace PracticeCompanyPvtLtd.Business.Tests
{
    [TestFixture]
    public class CompanyBusinessTests
    {
        [Test]
        public void ReturnNullWhenNoneOfTheEmployesAreReturned()
        {
            Mock<IEmployees> employeesMock = new Mock<IEmployees>();
            Mock<IDepartments> deptMock = new Mock<IDepartments>();

            CompanyBusiness cb = new CompanyBusiness(employeesMock.Object, deptMock.Object);
            employeesMock.Setup(x => x.GetAllEmployees()).Returns(() => null);

            var allEmployees = cb.GetAllEmployees();

            Assert.IsNull(allEmployees);
        }

        [Test]
        public void ReturnSameObjectAsReceivedFromMethodCall()
        {
            Mock<IEmployees> employeesMock = new Mock<IEmployees>();
            Mock<IDepartments> deptMock = new Mock<IDepartments>();

            
            List<Employee> lstEmp = new List<Employee>();
            var employee = new Employee
            {
                IsActive = true,
                Dob = DateTime.Now,
                Name = "Test"
            };
            lstEmp.Add(employee);

            CompanyBusiness cb = new CompanyBusiness(employeesMock.Object, deptMock.Object);
            employeesMock.Setup(x => x.GetAllEmployees()).Returns(lstEmp);

            var allEmployees = cb.GetAllEmployees();

            Assert.AreEqual(lstEmp, allEmployees);
        }

        [Test]
        public void ReturnNullIfNoEmployeObjectIsReturned()
        {
            Mock<IEmployees> employeesMock = new Mock<IEmployees>();
            Mock<IDepartments> deptMock = new Mock<IDepartments>();

            CompanyBusiness cb = new CompanyBusiness(employeesMock.Object, deptMock.Object);
            employeesMock.Setup(x => x.GetEmployee(It.IsAny<int>())).Returns(() => null);

            var employee = cb.GetEmployee(It.IsAny<int>());

            Assert.IsNull(employee);
        }

        [Test]
        public void ReturnSameEmployeeAsReceivedFromMethodCall()
        {
            Mock<IEmployees> employeesMock = new Mock<IEmployees>();
            Mock<IDepartments> deptMock = new Mock<IDepartments>();

            var employee = new Employee
            {
                Id = 1,
                IsActive = true,
                Dob = DateTime.Now,
                Name = "Test"
            };
            
            CompanyBusiness cb = new CompanyBusiness(employeesMock.Object, deptMock.Object);
            employeesMock.Setup(x => x.GetEmployee(It.IsAny<int>())).Returns(employee);

            var employeeReceived = cb.GetEmployee(It.IsAny<int>());

            Assert.AreEqual(employee, employeeReceived);
        }

    }
}
