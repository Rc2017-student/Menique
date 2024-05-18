using System.ComponentModel.DataAnnotations;

namespace Trabajos.Data
{
    public class Ventas
    {
        [Key]
        public int IdVenta { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? ProductoV { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe de ser un numero entero")]
        public int? PrecioV { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe de ser un numero entero")]
        public int? CantidadV { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime? FechaV { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public string? EmpleadoV { get; set; }
    }
}
