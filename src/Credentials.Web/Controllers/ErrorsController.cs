using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Credentials.Web.Controllers
{
    public class ErrorsController : Controller
    {
        //
        // GET: /Errors/
        public ActionResult Index()
        {
            Response.StatusCode = 500;
            return View("Error");
        }

        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View("Error");
        }
    }
}