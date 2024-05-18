using Microsoft.EntityFrameworkCore;
using Trabajos.Data;

namespace Trabajos.Repositorio
{
    public class CRepositorioCompras : RepositorioCompras
    {
        private readonly MuebleriaDBContext context;

        public CRepositorioCompras(MuebleriaDBContext contexto)
        {
            context = contexto;
        }
        public async Task<Compras> Add(Compras compras)
        {
            await context.Compras.AddAsync(compras);
            await context.SaveChangesAsync();
            return compras;
        }

        public async Task Delete(int id)
        {
            var compra = await context.Compras.FindAsync(id);
            if (compra != null)
            {
                context.Compras.Remove(compra);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Compras>> GetAll()
        {
            return await context.Compras.ToListAsync();
        }

        public async Task<Compras> Get(int id)
        {
            return await context.Compras.FindAsync(id);
        }

        public async Task Update(int id, Compras compra)
        {
            var compraActual = await context.Compras.FindAsync(id);
            if (compraActual != null)
            {
                compraActual.NombreC = compra.NombreC;
                compraActual.PrecioC = compra.PrecioC;
                compraActual.CantidadC = compra.CantidadC;
                compraActual.FechaC = compra.FechaC;

                await context.SaveChangesAsync();
            }
        }
    }
}
