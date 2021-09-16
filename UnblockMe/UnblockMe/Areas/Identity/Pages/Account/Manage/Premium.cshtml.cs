using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UnblockMe.Models;

namespace UnblockMe.Areas.Identity.Pages.Account.Manage
{
    public class PremiumModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly ILogger<PremiumModel> _logger;

        public PremiumModel(
            UserManager<User> userManager,
            ILogger<PremiumModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if(await _userManager.IsInRoleAsync(user, "Premium"))
            {
                return RedirectToPage("./AlreadyPremium"); 
            }

            return Page();
        }
    }
}
