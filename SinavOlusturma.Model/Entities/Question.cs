using SinavOlusturma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SinavOlusturma.Model.Entities
{
    public class Question : CoreEntity

    {   [Required]
        [MaxLength (500,ErrorMessage ="500'den Fazla Karakter Girilemez")]
        public string Content { get; set; }
        public int Point { get; set; } 
        public int ExamId { get; set; }

        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }
        public virtual List<Selection> Selections { get; set; }
        public virtual List<UserExamAnswer> UserExamAnswers { get; set; }

       
    }
}
