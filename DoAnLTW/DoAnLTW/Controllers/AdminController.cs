using DoAnLTW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult TacGia() //-------------- Làm PageList--------//
        {
            var all_tg = (from ss in data.tac_gias select ss);
            //ViewBag.sach= (from truyen_de_cu in data.chuongs group(truyen_de_cu.id_sach) select sum())
            return View(all_tg);
        }
        public ActionResult TheLoai() //-------------- Làm PageList--------//
        {
            var all_the_loai = from ss in data.the_loais select ss;
            //ViewBag.sach= (from truyen_de_cu in data.chuongs group(truyen_de_cu.id_sach) select sum())
            return View(all_the_loai);
        }

        public ActionResult Truyen() //-------------- Làm PageList--------//
        {
            var all_sach = from ss in data.saches select ss;
            //ViewBag.sach= (from truyen_de_cu in data.chuongs group(truyen_de_cu.id_sach) select sum())
            return View(all_sach);
        }

        public ActionResult ThanhVien() //-------------- Làm PageList--------//
        {
            var all_sach = from ss in data.users where ss.type_acc == true select ss;
            //ViewBag.sach= (from truyen_de_cu in data.chuongs group(truyen_de_cu.id_sach) select sum())
            return View(all_sach);
        }
    }
}