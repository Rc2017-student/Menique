using System.ComponentModel.DataAnnotations;

namespace Trabajos.Data
{
    public class Ventas
    {
        [Key]
        public int IdVenta { get; set; }

        public int ComprasId { get; set; }
        virtual public Compras? Compras { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe de ser un numero entero")]
        public int? CantidadV { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime? FechaV { get; set; }

        public int EmpleadosId { get; set; }
        virtual public Empleados? Empleados { get; set; }
    }
}
