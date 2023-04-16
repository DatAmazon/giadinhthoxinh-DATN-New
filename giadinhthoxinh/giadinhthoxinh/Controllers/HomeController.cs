using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using giadinhthoxinh.Models;
using PagedList;

namespace giadinhthoxinh.Controllers
{
    public class HomeController : Controller
    {
        public giadinhthoxinhEntities db = new giadinhthoxinhEntities();
        public ActionResult Index(int? page)
        {
            int productInPage = 10;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            giadinhthoxinhEntities db = new giadinhthoxinhEntities();
            List<tblProduct> ketQua = db.tblProducts.ToList();
            IPagedList<tblProduct> ketQuaFinal = null;
            ketQuaFinal = ketQua.ToPagedList(pageNumber, productInPage);
           // var ketQua = db.tblProducts.ToList();
           //  PagedList<tblProduct> ketQuaFinal = new PagedList<tblProduct>(ketQua, pageNumber, productInPage);
            return View(ketQuaFinal);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductDetail(int id)
        {
            var item = db.tblProducts.Find(id);

            return View(item);
        }
        public ActionResult Checkout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Promote()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}