using DoAnLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnLTW.Controllers
{
    public class AnMaSuVoDichController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: Read
        public ActionResult Chuong1()
        {
            var chuong1 = from ss in data.chuongs where (ss.ten_chuong == "Chương_1") where (ss.id_sach == "10") select ss;
            return View(chuong1);
        }

        public ActionResult Chuong2()
        {
            var chuong2 = from ss in data.chuongs where (ss.ten_chuong == "Chương_2") where (ss.id_sach == "10") select ss;
            return View(chuong2);
        }
        public ActionResult Chuong3()
        {
            var chuong3 = from ss in data.chuongs where (ss.ten_chuong == "Chương_3") where (ss.id_sach == "10") select ss;
            return View(chuong3);
        }
        public ActionResult Chuong4()
        {
            var chuong4 = from ss in data.chuongs where (ss.ten_chuong == "Chương_4") where (ss.id_sach == "10") select ss;
            return View(chuong4);
        }
        public ActionResult Chuong5()
        {
            var chuong5 = from ss in data.chuongs where (ss.ten_chuong == "Chương_5") where (ss.id_sach == "10") select ss;
            return View(chuong5);
        }

        public ActionResult Chuong6()
        {
            var chuong6 = from ss in data.chuongs where (ss.ten_chuong == "Chương_6") where (ss.id_sach == "10") select ss;
            return View(chuong6);
        }
        public ActionResult Chuong7()
        {
            var chuong7 = from ss in data.chuongs where (ss.ten_chuong == "Chương_7") where (ss.id_sach == "10") select ss;
            return View(chuong7);
        }
        public ActionResult Chuong8()
        {
            var chuong8 = from ss in data.chuongs where (ss.ten_chuong == "Chương_8") where (ss.id_sach == "10") select ss;
            return View(chuong8);
        }
        public ActionResult Chuong(string id, string tenchuong)
        {
            var chuong =  from ss in data.chuongs where (ss.ten_chuong == tenchuong) where (ss.id_sach == id) select ss;
            ViewBag.sach = (from ss in data.saches where (ss.id == id) select ss).First();
            return View(chuong);
        }
    }
}