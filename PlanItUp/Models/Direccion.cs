using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlanItUp.Models.ViewModels
{
    public class Direccion
    {
        [Key]
        public int IdDireccion { get; set; }
        //Fin campo IdDireccion

        [Required(ErrorMessage = "La provincia es requerida")]
        [StringLength(30)]
        public string Provincia { get; set; } = null!;
        //Fin campo Provincia

        [Required(ErrorMessage = "El Partido es requerido")]
        [StringLength(30)]
        public string Partido { get; set; } = null!;
        //Fin campo Partido

        [Required(ErrorMessage = "La Localidad es requerida")]
        [StringLength(30)]
        public string Localidad { get; set; } = null!;
        //Fin campo Localidad

        [Required(ErrorMessage = "La Calle es requerida")]
        [StringLength(60)]
        public string Calle { get; set; } = null!;
        //Fin campo Calle

        public int Altura { get; set; }
        //Fin campo Altura

        public int Capacidad { get; set; }
        //Fin campo Capacidad

        [Required(ErrorMessage = "Es necesario especificar si el lugar admite mascotas")]
        public bool AdmiteMascotas { get; set; }
        //Fin campo AdmiteMascotas

        public int NumeroCelular { get; set; }
        //Fin campo NumeroCelular

        [Required(ErrorMessage = "El Email es requerido")]
        [StringLength(80)]
        public string Email { get; set; } = null!;
        //Fin campo Email

        [Required(ErrorMessage = "Es necesario especificar si el lugar es techado")]
        public bool AireLibre { get; set; }
        //Fin campo AireLibre

        [Required(ErrorMessage = "Es necesario especificar si el posee un sector fumador")]
        public bool SectorFumador { get; set; }
        //Fin campo SectorFumador

        [Required(ErrorMessage = "El Nombre del Lugar es requerido")]
        [StringLength(60)]
        public string NombreLugar { get; set; } = null!;
        //Fin campo NombreLugar
    }
}
