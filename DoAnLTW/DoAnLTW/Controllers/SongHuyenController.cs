using DoAnLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLTW.Controllers
{
    public class SongHuyenController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: Read
        public ActionResult Chuong1()
        {
            var chuong1 = from ss in data.chuongs where (ss.ten_chuong == "Chương_1") where (ss.id_sach == "7") select ss;
            return View(chuong1);
        }

        public ActionResult Chuong2()
        {
            var chuong2 = from ss in data.chuongs where (ss.ten_chuong == "Chương_2") where (ss.id_sach == "7") select ss;
            return View(chuong2);
        }
    }
}