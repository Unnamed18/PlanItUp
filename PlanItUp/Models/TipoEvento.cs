using System.ComponentModel.DataAnnotations;

namespace PlanItUp.Models.ViewModels
{
    public class TipoEvento
    {
        [Key]
        public int IdTipoEvento { get; set; }
        //Fin campo IdTipoEvento

        [Required(ErrorMessage = "El campo Tipo de evento es requerido")]
        [StringLength(50)]
        public string TipoEvento_Desc { get; set; } = null!;
        //Fin campo TipoEvento_Desc
    }
}
