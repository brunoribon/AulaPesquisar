﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaPesquisar.Controllers
{
    public class login : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
