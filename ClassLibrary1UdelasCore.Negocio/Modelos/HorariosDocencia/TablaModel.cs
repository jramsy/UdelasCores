using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.HorariosDocencia;

public partial class TablaModel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("username")]
    [StringLength(50)]
    public string? Username { get; set; }

    [Column("password")]
    [StringLength(50)]
    public string? Password { get; set; }

    [Column("firstname")]
    [StringLength(50)]
    public string? Firstname { get; set; }

    [Column("lastname")]
    [StringLength(50)]
    public string? Lastname { get; set; }

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("course1")]
    [StringLength(50)]
    public string? Course1 { get; set; }

    [Column("cod_asignatura1")]
    [StringLength(50)]
    public string? CodAsignatura1 { get; set; }

    [Column("course2")]
    [StringLength(50)]
    public string? Course2 { get; set; }

    [Column("cod_asignatura2")]
    [StringLength(50)]
    public string? CodAsignatura2 { get; set; }

    [Column("course3")]
    [StringLength(50)]
    public string? Course3 { get; set; }

    [Column("cod_asignatura3")]
    [StringLength(50)]
    public string? CodAsignatura3 { get; set; }

    [Column("course4")]
    [StringLength(50)]
    public string? Course4 { get; set; }

    [Column("cod_asignatura4")]
    [StringLength(50)]
    public string? CodAsignatura4 { get; set; }
}
