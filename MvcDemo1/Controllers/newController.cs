using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MvcDemo1.Controllers
{
    public class newController : Controller
    {
        // GET: new
        public ActionResult TempDataExample()
        {
            TempData["student"] = "sandhya";
            return RedirectToAction("TempDataExample2");
        }
        public ActionResult TempDataExample2()
        {
            string value = TempData["student"].ToString();
            TempData.Keep();
            return Content(value);
        }
        public ContentResult content1()
        {
            return Content("<h1 style= color:red >welcome</h1>");
        }
    }
}