using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdelasCore.Negocio.Migrations.HorariosDocencia
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivacionHorarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anio = table.Column<int>(type: "int", nullable: false, defaultValue: 2000),
                    Periodo = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    Extension = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Activado = table.Column<int>(type: "int", nullable: false, defaultValue: -1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivacionHorarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Acuerdo_materia",
                columns: table => new
                {
                    Nomenclatura = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "N", comment: "identificacion del acuerdo"),
                    Fecha = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false, defaultValue: "N"),
                    Observacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false, defaultValue: "N"),
                    Titulo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "N", comment: "Hay veces que ademas de la nomenclatura o identif de plan, se adjunta un titulo que lo describe"),
                    Cod_carrera = table.Column<int>(type: "int", nullable: false),
                    plan_carrera = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "A")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Acuerdos_carreras",
                columns: table => new
                {
                    ID_Plan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_Plan = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false, defaultValue: "N"),
                    Acuerdo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false, defaultValue: "N"),
                    Cod_carrera = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acuerdos_carreras", x => x.ID_Plan);
                });

            migrationBuilder.CreateTable(
                name: "Bd_profesor",
                columns: table => new
                {
                    Cod_prof = table.Column<long>(type: "bigint", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Cedula = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    Nombre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Apellido = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Telefono = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    Telefono2 = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    Celular = table.Column<string>(type: "varchar(9)", unicode: false, maxLength: 9, nullable: true),
                    Seguro = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    annoingreso = table.Column<int>(type: "int", nullable: false),
                    Sexo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Provincia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Turnom = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Cod_especialidad = table.Column<long>(type: "bigint", nullable: false),
                    Cod_Tecnico = table.Column<int>(type: "int", nullable: true),
                    Cod_Licenciatura = table.Column<int>(type: "int", nullable: true),
                    Cod_Postgrado = table.Column<int>(type: "int", nullable: true),
                    Cod_Profesorado = table.Column<int>(type: "int", nullable: true),
                    Cod_Maestria = table.Column<int>(type: "int", nullable: true),
                    Cod_Doctorado = table.Column<int>(type: "int", nullable: true),
                    Cod_estudio = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Cod_perfeccionamiento = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Cod_ejecutoria = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Cod_publicaciones = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Cod_conferencias = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Cod_ponencias = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Puntaje = table.Column<int>(type: "int", nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(90)", unicode: false, maxLength: 90, nullable: true),
                    email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    habilitado = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Ano_periodo_entregar_listas = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    usuario = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: true),
                    Turnov = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    Turnon = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true),
                    fecha_trabajo = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    idioma1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    idioma2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cod_departamento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Bitacora_PR",
                columns: table => new
                {
                    ID_tbl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Materia = table.Column<int>(type: "int", nullable: true),
                    Cod_Materia_PR = table.Column<int>(type: "int", nullable: true),
                    Cod_Carrera = table.Column<int>(type: "int", nullable: true),
                    Estatus = table.Column<int>(type: "int", nullable: true, comment: "1. borró PR, 2. agregró PR"),
                    Operador = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Motivo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bitacora_PR", x => x.ID_tbl);
                });

            migrationBuilder.CreateTable(
                name: "Cambios_Horarios_Log",
                columns: table => new
                {
                    CambioHorarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CedulaAnterior = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    CedulaActual = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    CodCarrera = table.Column<int>(type: "int", nullable: false),
                    CodCurso = table.Column<int>(type: "int", nullable: false),
                    CodMateria = table.Column<int>(type: "int", nullable: false),
                    CodExtension = table.Column<int>(type: "int", nullable: false),
                    CodFacultad = table.Column<int>(type: "int", nullable: false),
                    Periodo = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cambios_Horarios_Log", x => x.CambioHorarioId);
                });

            migrationBuilder.CreateTable(
                name: "Carreras",
                columns: table => new
                {
                    cod_carrera = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_extension = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_facultad = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_escuela = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    carrera = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValue: "n"),
                    abrev_carrera = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    plan_carrera = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "A"),
                    Tipo_periodo = table.Column<int>(type: "int", nullable: false, defaultValue: 6),
                    Activa = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    Acuerdo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false, defaultValue: "N"),
                    Observacion = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true, defaultValue: "N"),
                    cod_facultad2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    cod_escuela2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    GradoId = table.Column<int>(type: "int", nullable: true),
                    Subgrado = table.Column<int>(type: "int", nullable: true, defaultValue: -1),
                    cod_tecnico = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Nivel = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    Estatus = table.Column<int>(type: "int", nullable: false, comment: "0: no promocionada 1: promocionada")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreras", x => x.cod_carrera);
                });

            migrationBuilder.CreateTable(
                name: "CarrerasTecnicos",
                columns: table => new
                {
                    Cod_Tecnico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tecnico = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    Abrev_Tecnico = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Activo = table.Column<int>(type: "int", nullable: true),
                    Acuerdo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GradoId = table.Column<int>(type: "int", nullable: true),
                    Subgrado = table.Column<int>(type: "int", nullable: true),
                    Cod_Carrera = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrerasTecnicos", x => x.Cod_Tecnico);
                });

            migrationBuilder.CreateTable(
                name: "Categoria_Profesores",
                columns: table => new
                {
                    Cod_Categoria_Profesor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Categoria_Profesor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Abreviatura = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false, defaultValue: "BD"),
                    Id_Tipo_Pago = table.Column<int>(type: "int", nullable: false, defaultValue: -1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria_Profesor", x => x.Cod_Categoria_Profesor);
                });

            migrationBuilder.CreateTable(
                name: "Clim_Lib_M_cursos_temp-1",
                columns: table => new
                {
                    M_cursosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_curso = table.Column<int>(type: "int", nullable: false),
                    cod_asignatura = table.Column<int>(type: "int", nullable: false),
                    asignatura = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    cod_profesor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false),
                    tope = table.Column<int>(type: "int", nullable: false),
                    minimo = table.Column<int>(type: "int", nullable: false),
                    bloqueado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cerrado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ver_en_informe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    id_asignatura = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    ano_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_extension_regional = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Clim_Lib_M_cursos_temp-2",
                columns: table => new
                {
                    M_cursosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_curso = table.Column<int>(type: "int", nullable: false),
                    cod_asignatura = table.Column<int>(type: "int", nullable: false),
                    asignatura = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    cod_profesor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false),
                    tope = table.Column<int>(type: "int", nullable: false),
                    minimo = table.Column<int>(type: "int", nullable: false),
                    bloqueado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cerrado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ver_en_informe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    id_asignatura = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    ano_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_extension_regional = table.Column<int>(type: "int", nullable: false),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    ced_profesor = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    apellido = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    cod_escuela = table.Column<int>(type: "int", nullable: false),
                    fechaasigdoc = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(((2000)-(1))-(1))"),
                    guidusuarioasigdoc = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "(NULL)"),
                    fechaasigpos = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(((2000)-(1))-(1))"),
                    guidusuarioasigpos = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "(NULL)")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Clim_Lib_M_grupos_temp-1",
                columns: table => new
                {
                    M_gruposID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    bloqueado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cerrado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ver_en_informe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    ano_matricula = table.Column<int>(type: "int", nullable: false),
                    mes_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_carrera = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_carrera = table.Column<int>(type: "int", nullable: false),
                    cod_extension_regional = table.Column<int>(type: "int", nullable: false),
                    primeringreso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Clim_Lib_M_grupos_temp-2",
                columns: table => new
                {
                    M_gruposID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    bloqueado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cerrado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ver_en_informe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    ano_matricula = table.Column<int>(type: "int", nullable: false),
                    mes_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_carrera = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_carrera = table.Column<int>(type: "int", nullable: false),
                    cod_extension_regional = table.Column<int>(type: "int", nullable: false),
                    primeringreso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_escuela = table.Column<int>(type: "int", nullable: false),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CodigosCursos",
                columns: table => new
                {
                    IdCurso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo_Curso = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    Cod_Extension = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    Periodo = table.Column<int>(type: "int", nullable: false),
                    TipoPeriodo = table.Column<int>(type: "int", nullable: false),
                    GradoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Condicion_salones",
                columns: table => new
                {
                    cod_condicion = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Constantes",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "Ninguno", comment: ""),
                    Valor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "Ninguno"),
                    Valor2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "Ninguno"),
                    Valor3 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Valor4 = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValue: 0.0m)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Constantes2",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "Ninguno", comment: ""),
                    Valor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "Ninguno"),
                    Valor2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "Ninguno"),
                    Valor3 = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Valor4 = table.Column<decimal>(type: "decimal(18,0)", nullable: true, defaultValue: 0.0m)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Constantes3",
                columns: table => new
                {
                    id_tabla = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ano = table.Column<int>(type: "int", nullable: true),
                    periodo = table.Column<int>(type: "int", nullable: true),
                    fecha_inicial_Sem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fecha_final_Sem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fecha_inicial_Post = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fecha_final_Post = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    version = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    periodo_post = table.Column<int>(type: "int", nullable: true),
                    actual = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "N"),
                    cerrado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cerradoEvaluacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    actualLibreta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    actualperiodoEvaluacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    id_curso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_grupo = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_curso = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_materia = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    materia_abreviada = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "n"),
                    materia_completa = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false, defaultValue: "n"),
                    ano = table.Column<int>(type: "int", nullable: false, defaultValue: 2007),
                    periodo = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    cod_profesor = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    ced_profesor = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false, defaultValue: "n"),
                    nombre = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValue: "POR"),
                    apellido = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false, defaultValue: "NOMBRAR"),
                    cod_turno = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValue: "n"),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    cantidad_estudiantes = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false, defaultValue: 3),
                    periodo_materia = table.Column<int>(type: "int", nullable: false, defaultValue: 10),
                    cod_financiero = table.Column<int>(type: "int", nullable: false, defaultValue: 10000),
                    dir_especial = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "DD"),
                    cod_grupo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "N"),
                    grupo = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "A"),
                    cod_deparatmento = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    cod_extension = table.Column<int>(type: "int", nullable: false, defaultValue: 8),
                    cod_facultad = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    cod_escuela = table.Column<int>(type: "int", nullable: true, defaultValue: 1),
                    cod_carrera = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    cod1 = table.Column<int>(type: "int", nullable: false, defaultValue: -1, comment: "La cantidad de semanas que realmente se va impartir este curso,si es -1, entonces se usan las semanas del periodo y se obvia la cantidad de este campo."),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValueSql: "((-1))"),
                    fechaasigdoc = table.Column<DateTime>(type: "datetime", nullable: true),
                    guidusuarioasigdoc = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    fechaasigpos = table.Column<DateTime>(type: "datetime", nullable: true),
                    guidusuarioasigpos = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ID_Posicion = table.Column<int>(type: "int", nullable: true, defaultValue: -1),
                    anio_vigente = table.Column<int>(type: "int", nullable: false, defaultValue: 2000)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.id_curso);
                });

            migrationBuilder.CreateTable(
                name: "Cursos_copia",
                columns: table => new
                {
                    id_curso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    cod_curso = table.Column<int>(type: "int", nullable: false),
                    cod_materia = table.Column<int>(type: "int", nullable: false),
                    materia_abreviada = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    materia_completa = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    periodo = table.Column<int>(type: "int", nullable: false),
                    cod_profesor = table.Column<int>(type: "int", nullable: false),
                    ced_profesor = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    apellido = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cantidad_estudiantes = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false),
                    periodo_materia = table.Column<int>(type: "int", nullable: false),
                    cod_financiero = table.Column<int>(type: "int", nullable: false),
                    dir_especial = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    cod_grupo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    grupo = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    cod_deparatmento = table.Column<int>(type: "int", nullable: false),
                    cod_extension = table.Column<int>(type: "int", nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_escuela = table.Column<int>(type: "int", nullable: true),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    cod1 = table.Column<int>(type: "int", nullable: false),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos_copia", x => x.id_curso);
                });

            migrationBuilder.CreateTable(
                name: "Cursos_copia2",
                columns: table => new
                {
                    id_curso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    cod_curso = table.Column<int>(type: "int", nullable: false),
                    cod_materia = table.Column<int>(type: "int", nullable: false),
                    materia_abreviada = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    materia_completa = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    periodo = table.Column<int>(type: "int", nullable: false),
                    cod_profesor = table.Column<int>(type: "int", nullable: false),
                    ced_profesor = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    apellido = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cantidad_estudiantes = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false),
                    periodo_materia = table.Column<int>(type: "int", nullable: false),
                    cod_financiero = table.Column<int>(type: "int", nullable: false),
                    dir_especial = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    cod_grupo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    grupo = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    cod_deparatmento = table.Column<int>(type: "int", nullable: false),
                    cod_extension = table.Column<int>(type: "int", nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_escuela = table.Column<int>(type: "int", nullable: true),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    cod1 = table.Column<int>(type: "int", nullable: false),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos_copia2", x => x.id_curso);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    cod_departamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_facultad = table.Column<int>(type: "int", nullable: true),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true, defaultValue: "N"),
                    descripcion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true, defaultValue: "N")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.cod_departamento);
                });

            migrationBuilder.CreateTable(
                name: "descripcion_periodos",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_descripcion_periodos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Dias",
                columns: table => new
                {
                    Numero_dia = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    Dia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Docente_CSV",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ced_profesor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    extension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    clave = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    version = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    activo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Plataforma = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente_CSV", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Edificios",
                columns: table => new
                {
                    codigo_edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValue: "n"),
                    cod_extension = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    ubicacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    cod_entidad = table.Column<int>(type: "int", nullable: false, defaultValue: -1)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    cod_entidad = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    ubicacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Escuelas",
                columns: table => new
                {
                    id_escuela = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_extension = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_facultad = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_escuela = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escuelas", x => x.id_escuela);
                });

            migrationBuilder.CreateTable(
                name: "Extensiones",
                columns: table => new
                {
                    cod_extension = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre_extension = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    provincia = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    distrito = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Facultades",
                columns: table => new
                {
                    cod_facultad = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    facultad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    cod_extension = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_Nivel = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    id_grupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ano_matricula = table.Column<int>(type: "int", nullable: true),
                    periodo_matricula = table.Column<int>(type: "int", nullable: true),
                    fecha_matricula = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cod_extension = table.Column<int>(type: "int", nullable: true),
                    cod_facultad = table.Column<int>(type: "int", nullable: true),
                    cod_escuela = table.Column<int>(type: "int", nullable: true),
                    cod_carrera = table.Column<int>(type: "int", nullable: true),
                    cod_grupo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    letra_grupo = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    semestre_grupo = table.Column<int>(type: "int", nullable: true),
                    turno = table.Column<int>(type: "int", nullable: true),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    estatus1 = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    estatus2 = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    cod_hor_plantilla = table.Column<int>(type: "int", nullable: true),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    cod1 = table.Column<int>(type: "int", nullable: true),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    cod_esp = table.Column<int>(type: "int", nullable: false, comment: "0: No; 1: Si *****\"código utilizado para las grupos de carreras fuera de periodo\"*****"),
                    turno2 = table.Column<int>(type: "int", nullable: true, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.id_grupo);
                });

            migrationBuilder.CreateTable(
                name: "Grupos_copia",
                columns: table => new
                {
                    id_grupo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ano_matricula = table.Column<int>(type: "int", nullable: true),
                    periodo_matricula = table.Column<int>(type: "int", nullable: true),
                    fecha_matricula = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cod_extension = table.Column<int>(type: "int", nullable: true),
                    cod_facultad = table.Column<int>(type: "int", nullable: true),
                    cod_escuela = table.Column<int>(type: "int", nullable: true),
                    cod_carrera = table.Column<int>(type: "int", nullable: true),
                    cod_grupo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    letra_grupo = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    semestre_grupo = table.Column<int>(type: "int", nullable: true),
                    turno = table.Column<int>(type: "int", nullable: true),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cod_hor_plantilla = table.Column<int>(type: "int", nullable: true),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    cod1 = table.Column<int>(type: "int", nullable: true),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos_copia", x => x.id_grupo);
                });

            migrationBuilder.CreateTable(
                name: "Grupos_especiales",
                columns: table => new
                {
                    Idr = table.Column<int>(type: "int", nullable: false),
                    Anio_actual = table.Column<int>(type: "int", nullable: true),
                    Periodo_actual = table.Column<int>(type: "int", nullable: true),
                    Grupo_actual = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cod_extension = table.Column<int>(type: "int", nullable: true),
                    cod_facultad = table.Column<int>(type: "int", nullable: true),
                    id_grupo_referencia = table.Column<int>(type: "int", nullable: true),
                    Grupo_anterior = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Anio_anterior = table.Column<int>(type: "int", nullable: true),
                    Periodo_anterior = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo_especial", x => x.Idr);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoCursos",
                columns: table => new
                {
                    id_curso = table.Column<int>(type: "int", nullable: false),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    cod_curso = table.Column<int>(type: "int", nullable: false),
                    cod_materia = table.Column<int>(type: "int", nullable: false),
                    materia_abreviada = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    materia_completa = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    periodo = table.Column<int>(type: "int", nullable: false),
                    cod_profesor = table.Column<int>(type: "int", nullable: false),
                    ced_profesor = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    apellido = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cantidad_estudiantes = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false),
                    periodo_materia = table.Column<int>(type: "int", nullable: false),
                    cod_financiero = table.Column<int>(type: "int", nullable: false),
                    dir_especial = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    cod_grupo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    grupo = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    cod_deparatmento = table.Column<int>(type: "int", nullable: false),
                    cod_extension = table.Column<int>(type: "int", nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_escuela = table.Column<int>(type: "int", nullable: true),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    cod1 = table.Column<int>(type: "int", nullable: false),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoCursos", x => x.id_curso);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoGrupos",
                columns: table => new
                {
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    ano_matricula = table.Column<int>(type: "int", nullable: true),
                    periodo_matricula = table.Column<int>(type: "int", nullable: true),
                    fecha_matricula = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    cod_extension = table.Column<int>(type: "int", nullable: true),
                    cod_facultad = table.Column<int>(type: "int", nullable: true),
                    cod_escuela = table.Column<int>(type: "int", nullable: true),
                    cod_carrera = table.Column<int>(type: "int", nullable: true),
                    cod_grupo = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    letra_grupo = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    semestre_grupo = table.Column<int>(type: "int", nullable: true),
                    turno = table.Column<int>(type: "int", nullable: true),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    cod_hor_plantilla = table.Column<int>(type: "int", nullable: true),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    cod1 = table.Column<int>(type: "int", nullable: true),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Hoja1$",
                columns: table => new
                {
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    status = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    conexión = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    id_horario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_grupo = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    id_curso = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_curso = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    abrev_materia = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false, defaultValue: "n"),
                    h_inicial = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    m_inicial = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    am_pm_i = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "n"),
                    h_final = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    m_final = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    am_pm_f = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "n"),
                    intermedio_minutos = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    numero_dia = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre_dia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "n"),
                    numero_hora = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValue: "n"),
                    tipo_hora_clase = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    nombre_tipo_clase = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    tipo_pago = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    cod_horario_plantilla = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod1 = table.Column<int>(type: "int", nullable: false, defaultValue: -1, comment: "En cantidad de semanas que debe darse, si es -1 se ajusta a lo señalado por periodo y se obvia la cantidad de este campo."),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValue: "n"),
                    ano = table.Column<int>(type: "int", nullable: true, defaultValue: 9999),
                    periodo = table.Column<int>(type: "int", nullable: true, defaultValue: 3),
                    fechamodificacion = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    guidusuario = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.id_horario);
                });

            migrationBuilder.CreateTable(
                name: "Horarios_copia",
                columns: table => new
                {
                    id_horario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    id_curso = table.Column<int>(type: "int", nullable: false),
                    cod_curso = table.Column<int>(type: "int", nullable: false),
                    abrev_materia = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    h_inicial = table.Column<int>(type: "int", nullable: false),
                    m_inicial = table.Column<int>(type: "int", nullable: false),
                    am_pm_i = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    h_final = table.Column<int>(type: "int", nullable: false),
                    m_final = table.Column<int>(type: "int", nullable: false),
                    am_pm_f = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    intermedio_minutos = table.Column<int>(type: "int", nullable: false),
                    numero_dia = table.Column<int>(type: "int", nullable: false),
                    nombre_dia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    numero_hora = table.Column<int>(type: "int", nullable: false),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    tipo_hora_clase = table.Column<int>(type: "int", nullable: false),
                    nombre_tipo_clase = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    tipo_pago = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cod_horario_plantilla = table.Column<int>(type: "int", nullable: false),
                    cod1 = table.Column<int>(type: "int", nullable: false),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    periodo = table.Column<int>(type: "int", nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios_copia2", x => x.id_horario);
                });

            migrationBuilder.CreateTable(
                name: "Horarios_copia1",
                columns: table => new
                {
                    id_horario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    id_curso = table.Column<int>(type: "int", nullable: false),
                    cod_curso = table.Column<int>(type: "int", nullable: false),
                    abrev_materia = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    h_inicial = table.Column<int>(type: "int", nullable: false),
                    m_inicial = table.Column<int>(type: "int", nullable: false),
                    am_pm_i = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    h_final = table.Column<int>(type: "int", nullable: false),
                    m_final = table.Column<int>(type: "int", nullable: false),
                    am_pm_f = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    intermedio_minutos = table.Column<int>(type: "int", nullable: false),
                    numero_dia = table.Column<int>(type: "int", nullable: false),
                    nombre_dia = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    numero_hora = table.Column<int>(type: "int", nullable: false),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    tipo_hora_clase = table.Column<int>(type: "int", nullable: false),
                    nombre_tipo_clase = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    tipo_pago = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    estatus1 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    estatus2 = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    cod_horario_plantilla = table.Column<int>(type: "int", nullable: false),
                    cod1 = table.Column<int>(type: "int", nullable: false),
                    cod2 = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios_copia", x => x.id_horario);
                });

            migrationBuilder.CreateTable(
                name: "Horarios_plantilla",
                columns: table => new
                {
                    cod_plantilla = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Horarios_plantilla_detalles",
                columns: table => new
                {
                    cod_plantilla = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    numero_hora = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    h_inicial = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    m_inicial = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    ampm_i = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "n"),
                    h_final = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    m_final = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    ampm_f = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "n"),
                    minutos_intermedio = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_extension = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios_plantilla_detalles", x => new { x.cod_plantilla, x.numero_hora });
                });

            migrationBuilder.CreateTable(
                name: "M_costos_fijos_grupos_TEMP",
                columns: table => new
                {
                    M_costos_fijos_gruposID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    cod_contenedor = table.Column<int>(type: "int", nullable: false),
                    cod_grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_extension = table.Column<int>(type: "int", nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_matricula = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_costos_fijos_grupos_TEMP", x => x.M_costos_fijos_gruposID);
                });

            migrationBuilder.CreateTable(
                name: "M_cursos",
                columns: table => new
                {
                    M_cursosID = table.Column<int>(type: "int", nullable: false),
                    cod_grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_curso = table.Column<int>(type: "int", nullable: false),
                    cod_asignatura = table.Column<int>(type: "int", nullable: false),
                    asignatura = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    cod_profesor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false),
                    tope = table.Column<int>(type: "int", nullable: false),
                    minimo = table.Column<int>(type: "int", nullable: false),
                    bloqueado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cerrado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ver_en_informe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    id_asignatura = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    ano_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_extension_regional = table.Column<int>(type: "int", nullable: false),
                    id_grupo = table.Column<int>(type: "int", nullable: false),
                    ced_profesor = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    apellido = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    cod_escuela = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "M_grupos",
                columns: table => new
                {
                    M_gruposID = table.Column<int>(type: "int", nullable: false),
                    cod_grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    grupo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_turno = table.Column<int>(type: "int", nullable: false),
                    bloqueado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cerrado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ver_en_informe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_facultad = table.Column<int>(type: "int", nullable: false),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    ano_matricula = table.Column<int>(type: "int", nullable: false),
                    mes_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_matricula = table.Column<int>(type: "int", nullable: false),
                    cod_periodo_carrera = table.Column<int>(type: "int", nullable: false),
                    tipo_periodo_carrera = table.Column<int>(type: "int", nullable: false),
                    cod_extension_regional = table.Column<int>(type: "int", nullable: false),
                    primeringreso = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    cod_escuela = table.Column<int>(type: "int", nullable: false),
                    salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Materias_por_carreras",
                columns: table => new
                {
                    id_materia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_materia = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    abreviatura = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    tipo_periodo = table.Column<int>(type: "int", nullable: false),
                    periodo = table.Column<int>(type: "int", nullable: false),
                    creditos = table.Column<int>(type: "int", nullable: false),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    cod_departamento = table.Column<int>(type: "int", nullable: false),
                    Horas_teoria = table.Column<int>(type: "int", nullable: false),
                    Horas_Lab = table.Column<int>(type: "int", nullable: false),
                    Horas_otros = table.Column<int>(type: "int", nullable: false),
                    Horas_total = table.Column<int>(type: "int", nullable: false),
                    Flag_prerequisitos = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    ID_Plan = table.Column<int>(type: "int", nullable: true),
                    cod_carrera2 = table.Column<int>(type: "int", nullable: false),
                    tecnico = table.Column<int>(type: "int", nullable: false),
                    estatus = table.Column<int>(type: "int", nullable: false, defaultValue: 1, comment: "1 - materia activa / 0 - materia desactivada"),
                    horas_practicas = table.Column<int>(type: "int", nullable: false, comment: "Estatus para las materias Prácticas Universitarias: 0 No tiene horas prácticas, 1 si tiene horas prácticas (Lic)"),
                    horaregistro = table.Column<DateTime>(type: "datetime", nullable: false, defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    operador = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "sistema")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Materias_Practicas",
                columns: table => new
                {
                    Idmateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_materia = table.Column<int>(type: "int", nullable: false),
                    Cod_carrera = table.Column<int>(type: "int", nullable: false),
                    Competencia_nivel_practica = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false, defaultValue: "N")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Materias_PreRequisitos",
                columns: table => new
                {
                    cod_materia = table.Column<int>(type: "int", nullable: false),
                    id_materia_asociada = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    plan_carrera = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "A"),
                    nombre_materia = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false, defaultValue: "N")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias_PreRequisitos", x => new { x.cod_materia, x.id_materia_asociada });
                });

            migrationBuilder.CreateTable(
                name: "Nivel_acceso",
                columns: table => new
                {
                    cod_acceso = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    descripcion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NivelDiplomados",
                columns: table => new
                {
                    IdNivelDip = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescripcionNivel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelDiplomados", x => x.IdNivelDip);
                });

            migrationBuilder.CreateTable(
                name: "Notas_carreras",
                columns: table => new
                {
                    Nomenclatura = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "N"),
                    Fecha = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false, defaultValue: "N"),
                    Firma_de = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "N"),
                    Resumen_contenido = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false, defaultValue: "N"),
                    Asunto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "N"),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    plan_carrera = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "A")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Notas_materia",
                columns: table => new
                {
                    Nomenclatura = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "N"),
                    Fecha = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "N"),
                    Firma_de = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "N"),
                    Resumen_contenido = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: false, defaultValue: "N"),
                    Asunto = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "N"),
                    cod_carrera = table.Column<int>(type: "int", nullable: false),
                    plan_carrera = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false, defaultValue: "A")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Numeros",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Observaciones_materia",
                columns: table => new
                {
                    id_materia = table.Column<int>(type: "int", nullable: false),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "Ninguna")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observaciones_materia", x => x.id_materia);
                });

            migrationBuilder.CreateTable(
                name: "OpcionesDePagos",
                columns: table => new
                {
                    OpcionDePagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpcionesDePagos", x => x.OpcionDePagoId);
                });

            migrationBuilder.CreateTable(
                name: "PeriodoPorDiplomados",
                columns: table => new
                {
                    IdPeriodoPorDiplomado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Periodo = table.Column<int>(type: "int", nullable: false),
                    codPeriodo = table.Column<int>(type: "int", nullable: false),
                    CodCarrera = table.Column<int>(type: "int", nullable: false),
                    DescripcionDiplomado = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoPorDiplomados", x => x.IdPeriodoPorDiplomado);
                });

            migrationBuilder.CreateTable(
                name: "Periodos",
                columns: table => new
                {
                    PeriodoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Periodo = table.Column<int>(type: "int", nullable: false),
                    CodPeriodo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradoId = table.Column<int>(type: "int", nullable: false, defaultValue: -1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodos", x => x.PeriodoId);
                });

            migrationBuilder.CreateTable(
                name: "Periodos_academicos",
                columns: table => new
                {
                    Cod_tipo_periodo = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Abreviado = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "N")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periodos_academicos", x => new { x.Cod_tipo_periodo, x.Numero });
                });

            migrationBuilder.CreateTable(
                name: "Periodos_vigentes",
                columns: table => new
                {
                    Ano_vigente = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    periodo_semestre = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    periodo_cuatrimestre = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    periodo_modulo = table.Column<int>(type: "int", nullable: false, defaultValue: -1)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    COD_SEDE = table.Column<int>(type: "int", nullable: true),
                    COD_FACULT = table.Column<int>(type: "int", nullable: true),
                    COD_ESCUEL = table.Column<int>(type: "int", nullable: true),
                    COD_CARRER = table.Column<int>(type: "int", nullable: true),
                    CARRERA = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NOMBRE_COR = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Salones",
                columns: table => new
                {
                    cod_salon = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    cod_edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false, defaultValue: "n"),
                    cod_extension = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    nombre_salon = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    ubicacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    tipo_salon = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    condiciones = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    GG = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Salones_choques",
                columns: table => new
                {
                    numero_dia = table.Column<int>(type: "int", nullable: false),
                    numero_hora = table.Column<int>(type: "int", nullable: false),
                    salon = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    edificio = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Expr1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Sem_mat",
                columns: table => new
                {
                    IdSemMat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom_sem_materia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Codigo = table.Column<int>(type: "int", nullable: true),
                    Cod_carrera = table.Column<int>(type: "int", nullable: true),
                    Periodo = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    TipoPeriodo = table.Column<int>(type: "int", nullable: false, defaultValue: 4),
                    GradoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sem_mat", x => x.IdSemMat);
                });

            migrationBuilder.CreateTable(
                name: "Sesiones",
                columns: table => new
                {
                    id_sesion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    tablas_afectadas = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    tipo_de_operaciones = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    id_usuario = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    maquina = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    macadress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    ip = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n"),
                    fecha = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "n"),
                    hora = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SubTiposGrados",
                columns: table => new
                {
                    SubTipoGradoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoGrado = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTiposGrados", x => x.SubTipoGradoId);
                });

            migrationBuilder.CreateTable(
                name: "TablaModel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    firstname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    course1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cod_asignatura1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    course2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cod_asignatura2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    course3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cod_asignatura3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    course4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cod_asignatura4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Temp_Doc3Anios",
                columns: table => new
                {
                    Id_Doc = table.Column<int>(type: "int", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempD1",
                columns: table => new
                {
                    cedprofe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nomprofe = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    apeprofe = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    codext = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempD2",
                columns: table => new
                {
                    cedprofe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nomprofe = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    apeprofe = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    codext = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempDocentes_PendRevisar",
                columns: table => new
                {
                    Ced_profe = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TempoDoceSS3A1",
                columns: table => new
                {
                    Id1 = table.Column<int>(type: "int", nullable: true),
                    cedula1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Cod_sede1 = table.Column<int>(type: "int", nullable: true),
                    Sede1 = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TemporalDoceSS3A",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CodSede = table.Column<int>(type: "int", nullable: true),
                    Sede = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tipo_docente",
                columns: table => new
                {
                    cod_tipo_docente = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    descripcion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tipo_horaclase",
                columns: table => new
                {
                    cod_tipo_hora = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    descripcion = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "n"),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tipo_pago",
                columns: table => new
                {
                    cod_tipo = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    descripcion = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Pagos",
                columns: table => new
                {
                    Id_Tipo_Pago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false, defaultValue: "n"),
                    Monto_Horas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Monto_Vacaciones = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo_Estudio = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    SubTipoGrado = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    Nivel = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Pagos", x => x.Id_Tipo_Pago);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_periodos",
                columns: table => new
                {
                    Cod_periodo = table.Column<int>(type: "int", nullable: false, defaultValue: 6),
                    descripcion = table.Column<string>(type: "char(15)", unicode: false, fixedLength: true, maxLength: 15, nullable: false, defaultValue: "Semestre")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TiposGrados",
                columns: table => new
                {
                    GradoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGrado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposGrados", x => x.GradoId);
                });

            migrationBuilder.CreateTable(
                name: "TokenDocentes",
                columns: table => new
                {
                    Sede = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Cedula = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DNI2 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValue: "N")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Turnos",
                columns: table => new
                {
                    cod_turno = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    nombre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false, defaultValue: "n"),
                    abreviado = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false, defaultValue: "n"),
                    observacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false, defaultValue: "n")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuario = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    password = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    nombre = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    apellido = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    cedula = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false, defaultValue: "n"),
                    entidad_labora = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    ubicacion_fisica = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n"),
                    maquina = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    macadress = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    ip = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    cargo = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    funciones = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false, defaultValue: "n"),
                    nivel_acceso = table.Column<int>(type: "int", nullable: false, defaultValue: -1, comment: "0 no entra, 1 consulta, 5 operativo , 6 administrador"),
                    fecha_creacion = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false, defaultValue: "n"),
                    observacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false, defaultValue: "n"),
                    creador_cuenta = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false, defaultValue: "n"),
                    facultad = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    escuela = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    carreras = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    extension = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    guidusuario = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    codunidad = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "ID_CURSONOC3",
                table: "Cursos",
                columns: new[] { "ano", "periodo", "ced_profesor" });

            migrationBuilder.CreateIndex(
                name: "ID_CursosNOC",
                table: "Cursos",
                columns: new[] { "cod_curso", "ano", "periodo", "ced_profesor" });

            migrationBuilder.CreateIndex(
                name: "ID_CURSOSNONC",
                table: "Cursos",
                columns: new[] { "ano", "cod_carrera" });

            migrationBuilder.CreateIndex(
                name: "ID_cod_extension",
                table: "Extensiones",
                column: "cod_extension")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "ID_cod_facultad",
                table: "Facultades",
                column: "cod_facultad")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "ID_GrupoNONC1",
                table: "Grupos",
                columns: new[] { "ano_matricula", "periodo_matricula", "cod_extension", "cod_carrera" });

            migrationBuilder.CreateIndex(
                name: "ID_IDCURSOHorario",
                table: "Horarios",
                column: "id_curso");

            migrationBuilder.CreateIndex(
                name: "ID_MXCNOC1",
                table: "Materias_por_carreras",
                columns: new[] { "cod_carrera", "estatus" });

            migrationBuilder.CreateIndex(
                name: "ID_cod_turno",
                table: "Turnos",
                column: "cod_turno")
                .Annotation("SqlServer:Clustered", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivacionHorarios");

            migrationBuilder.DropTable(
                name: "Acuerdo_materia");

            migrationBuilder.DropTable(
                name: "Acuerdos_carreras");

            migrationBuilder.DropTable(
                name: "Bd_profesor");

            migrationBuilder.DropTable(
                name: "Bitacora_PR");

            migrationBuilder.DropTable(
                name: "Cambios_Horarios_Log");

            migrationBuilder.DropTable(
                name: "Carreras");

            migrationBuilder.DropTable(
                name: "CarrerasTecnicos");

            migrationBuilder.DropTable(
                name: "Categoria_Profesores");

            migrationBuilder.DropTable(
                name: "Clim_Lib_M_cursos_temp-1");

            migrationBuilder.DropTable(
                name: "Clim_Lib_M_cursos_temp-2");

            migrationBuilder.DropTable(
                name: "Clim_Lib_M_grupos_temp-1");

            migrationBuilder.DropTable(
                name: "Clim_Lib_M_grupos_temp-2");

            migrationBuilder.DropTable(
                name: "CodigosCursos");

            migrationBuilder.DropTable(
                name: "Condicion_salones");

            migrationBuilder.DropTable(
                name: "Constantes");

            migrationBuilder.DropTable(
                name: "Constantes2");

            migrationBuilder.DropTable(
                name: "Constantes3");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Cursos_copia");

            migrationBuilder.DropTable(
                name: "Cursos_copia2");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "descripcion_periodos");

            migrationBuilder.DropTable(
                name: "Dias");

            migrationBuilder.DropTable(
                name: "Docente_CSV");

            migrationBuilder.DropTable(
                name: "Edificios");

            migrationBuilder.DropTable(
                name: "Entidades");

            migrationBuilder.DropTable(
                name: "Escuelas");

            migrationBuilder.DropTable(
                name: "Extensiones");

            migrationBuilder.DropTable(
                name: "Facultades");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Grupos_copia");

            migrationBuilder.DropTable(
                name: "Grupos_especiales");

            migrationBuilder.DropTable(
                name: "HistoricoCursos");

            migrationBuilder.DropTable(
                name: "HistoricoGrupos");

            migrationBuilder.DropTable(
                name: "Hoja1$");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Horarios_copia");

            migrationBuilder.DropTable(
                name: "Horarios_copia1");

            migrationBuilder.DropTable(
                name: "Horarios_plantilla");

            migrationBuilder.DropTable(
                name: "Horarios_plantilla_detalles");

            migrationBuilder.DropTable(
                name: "M_costos_fijos_grupos_TEMP");

            migrationBuilder.DropTable(
                name: "M_cursos");

            migrationBuilder.DropTable(
                name: "M_grupos");

            migrationBuilder.DropTable(
                name: "Materias_por_carreras");

            migrationBuilder.DropTable(
                name: "Materias_Practicas");

            migrationBuilder.DropTable(
                name: "Materias_PreRequisitos");

            migrationBuilder.DropTable(
                name: "Nivel_acceso");

            migrationBuilder.DropTable(
                name: "NivelDiplomados");

            migrationBuilder.DropTable(
                name: "Notas_carreras");

            migrationBuilder.DropTable(
                name: "Notas_materia");

            migrationBuilder.DropTable(
                name: "Numeros");

            migrationBuilder.DropTable(
                name: "Observaciones_materia");

            migrationBuilder.DropTable(
                name: "OpcionesDePagos");

            migrationBuilder.DropTable(
                name: "PeriodoPorDiplomados");

            migrationBuilder.DropTable(
                name: "Periodos");

            migrationBuilder.DropTable(
                name: "Periodos_academicos");

            migrationBuilder.DropTable(
                name: "Periodos_vigentes");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "Salones");

            migrationBuilder.DropTable(
                name: "Salones_choques");

            migrationBuilder.DropTable(
                name: "Sem_mat");

            migrationBuilder.DropTable(
                name: "Sesiones");

            migrationBuilder.DropTable(
                name: "SubTiposGrados");

            migrationBuilder.DropTable(
                name: "TablaModel");

            migrationBuilder.DropTable(
                name: "Temp_Doc3Anios");

            migrationBuilder.DropTable(
                name: "TempD1");

            migrationBuilder.DropTable(
                name: "TempD2");

            migrationBuilder.DropTable(
                name: "TempDocentes_PendRevisar");

            migrationBuilder.DropTable(
                name: "TempoDoceSS3A1");

            migrationBuilder.DropTable(
                name: "TemporalDoceSS3A");

            migrationBuilder.DropTable(
                name: "Tipo_docente");

            migrationBuilder.DropTable(
                name: "Tipo_horaclase");

            migrationBuilder.DropTable(
                name: "Tipo_pago");

            migrationBuilder.DropTable(
                name: "Tipo_Pagos");

            migrationBuilder.DropTable(
                name: "Tipo_periodos");

            migrationBuilder.DropTable(
                name: "TiposGrados");

            migrationBuilder.DropTable(
                name: "TokenDocentes");

            migrationBuilder.DropTable(
                name: "Turnos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
