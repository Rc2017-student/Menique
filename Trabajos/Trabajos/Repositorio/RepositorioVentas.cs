using Trabajos.Data;

namespace Trabajos.Repositorio
{
    public interface RepositorioVentas
    {
        Task<List<Ventas>> GetAll();
        Task<Ventas> Get(int id);
        Task<Ventas> Add(Ventas ventas);
        Task Update(int id, Ventas ventas);
        Task Delete(int id);
    }
}
