using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.BancoDeDatos;

[Table("Bd_profesor")]
public partial class BdProfesor
{
    [Key]
    [Column("Cedula")]
    [Required]
    [StringLength(13)]
    public string Cedula { get; set; } = string.Empty;

    [Column("Cod_prof")]
    public long CodProf { get; set; } = 0;

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("Cantidad")]
    public int Cantidad { get; set; } = 0;

    [Required]
    [StringLength(30)]
    [Column("Nombre")]
    public string Nombre { get; set; } = string.Empty;

    [Required]
    [StringLength(30)]
    [Column("Apellido")]
    public string Apellido { get; set; } = string.Empty;

    [StringLength(9)]
    [Column("Telefono")]
    public string? Telefono { get; set; } = null;

    [StringLength(9)]
    [Column("Telefono2")]
    public string? Telefono2 { get; set; } = null;

    [StringLength(9)]
    [Column("Celular")]
    public string? Celular { get; set; } = null;

    [StringLength(13)]
    [Column("Seguro")]
    public string? Seguro { get; set; } = null;

    [Required]
    [Column("annoingreso")]
    public int AnnoIngreso { get; set; } = 0;

    [Required]
    [StringLength(10)]
    [Column("Sexo")]
    public string Sexo { get; set; } = string.Empty;

    [Required]
    [StringLength(10)]
    [Column("Provincia")]
    public string Provincia { get; set; } = "PANAMA";

    [StringLength(10)]
    [Column("Turnom")]
    public string? Turnom { get; set; } = null;

    [Required]
    [Column("Cod_especialidad")]
    public long CodEspecialidad { get; set; } = 0;

    [Column("Cod_Tecnico")]
    public int? CodTecnico { get; set; } = 0;

    [Column("Cod_Licenciatura")]
    public int? CodLicenciatura { get; set; } = 0;

    [Column("Cod_Postgrado")]
    public int? CodPostgrado { get; set; } = 0;

    [Column("Cod_Profesorado")]
    public int? CodProfesorado { get; set; } = 0;

    [Column("Cod_Maestria")]
    public int? CodMaestria { get; set; } = 0;

    [Column("Cod_Doctorado")]
    public int? CodDoctorado { get; set; } = 0;

    [StringLength(20)]
    [Column("Cod_estudio")]
    public string? CodEstudio { get; set; } = null;

    [StringLength(20)]
    [Column("Cod_perfeccionamiento")]
    public string? CodPerfeccionamiento { get; set; } = null;

    [StringLength(20)]
    [Column("Cod_ejecutoria")]
    public string? CodEjecutoria { get; set; } = null;

    [StringLength(20)]
    [Column("Cod_publicaciones")]
    public string? CodPublicaciones { get; set; } = null;

    [StringLength(20)]
    [Column("Cod_conferencias")]
    public string? CodConferencias { get; set; } = null;

    [StringLength(20)]
    [Column("Cod_ponencias")]
    public string? CodPonencias { get; set; } = null;

    public int? Puntaje { get; set; } = null;

    public int? Numero { get; set; } = null;

    [StringLength(90)]
    [Column("Direccion")]
    public string? Direccion { get; set; } = null;

    [StringLength(50)]
    [Column("email")]
    public string? Email { get; set; } = null;

    [StringLength(50)]
    [Column("password")]
    public string? Password { get; set; } = null;

    [StringLength(2)]
    [Column("habilitado")]
    public string Habilitado { get; set; } = "N";

    [Required]
    [StringLength(50)]
    [Column("Ano_periodo_entregar_listas")]
    public string AnoPeriodoEntregarListas { get; set; } = "0_0000_0_00";

    [StringLength(50)]
    [Column("usuario")]
    public string Usuario { get; set; } = "ADMIN";

    [Column("fecha", TypeName = "datetime")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [StringLength(2)]
    [Column("Turnov")]
    public string Turnov { get; set; } = "0";

    [StringLength(2)]
    [Column("Turnon")]
    public string Turnon { get; set; } = "0";

    [Required]
    [StringLength(11)]
    [Column("fecha_trabajo")]
    public string FechaTrabajo { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");

    [StringLength(50)]
    [Column("idioma1")]
    public string Idioma1 { get; set; } = "n";

    [StringLength(50)]
    [Column("idioma2")]
    public string Idioma2 { get; set; } = "n";

    [Column("cod_departamento")]
    public int CodDepartamento { get; set; } = 0;

    [StringLength(50)]
    [Column("R")]
    public string R { get; set; } = "N";

    [Required]
    [StringLength(50)]
    [Column("experiencia")]
    public string Experiencia { get; set; } = "N";

    [Required]
    [StringLength(50)]
    [Column("valor1")]
    public string Valor1 { get; set; } = "N";

    [StringLength(150)]
    [Column("LugarNacimiento")]
    public string LugarNacimiento { get; set; } = " ";

    [StringLength(50)]
    [Column("FechaNacimiento")]
    public string FechaNacimiento { get; set; } = "01 de enero 1999";

    [Required]
    [Column("dia")]
    public int Dia { get; set; } = 31;

    [Required]
    [Column("mes")]
    public int Mes { get; set; } = 12;

    [Required]
    [Column("anio")]
    public int Anio { get; set; } = 1900;

    [StringLength(3)]
    [Column("TipoSangre")]
    public string? TipoSangre { get; set; } = null;

    [StringLength(50)]
    [Column("Alergico")]
    public string? Alergico { get; set; } = null;
}
