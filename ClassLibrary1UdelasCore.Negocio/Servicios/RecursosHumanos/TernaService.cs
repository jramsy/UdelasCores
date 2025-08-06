using Microsoft.EntityFrameworkCore;
using Udelascore.Negocio.Data;
using Udelascore.Negocio.Models.RecursosHumanos;
using UdelasCore.Negocio.Data;
using UdelasCore.Negocio.DTOs;
using UdelasCore.Negocio.Modelos.RecursosHumanos;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs.TernaDetalles;
using UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs.Ternas;
using UdelasCore.Negocio.Servicios.HorariosDocencia;

namespace UdelasCore.Negocio.Servicios.RecursosHumanos
{
    public class TernaService
    {
        private readonly RecursosHumanosContext _rhContext;
        private readonly FacultadService _facultadService;
        private readonly SemMatService _semMatService;
        private readonly MateriasPorCarreraService _mcpService;
        private readonly CarreraService _carreraService;
        public TernaService(RecursosHumanosContext context, FacultadService facultadService, SemMatService semMatService, MateriasPorCarreraService mcp, CarreraService carreraService)
        {
            _rhContext = context;
            _facultadService = facultadService;
            _semMatService = semMatService;
            _mcpService = mcp;
            _carreraService = carreraService;
        }
        public async Task<List<ObtainTernasDTO>> GetAllTernasAsync()
        {
            var ternas = await _rhContext.Ternas.Where(t => t.Borrado == false).Include(t => t.Estado)
                                              .ToListAsync();


            var codCarreras = ternas.Select(t => t.CodCarrera).Distinct().ToList();
            var codMaterias = ternas.Select(t => t.CodMateria).Distinct().ToList();

            var mpcs = await _mcpService.GetMateriasPorCarreraAsync();

            var carreras = await _carreraService.GetCarrerasAsync();
            var facultades = await _facultadService.GetFacultadesAsync();
            var semestres = await _semMatService.GetSemMatAsync();

            var resultado = (from t in ternas
                             join mpc in mpcs on new { t.CodCarrera, t.CodMateria }
                                 equals new { mpc.CodCarrera, mpc.CodMateria }
                             join ca in carreras on mpc.CodCarrera equals ca.CodCarrera
                             join fa in facultades on ca.CodFacultad2 equals fa.CodFacultad
                             select new ObtainTernasDTO
                             {
                                 Descripcion = mpc.Descripcion,
                                 Carrera = ca.Carrera,
                                 IdTerna = t.IdTerna,
                                 Facultad = fa.Facultad,
                                 Periodo = mpc.Periodo,
                                 CodCarrera = t.CodCarrera,
                                 CodMateria = t.CodMateria,
                                 Anio = t.Anio,
                                 NomPeriodo = semestres.FirstOrDefault(sm => sm.Codigo == mpc.Periodo)?.NomSemMateria,
                                 EstadoNombre = t.Estado?.Nombre,
                                 FechaInicio = t.FechaInicio,
                                 FechaFinal = t.FechaFinal,
                                 IdEstado = t.EstadoIdEstado
                             }).ToList();


            return resultado ?? new List<ObtainTernasDTO>();
        }
        public async Task<List<TernaDetalleProfesorDTO>> GetTernasDetalleByIdAsync(int id)
        {
            if (id <= 0)
                return new List<TernaDetalleProfesorDTO>();

            var query = @"
                SELECT 
            TD.IdTernaDetalle,
            TD.IdTerna,
            TD.IdEstado,
            TD.CedDocente,

            PR.Cod_prof,
            PR.Cedula,
            PR.Nombre,
            PR.Apellido,
            PR.Telefono,
            PR.Celular,
            PR.Provincia,
            PR.Turnom,

            ED.Id_Estudio AS IdEstudio,
            ED.Cedula AS CedulaEstudio,
            ED.Cod_Tipo_Estudio,
            ED.Nombre_Estudio,
            ED.Puntaje AS PuntajeEstudio,
            ED.Provincia AS ProvinciaEstudio,
            ED.Habilitado AS HabilitadoEstudio,
            ED.Direccion AS DireccionEstudio

        FROM TernaDetalles TD
        INNER JOIN [BANCO DE DATOS].dbo.Bd_profesor PR 
            ON TD.CedDocente COLLATE SQL_Latin1_General_CP1_CI_AS = PR.Cedula
        INNER JOIN [BANCO DE DATOS].dbo.Bd_Estudios_Docentes ED 
            ON ED.Cedula = PR.Cedula
        WHERE TD.IdTerna = {0} AND Cod_Tipo_Estudio = 2 AND TD.Borrado = 'false'";

            var resultado = await _rhContext.Set<TernaDetalleProfesorDTO>()
                .FromSqlRaw(query, id)
                .ToListAsync();

            return resultado ?? new List<TernaDetalleProfesorDTO>();
        }
        public async Task<Terna?> GetTernaByIdAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El Id de la terna debe ser mayor que cero.", nameof(id));

            return await _rhContext.Ternas
                                 .AsNoTracking()
                                 .SingleOrDefaultAsync(t => t.IdTerna == id);
        }
        public async Task<bool> UpdateTernaDetalleAsync(ActualizarTernaDetalleDTO detalle)
        {
            if (detalle == null || detalle.IdTernaDetalle <= 0)
                return false;
            var ternaDetalle = await _rhContext.TernaDetalles.FindAsync(detalle.IdTernaDetalle);
            if (ternaDetalle == null)
                return false;

            if (detalle.IdEstado != 0 || detalle.IdEstado != null)
            {
                //Actualizar el estado de la terna apenas se acepta o rechaza una TernaDetalle
                var terna = await GetTernaByIdAsync(detalle.IdTerna);
                ternaDetalle.IdEstado = (int)detalle.IdEstado;
                terna.Estado.IdEstado = (int)detalle.IdEstado;
            }


            ternaDetalle.IdUsuarioModificador = detalle.IdUsuarioModificador;
            ternaDetalle.FechaModificacion = detalle.FechaModificacion ?? DateTime.Now;
            _rhContext.TernaDetalles.Update(ternaDetalle);
            await _rhContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateTernaEstado(ActualizarTernaEstadoDTO datos)
        {
            if (datos == null || datos.IdTerna <= 0)
                return false;

            var terna = await _rhContext.Ternas.FindAsync(datos.IdTerna);

            if (terna == null)
                return false;

            // Actualizar el estado de la terna
            terna.IdUsuarioModificador = datos.IdUsuarioModificador;
            terna.FechaModificacion = datos.FechaModificacion ?? DateTime.Now;

            if (datos.IdEstado != 0)
            {
                terna.EstadoIdEstado = datos.IdEstado;
                //Buscar terna detalle seleccionado
                if (datos.IdTernaDetalleSeleccionado.HasValue && datos.IdTernaDetalleSeleccionado > 0)
                {
                    var ternaDetalle = await _rhContext.TernaDetalles
                        .FirstOrDefaultAsync(td => td.IdTernaDetalle == datos.IdTernaDetalleSeleccionado);

                    if (ternaDetalle != null)
                    {
                        ternaDetalle.IdEstado = datos.IdEstado;
                        ternaDetalle.IdUsuarioModificador = datos.IdUsuarioModificador;
                        ternaDetalle.FechaModificacion = datos.FechaModificacion ?? DateTime.Now;
                        _rhContext.TernaDetalles.Update(ternaDetalle);
                    }
                }
            }

            // Guardar todos los cambios realizados
            _rhContext.Ternas.Update(terna);
            await _rhContext.SaveChangesAsync();

            return true;
        }
        public async Task<bool> TernaExistsAsync(int id)
        {
            if (id <= 0)
                return false;
            return await _rhContext.Ternas.AnyAsync(t => t.IdTerna == id);
        }
        public async Task<Terna> CreateOrUpdateTernaAsync(InsertarTernaDTO dtoTerna, InsertarTernaDetalleDTO? dtoDetalle)
        {
            if (dtoTerna == null)
                throw new ArgumentNullException(nameof(dtoTerna));

            Terna terna;

            // CREAR o ACTUALIZAR la Terna
            if (dtoTerna.IdTerna.HasValue && dtoTerna.IdTerna > 0)
            {
                terna = await _rhContext.Ternas.FindAsync(dtoTerna.IdTerna.Value);

                if (terna == null)
                    throw new Exception($"No se encontró una Terna con ID {dtoTerna.IdTerna}");

                // Editar campos
                terna.CodMateria = dtoTerna.CodMateria;
                terna.Anio = dtoTerna.Anio;
                terna.CodCarrera = dtoTerna.CodCarrera;
                terna.EstadoIdEstado = dtoTerna.EstadoIdEstado;
            }
            else
            {
                // Crear nueva terna
                terna = new Terna
                {
                    CodMateria = dtoTerna.CodMateria,
                    Anio = dtoTerna.Anio,
                    CodCarrera = dtoTerna.CodCarrera,
                    EstadoIdEstado = dtoTerna.EstadoIdEstado,
                    IdUsuarioCreador = dtoTerna.IdUsuarioCreador,
                    FechaCreacion = DateTime.Now,
                    FechaInicio = dtoTerna.fechaInicio,
                    FechaFinal = dtoTerna.fechaCulmina
                };

                _rhContext.Ternas.Add(terna);
            }

            await _rhContext.SaveChangesAsync(); // Se asegura el Id de la terna

            // Si viene detalle, CREAR o EDITAR
            if (dtoDetalle != null)
            {
                // Validar cantidad máxima de docentes activos
                var cantidadDocentes = await _rhContext.TernaDetalles
                    .CountAsync(td => td.IdTerna == terna.IdTerna && td.IdEstado == 1 && td.Borrado == false); // activos

                // Validar cédula repetida (solo si se va a crear un nuevo detalle)
                var cedulaYaRegistrada = await _rhContext.TernaDetalles
                    .AnyAsync(td =>
                        td.IdTerna == terna.IdTerna &&
                        td.CedDocente == dtoDetalle.CedDocente &&
                        td.IdEstado == 1 && 
                        td.Borrado == false);

                if (!dtoDetalle.IdTernaDetalle.HasValue || dtoDetalle.IdTernaDetalle == 0)
                {
                    if (cantidadDocentes >= 3)
                        throw new Exception("No se pueden agregar más de 3 docentes a esta terna.");

                    if (cedulaYaRegistrada)
                        throw new Exception($"Ya existe un docente con cédula {dtoDetalle.CedDocente} en esta terna.");
                }

                TernaDetalle detalle;

                if (dtoDetalle.IdTernaDetalle.HasValue && dtoDetalle.IdTernaDetalle > 0)
                {
                    detalle = await _rhContext.TernaDetalles.FindAsync(dtoDetalle.IdTernaDetalle.Value);

                    if (detalle == null)
                        throw new Exception($"No se encontró un detalle con ID {dtoDetalle.IdTernaDetalle}");

                    detalle.CedDocente = dtoDetalle.CedDocente;
                    detalle.IdEstado = dtoDetalle.IdEstado;
                }
                else
                {
                    detalle = new TernaDetalle
                    {
                        IdTerna = terna.IdTerna,
                        CedDocente = dtoDetalle.CedDocente,
                        IdEstado = dtoDetalle.IdEstado,
                        IdUsuarioCreador = dtoDetalle.IdUsuarioCreador,
                        FechaCreacion = DateTime.Now
                    };

                    _rhContext.TernaDetalles.Add(detalle);
                }

                await _rhContext.SaveChangesAsync();
            }

            return terna;
        }
        public async Task<bool> DeleteTernaAsync(int idTerna, int IdUsuarioBorrador)
        {
            try
            {
                var updatedCount = await _rhContext.Ternas
                    .Where(t => t.IdTerna == idTerna)
                    .ExecuteUpdateAsync(setters => setters
                    .SetProperty(t => t.Borrado, true)
                    .SetProperty(t => t.FechaBorrador, DateTime.UtcNow)
                    .SetProperty(t => t.IdUsuarioBorrador, IdUsuarioBorrador) // usuarioActual es un string con quien borra
                );



                return updatedCount > 0;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> DeleteTernaDetalleAsync(int idTernaDetalle, int IdUsuarioBorrador)
        {

            try
            {
                var updatedCount = await _rhContext.TernaDetalles
                    .Where(t => t.IdTernaDetalle == idTernaDetalle)
                    .ExecuteUpdateAsync(setters => setters
                    .SetProperty(t => t.Borrado, true)
                    .SetProperty(t => t.FechaBorrador, DateTime.UtcNow)
                    .SetProperty(t => t.IdUsuarioBorrador, IdUsuarioBorrador) // usuarioActual es un string con quien borra
                );



                return updatedCount > 0;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
