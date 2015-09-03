using AdvWorks.Core;
using AdvWrks.DataModel;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvWrks.ObjectMappings
{
    public class DepartmentDataProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Department, DepartmentData>()
                .ForMember(sfData => sfData.Id, map => map.MapFrom(p => p.DepartmentID))
                .ForMember(sfData => sfData.Name, map => map.MapFrom(p => p.Name))
                .ForMember(sfData => sfData.GroupName, map => map.MapFrom(p => p.GroupName));
                
        }
    }
}
