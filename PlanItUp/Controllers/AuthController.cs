using Microsoft.AspNetCore.Mvc;
using PlanItUp.Models.CustomRequest.AccountRequest;
using PlanItUp.Services;

namespace PlanItUp.Controllers
{
    public class AuthController : Controller
    {
        private readonly AccountService _usuarioService;

        public AuthController()
        {//
            _usuarioService = new AccountService();
        }
        [HttpPost("signup")]

        public async Task<IActionResult> SignUp([FromBody] CreateUserRequest createClientRequest)
        {

            var rowsAffected = await _usuarioService.SingUpService(createClientRequest);
            return Ok("Succes");

        }

    }
}
