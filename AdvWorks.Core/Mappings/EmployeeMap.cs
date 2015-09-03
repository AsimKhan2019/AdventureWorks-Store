using System.Data.Entity.ModelConfiguration;

namespace AdvWorks.Core.Mappings
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            this.Property(e => e.MaritalStatus)
                .IsFixedLength();

            this.Property(e => e.Gender)
                .IsFixedLength();

            this.HasMany(e => e.EmployeeDepartmentHistories)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);            
        }
    }
}
