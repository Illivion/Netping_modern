﻿using System.Web.Mvc;

namespace NetPing_modern.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult NotFound()
        {
            Response.StatusCode = 404;
            return View("NotFound");
        }

        public ViewResult Error()
        {
            return View("Error");
        }
    }
}