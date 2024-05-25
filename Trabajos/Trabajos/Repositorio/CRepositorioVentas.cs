using Microsoft.EntityFrameworkCore;
using Trabajos.Data;

namespace Trabajos.Repositorio
{
    public class CRepositorioVentas : RepositorioVentas
    {
        private readonly MuebleriaDBContext context;

        public CRepositorioVentas(MuebleriaDBContext contexto)
        {
            context = contexto;
        }
        public async Task<Ventas> Add(Ventas ventas)
        {
            await context.Ventas.AddAsync(ventas);
            await context.SaveChangesAsync();
            return ventas;
        }

        public async Task Delete(int id)
        {
            var venta = await context.Ventas.FindAsync(id);
            if (venta != null)
            {
                context.Ventas.Remove(venta);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Ventas>> GetAll()
        {
            return await context.Ventas.ToListAsync();
        }

        public async Task<Ventas> Get(int id)
        {
            return await context.Ventas.FindAsync(id);
        }

        public async Task Update(int id, Ventas ventas)
        {
            var ventaActual = await context.Ventas.FindAsync(id);
            if (ventaActual != null)
            {
                ventaActual.CantidadV = ventas.CantidadV;
                ventaActual.FechaV = ventas.FechaV;

                await context.SaveChangesAsync();
            }
        }
    }
}
