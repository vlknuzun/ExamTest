using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace SinavOlusturma.Core.Map
{
    public class CoreMap<T>:EntityTypeConfiguration<T> where T:CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Status).HasColumnName("Status").IsRequired();
        }
    }
}
