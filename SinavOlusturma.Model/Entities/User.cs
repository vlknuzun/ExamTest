using SinavOlusturma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SinavOlusturma.Model.Entities
{
    public enum Role
    {
        Teacher=1,
        Strudent=2
    }
    public class User:CoreEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public Role Role { get; set; }
        public List<UserExamAnswer> UserExamAnswers { get; set; }
    }
}
