﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace React_Template.Controllers
{
    public class HelloWorldController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
    }
}