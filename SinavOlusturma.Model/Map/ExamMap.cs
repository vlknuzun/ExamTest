using SinavOlusturma.Core.Map;
using SinavOlusturma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinavOlusturma.Model.Map
{
    public class ExamMap:CoreMap<Exam>
    {
        public ExamMap()
        {
            ToTable("dbo.Exams");
            Property(x => x.Headline).HasMaxLength(300).IsRequired();
            Property(x => x.Content).HasMaxLength(3000).IsRequired();

        }
    }
}
