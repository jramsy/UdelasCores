using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

[Keyless]
[Table("Bd_profesor")]
public partial class BdProfesor
{
    [Column("Cod_prof")]
    public long CodProf { get; set; }

    public int Cantidad { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string Cedula { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Apellido { get; set; } = null!;

    [StringLength(9)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? Telefono2 { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? Celular { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? Seguro { get; set; }

    [Column("annoingreso")]
    public int Annoingreso { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Sexo { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Provincia { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Turnom { get; set; }

    [Column("Cod_especialidad")]
    public long CodEspecialidad { get; set; }

    [Column("Cod_Tecnico")]
    public int? CodTecnico { get; set; }

    [Column("Cod_Licenciatura")]
    public int? CodLicenciatura { get; set; }

    [Column("Cod_Postgrado")]
    public int? CodPostgrado { get; set; }

    [Column("Cod_Profesorado")]
    public int? CodProfesorado { get; set; }

    [Column("Cod_Maestria")]
    public int? CodMaestria { get; set; }

    [Column("Cod_Doctorado")]
    public int? CodDoctorado { get; set; }

    [Column("Cod_estudio")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CodEstudio { get; set; }

    [Column("Cod_perfeccionamiento")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CodPerfeccionamiento { get; set; }

    [Column("Cod_ejecutoria")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CodEjecutoria { get; set; }

    [Column("Cod_publicaciones")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CodPublicaciones { get; set; }

    [Column("Cod_conferencias")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CodConferencias { get; set; }

    [Column("Cod_ponencias")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CodPonencias { get; set; }

    public int? Puntaje { get; set; }

    public int? Numero { get; set; }

    [StringLength(90)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("password")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Password { get; set; }

    [Column("habilitado")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Habilitado { get; set; }

    [Column("Ano_periodo_entregar_listas")]
    [StringLength(50)]
    [Unicode(false)]
    public string AnoPeriodoEntregarListas { get; set; } = null!;

    [Column("usuario")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Usuario { get; set; }

    [Column("fecha", TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Turnov { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? Turnon { get; set; }

    [Column("fecha_trabajo")]
    [StringLength(11)]
    [Unicode(false)]
    public string FechaTrabajo { get; set; } = null!;

    [Column("idioma1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Idioma1 { get; set; }

    [Column("idioma2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Idioma2 { get; set; }

    [Column("cod_departamento")]
    public int? CodDepartamento { get; set; }
}
