using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvWorks.Core.Mappings
{
    public class BusinessEntityMap : EntityTypeConfiguration<BusinessEntity>
    {
        public BusinessEntityMap ()
	{
            this
                .HasMany(e => e.BusinessEntityAddresses)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            this
                .HasMany(e => e.BusinessEntityContacts)
                .WithRequired(e => e.BusinessEntity)
                .WillCascadeOnDelete(false);

            this
                .HasOptional(e => e.Person)
                .WithRequired(e => e.BusinessEntity);

            //this
            //    .HasOptional(e => e.Store)
            //    .WithRequired(e => e.BusinessEntity);

            //this
            //    .HasOptional(e => e.Vendor)
            //    .WithRequired(e => e.BusinessEntity);
	}
    }
}
