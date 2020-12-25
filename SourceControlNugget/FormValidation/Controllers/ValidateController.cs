using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormValidation.Models;

namespace FormValidation.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Validate vc)
        {
            return View();
        }

    }
}