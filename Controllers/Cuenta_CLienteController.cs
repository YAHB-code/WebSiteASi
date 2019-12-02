using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebSiteASi.Controllers
{
    public class Cuenta_CLienteController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}