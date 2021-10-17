using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2_DPA_PrimerMVC.web.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string email,string password) 
        {

            if (email == "mezajose@hotmail.com" && password == "1254") 
            {
                return RedirectToAction("Index", "Home", new { area = "Marketing" });
            
             }

            return RedirectToAction("Index"); 

        }
    }
}
