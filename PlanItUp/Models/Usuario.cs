namespace PlanItUp.Models.ViewModels
{
    public class Usuario
    {
        public short IdUsuario { get; set; }
        public short IdRol { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; }
        public byte DNI { get; set; }
        public string Email { get; set; } = null!;
        public string ContrasenaHash { get; set; } = null!;
        public string Celular { get; set; } = null!;
        public DateTime FechaNac { get; set; }
        public string Genero { get; set; } = null!;
        public bool EstadoUsuario { get; set; }
        public bool? Token { get; set; }
    }
}
