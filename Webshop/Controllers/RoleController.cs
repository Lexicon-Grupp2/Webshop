﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Models;
using Webshop.Viewmodels;

namespace Webshop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        //Task needs to be Async
        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                    return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult AddRoleToUser()
        {
            AddRoleToUsersViewModel model = new AddRoleToUsersViewModel();
            model.Roles = new SelectList(_roleManager.Roles, "Name", "Name");
            model.Users = new SelectList(_userManager.Users, "Id", "UserName");

            return View(model);
        }

        public IActionResult AddRoleToSpecificUser(ApplicationUser roleUser)
        {
            AddRoleToUserViewModel model = new AddRoleToUserViewModel();
            model.Roles = new SelectList(_roleManager.Roles, "Name", "Name");
            model.User = roleUser;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddRoleToUser(string role, string user)
        {
            var tempUser = await _userManager.FindByIdAsync(user);

            IdentityResult result = await _userManager.AddToRoleAsync(tempUser, role);
            if (result.Succeeded)
                return RedirectToAction("Index");

            //if reached-> error -> create error message to viewmodel
            AddRoleToUsersViewModel model = new AddRoleToUsersViewModel();
            model.Roles = new SelectList(_roleManager.Roles, "Name", "Name");
            model.Users = new SelectList(_userManager.Users, "Id", "UserName");
            if (result.Errors.Any())
            {
                foreach (var item in result.Errors)
                {
                    //Todo-> change to array 
                    model.Message += item.Description;
                }
            }
            return View(model);
        }
    }
}