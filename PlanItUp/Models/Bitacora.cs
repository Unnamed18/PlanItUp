using System.ComponentModel.DataAnnotations;

namespace PlanItUp.Models.ViewModels
{
    public class Bitacora
    {
        [Required(ErrorMessage = "Por favor especificar Procedure")]
        [StringLength(60)]
        public string Nombre_Procedure { get; set; } = null!;
        //Fin campo Nombre_Procedure

        [Required(ErrorMessage = "La fecha de realizacion es requerida")]
        public DateTime Fecha_realizacion { get; set; }
        //Fin campo Fecha_realizacion

        public int IdUsuario { get; set; }
        //Fin campo IdUsuario

        [Required(ErrorMessage = "Por favor especificar Movimiento")]
        [StringLength(60)]
        public string Movimiento { get; set; } = null!;
        //Fin campo Movimiento
    }
}
