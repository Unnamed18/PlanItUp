using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PlanItUp.Data;
using PlanItUp.Models.ViewModels;
using System.Data.Common;
using System.Diagnostics;

namespace PlanItUp.Models
{
    public class BaseController : Controller
    {
        public readonly AppDbContext _Context;

        public BaseController(AppDbContext context)
        {

            _Context = context;
        }

        //public override ViewResult View(string? viewName, object? model)
        //{
        //    ViewBag.CantidadReservas = GetCarritoCount();
        //    return base.View(viewName, model);
        //}

        //protected int GetCarritoCount()
        //{
        //    int count = 0;

        //    string? CarritoJson = Request.Cookies["Carrito"];

        //    if (!string.IsNullOrEmpty(CarritoJson))
        //    {
        //        var Carrito = JsonConvert.DeserializeObject<List<ReservaIdAndCantidad>>(CarritoJson);

        //        if (Carrito != null)
        //        {
        //            count = Carrito.Count;
        //        }
        //    }

        //    return count;
        //}

        protected IActionResult HandleError(Exception e)
        {
            return View("Error", new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
            }
    );
        }

        protected IActionResult HandleDbError(DbException dbException)
        {
            var viewModel = new DbErrorViewModel
            {
                ErrorMessage = "Error de Base de Datos",
                ErrorDetail = dbException.Message
            };

            return View("DbError", viewModel);
        }

        protected IActionResult HandleDbUpdateError(DbUpdateException dbUpdateException)
        {
            var viewModel = new DbErrorViewModel
            {
                ErrorMessage = "Error de actualización de Base de Datos",
                ErrorDetail = dbUpdateException.Message
            };

            return View("DbError", viewModel);
        }
    }

}