using SinavOlusturma.Core.Map;
using SinavOlusturma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinavOlusturma.Model.Map
{
    public class UserMap : CoreMap<User>
    {
        public UserMap()
        {
            ToTable("dbo.Users");
            Property(x => x.Name).HasMaxLength(25).IsOptional();
            Property(x => x.SurName).HasMaxLength(25).IsOptional();
            Property(x => x.UserName).HasMaxLength(25).IsRequired();
            HasIndex(x => x.UserName).IsUnique();
            Property(x => x.Password).HasMaxLength(10).IsRequired();
            Property(x => x.Role).IsRequired();
        }
    }
}
