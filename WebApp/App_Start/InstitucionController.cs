using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.App_Start
{
    public class InstitucionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Crear()
        {
            return View();
        }
    }
}
