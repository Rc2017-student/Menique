using System.ComponentModel.DataAnnotations;

namespace Trabajos.Data
{
    public class Empleados
    {
        [Key]
        public int IdEmpleado { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede exeder los 50 caracteres")]
        public string? NombreE { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede exeder los 50 caracteres")]
        public string? ApellidoE { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(50, ErrorMessage = "El nombre no puede exeder los 50 caracteres")]
        public string? PuestoE { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime? FechaContratacion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe de ser un numero entero")]
        public int? Salario { get; set; }
    }
}
