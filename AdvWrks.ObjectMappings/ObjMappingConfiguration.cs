using AutoMapper;

namespace AdvWrks.ObjectMappings
{
    public class ObjMappingConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new EmployeeDataProfile());
                cfg.AddProfile(new EmployeeDepartmentDataProfile());
                cfg.AddProfile(new ShiftDataProfile());
                cfg.AddProfile(new DepartmentDataProfile());
                
            });
        }
    }
}
