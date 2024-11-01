using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanItUp.Models.ViewModels
{
    public class Evento
    {
        [Key]
        public int IdEvento { get; set; }
        //Fin campo IdEvento

        [ForeignKey("IdTipoEvento")]
        public int IdTipoEvento { get; set; }
        //Fin campo IdTipoEvento

        [Required(ErrorMessage = "El nombre del evento es requerido")]
        [StringLength(30)]
        public string NombreEvento { get; set; } = null!;
        //Fin campo NombreEvento

        [ForeignKey("IdDireccion")]
        public int IdDireccion { get; set; }
        //Fin campo IdDireccion

        [ForeignKey("IdUsuario")]
        public int IdOrganizador { get; set; }
        //Fin campo IdOrganizador

        [Required(ErrorMessage = "Es necesario confirmacion")]
        public bool Confirmada { get; set; }
        //Fin campo Confirmada
    }
}
