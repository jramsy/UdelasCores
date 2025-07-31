using System;

namespace UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs
{
    public class TernaDetalleProfesorDTO
    {
        // TernaDetalles
        public int IdTernaDetalle { get; set; }
        public int IdTerna { get; set; }
        public int IdEstado { get; set; }
        public string CedDocente { get; set; }

        // Bd_profesor
        public long Cod_prof { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Provincia { get; set; }
        public string Turnom { get; set; }

        // Bd_Estudios_Docentes
        public int IdEstudio { get; set; }           // corresponde a ED.Id_Estudio AS IdEstudio
        public string CedulaEstudio { get; set; }   // corresponde a ED.Cedula AS CedulaEstudio
        public int Cod_Tipo_Estudio { get; set; }
        public string Nombre_Estudio { get; set; }
        public int PuntajeEstudio { get; set; }
        public string ProvinciaEstudio { get; set; }
        public string HabilitadoEstudio { get; set; }
        public string DireccionEstudio { get; set; }
    }

}
