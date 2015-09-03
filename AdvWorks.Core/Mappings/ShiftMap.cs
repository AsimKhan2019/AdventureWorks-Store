using System.Data.Entity.ModelConfiguration;

namespace AdvWorks.Core.Mappings
{
    public class ShiftMap : EntityTypeConfiguration<Shift>
    {
        public ShiftMap()
        {
            this
                .HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Shift)
                .WillCascadeOnDelete(false);
        }
    }
}
