﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyRepoWebCore.Controllers
{
    public class KnockoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}