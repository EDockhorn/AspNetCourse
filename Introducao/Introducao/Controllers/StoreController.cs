﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class StoreController : Controller
    {

        // GET: Store
        public ActionResult Loja()
        {
            return View();
        }
    }
}