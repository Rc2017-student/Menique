using Microsoft.EntityFrameworkCore;
using Trabajos.Data;

namespace Trabajos.Repositorio
{
    public class CRepositorioEmpleados : RepositorioEmpleados
    {
        private readonly MuebleriaDBContext context;

        public CRepositorioEmpleados(MuebleriaDBContext contexto)
        {
            context = contexto;
        }
        public async Task<Empleados> Add(Empleados empleados)
        {
            await context.Empleados.AddAsync(empleados);
            await context.SaveChangesAsync();
            return empleados;
        }

        public async Task Delete(int id)
        {
            var empleados = await context.Empleados.FindAsync(id);
            if (empleados != null)
            {
                context.Empleados.Remove(empleados);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Empleados>> GetAll()
        {
            return await context.Empleados.ToListAsync();
        }

        public async Task<Empleados> Get(int id)
        {
            return await context.Empleados.FindAsync(id);
        }

        public async Task Update(int id, Empleados empleados)
        {
            var empleadoActual = await context.Empleados.FindAsync(id);
            if (empleadoActual != null)
            {
                empleadoActual.NombreE = empleados.NombreE;
                empleadoActual.ApellidoE = empleados.ApellidoE;
                empleadoActual.PuestoE = empleados.PuestoE;
                empleadoActual.FechaContratacion = empleados.FechaContratacion;
                empleadoActual.Salario = empleados.Salario;

                await context.SaveChangesAsync();
            }
        }
    }
}
