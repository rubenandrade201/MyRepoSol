using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyRepoWebCore.Controllers
{
    public class KnockoutController : Controller
    {
        public static List<string> SampleData = new List<string>()
        {
            "Uno", "Dos","Tres"
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoopSample()
        {
            return View();
        }

        public IActionResult DataSample()
        {
            return View();
        }

        public IActionResult GetData()
        {
            return Json(SampleData);
        }
        
        [HttpPost]
        public IActionResult PostData(string value)
        {
            SampleData.Add(value);
            return Json(true);
        }
    }
}