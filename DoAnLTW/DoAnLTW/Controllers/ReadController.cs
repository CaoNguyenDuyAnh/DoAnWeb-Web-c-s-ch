using DoAnLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLTW.Controllers
{
    public class ReadController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: Read
        public ActionResult Chuong1()
        {
            var chuong1 = from ss in data.Saches where ss.chuong == 1 select ss;
            return View(chuong1);
        }

        public ActionResult Chuong2()
        {
            var chuong2 = from ss in data.Saches where ss.chuong == 2 select ss;
            return View(chuong2);
        }
    }
}