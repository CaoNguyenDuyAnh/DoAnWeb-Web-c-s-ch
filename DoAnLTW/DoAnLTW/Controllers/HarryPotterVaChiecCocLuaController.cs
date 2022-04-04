using DoAnLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLTW.Controllers
{
    public class HarryPotterVaChiecCocLuaController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: Read
        public ActionResult Chuong1()
        {
            var chuong1 = from ss in data.chuongs where (ss.ten_chuong == "Chương_1") where (ss.id_sach == "099") select ss;
            return View(chuong1);
        }
    }
}