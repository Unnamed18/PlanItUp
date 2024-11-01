using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanItUp.Models.ViewModels
{
    public class Pago
    {
        [Key]
        public int Id_Pago { get; set; }
        //Fin campo Id_Pago


        [ForeignKey("IdTipoPago")]
        public int IdTipoPago { get; set; }
        //Fin campo IdTipoPago


        public int Monto { get; set; }
        //Fin campo Monto

        [ForeignKey("IdUsuario")]
        public int IdCliente { get; set; }
        //Fin campo IdCliente

        [ForeignKey("IdUsuario")]
        public int IdConsumidor { get; set; }
        //Fin campo IdConsumidor

    }
}
