﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DustinCrawford.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Missing()
        {
            Response.StatusCode = 404;
            return View();
        }

        public ActionResult Error()
        {
            Response.StatusCode = 500;
            return View();
        }
    }
}