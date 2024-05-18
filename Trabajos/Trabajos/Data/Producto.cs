/*using System.ComponentModel.DataAnnotations;
namespace Trabajos.Data
{
    public class Producto
    {
        [Required(ErrorMessage = "El numero de inventario es neccesario")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe de ser un numero entero")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "El nombre es neccesario")]
        [MaxLength(200, ErrorMessage = "El nombre no puede exeder los 200 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El departamento es neccesario")]
        public string? Departmento { get; set; }
    }

    public class Validacion
    {
        private List<Producto> productos = new List<Producto>();

        public IReadOnlyList<Producto> Productos => productos.AsReadOnly();

        public void AddProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void RemoveProducto(Producto producto)
        {
            productos.Remove(producto);
        }

        public bool IsNumeroDup(int Numero)
        {
            return productos.Any(p => p.Numero == Numero);
        }

    }
}
*/