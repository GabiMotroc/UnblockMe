using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;
using UnblockMe.Services;
using UnblockMe.ViewModels;

namespace UnblockMe.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly INotyfService _notyfService;
        private readonly IUserService _userService;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdministrationController(UserManager<User> userManager, IUserService userService,
            INotyfService notyfService, RoleManager<IdentityRole> roleManager)
        {
            _notyfService = notyfService;
            _userService = userService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    _notyfService.Success("Role succesufylly added.");
                    return RedirectToAction("listRoles", "administration");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }


            return View(model);
        }

        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id ={id} cannot be found";
                return View("NotFound");
            }

            EditRoleViewModel model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach (var user in _userManager.Users.ToList())
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {

            var role = await _roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id ={model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;
                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    _notyfService.Success("Role succcesufully updated");
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id {roleId} cannot be found.";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in _userManager.Users.ToList())
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    Id = user.Id,
                    UserName = user.UserName
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id {roleId} cannot be found.";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].Id);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && (await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                    {
                        _notyfService.Success("List updated succesufully");
                        return RedirectToAction("EditRole", new { Id = roleId });
                    }

                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id {roleId} cannot be found.";
                return View("NotFound");
            }

            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                _notyfService.Success("Role successufully removed.");
            }
            else
            {
                _notyfService.Warning("Failed operation.");
            }

            return RedirectToAction("ListRoles");
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = _userManager.Users.ToList();
            var model = new List<ListUserViewModel>();
            foreach (var user in users)
            {
                var aux = new ListUserViewModel
                {
                    Id = user.Id,
                    Name = user.UserName
                };
                model.Add(aux);
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> BlockUserAsync(string Id)
        {
            var model = new BlockUserViewModel();

            var user = await _userManager.FindByIdAsync(Id);
            model.UserId = Id;
            model.Username = user.UserName;
            model.Email = user.Email;

            var Bans = await _userService.GetAllBansOfUser(Id);

            foreach (var ban in Bans)
            {
                model.Bans.Add(ban);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BlockUser(BlockUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with id {model.UserId} cannot be found.";
                return View("NotFound");
            }

            var Ban = new BlockedUsers
            {
                // just fo test needs to be edited
                StartTime = DateTime.UtcNow,
                StopTime = DateTime.UtcNow.AddDays(1),
                Reason = "ca asa vreau",
                // end of test
            };

            var result = await _userService.BlockUserAsync(Ban);

            if (result != null)
            {
                ViewBag.ErrorMessage = result;
                return View("NotFound");
            }

            _notyfService.Success("User succesufully blocked");

            return View(model);
        }

        [HttpGet]
        public IActionResult AdminPanel()
        {
            return View();
        }
    }
}
