using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Udelascore.Negocio.Models.RecursosHumanos;

[Keyless]
[Table("ADMINISTRATIVOSAccess")]
public partial class Administrativosaccess
{
    [Column("cod_empleado")]
    public int CodEmpleado { get; set; }

    [Column("codigo_estructura")]
    [StringLength(6)]
    public string? CodigoEstructura { get; set; }

    [Column("fecha_creacion", TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column("primer_nombre")]
    [StringLength(80)]
    public string? PrimerNombre { get; set; }

    [Column("segundo_nombre")]
    [StringLength(80)]
    public string? SegundoNombre { get; set; }

    [Column("apellido_paterno")]
    [StringLength(80)]
    public string? ApellidoPaterno { get; set; }

    [Column("apellido_materno_casada")]
    [StringLength(80)]
    public string? ApellidoMaternoCasada { get; set; }

    [Column("cedula")]
    [StringLength(15)]
    public string? Cedula { get; set; }

    [Column("seguro_social")]
    [StringLength(15)]
    public string? SeguroSocial { get; set; }

    [Column("sexo")]
    [StringLength(1)]
    public string? Sexo { get; set; }

    [Column("estado_civil")]
    [StringLength(30)]
    public string? EstadoCivil { get; set; }

    [Column("tipo_sangre")]
    [StringLength(3)]
    public string? TipoSangre { get; set; }

    [Column("fecha_nacimiento (MM/DD/YYYY)", TypeName = "datetime")]
    public DateTime? FechaNacimientoMmDdYyyy { get; set; }

    [Column("lugar_nacimiento")]
    [StringLength(25)]
    public string? LugarNacimiento { get; set; }

    [Column("nacionalidad")]
    [StringLength(30)]
    public string? Nacionalidad { get; set; }

    [Column("direccion_residencial")]
    [StringLength(255)]
    public string? DireccionResidencial { get; set; }

    [Column("tel_residencia")]
    [StringLength(15)]
    public string? TelResidencia { get; set; }

    [Column("celular")]
    [StringLength(15)]
    public string? Celular { get; set; }

    [Column("correo_electronico")]
    [StringLength(70)]
    public string? CorreoElectronico { get; set; }

    [Column("es_alergico")]
    public bool EsAlergico { get; set; }

    [Column("a_que_es_alergico")]
    [StringLength(100)]
    public string? AQueEsAlergico { get; set; }

    [Column("problemas_de_salud")]
    public bool ProblemasDeSalud { get; set; }

    [Column("explique")]
    [StringLength(100)]
    public string? Explique { get; set; }

    [Column("nombre_conyugue")]
    [StringLength(80)]
    public string? NombreConyugue { get; set; }

    [Column("telefono_conyugue")]
    [StringLength(30)]
    public string? TelefonoConyugue { get; set; }

    [Column("nombre_padre")]
    [StringLength(80)]
    public string? NombrePadre { get; set; }

    [Column("vive_padre")]
    public bool VivePadre { get; set; }

    [Column("nombre_madre")]
    [StringLength(80)]
    public string? NombreMadre { get; set; }

    [Column("vive_madre")]
    public bool ViveMadre { get; set; }

    [Column("dependiente1")]
    [StringLength(60)]
    public string? Dependiente1 { get; set; }

    [Column("parentesco1")]
    [StringLength(20)]
    public string? Parentesco1 { get; set; }

    [Column("edad1")]
    public int? Edad1 { get; set; }

    [Column("dependiente2")]
    [StringLength(60)]
    public string? Dependiente2 { get; set; }

    [Column("parentesco2")]
    [StringLength(20)]
    public string? Parentesco2 { get; set; }

    [Column("edad2")]
    public int? Edad2 { get; set; }

    [Column("dependiente3")]
    [StringLength(60)]
    public string? Dependiente3 { get; set; }

    [Column("parentesco3")]
    [StringLength(20)]
    public string? Parentesco3 { get; set; }

    [Column("edad3")]
    public int? Edad3 { get; set; }

    [Column("dependiente4")]
    [StringLength(60)]
    public string? Dependiente4 { get; set; }

    [Column("parentesco4")]
    [StringLength(20)]
    public string? Parentesco4 { get; set; }

    [Column("edad4")]
    public int? Edad4 { get; set; }

    [Column("dependiente5")]
    [StringLength(60)]
    public string? Dependiente5 { get; set; }

    [Column("parentesco5")]
    [StringLength(20)]
    public string? Parentesco5 { get; set; }

    [Column("edad5")]
    public int? Edad5 { get; set; }

    [Column("dependiente6")]
    [StringLength(60)]
    public string? Dependiente6 { get; set; }

    [Column("parentesco6")]
    [StringLength(20)]
    public string? Parentesco6 { get; set; }

    [Column("edad6")]
    public int? Edad6 { get; set; }

    [Column("primaria")]
    [StringLength(150)]
    public string? Primaria { get; set; }

    [Column("años_primaria")]
    public int? AñosPrimaria { get; set; }

    [Column("titulos_primaria")]
    [StringLength(200)]
    public string? TitulosPrimaria { get; set; }

    [Column("secundaria")]
    [StringLength(150)]
    public string? Secundaria { get; set; }

    [Column("años_secundaria")]
    public int? AñosSecundaria { get; set; }

    [Column("titulos_secundaria")]
    [StringLength(200)]
    public string? TitulosSecundaria { get; set; }

    [Column("vocacional_tecnico")]
    [StringLength(150)]
    public string? VocacionalTecnico { get; set; }

    [Column("años_vocacional_tecnico")]
    public int? AñosVocacionalTecnico { get; set; }

    [Column("titulos_vocacional_tecnico")]
    [StringLength(200)]
    public string? TitulosVocacionalTecnico { get; set; }

    [Column("universitario")]
    [StringLength(150)]
    public string? Universitario { get; set; }

    [Column("años_universitario")]
    public int? AñosUniversitario { get; set; }

    [Column("titulos_universitario")]
    [StringLength(200)]
    public string? TitulosUniversitario { get; set; }

    [Column("post_grado")]
    [StringLength(150)]
    public string? PostGrado { get; set; }

    [Column("años_post_grado")]
    public int? AñosPostGrado { get; set; }

    [Column("titulos_post_grado")]
    [StringLength(200)]
    public string? TitulosPostGrado { get; set; }

    [Column("maestria")]
    [StringLength(150)]
    public string? Maestria { get; set; }

    [Column("años_maestria")]
    public int? AñosMaestria { get; set; }

    [Column("titulos_maestria")]
    [StringLength(200)]
    public string? TitulosMaestria { get; set; }

    [Column("doctorado")]
    [StringLength(150)]
    public string? Doctorado { get; set; }

    [Column("años_doctorado")]
    public int? AñosDoctorado { get; set; }

    [Column("titulos_doctorado")]
    [StringLength(200)]
    public string? TitulosDoctorado { get; set; }

    [Column("estudia_actualmente")]
    public bool EstudiaActualmente { get; set; }

    [Column("donde")]
    [StringLength(100)]
    public string? Donde { get; set; }

    [Column("que_estudia")]
    [StringLength(150)]
    public string? QueEstudia { get; set; }

    [Column("nivel")]
    [StringLength(50)]
    public string? Nivel { get; set; }

    [Column("cursos_o_seminarios1")]
    [StringLength(255)]
    public string? CursosOSeminarios1 { get; set; }

    [Column("duracion1")]
    [StringLength(30)]
    public string? Duracion1 { get; set; }

    [Column("cursos_o_seminarios2")]
    [StringLength(255)]
    public string? CursosOSeminarios2 { get; set; }

    [Column("duracion2")]
    [StringLength(30)]
    public string? Duracion2 { get; set; }

    [Column("cursos_o_seminarios3")]
    [StringLength(255)]
    public string? CursosOSeminarios3 { get; set; }

    [Column("duracion3")]
    [StringLength(30)]
    public string? Duracion3 { get; set; }

    [Column("cursos_o_seminarios4")]
    [StringLength(255)]
    public string? CursosOSeminarios4 { get; set; }

    [Column("duracion4")]
    [StringLength(30)]
    public string? Duracion4 { get; set; }

    [Column("cursos_o_seminarios5")]
    [StringLength(255)]
    public string? CursosOSeminarios5 { get; set; }

    [Column("duracion5")]
    [StringLength(30)]
    public string? Duracion5 { get; set; }

    [Column("organizacion1")]
    [StringLength(200)]
    public string? Organizacion1 { get; set; }

    [Column("cargo_tiempo_de_servicio1")]
    [StringLength(200)]
    public string? CargoTiempoDeServicio1 { get; set; }

    [Column("organizacion2")]
    [StringLength(200)]
    public string? Organizacion2 { get; set; }

    [Column("cargo_tiempo_de_servicio2")]
    [StringLength(200)]
    public string? CargoTiempoDeServicio2 { get; set; }

    [Column("organizacion3")]
    [StringLength(200)]
    public string? Organizacion3 { get; set; }

    [Column("cargo_tiempo_de_servicio3")]
    [StringLength(200)]
    public string? CargoTiempoDeServicio3 { get; set; }

    [Column("organizacion4")]
    [StringLength(200)]
    public string? Organizacion4 { get; set; }

    [Column("cargo_tiempo_de_servicio4")]
    [StringLength(200)]
    public string? CargoTiempoDeServicio4 { get; set; }

    [Column("cod_sede")]
    public int? CodSede { get; set; }

    [Column("cod_depto")]
    public int? CodDepto { get; set; }

    [Column("ubicacion_actual_del_colaborador")]
    public int? UbicacionActualDelColaborador { get; set; }

    [Column("nombre_completo")]
    [StringLength(100)]
    public string? NombreCompleto { get; set; }

    [Column("mama")]
    public bool Mama { get; set; }

    [Column("papa")]
    public bool Papa { get; set; }

    [Column("dincap")]
    public int? Dincap { get; set; }

    [Column("hincap", TypeName = "datetime")]
    public DateTime? Hincap { get; set; }

    [Column("dperm")]
    public int? Dperm { get; set; }

    [Column("hperm", TypeName = "datetime")]
    public DateTime? Hperm { get; set; }

    [Column("dcomp")]
    public int? Dcomp { get; set; }

    [Column("hcomp", TypeName = "datetime")]
    public DateTime? Hcomp { get; set; }

    [Column("dias_vacaciones")]
    public int? DiasVacaciones { get; set; }

    [Column("TARDANZAS")]
    public int? Tardanzas { get; set; }

    [Column("fecha_ingreso_labores (MM/DD/YYYY)", TypeName = "datetime")]
    public DateTime? FechaIngresoLaboresMmDdYyyy { get; set; }

    [Column("FICHA")]
    public bool Ficha { get; set; }

    [Column("fecha (MM/DD/YYYY)", TypeName = "datetime")]
    public DateTime? FechaMmDdYyyy { get; set; }

    [StringLength(100)]
    public string? Estatus { get; set; }

    [Column("año1")]
    public int? Año1 { get; set; }

    [Column("año2")]
    public int? Año2 { get; set; }

    [Column("año3")]
    public int? Año3 { get; set; }

    [Column("año4")]
    public int? Año4 { get; set; }

    [Column("Licencia o idoneidad")]
    [StringLength(255)]
    public string? LicenciaOIdoneidad { get; set; }

    [Column("año5")]
    public int? Año5 { get; set; }

    [Column("acreditado")]
    public bool Acreditado { get; set; }

    [Column("año")]
    public int? Año { get; set; }
}
