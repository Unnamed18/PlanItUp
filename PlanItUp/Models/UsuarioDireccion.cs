using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlanItUp.Models.ViewModels
{
    public class UsuarioDireccion
    {
        [Key]
        public int IdUsuarioDireccion { get; set; }
        //Fin campo IdUsuarioDireccion

        public int order_id { get; set; }
        //Fin campo order_id

        [ForeignKey("IdUsuario")]
        public int IdUsuario { get; set; }
        //Fin campo IdUsuario

        [ForeignKey("IdDireccion")]
        public int IdDireccion { get; set; }
        //Fin campo IdDireccion
        

    }
}
