using PlanItUp.Data.Implementations;
using PlanItUp.Models.ViewModels;

namespace PlanItUp.Services
{
    public class UsuarioService
    {
        private readonly AuthDAO _authDAO;

        public UsuarioService()
        {
            _authDAO = new AuthDAO();
        }


        public async Task<int?> SingUpService(Usuario user)
        {

            int? rowsAffected = await _authDAO.signUp(user);
            return rowsAffected;
        }

    }
}
