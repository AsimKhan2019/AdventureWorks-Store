using System;
using System.Collections.Generic;

namespace AdvWrks.DataModel
{
    public class EmployeeData
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public IList<EmployeeDepartmentData> DepartmentHistory { get; set; }

        public string FullName
        {
            get { return string.Concat(FirstName + ", " + LastName); }
        }
    }
}
