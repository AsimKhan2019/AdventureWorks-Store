using AutoMapper;
using AdvWorks.Core;
using AdvWrks.DataModel;

namespace AdvWrks.ObjectMappings
{
    public class EmployeeDataProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Employee, EmployeeData>()
                .ForMember(sfData => sfData.Id, map => map.MapFrom(p => p.BusinessEntityID))
                .ForMember(sfData => sfData.JobTitle, map => map.MapFrom(p => p.JobTitle))
                .ForMember(sfData => sfData.DateOfBirth, map => map.MapFrom(p => p.BirthDate))
                .ForMember(sfData => sfData.MaritalStatus, map => map.MapFrom(p => p.MaritalStatus))
                .ForMember(sfData => sfData.Gender, map => map.MapFrom(p => p.Gender))
                .ForMember(sfData => sfData.FirstName, map => map.MapFrom(p => p.Person.FirstName))
                .ForMember(sfData => sfData.LastName, map => map.MapFrom(p => p.Person.LastName))
                .ForMember(sfData => sfData.DepartmentHistory, map => map.MapFrom(p => p.EmployeeDepartmentHistories));
        }
    }
}
