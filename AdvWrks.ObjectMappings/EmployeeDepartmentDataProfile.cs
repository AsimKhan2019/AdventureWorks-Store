using AdvWorks.Core;
using AdvWrks.DataModel;
using AutoMapper;

namespace AdvWrks.ObjectMappings
{
    public class EmployeeDepartmentDataProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<EmployeeDepartmentHistory, EmployeeDepartmentData>()
                   .ForMember(sfData => sfData.Id, map => map.MapFrom(p => p.BusinessEntityID))
                   .ForMember(sfData => sfData.DepartmentId, map => map.MapFrom(p => p.DepartmentID))
                   .ForMember(sfData => sfData.ShiftId, map => map.MapFrom(p => p.ShiftID))
                   .ForMember(sfData => sfData.StartDate, map => map.MapFrom(p => p.StartDate))
                   .ForMember(sfData => sfData.EndDate, map => map.MapFrom(p => p.EndDate))
                   .ForMember(sfData => sfData.DepartmentName, map => map.MapFrom(p => p.Department.Name))
                   .ForMember(sfData => sfData.ShiftName, map => map.MapFrom(p => p.Shift.Name));
        }
    }
}
