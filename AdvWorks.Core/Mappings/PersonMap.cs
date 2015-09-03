using System.Data.Entity.ModelConfiguration;

namespace AdvWorks.Core.Mappings
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            this
                .Property(e => e.PersonType)
                .IsFixedLength();

            this
                .HasOptional(e => e.Employee)
                .WithRequired(e => e.Person);

            this
                .HasMany(e => e.BusinessEntityContacts)
                .WithRequired(e => e.Person)
                .HasForeignKey(e => e.PersonID)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.EmailAddresses)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            this
                .HasOptional(e => e.Password)
                .WithRequired(e => e.Person);

            //this
            //    .HasMany(e => e.Customers)
            //    .WithOptional(e => e.Person)
            //    .HasForeignKey(e => e.PersonID);

            this
                .HasMany(e => e.PersonCreditCards)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.PersonPhones)
                .WithRequired(e => e.Person)
                .WillCascadeOnDelete(false);
        }
    }
}
