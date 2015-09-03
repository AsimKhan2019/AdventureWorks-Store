using AdvWorks.Core;
using AdvWrks.DataModel;
using AutoMapper;

namespace AdvWrks.ObjectMappings
{
    public class ShiftDataProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Shift, ShiftData>()
                .ForMember(sfData => sfData.Id, map => map.MapFrom(p => p.ShiftID))
                .ForMember(sfData => sfData.Name, map => map.MapFrom(p => p.Name))
                .ForMember(sfData => sfData.StartTime, map => map.MapFrom(p => p.StartTime))
                .ForMember(sfData => sfData.EndTime, map => map.MapFrom(p => p.EndTime));                
        }
    }
}
