using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanItUp.Data;
using PlanItUp.Models;
using PlanItUp.Models.CustomRequest.AccountRequest;
using PlanItUp.Models.ViewModels;
using PlanItUp.Services;
using System.Data.Common;
using System.Security.Claims;

namespace PlanItUp.Controllers
{
    public class AccountController : BaseController
    {
        private readonly AccountService _usuarioService;

        public AccountController()
        {
            _usuarioService = new AccountService();
        }

        [AllowAnonymous]
        public IActionResult register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> register(CreateUserRequest usuario)
        {

            var rowsAffected = await _usuarioService.SingUpService(usuario);
            //return Ok("Succes"); 

            return View(usuario);
        }

        [AllowAnonymous]
        public IActionResult Login()
        {

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await Usuario.ChangePasswordAsync(User.Identity.Name, model.NewPassword);
        //        if (result.Succeeded)
        //        {
        //            ViewBag.Message = "Contraseña cambiada exitosamente!";
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Error al cambiar la contraseña");
        //        }
        //    }
        //    return View(model);
        //}
    }
}