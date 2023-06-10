using System;
using EcommerceApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApp.Controllers;

public class AdministrationController : Controller
{
    private readonly RoleManager<IdentityRole> roleManager;
    private readonly ILogger<AdministrationController> logger;

    public AdministrationController(RoleManager<IdentityRole> roleManager, ILogger<AdministrationController> logger)
    {
        this.roleManager = roleManager;
        this.logger = logger;
    }


    [HttpGet]
    public IActionResult CreateRole()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> CreateRole(CreateRolesViewModel model)
    {
        if(ModelState.IsValid)
        {
            IdentityRole identityRole = new IdentityRole
            {
                Name = model.RoleName
            };
            IdentityResult result = await roleManager.CreateAsync(identityRole);

            if(result.Succeeded)
            {
                return RedirectToAction("index", "goods");
            }

            foreach(IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
         }

         return View(model);
    }
}