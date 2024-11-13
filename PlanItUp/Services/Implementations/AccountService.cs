using PlanItUp.Data.Implementations;
using PlanItUp.Models.CustomRequest.AccountRequest;

namespace PlanItUp.Services
{
    public class AccountService
    {
        private readonly AccountDAO _accountDAO;

        public AccountService()
        {
            _accountDAO = new AccountDAO();
        }


        public async Task<int?> SingUpService(CreateUserRequest user)
        {

            int? rowsAffected = await _accountDAO.signUp(user);
            return rowsAffected;
        }

    }
}
