using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvWorks.DataLayer;
using System.Linq;

namespace AdvWrks.CoreUnitTest
{
    [TestClass]
    public class HumanResourceRepTests
    {
        private IHumanResourceBCRepo HeRepo;
        [TestInitialize]
        public void TestSetups()
        {
            HeRepo = new HumanResourceBCRepo();
        }

        [TestMethod]
        public void GetShiftsCount()
        {
            //Act
            var countVal = HeRepo.GetShifts();
            Assert.AreEqual(3, countVal.Count());
        }

        [TestMethod]
        public void GetShiftsFirst()
        {
            //Act
            var countVal = HeRepo.GetShifts();
            Assert.AreEqual("Day", countVal.FirstOrDefault().Name);
        }

        [TestMethod]
        public void GetDepartmentsCount()
        {
            //Act
            var countVal = HeRepo.GetDepartments();
            Assert.AreEqual(16, countVal.Count());
        }

        [TestMethod]
        public void GetDeparmentsFifthName()
        {
            //Act
            var countVal = HeRepo.GetDepartments();
            Assert.AreEqual("Research and Development", countVal.ElementAt(5).Name);
        }

        [TestMethod]
        public void GetEmployeeWithDeparmentsCount()
        {
            //Act
            var emp = HeRepo.GetEmployeeWithDepartment(16);
            Assert.AreEqual(2, emp.DepartmentHistory.Count);
        }

        [TestMethod]
        public void GetEmployeeDetails()
        {
            //Act
            var emp = HeRepo.GetEmployeeWithDepartment(16);
            Assert.AreEqual("David, Bradley", emp.FullName);
            Assert.AreEqual("Marketing Manager", emp.JobTitle);
        }

        [TestMethod]
        public void GetEmployeeList()
        {
            //Act
            var emp = HeRepo.GetEmployees(string.Empty, 1, 10);
            Assert.AreEqual(10, emp.Count());            
        }

        [TestMethod]
        public void GetEmployeeListWithQuery()
        {
            //Act
            var emp = HeRepo.GetEmployees("David", 1, 10);
            Assert.AreEqual(9, emp.Count());            
        }
    }
}
