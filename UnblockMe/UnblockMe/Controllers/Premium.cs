﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Controllers
{
    [Authorize(Roles = "Admin, Premium")]
    public class Premium : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
