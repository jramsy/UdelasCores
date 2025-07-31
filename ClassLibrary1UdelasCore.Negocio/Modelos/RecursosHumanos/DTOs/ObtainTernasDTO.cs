namespace UdelasCore.Negocio.Modelos.RecursosHumanos.DTOs
{
    public class ObtainTernasDTO
    {
        public string Descripcion { get; set; }
        public int IdEstado { get; set; }
        public string Carrera { get; set; }
        public int IdTerna { get; set; }
        public string Facultad { get; set; }
        public int Periodo { get; set; }
        public int CodCarrera { get; set; }
        public int CodMateria { get; set; }
        public int Anio { get; set; }
        public string NomPeriodo { get; set; } // Este es el subquery "Periodo"
        public string EstadoNombre { get; set; } // Este es el subquery "Estado"
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFinal { get; set; }
    }
}
