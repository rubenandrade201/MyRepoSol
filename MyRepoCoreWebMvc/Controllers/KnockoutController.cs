using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyRepoCoreWebMvc.Controllers
{
    public class KnockoutController : Controller
    {
        public IActionResult HelloWorldComponent()
        {
            return PartialView("~/views/Shared/_HelloWorldPv.cshtml");
        }
    }
}