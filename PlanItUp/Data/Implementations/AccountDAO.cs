﻿namespace PlanItUp.Data.Implementations

{
    using Dapper;
    using PlanItUp.Models.CustomRequest.AccountRequest;
    using System.Data.SqlClient;

    public class AccountDAO
    {
        private string _connectionString = @"data source=DESKTOP-KCGGJDV\\SQLEXPRESS;initial Catalog=PlanItUp; Integrated Security=True;";

        private string _insertUser = @"INSERT INTO [Usuario] (id_rol,Nombre, Apellido, DNI,Email, Contrasena_Hash,Celular,FechaNac,EstadoUsuario, Token)
                                         VALUES (@Roleid, @Name, @LastName,@Dni, @Password, @PhoneNumber, @FechaNac, @Genero, @EstadoUsuario)";

        private SqlConnection _dbConnection;
        public AccountDAO()
        {
            _dbConnection = new SqlConnection(_connectionString);
        }

        public async Task<int?> signUp(CreateUserRequest user)
        {
            using (_dbConnection)
            {
                var parameters = new
                {
                    Roleid = 1,
                    Name = user.Nombre,
                    LastName = user.Apellido,
                    Dni = user.DNI,
                    Email = user.Email,
                    Password = user.ContrasenaHash,
                    PhoneNumber = user.Celular,
                    FechaNac = user.FechaNac,
                    EstadoUsuario = 1,
                };
                var rowsAffected = await _dbConnection.ExecuteAsync(_insertUser, parameters);
                return rowsAffected;
            }

        }
    }

}