using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdvWorks.Core.HumanResourceBC;

namespace AdvWrks.CoreUnitTest
{
    [TestClass]
    public class CoreUnitTests
    {
        [TestMethod]
        public void GetAdvWorks_EmployeesCount()
        {
            //Arrange
            var empCount = 0;
            //Act
            using (var HRcontext = new HumanResourceBoundedContext())
            {
                empCount = HRcontext.Employees.Count();
            }
            //Assert
            
            Assert.AreEqual(empCount, 290);
        }

        [TestMethod]
        public void GetFirstNamePeople()
        {
            using (var HRcontext = new HumanResourceBoundedContext())
            {
                Assert.AreEqual(HRcontext.People.Find(16).FirstName, "David");
            }
        }

        [TestMethod]
        public void GetAdvWrks_DepartmentCount()
        {
            //Arrange
            var deptCount = 0;
            //Act
            using (var HRcontext = new HumanResourceBoundedContext())
            {
                deptCount = HRcontext.Departments.Count();
            }
            //Assert
            Assert.AreEqual(deptCount, 16);
        }
    }
}
