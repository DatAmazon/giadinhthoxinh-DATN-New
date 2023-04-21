using giadinhthoxinh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace giadinhthoxinh.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Cart()
        {
            Cart giohang = (Cart)Session["giohang"];
            var listitem = giohang.lstproduct;
            ViewBag.list = listitem;
            return View();
        }
        /*
         * Thanh toán 
         * giohang.lstproduct.Clear();
         */
        public ActionResult Checkout()
        {
            return View();
        }
    }
}