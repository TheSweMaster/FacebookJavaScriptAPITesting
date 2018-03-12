using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FacebookAPITesting.Controllers
{
    public class FacebookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}