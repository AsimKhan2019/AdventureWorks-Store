using System;
using AdvWorks.Core;
using AdvWrks.DataModel;
using AdvWorks.Core.HumanResourceBC;
using System.Linq;
using AutoMapper.QueryableExtensions;
using System.Data.Entity;
using AdvWrks.ObjectMappings;

namespace AdWrksConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObjMappingConfiguration.Configure();
            // IEveryLogger _logger = new EveryLogger();
            //_logger.Log(GlobalType.GlobalInformational, "Hello World");
            //_logger.Log(GlobalType.GlobalError, "This is an ERROR !!");
            //_logger.Log(GlobalType.GlobalWarning, "Hello World, This a WARNING");

            //Mapper.CreateMap<byte, int>().ConvertUsing(new ByteToIntMapConverter());
            //Mapper.CreateMap<Shift, ShiftData>()
            //    .ForMember(sfData => sfData.Id, map => map.MapFrom(p => p.ShiftID));

            //using (var context = new HumanResourceBoundedContext())
            //{
            //    var test = context.Shifts.Project().To<ShiftData>().ToList();               

            //    foreach (var item in test)
            //    {
            //        Console.WriteLine(item.Name + " " + item.StartTime);
            //    }
            //}

            using (var context = new HumanResourceBoundedContext())
            {

                var linqQuery = context.Employees.Include(n => n.Person)
                    .Include(n => n.EmployeeDepartmentHistories);


                int page = 1;
                int pageSize = 10;

                if (page > 0 && pageSize > 0)
                {
                    linqQuery = linqQuery.OrderBy(n => n.BusinessEntityID).Skip(page - 1).Take(pageSize);
                }

                //var companyList = context.Employees.AsNoTracking()                    
                //    .Include(n => n.EmployeeDepartmentHistories)                    
                //    .Where(e => e.BusinessEntityID == 16).Project().To<EmployeeData>().ToList();

                var companList = linqQuery.Project().To<EmployeeData>().ToList();

                foreach (var item in companList)
                {
                    Console.WriteLine(string.Format("{0}, {1}", item.FullName, item.DepartmentHistory.Count));
                }


            }


            Console.ReadLine();
        }
       
    }
}