using AdvWrks.DataModel;
using System.Collections.Generic;

namespace AdvWorks.DataLayer
{
    public interface IHumanResourceBCRepo
    {
        IList<EmployeeData> GetEmployees(string query, int page, int pageSize);
        EmployeeData GetEmployeeWithDepartment(int businessId);
        IList<ShiftData> GetShifts();
        IList<DepartmentData> GetDepartments();
        EmployeeData ChangeEmployeeDepartment(EmployeeData data);
    }
}
