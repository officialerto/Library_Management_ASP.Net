using Library_Management_ASP.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_Management_ASP.Net.Controllers
{
    public class ReturnBookController : Controller
    {
        nitlibraryEntities1 db = new nitlibraryEntities1();

        // GET: ReturnBook
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(returnbook returnb)
        {
            if (ModelState.IsValid)
            {
                db.returnbooks.Add(returnb);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(returnb);
        }

        [HttpPost]
        public ActionResult GetMid(int mid)
        {
            var memberid = (from s in db.issuebooks
                            where s.m_id == mid
                            select new
                            {
                                IssueDate = s.issuedate,
                                ReturnDate = s.returndate,
                                Memberid = s.m_id,
                                BookName = s.book_id,
                                ElapsedDays = SqlFunctions.DateDiff("day",
                                s.returndate, DateTime.Now)
                            }).ToArray();

            return Json(memberid, JsonRequestBehavior.AllowGet);
        }

    }
}