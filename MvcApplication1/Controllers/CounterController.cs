using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using System.Data;

namespace MvcApplication1.Controllers
{
    public class CounterController : Controller
    {
        //
        // GET: /Counter/

        public ActionResult Index()
        {
            Model1 mod = new Model1();
            DataTable dt = mod.getVal();
            ViewBag.Val = dt.Rows[0][1].ToString();
            return View();
        }

        public ActionResult Increment()
        {
            Model1 mod = new Model1();
            DataTable dt = mod.getVal();
            
            string val = "";
            if (Convert.ToInt32(dt.Rows[0][1]) == 10)
            {
                val = "Limit Reached!";
            }
            else
            {
                DataTable dt2 = mod.updateVal();
                val = dt2.Rows[0][0].ToString();
            }
            return Content(val);
        }

    }
}
