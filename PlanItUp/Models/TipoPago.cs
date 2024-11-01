using System.ComponentModel.DataAnnotations;

namespace PlanItUp.Models.ViewModels
{
    public class TipoPago
    {
        [Key]
        public int IdTipoPago { get; set; }
        //Fin campo IdTipoPago_id

        [Required(ErrorMessage = "El campo Tipo de Pago es requerido")]
        [StringLength(50)]
        public string TipoPago_Desc { get; set; } = null!;
        //Fin campo TipoPago_Desc
    }
}
