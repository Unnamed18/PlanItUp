using Microsoft.AspNetCore.Mvc;
using PlanItUp.Models;
using PlanItUp.Services;

namespace PlanItUp.Controllers
{
    public class AuthController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public AuthController()
        {
            _usuarioService = new UsuarioService();
        }
        [HttpPost("signup")]

        public async Task<IActionResult> SignUp([FromBody] Client createClientRequest)
        {

            var rowsAffected = await _usuarioService.SingUpService(createClientRequest);
            return Ok("Succes");

        }

    }
}
