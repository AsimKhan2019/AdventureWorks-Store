using AdvWorks.Core.Mappings;
using System.Data.Entity;

namespace AdvWorks.Core.HumanResourceBC
{
    /// <summary>
    /// Human Resource Bounded Context with private setter for Shifts, Departments, People
    /// </summary>
    public class HumanResourceBoundedContext : BaseContext<HumanResourceBoundedContext>
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }        
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   
            //Mapping using Entity Type Configurations -- Clean Code
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new DepartmentMap());
            modelBuilder.Configurations.Add(new ShiftMap());
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new BusinessEntityMap());

            modelBuilder.Ignore<Store>();
            modelBuilder.Ignore<SalesPerson>();            
            modelBuilder.Ignore<PurchaseOrderHeader>();
            modelBuilder.Ignore<Vendor>();
            modelBuilder.Ignore<Customer>();
        }
    }
}