using System.ComponentModel.DataAnnotations;

namespace PlanItUp.Models.ViewModels
{
    public class Rol
    {
        [Key]
        public int ID_ROL { get; set; }
        //Fin campo rol

        [Required(ErrorMessage = "El campo Rol es requerido")]
        [StringLength(50)]
        public string Descripcion_Rol { get; set; } = null!;
        //Fin campo Descripcion_Rol
    }
}
