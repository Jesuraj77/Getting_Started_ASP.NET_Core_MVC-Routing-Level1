﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level1.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            //implement the code here
            return View();
        }
    }
}