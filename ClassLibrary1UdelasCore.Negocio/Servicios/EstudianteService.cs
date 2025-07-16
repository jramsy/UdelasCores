using Microsoft.EntityFrameworkCore;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Modelos.Modelo_Terna;

namespace UdelasCore.Negocio.Servicios
{
    public class EstudianteService : IEstudianteService
    {
        private readonly RHHDbContext _context;

        public EstudianteService(RHHDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Estudiante>> ObtenerTodosAsync()
        {
            return await _context.Estudiantes
                .Include(e => e.Terna)
                .ToListAsync();
        }

        public async Task<Estudiante?> ObtenerPorIdAsync(int id)
        {
            return await _context.Estudiantes
                .Include(e => e.Terna)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Estudiante> CrearAsync(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();
            return estudiante;
        }

        public async Task<Estudiante> ActualizarAsync(Estudiante estudiante)
        {
            _context.Entry(estudiante).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return estudiante;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);
            if (estudiante == null) return false;

            _context.Estudiantes.Remove(estudiante);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}