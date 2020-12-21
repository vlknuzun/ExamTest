using SinavOlusturma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SinavOlusturma.Model.Entities
{
    public class Selection:CoreEntity
    {
        public Selection()
        {
            UserExamAnswers = new List<UserExamAnswer>();
        }

        [Required]
        [MaxLength(50,ErrorMessage ="50'den Fazla Karakter Girilemez")]
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        public virtual List<UserExamAnswer> UserExamAnswers { get; set; }
    }
}
