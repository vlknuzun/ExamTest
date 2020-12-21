using Newtonsoft.Json;
using SinavOlusturma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SinavOlusturma.Model.Entities
{
    public class Exam:CoreEntity
    {
        public Exam()
        {
            UserExamAnswers = new List<UserExamAnswer>();
            Questions = new List<Question>();
        }
        [Required]
        [MaxLength(500)]
        public string Headline { get; set; }
        [Required]
        [MaxLength(3000)]
        public string Content { get; set; } 
        public virtual List<UserExamAnswer> UserExamAnswers { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
