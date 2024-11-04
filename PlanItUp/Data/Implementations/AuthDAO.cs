namespace PlanItUp.Data.Implementations

{
    using Dapper;
    using PlanItUp.Models;
    using System.Data.SqlClient;

    public class AuthDAO
    {
        private string _connectionString = @"data source=DESKTOP-KCGGJDV\\SQLEXPRESS;initial Catalog=PlanItUp; Integrated Security=True;";
        private string _insertUser = @"INSERT INTO [client] (name, lastname, email,password_hash, role_id,phone_number)
                                         VALUES (@Name, @LastName, @Email,@Password, @Roleid, @PhoneNumber)";

        private SqlConnection _dbConnection;
        public AuthDAO()
        {
            _dbConnection = new SqlConnection(_connectionString);
        }

        public async Task<int?> signUp(Client client)
        {
            using (_dbConnection)
            {
                var parameters = new
                {
                    Name = client.name.ToLower(),
                    LastName = client.lastname.ToLower(),
                    Email = client.email,
                    Password = client.password_hash,
                    Roleid = client.role_id,
                    PhoneNumber = client.phone_number
                };
                var rowsAffected = await _dbConnection.ExecuteAsync(_insertUser, parameters);
                return rowsAffected;
            }

        }
    }

}
