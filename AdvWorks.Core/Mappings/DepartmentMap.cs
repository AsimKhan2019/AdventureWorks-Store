using System.Data.Entity.ModelConfiguration;

namespace AdvWorks.Core.Mappings
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            this.HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);
        }
    }
}
