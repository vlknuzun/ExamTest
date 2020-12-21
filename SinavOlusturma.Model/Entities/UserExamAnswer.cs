using SinavOlusturma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SinavOlusturma.Model.Entities
{
   public class UserExamAnswer:CoreEntity
    {
       
        public int UserId { get; set; } 
        public int ExamId { get; set; } 
        public int SelectionId { get; set; }
        public int QuestionId { get; set; }



        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }

        [ForeignKey("SelectionId")]
        public Selection Selection { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }


    }
}
