// Archivo: UdelasCore.Negocio/Servicios/MateriaService.cs
using Microsoft.EntityFrameworkCore;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.Modelos;

namespace UdelasCore.Negocio.Servicios
{
    public class MateriaService : IMateriaService
    {
        private readonly ApplicationDbContext _context;

        public MateriaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Materia>> ObtenerTodosAsync()
        {
            return await _context.Materias
                .Include(m => m.Ternas)
                .Include(m => m.Profesores)
                .ToListAsync();
        }

        public async Task<Materia?> ObtenerPorIdAsync(int id)
        {
            return await _context.Materias
                .Include(m => m.Ternas)
                .Include(m => m.Profesores)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Materia> CrearAsync(Materia materia)
        {
            _context.Materias.Add(materia);
            await _context.SaveChangesAsync();
            return materia;
        }

        public async Task<Materia> ActualizarAsync(Materia materia)
        {
            _context.Entry(materia).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return materia;
        }

        public async Task<bool> EliminarAsync(int id)
        {
            var materia = await _context.Materias.FindAsync(id);
            if (materia == null) return false;

            _context.Materias.Remove(materia);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}