using SinavOlusturma.Core.Map;
using SinavOlusturma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinavOlusturma.Model.Map
{
    public class SelectionMap:CoreMap<Selection>
    {
        public SelectionMap()
        {
            ToTable("dbo.Selection");
            Property(x => x.Content).IsRequired().HasMaxLength(50);

            //HasRequired(q => q.Question)
            //    .WithMany(w => w.Selections)
            //    .HasForeignKey(e => e.QuestionId)
            //    .WillCascadeOnDelete(false);
        }
    }
}
