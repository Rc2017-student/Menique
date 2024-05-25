using System.ComponentModel.DataAnnotations;

namespace Trabajos.Data
{
    public class Compras
    {
        [Key]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string? NombreC { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero")]
        public int? PrecioC { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ser un número entero")]
        public int CantidadC { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime? FechaC { get; set; }
    }
}
