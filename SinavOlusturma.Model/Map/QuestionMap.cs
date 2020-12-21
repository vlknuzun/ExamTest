using SinavOlusturma.Core.Map;
using SinavOlusturma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SinavOlusturma.Model.Map
{
    public class QuestionMap:CoreMap<Question>
    {
        public QuestionMap()
        {
            ToTable("dbo.Question");
            Property(x => x.Content).IsRequired().HasMaxLength(3000);
            Property(x => x.Point).IsOptional();


            //HasRequired(o => o.Exam)
            //    .WithMany(p => p.Questions)
            //    .HasForeignKey(q => q.ExamId)   
            //    .WillCascadeOnDelete(false);
        }
    }
}
