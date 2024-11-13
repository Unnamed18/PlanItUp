namespace PlanItUp.Models.CustomRequest.AccountRequest
{
    public class CreateUserRequest
    {
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public byte DNI { get; set; }
        public string Email { get; set; } = null!;
        public string ContrasenaHash { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public DateTime? FechaNac { get; set; }


    }
}
