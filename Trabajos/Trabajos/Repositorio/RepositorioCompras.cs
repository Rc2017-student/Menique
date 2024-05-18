using Trabajos.Data;

namespace Trabajos.Repositorio
{
    public interface RepositorioCompras
    {
        Task<List<Compras>> GetAll();
        Task<Compras> Get(int id);
        Task<Compras> Add(Compras compras);
        Task Update(int id, Compras compra);
        Task Delete(int id);
    }
}
