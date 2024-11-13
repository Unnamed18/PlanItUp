using PlanItUp.Data.Implementations;
using PlanItUp.Models;

namespace PlanItUp.Services
{
    public class UsuarioService
    {
        private readonly AuthDAO _authDAO;

        public UsuarioService()
        {
            _authDAO = new AuthDAO();
        }


        public async Task<int?> SingUpService(Client client)
        {

            int? rowsAffected = await _authDAO.signUp(client);
            return rowsAffected;
        }

    }
}
