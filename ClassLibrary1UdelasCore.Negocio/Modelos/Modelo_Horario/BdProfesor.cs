using System;
using System.Collections.Generic;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class BdProfesor
{
    public long CodProf { get; set; }

    public int Cantidad { get; set; }

    public string Cedula { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Telefono2 { get; set; }

    public string? Celular { get; set; }

    public string? Seguro { get; set; }

    public int Annoingreso { get; set; }

    public string Sexo { get; set; } = null!;

    public string Provincia { get; set; } = null!;

    public string? Turnom { get; set; }

    public long CodEspecialidad { get; set; }

    public int? CodTecnico { get; set; }

    public int? CodLicenciatura { get; set; }

    public int? CodPostgrado { get; set; }

    public int? CodProfesorado { get; set; }

    public int? CodMaestria { get; set; }

    public int? CodDoctorado { get; set; }

    public string? CodEstudio { get; set; }

    public string? CodPerfeccionamiento { get; set; }

    public string? CodEjecutoria { get; set; }

    public string? CodPublicaciones { get; set; }

    public string? CodConferencias { get; set; }

    public string? CodPonencias { get; set; }

    public int? Puntaje { get; set; }

    public int? Numero { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Habilitado { get; set; }

    public string AnoPeriodoEntregarListas { get; set; } = null!;

    public string? Usuario { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Turnov { get; set; }

    public string? Turnon { get; set; }

    public string FechaTrabajo { get; set; } = null!;

    public string? Idioma1 { get; set; }

    public string? Idioma2 { get; set; }

    public int? CodDepartamento { get; set; }
}
