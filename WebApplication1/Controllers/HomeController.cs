using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult ContactUs()
        {
            Product p = new Product();
            var data=p.GetProductData();
            p.ProductId =Convert.ToInt32( data.Tables[0].Rows[0][0].ToString());
            p.ProductName = Convert.ToString(data.Tables[0].Rows[0][1].ToString());
            p.ProductType = Convert.ToString(data.Tables[0].Rows[0][2].ToString());
            
            //ViewBag.Message = "WELCOME TO THIS PAGE";
            return View(p);
        }
    }
}