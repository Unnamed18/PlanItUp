namespace PlanItUp.Data.Implementations

{
    using Dapper;
    using PlanItUp.Models.ViewModels;
    using System.Data.SqlClient;

    public class AuthDAO
    {
        private string _connectionString = @"data source=DESKTOP-KCGGJDV\\SQLEXPRESS;initial Catalog=PlanItUp; Integrated Security=True;";
        private string _insertUser = @"INSERT INTO [Usuario] (id_rol,Nombre, Apellido, DNI,Email, Contrasena_Hash,Celular,FechaNac,Genero,EstadoUsuario)
                                         VALUES (@Roleid, @Name, @LastName,@Dni, @Password, @PhoneNumber, @FechaNac, @Genero, @EstadoUsuario)";

        private SqlConnection _dbConnection;
        public AuthDAO()
        {
            _dbConnection = new SqlConnection(_connectionString);
        }

        public async Task<int?> signUp(Usuario user)
        {
            using (_dbConnection)
            {
                var parameters = new
                {
                    Roleid = user.IdRol,
                    Name = user.Nombre,
                    LastName = user.Apellido,
                    Dni = user.DNI,
                    Email = user.Email,
                    Password = user.ContrasenaHash,
                    PhoneNumber = user.Celular,
                    FechaNac = user.FechaNac,
                    Genero = user.Genero,
                    EstadoUsuario = 1,
                };
                var rowsAffected = await _dbConnection.ExecuteAsync(_insertUser, parameters);
                return rowsAffected;
            }

        }
    }

}
