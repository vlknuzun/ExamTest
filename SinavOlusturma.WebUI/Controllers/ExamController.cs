using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SinavOlusturma.Core.Entity.Enum;
using SinavOlusturma.Core.Service;
using SinavOlusturma.Model.Context;
using SinavOlusturma.Model.Entities;

using SinavOlusturma.Service.Option;
using SinavOlusturma.WebUI.Models;

namespace SinavOlusturma.WebUI.Controllers
{
    public class ExamController : Controller
    {
        //ProjectContext _db;
        ExamService _examService;
        QuestionService _qestionService;
        SelectionService _selectionService;
        UserExamAnswerService _answerService;
        public ExamController(ICoreService<Exam> examService)
        {
            _examService = (ExamService)examService;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userName, string password)
        {
            //var user = _db.Users.FirstOrDefault(x => x.UserName == userName);

            //if (user.Status == Status.Active && user.Role == Role.Teacher && user.Password == password)
            //{
            //    return RedirectToAction("CreatExam");
            //}
            //else if (user.Status == Status.Active && user.Role == Role.Strudent && user.Password == password)
            //{
            //    return RedirectToAction("SolveExam");
            //}
            //else
            //{
            //    return RedirectToAction("Index");
            //}
            return RedirectToAction("CreatExam");
        }

        [HttpGet]
        public IActionResult CreatExam()
        {
            var headlines = new List<SelectListItem>();
            var doc1 = new HtmlWeb().Load("https://www.wired.com/most-popular/");

            for (int i = 1; i < 6; i++)
            {
                var title = doc1.DocumentNode.SelectSingleNode($"/html/body/div[3]/div/div[3]/div/div/div/ul/li[{i}]/div/a/h2");
                headlines.Add(new SelectListItem
                {
                    Text = title.InnerText,
                    Value = i.ToString()
                });
            }

            ViewBag.Headlines = headlines;

            return View(new ViewModel());
        }
        [HttpPost]
        public IActionResult CreatExam(Exam exam, Question question, Selection selection)
        {
            
            return View("GetExam");

        }

        public ActionResult GetExam()
        {
            return View();
        }
        public IActionResult SolveExam()
        {
            return View();
        }

      

        [HttpGet]
        public IActionResult GetContentById(int id)
        {
            var doc = new HtmlWeb().Load("https://www.wired.com/gallery/best-face-masks/#intcid=_wired-most-popular-right-rail_b0f0c4eb-a399-4a08-af92-b12e2fd94cf6_popular4-1");
            var description = doc.DocumentNode.SelectSingleNode($"/html/body/div[1]/div/main/article/div[2]/div[1]/div[1]/div[1]/div/div[1]/div/p[{id}]");
            return Json(description.InnerText);
        }
    }
}




