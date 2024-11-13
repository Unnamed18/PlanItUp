using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanItUp.Data;
using PlanItUp.Models;
using PlanItUp.Models.ViewModels;
using System.Data.Common;
using System.Security.Claims;

namespace PlanItUp.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(AppDbContext context)
            : base(context) { }

        [AllowAnonymous]
        public IActionResult register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> register(Usuario usuario)
        {
            try
            {
                if (usuario != null)
                {
                    if (await _Context.Usuarios.AnyAsync(u => u.Email == usuario.Email))
                    {
                        ModelState.AddModelError(nameof(usuario.Email), "El mail ingresado ya esta en uso");
                        return View(usuario);
                    }

                    var RolUsu = await _Context.Roles.FirstOrDefaultAsync(r => r.Descripcion_Rol == "Consumidor");

                    if (RolUsu != null)
                    {
                        usuario.IdRol = RolUsu.ID_ROL;
                    }

                    _Context.Usuarios.Add(usuario);
                    await _Context.SaveChangesAsync();

                    //Validar Mail

                    var Identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                    Identity.AddClaim(new Claim(ClaimTypes.Name, usuario.Nombre));
                    Identity.AddClaim(new Claim(ClaimTypes.Role, "Consumidor"));

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(Identity)
                    );

                    return RedirectToAction("Index", "Home");
                }

                return View(usuario);
            }
            catch (DbException DbException)
            {
                return HandleDbError(DbException);
            }
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Administrador") || User.IsInRole("Prestador"))
                    return RedirectToAction("Index", "Dashboard");

                else
                    return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(string Email, string password)
        {
            try
            {
                var User = await _Context.Usuarios.FirstOrDefaultAsync(u => u.Email == Email && u.Contraseña == password);
                if (User != null)
                {
                    var Identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                    Identity.AddClaim(new Claim(ClaimTypes.Name, Email));
                    Identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, User.IdUsuario.ToString()));

                    var Rol = await _Context.Roles.FirstOrDefaultAsync(r => r.ID_ROL == User.IdRol);
                    if (Rol != null)
                    {
                        Identity.AddClaim(new Claim(ClaimTypes.Role, Rol.Descripcion_Rol));
                    }

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(Identity)
                    );

                    //if (User.IsInRole("Administrador") || User.IsInRole ("Supervisor"))
                    //    return RedirectToAction("Index", "Dashboard");

                    //else
                    //    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Datos incorrectos.");
                return View();
            }
            catch (DbException DbException)
            {
                return HandleDbError(DbException);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
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