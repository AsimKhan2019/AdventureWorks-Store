using System;
using AdvWrks.DataModel;
using AdvWorks.Core.HumanResourceBC;
using System.Linq;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;
using AdvWrks.ObjectMappings;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace AdvWorks.DataLayer
{
    public class HumanResourceBCRepo : IHumanResourceBCRepo
    {
        public HumanResourceBCRepo()
        {
            ObjMappingConfiguration.Configure();
        }

        public IList<EmployeeData> GetEmployees(string query, int page, int pageSize)
        {
            using (var context = new HumanResourceBoundedContext())
            {
                //#if DEBUG
                //context.Database.Log = message => File.AppendText("C:\\mylog.txt").WriteLine(message);
                //#endif
                var linqQuery = context.Employees.Include(n => n.Person);

                if (!string.IsNullOrEmpty(query))
                {
                    linqQuery = linqQuery.Where(n => n.Person.FirstName.Contains(query));
                }
                if (page > 0 && pageSize > 0)
                {
                    linqQuery = linqQuery.OrderBy(n => n.BusinessEntityID).Skip(page - 1).Take(pageSize);
                }

                return linqQuery.Project().To<EmployeeData>().ToList();
            }
        }

        public EmployeeData GetEmployeeWithDepartment(int businessId)
        {
            using (var context = new HumanResourceBoundedContext())
            {
                var linqQuery = context.Employees.Include(n => n.Person)
                    .Include(n => n.EmployeeDepartmentHistories)
                    .Where(e => e.BusinessEntityID == businessId)
                    .Project().To<EmployeeData>().SingleOrDefault();

                return linqQuery;
            }
        }

        public IList<ShiftData> GetShifts()
        {
            using (var context = new HumanResourceBoundedContext())
            {
                return context.Shifts.AsNoTracking().Project().To<ShiftData>().ToList();
            }
        }

        public IList<DepartmentData> GetDepartments()
        {
            using (var context = new HumanResourceBoundedContext())
            {
                return context.Departments.AsNoTracking().Project().To<DepartmentData>().ToList();
            }
        }

        public void ChangeEmployeeDepartment(EmployeeData data)
        {
            throw new NotImplementedException();
        }
    }
}