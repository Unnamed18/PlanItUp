using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanItUp.Models.ViewModels
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        //Fin campo IdUsuario

        [ForeignKey("ID_ROL")]
        public int IdRol { get; set;}
        //Fin campo IdRol

        [Required(ErrorMessage = "Por favor especificar Genero")]
        [StringLength(15)]
        public string Genero { get; set; } = null!;
        //Fin campo Genero

        public int DNI { get; set; }
        //Fin campo DNI

        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        public DateTime FechaNac { get; set; }
        //Fin campo FechaNac

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;
        //Fin campo Nombre

        [Required(ErrorMessage = "El Apellido es requerido")]
        [StringLength(50)]
        public string Apellido { get; set; } = null!;
        //Fin campo Apellido

        [Required(ErrorMessage = "El Numero de celular es requerido")]
        public int NumeroCelular { get; set; }
        //Fin campo NumeroCelular

        [Required(ErrorMessage = "El Email es requerido")]
        [StringLength(80)]
        public string Email { get; set; } = null!;
        //Fin campo Email

        [Required(ErrorMessage = "La Contraseña es requerida")]
        [StringLength(15)]
        public string Contraseña { get; set; } = null!;
        //Fin campo Contraseña

        [Required(ErrorMessage = "Es necesario especificar si el usuario esta activo")]
        public bool Activo { get; set; }
        //Fin campo Activo

        [Required(ErrorMessage = "Es necesario especificar si el usuario esta Verificado utilizando el token")]
        public bool token {get; set;}
        //Fin campo token
    }
}
