using Trabajos.Data;

namespace Trabajos.Repositorio
{
    public interface RepositorioEmpleados
    {
        Task<List<Empleados>> GetAll();
        Task<Empleados> Get(int id);
        Task<Empleados> Add(Empleados empleados);
        Task Update(int id, Empleados empleados);
        Task Delete(int id);
    }
}
