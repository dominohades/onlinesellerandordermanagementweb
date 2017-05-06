using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Services.Models.Entities;
using BackEnd.Services.Methods;
namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        ProductServices prodService = new ProductServices();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }

        public ActionResult add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add(ProductInfo prodinfo)
        {
            prodService.Add(prodinfo);
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult wheretobuy()
        {
            return View();
        }
        public ActionResult faqs()
        {
            return View();
        }




    }
}