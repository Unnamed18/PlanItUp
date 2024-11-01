using System.ComponentModel.DataAnnotations;

namespace PlanItUp.Models.ViewModels
{
    public class log_Error
    {
        [Required(ErrorMessage = "El Mensaje es requerido")]
        [StringLength(60)]
        public string Mensaje { get; set; } = null!;
        //Fin campo Mensaje

        [Required(ErrorMessage = "El Codigo de error es requerido")]
        [StringLength(60)]
        public string Codigo { get; set; } = null!;
        //Fin campo Codigo

        [Required(ErrorMessage = "La fecha de error es requerida")]
        public DateTime Date_Error { get; set; }
        //Fin campo Date_Error

        [Required(ErrorMessage = "El Log_Error_Object_ es requerido")]
        [StringLength(60)]
        public string Log_Error_Object_ { get; set; } = null!;
        //Fin campo Log_Error_Object_

    }
}
