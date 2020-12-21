using Microsoft.AspNetCore.Mvc.Rendering;
using SinavOlusturma.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.WebUI.Models
{
    public class ViewModel
    {
        public List<Exam> Exam { get; set; }
        public List<Question> Question { get; set; }
        public List<Selection> Selection { get; set; }
        public UserExamAnswer UserExamAnswer { get; set; }
    }
}
