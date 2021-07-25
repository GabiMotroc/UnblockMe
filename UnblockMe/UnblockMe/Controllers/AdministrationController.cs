using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Services;

namespace UnblockMe.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly ICarService _carService;
        private readonly IUserService _userService;
        private readonly ILogger<AdministrationController> _logger;
        private readonly INotyfService _notyfService;

        public AdministrationController(ICarService carService, IUserService userService, ILogger<AdministrationController> logger, INotyfService notyfService)
        {
            _carService = carService;
            _userService = userService;
            _logger = logger;
            _notyfService = notyfService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
