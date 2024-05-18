/*using System.ComponentModel.DataAnnotations;

namespace Trabajos.Data
{
    public class Alumno
    {
        [Required(ErrorMessage = "El nombre no es valido")]
        [StringLength(20, ErrorMessage = "Exedente de caracteres")]
        public string? name { get; set; }

        [Required(ErrorMessage = "El correo no es valido")]
        [EmailAddress(ErrorMessage = "Correo no valido")]
        public string? mail { get; set; }

        [Required(ErrorMessage = "Ingresa la calificacion")]
        [Range(0, 10, ErrorMessage = "Debe de ser un numero de entre 0 - 10")]
        public float? cali { get; set; }
    }
}
*/