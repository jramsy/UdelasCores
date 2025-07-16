using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UdelasCore.Negocio.Modelos.Modelo_Horario;

public partial class HorarioDbContext : DbContext
{
    public HorarioDbContext()
    {
    }

    public HorarioDbContext(DbContextOptions<HorarioDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActivacionHorario> ActivacionHorarios { get; set; }

    public virtual DbSet<AcuerdoMaterium> AcuerdoMateria { get; set; }

    public virtual DbSet<AcuerdosCarrera> AcuerdosCarreras { get; set; }

    public virtual DbSet<AuditoriaUsuarioHorario> AuditoriaUsuarioHorarios { get; set; }

    public virtual DbSet<BdProfesor> BdProfesors { get; set; }

    public virtual DbSet<BitacoraPr> BitacoraPrs { get; set; }

    public virtual DbSet<CambiosHorariosLog> CambiosHorariosLogs { get; set; }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<CarrerasTecnico> CarrerasTecnicos { get; set; }

    public virtual DbSet<CategoriaProfesore> CategoriaProfesores { get; set; }

    public virtual DbSet<ClimLibMCursosTemp1> ClimLibMCursosTemp1s { get; set; }

    public virtual DbSet<ClimLibMCursosTemp2> ClimLibMCursosTemp2s { get; set; }

    public virtual DbSet<ClimLibMGruposTemp1> ClimLibMGruposTemp1s { get; set; }

    public virtual DbSet<ClimLibMGruposTemp2> ClimLibMGruposTemp2s { get; set; }

    public virtual DbSet<CodigosCurso> CodigosCursos { get; set; }

    public virtual DbSet<CondicionSalone> CondicionSalones { get; set; }

    public virtual DbSet<Constante> Constantes { get; set; }

    public virtual DbSet<Constantes2> Constantes2s { get; set; }

    public virtual DbSet<Constantes3> Constantes3s { get; set; }

    public virtual DbSet<Csvdocente> Csvdocentes { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<CursoOficialCruceMatriculadaPanama> CursoOficialCruceMatriculadaPanamas { get; set; }

    public virtual DbSet<CursosCopia2> CursosCopia2s { get; set; }

    public virtual DbSet<CursosCopium> CursosCopia { get; set; }

    public virtual DbSet<CursosOficialesXPeriodo> CursosOficialesXPeriodos { get; set; }

    public virtual DbSet<CursosXGrupo> CursosXGrupos { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DescripcionPeriodo> DescripcionPeriodos { get; set; }

    public virtual DbSet<Dia> Dias { get; set; }

    public virtual DbSet<DocenteConHor3Anio> DocenteConHor3Anios { get; set; }

    public virtual DbSet<DocenteCsv> DocenteCsvs { get; set; }

    public virtual DbSet<Docentes2016> Docentes2016s { get; set; }

    public virtual DbSet<Docentes2017> Docentes2017s { get; set; }

    public virtual DbSet<Docentes2018> Docentes2018s { get; set; }

    public virtual DbSet<DocentesNuevos20182> DocentesNuevos20182s { get; set; }

    public virtual DbSet<DocentesXCuenta> DocentesXCuentas { get; set; }

    public virtual DbSet<Edificio> Edificios { get; set; }

    public virtual DbSet<Emailcorregir> Emailcorregirs { get; set; }

    public virtual DbSet<Entidade> Entidades { get; set; }

    public virtual DbSet<Escuela> Escuelas { get; set; }

    public virtual DbSet<Extensione> Extensiones { get; set; }

    public virtual DbSet<Facultade> Facultades { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<GrupoCursoLibretum> GrupoCursoLibreta { get; set; }

    public virtual DbSet<GruposChoque> GruposChoques { get; set; }

    public virtual DbSet<GruposCopium> GruposCopia { get; set; }

    public virtual DbSet<GruposEspeciale> GruposEspeciales { get; set; }

    public virtual DbSet<HistoricoCurso> HistoricoCursos { get; set; }

    public virtual DbSet<HistoricoGrupo> HistoricoGrupos { get; set; }

    public virtual DbSet<Hoja1> Hoja1s { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<HorarioTipoPago> HorarioTipoPagos { get; set; }

    public virtual DbSet<HorariosCopia1> HorariosCopia1s { get; set; }

    public virtual DbSet<HorariosCopium> HorariosCopia { get; set; }

    public virtual DbSet<HorariosPlantilla> HorariosPlantillas { get; set; }

    public virtual DbSet<HorariosPlantillaDetalle> HorariosPlantillaDetalles { get; set; }

    public virtual DbSet<ListaCursoOficialesPma> ListaCursoOficialesPmas { get; set; }

    public virtual DbSet<ListaCursosColegiadasPma> ListaCursosColegiadasPmas { get; set; }

    public virtual DbSet<ListadoAnioMayorDocente> ListadoAnioMayorDocentes { get; set; }

    public virtual DbSet<LsAmAm> LsAmAms { get; set; }

    public virtual DbSet<LsAmAmCarga> LsAmAmCargas { get; set; }

    public virtual DbSet<LsAmPm> LsAmPms { get; set; }

    public virtual DbSet<LsAmPmCarga> LsAmPmCargas { get; set; }

    public virtual DbSet<LsDocentesPorCarga> LsDocentesPorCargas { get; set; }

    public virtual DbSet<LsDocentesPorPago> LsDocentesPorPagos { get; set; }

    public virtual DbSet<LsPmPmMayora4> LsPmPmMayora4s { get; set; }

    public virtual DbSet<LsPmPmMayora4Carga> LsPmPmMayora4Cargas { get; set; }

    public virtual DbSet<LsPmPmMenora4> LsPmPmMenora4s { get; set; }

    public virtual DbSet<LsPmPmMenora4Carga> LsPmPmMenora4Cargas { get; set; }

    public virtual DbSet<MCostosFijosGruposTemp> MCostosFijosGruposTemps { get; set; }

    public virtual DbSet<MCurso> MCursos { get; set; }

    public virtual DbSet<MGrupo> MGrupos { get; set; }

    public virtual DbSet<MatPoCarreraFiltro> MatPoCarreraFiltros { get; set; }

    public virtual DbSet<Matcar> Matcars { get; set; }

    public virtual DbSet<MateriasParaVerificarTecnico> MateriasParaVerificarTecnicos { get; set; }

    public virtual DbSet<MateriasPorCarrera> MateriasPorCarreras { get; set; }

    public virtual DbSet<MateriasPractica> MateriasPracticas { get; set; }

    public virtual DbSet<MateriasPreRequisito> MateriasPreRequisitos { get; set; }

    public virtual DbSet<NivelAcceso> NivelAccesos { get; set; }

    public virtual DbSet<NivelDiplomado> NivelDiplomados { get; set; }

    public virtual DbSet<Notanoentregadum> Notanoentregada { get; set; }

    public virtual DbSet<NotasCarrera> NotasCarreras { get; set; }

    public virtual DbSet<NotasMaterium> NotasMateria { get; set; }

    public virtual DbSet<Numero> Numeros { get; set; }

    public virtual DbSet<ObservacionesMaterium> ObservacionesMateria { get; set; }

    public virtual DbSet<OpcionesDePago> OpcionesDePagos { get; set; }

    public virtual DbSet<Parte1Reportesubhumano> Parte1Reportesubhumanos { get; set; }

    public virtual DbSet<Parte2Reportesubhumano> Parte2Reportesubhumanos { get; set; }

    public virtual DbSet<Periodo> Periodos { get; set; }

    public virtual DbSet<PeriodoPorDiplomado> PeriodoPorDiplomados { get; set; }

    public virtual DbSet<PeriodosAcademico> PeriodosAcademicos { get; set; }

    public virtual DbSet<PeriodosVigente> PeriodosVigentes { get; set; }

    public virtual DbSet<ProfesoresEvaluacionCurso> ProfesoresEvaluacionCursos { get; set; }

    public virtual DbSet<Resultado> Resultados { get; set; }

    public virtual DbSet<Salone> Salones { get; set; }

    public virtual DbSet<SalonesChoque> SalonesChoques { get; set; }

    public virtual DbSet<SalonesChoque1> SalonesChoques1 { get; set; }

    public virtual DbSet<SemMat> SemMats { get; set; }

    public virtual DbSet<Sesione> Sesiones { get; set; }

    public virtual DbSet<SubTiposGrado> SubTiposGrados { get; set; }

    public virtual DbSet<T3Horario> T3Horarios { get; set; }

    public virtual DbSet<TablaModel> TablaModels { get; set; }

    public virtual DbSet<TempD1> TempD1s { get; set; }

    public virtual DbSet<TempD2> TempD2s { get; set; }

    public virtual DbSet<TempDoc3Anio> TempDoc3Anios { get; set; }

    public virtual DbSet<TempDocentesPendRevisar> TempDocentesPendRevisars { get; set; }

    public virtual DbSet<TempoDoceSs3a1> TempoDoceSs3a1s { get; set; }

    public virtual DbSet<TemporalDoceSs3a> TemporalDoceSs3as { get; set; }

    public virtual DbSet<TipoDocente> TipoDocentes { get; set; }

    public virtual DbSet<TipoHoraclase> TipoHoraclases { get; set; }

    public virtual DbSet<TipoPago> TipoPagos { get; set; }

    public virtual DbSet<TipoPago1> TipoPagos1 { get; set; }

    public virtual DbSet<TipoPeriodo> TipoPeriodos { get; set; }

    public virtual DbSet<TiposGrado> TiposGrados { get; set; }

    public virtual DbSet<TokenDocente> TokenDocentes { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VerificarGruposCantEstPma> VerificarGruposCantEstPmas { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<View2> View2s { get; set; }

    public virtual DbSet<View3> View3s { get; set; }

    public virtual DbSet<View4l> View4ls { get; set; }

    public virtual DbSet<ViewCantidadHorasCurso> ViewCantidadHorasCursos { get; set; }

    public virtual DbSet<ViewConPostgrado> ViewConPostgrados { get; set; }

    public virtual DbSet<ViewCuentasCreadasXcorte> ViewCuentasCreadasXcortes { get; set; }

    public virtual DbSet<ViewCursosnogendpc2023> ViewCursosnogendpc2023s { get; set; }

    public virtual DbSet<ViewDoc3A> ViewDoc3As { get; set; }

    public virtual DbSet<ViewDoc3Aa> ViewDoc3Aas { get; set; }

    public virtual DbSet<ViewDocent20222023> ViewDocent20222023s { get; set; }

    public virtual DbSet<ViewDocent2024> ViewDocent2024s { get; set; }

    public virtual DbSet<ViewDocente2023> ViewDocente2023s { get; set; }

    public virtual DbSet<ViewDocenteVotantesUlt3Anio> ViewDocenteVotantesUlt3Anios { get; set; }

    public virtual DbSet<ViewDocentesPrelVoto24> ViewDocentesPrelVoto24s { get; set; }

    public virtual DbSet<ViewDocentesXCuenta> ViewDocentesXCuentas { get; set; }

    public virtual DbSet<ViewHorariosCurso> ViewHorariosCursos { get; set; }

    public virtual DbSet<ViewIltec1> ViewIltec1s { get; set; }

    public virtual DbSet<ViewIltec2> ViewIltec2s { get; set; }

    public virtual DbSet<ViewMateriasXcarreraSemestre> ViewMateriasXcarreraSemestres { get; set; }

    public virtual DbSet<ViewNumCar> ViewNumCars { get; set; }

    public virtual DbSet<ViewPorAutorizarConHorariosTurno> ViewPorAutorizarConHorariosTurnos { get; set; }

    public virtual DbSet<ViewPreliFinalDoce2024> ViewPreliFinalDoce2024s { get; set; }

    public virtual DbSet<ViewSinPostgrado> ViewSinPostgrados { get; set; }

    public virtual DbSet<ViewUlt3AnioV2> ViewUlt3AnioV2s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Horarios Docencia;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AI");

        modelBuilder.Entity<ActivacionHorario>(entity =>
        {
            entity.Property(e => e.Activado).HasDefaultValue(-1);
            entity.Property(e => e.Anio).HasDefaultValue(2000);
            entity.Property(e => e.Extension).HasDefaultValue(1);
            entity.Property(e => e.Periodo).HasDefaultValue(-1);
        });

        modelBuilder.Entity<AcuerdoMaterium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Acuerdo_materia");

            entity.Property(e => e.CodCarrera).HasColumnName("Cod_carrera");
            entity.Property(e => e.Fecha)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.Nomenclatura)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasComment("identificacion del acuerdo");
            entity.Property(e => e.Observacion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .HasColumnName("plan_carrera");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasComment("Hay veces que ademas de la nomenclatura o identif de plan, se adjunta un titulo que lo describe");
        });

        modelBuilder.Entity<AcuerdosCarrera>(entity =>
        {
            entity.HasKey(e => e.IdPlan);

            entity.ToTable("Acuerdos_carreras");

            entity.Property(e => e.IdPlan).HasColumnName("ID_Plan");
            entity.Property(e => e.Acuerdo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.CodCarrera).HasColumnName("Cod_carrera");
            entity.Property(e => e.NomPlan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("Nom_Plan");
        });

        modelBuilder.Entity<AuditoriaUsuarioHorario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AuditoriaUsuarioHorario");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Email)
                .HasMaxLength(256)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Escuela).HasColumnName("escuela");
            entity.Property(e => e.Extension).HasColumnName("extension");
            entity.Property(e => e.Facultad).HasColumnName("facultad");
            entity.Property(e => e.Guidusuario).HasColumnName("guidusuario");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.NivelAcceso).HasColumnName("nivel_acceso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.RoleName)
                .HasMaxLength(256)
                .UseCollation("Modern_Spanish_CI_AS");
        });

        modelBuilder.Entity<BdProfesor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bd_profesor");

            entity.Property(e => e.Annoingreso).HasColumnName("annoingreso");
            entity.Property(e => e.AnoPeriodoEntregarListas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ano_periodo_entregar_listas");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cedula)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.CodConferencias)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cod_conferencias");
            entity.Property(e => e.CodDepartamento).HasColumnName("cod_departamento");
            entity.Property(e => e.CodDoctorado).HasColumnName("Cod_Doctorado");
            entity.Property(e => e.CodEjecutoria)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cod_ejecutoria");
            entity.Property(e => e.CodEspecialidad).HasColumnName("Cod_especialidad");
            entity.Property(e => e.CodEstudio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cod_estudio");
            entity.Property(e => e.CodLicenciatura).HasColumnName("Cod_Licenciatura");
            entity.Property(e => e.CodMaestria).HasColumnName("Cod_Maestria");
            entity.Property(e => e.CodPerfeccionamiento)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cod_perfeccionamiento");
            entity.Property(e => e.CodPonencias)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cod_ponencias");
            entity.Property(e => e.CodPostgrado).HasColumnName("Cod_Postgrado");
            entity.Property(e => e.CodProf).HasColumnName("Cod_prof");
            entity.Property(e => e.CodProfesorado).HasColumnName("Cod_Profesorado");
            entity.Property(e => e.CodPublicaciones)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Cod_publicaciones");
            entity.Property(e => e.CodTecnico).HasColumnName("Cod_Tecnico");
            entity.Property(e => e.Direccion)
                .HasMaxLength(90)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaTrabajo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("fecha_trabajo");
            entity.Property(e => e.Habilitado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("habilitado");
            entity.Property(e => e.Idioma1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idioma1");
            entity.Property(e => e.Idioma2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("idioma2");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Provincia)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Seguro)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Telefono2)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Turnom)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Turnon)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Turnov)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<BitacoraPr>(entity =>
        {
            entity.HasKey(e => e.IdTbl);

            entity.ToTable("Bitacora_PR");

            entity.Property(e => e.IdTbl).HasColumnName("ID_tbl");
            entity.Property(e => e.CodCarrera).HasColumnName("Cod_Carrera");
            entity.Property(e => e.CodMateriaPr).HasColumnName("Cod_Materia_PR");
            entity.Property(e => e.Estatus).HasComment("1. borró PR, 2. agregró PR");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.IdMateria).HasColumnName("ID_Materia");
            entity.Property(e => e.Motivo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Operador)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CambiosHorariosLog>(entity =>
        {
            entity.HasKey(e => e.CambioHorarioId);

            entity.ToTable("Cambios_Horarios_Log");

            entity.Property(e => e.CedulaActual).HasMaxLength(13);
            entity.Property(e => e.CedulaAnterior).HasMaxLength(13);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Usuario).HasMaxLength(50);
        });

        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.CodCarrera);

            entity.Property(e => e.CodCarrera)
                .HasDefaultValue(-1)
                .HasColumnName("cod_carrera");
            entity.Property(e => e.AbrevCarrera)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("abrev_carrera");
            entity.Property(e => e.Activa).HasDefaultValue(1);
            entity.Property(e => e.Acuerdo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.Carrera1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("carrera");
            entity.Property(e => e.CodEscuela)
                .HasDefaultValue(-1)
                .HasColumnName("cod_escuela");
            entity.Property(e => e.CodEscuela2)
                .HasDefaultValue(0)
                .HasColumnName("cod_escuela2");
            entity.Property(e => e.CodExtension)
                .HasDefaultValue(-1)
                .HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad)
                .HasDefaultValue(-1)
                .HasColumnName("cod_facultad");
            entity.Property(e => e.CodFacultad2)
                .HasDefaultValue(0)
                .HasColumnName("cod_facultad2");
            entity.Property(e => e.CodTecnico)
                .HasDefaultValue(0)
                .HasColumnName("cod_tecnico");
            entity.Property(e => e.Estatus).HasComment("0: no promocionada 1: promocionada");
            entity.Property(e => e.Nivel).HasDefaultValue(1);
            entity.Property(e => e.Observacion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .HasColumnName("plan_carrera");
            entity.Property(e => e.Subgrado).HasDefaultValue(-1);
            entity.Property(e => e.TipoPeriodo)
                .HasDefaultValue(6)
                .HasColumnName("Tipo_periodo");
        });

        modelBuilder.Entity<CarrerasTecnico>(entity =>
        {
            entity.HasKey(e => e.CodTecnico);

            entity.Property(e => e.CodTecnico).HasColumnName("Cod_Tecnico");
            entity.Property(e => e.AbrevTecnico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Abrev_Tecnico");
            entity.Property(e => e.Acuerdo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodCarrera).HasColumnName("Cod_Carrera");
            entity.Property(e => e.Tecnico)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CategoriaProfesore>(entity =>
        {
            entity.HasKey(e => e.CodCategoriaProfesor).HasName("PK_Categoria_Profesor");

            entity.ToTable("Categoria_Profesores");

            entity.Property(e => e.CodCategoriaProfesor).HasColumnName("Cod_Categoria_Profesor");
            entity.Property(e => e.Abreviatura)
                .HasMaxLength(10)
                .HasDefaultValue("BD")
                .IsFixedLength();
            entity.Property(e => e.IdTipoPago)
                .HasDefaultValue(-1)
                .HasColumnName("Id_Tipo_Pago");
            entity.Property(e => e.NombreCategoriaProfesor)
                .HasMaxLength(50)
                .HasColumnName("Nombre_Categoria_Profesor");
        });

        modelBuilder.Entity<ClimLibMCursosTemp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Clim_Lib_M_cursos_temp-1");

            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asignatura");
            entity.Property(e => e.Bloqueado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bloqueado");
            entity.Property(e => e.Cerrado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cerrado");
            entity.Property(e => e.CodAsignatura).HasColumnName("cod_asignatura");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodExtensionRegional).HasColumnName("cod_extension_regional");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodPeriodoMatricula).HasColumnName("cod_periodo_matricula");
            entity.Property(e => e.CodProfesor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_profesor");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.MCursosId)
                .ValueGeneratedOnAdd()
                .HasColumnName("M_cursosID");
            entity.Property(e => e.Minimo).HasColumnName("minimo");
            entity.Property(e => e.TipoPeriodoMatricula).HasColumnName("tipo_periodo_matricula");
            entity.Property(e => e.Tope).HasColumnName("tope");
            entity.Property(e => e.VerEnInforme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ver_en_informe");
        });

        modelBuilder.Entity<ClimLibMCursosTemp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Clim_Lib_M_cursos_temp-2");

            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asignatura");
            entity.Property(e => e.Bloqueado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bloqueado");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Cerrado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cerrado");
            entity.Property(e => e.CodAsignatura).HasColumnName("cod_asignatura");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtensionRegional).HasColumnName("cod_extension_regional");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodPeriodoMatricula).HasColumnName("cod_periodo_matricula");
            entity.Property(e => e.CodProfesor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_profesor");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.Fechaasigdoc)
                .HasDefaultValueSql("(((2000)-(1))-(1))")
                .HasColumnType("datetime")
                .HasColumnName("fechaasigdoc");
            entity.Property(e => e.Fechaasigpos)
                .HasDefaultValueSql("(((2000)-(1))-(1))")
                .HasColumnType("datetime")
                .HasColumnName("fechaasigpos");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.Guidusuarioasigdoc)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("guidusuarioasigdoc");
            entity.Property(e => e.Guidusuarioasigpos)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("guidusuarioasigpos");
            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.MCursosId)
                .ValueGeneratedOnAdd()
                .HasColumnName("M_cursosID");
            entity.Property(e => e.Minimo).HasColumnName("minimo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoPeriodoMatricula).HasColumnName("tipo_periodo_matricula");
            entity.Property(e => e.Tope).HasColumnName("tope");
            entity.Property(e => e.VerEnInforme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ver_en_informe");
        });

        modelBuilder.Entity<ClimLibMGruposTemp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Clim_Lib_M_grupos_temp-1");

            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Bloqueado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bloqueado");
            entity.Property(e => e.Cerrado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cerrado");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodExtensionRegional).HasColumnName("cod_extension_regional");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodPeriodoCarrera).HasColumnName("cod_periodo_carrera");
            entity.Property(e => e.CodPeriodoMatricula).HasColumnName("cod_periodo_matricula");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.MGruposId)
                .ValueGeneratedOnAdd()
                .HasColumnName("M_gruposID");
            entity.Property(e => e.MesMatricula).HasColumnName("mes_matricula");
            entity.Property(e => e.Primeringreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primeringreso");
            entity.Property(e => e.TipoPeriodoCarrera).HasColumnName("tipo_periodo_carrera");
            entity.Property(e => e.TipoPeriodoMatricula).HasColumnName("tipo_periodo_matricula");
            entity.Property(e => e.VerEnInforme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ver_en_informe");
        });

        modelBuilder.Entity<ClimLibMGruposTemp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Clim_Lib_M_grupos_temp-2");

            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Bloqueado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bloqueado");
            entity.Property(e => e.Cerrado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cerrado");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtensionRegional).HasColumnName("cod_extension_regional");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodPeriodoCarrera).HasColumnName("cod_periodo_carrera");
            entity.Property(e => e.CodPeriodoMatricula).HasColumnName("cod_periodo_matricula");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.MGruposId)
                .ValueGeneratedOnAdd()
                .HasColumnName("M_gruposID");
            entity.Property(e => e.MesMatricula).HasColumnName("mes_matricula");
            entity.Property(e => e.Primeringreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primeringreso");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
            entity.Property(e => e.TipoPeriodoCarrera).HasColumnName("tipo_periodo_carrera");
            entity.Property(e => e.TipoPeriodoMatricula).HasColumnName("tipo_periodo_matricula");
            entity.Property(e => e.VerEnInforme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ver_en_informe");
        });

        modelBuilder.Entity<CodigosCurso>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodExtension).HasColumnName("Cod_Extension");
            entity.Property(e => e.CodigoCurso)
                .HasDefaultValue(-1)
                .HasColumnName("Codigo_Curso");
            entity.Property(e => e.IdCurso).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CondicionSalone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Condicion_salones");

            entity.Property(e => e.CodCondicion)
                .HasDefaultValue(-1)
                .HasColumnName("cod_condicion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Constante>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Ninguno")
                .HasComment("");
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Ninguno");
            entity.Property(e => e.Valor2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Ninguno");
            entity.Property(e => e.Valor3).HasDefaultValue(0);
            entity.Property(e => e.Valor4)
                .HasDefaultValue(0.0m)
                .HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Constantes2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Constantes2");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Ninguno")
                .HasComment("");
            entity.Property(e => e.Valor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Ninguno");
            entity.Property(e => e.Valor2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Ninguno");
            entity.Property(e => e.Valor3).HasDefaultValue(0);
            entity.Property(e => e.Valor4)
                .HasDefaultValue(0.0m)
                .HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Constantes3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Constantes3");

            entity.Property(e => e.Actual)
                .HasMaxLength(50)
                .HasDefaultValue("N")
                .HasColumnName("actual");
            entity.Property(e => e.ActualLibreta)
                .HasMaxLength(50)
                .HasColumnName("actualLibreta");
            entity.Property(e => e.ActualperiodoEvaluacion)
                .HasMaxLength(50)
                .HasColumnName("actualperiodoEvaluacion");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Cerrado)
                .HasMaxLength(50)
                .HasColumnName("cerrado");
            entity.Property(e => e.CerradoEvaluacion)
                .HasMaxLength(50)
                .HasColumnName("cerradoEvaluacion");
            entity.Property(e => e.FechaFinalPost)
                .HasMaxLength(50)
                .HasColumnName("fecha_final_Post");
            entity.Property(e => e.FechaFinalSem)
                .HasMaxLength(50)
                .HasColumnName("fecha_final_Sem");
            entity.Property(e => e.FechaInicialPost)
                .HasMaxLength(50)
                .HasColumnName("fecha_inicial_Post");
            entity.Property(e => e.FechaInicialSem)
                .HasMaxLength(50)
                .HasColumnName("fecha_inicial_Sem");
            entity.Property(e => e.IdTabla)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_tabla");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.PeriodoPost).HasColumnName("periodo_post");
            entity.Property(e => e.Version)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("version");
        });

        modelBuilder.Entity<Csvdocente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CSVDocentes");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Email)
                .HasMaxLength(169)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Sede)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(21)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso);

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("tg_Update_Horarios");
                    tb.HasTrigger("trg_ActulizaDocenteCred");
                });

            entity.HasIndex(e => new { e.Ano, e.Periodo, e.CedProfesor }, "ID_CURSONOC3");

            entity.HasIndex(e => new { e.Ano, e.CodCarrera }, "ID_CURSOSNONC");

            entity.HasIndex(e => new { e.CodCurso, e.Ano, e.Periodo, e.CedProfesor }, "ID_CursosNOC");

            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.AnioVigente)
                .HasDefaultValue(2000)
                .HasColumnName("anio_vigente");
            entity.Property(e => e.Ano)
                .HasDefaultValue(2007)
                .HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValue("NOMBRAR")
                .HasColumnName("apellido");
            entity.Property(e => e.CantidadEstudiantes).HasColumnName("cantidad_estudiantes");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Cod1)
                .HasDefaultValue(-1)
                .HasComment("La cantidad de semanas que realmente se va impartir este curso,si es -1, entonces se usan las semanas del periodo y se obvia la cantidad de este campo.")
                .HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("((-1))")
                .HasColumnName("cod2");
            entity.Property(e => e.CodCarrera)
                .HasDefaultValue(1)
                .HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso)
                .HasDefaultValue(-1)
                .HasColumnName("cod_curso");
            entity.Property(e => e.CodDeparatmento)
                .HasDefaultValue(1)
                .HasColumnName("cod_deparatmento");
            entity.Property(e => e.CodEscuela)
                .HasDefaultValue(1)
                .HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtension)
                .HasDefaultValue(8)
                .HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad)
                .HasDefaultValue(1)
                .HasColumnName("cod_facultad");
            entity.Property(e => e.CodFinanciero)
                .HasDefaultValue(10000)
                .HasColumnName("cod_financiero");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria)
                .HasDefaultValue(-1)
                .HasColumnName("cod_materia");
            entity.Property(e => e.CodProfesor)
                .HasDefaultValue(-1)
                .HasColumnName("cod_profesor");
            entity.Property(e => e.CodTurno)
                .HasDefaultValue(-1)
                .HasColumnName("cod_turno");
            entity.Property(e => e.Creditos)
                .HasDefaultValue(3)
                .HasColumnName("creditos");
            entity.Property(e => e.DirEspecial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("DD")
                .HasColumnName("dir_especial");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("estatus2");
            entity.Property(e => e.Fechaasigdoc)
                .HasColumnType("datetime")
                .HasColumnName("fechaasigdoc");
            entity.Property(e => e.Fechaasigpos)
                .HasColumnType("datetime")
                .HasColumnName("fechaasigpos");
            entity.Property(e => e.Grupo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .HasColumnName("grupo");
            entity.Property(e => e.Guidusuarioasigdoc).HasColumnName("guidusuarioasigdoc");
            entity.Property(e => e.Guidusuarioasigpos).HasColumnName("guidusuarioasigpos");
            entity.Property(e => e.IdGrupo)
                .HasDefaultValue(-1)
                .HasColumnName("id_grupo");
            entity.Property(e => e.IdPosicion)
                .HasDefaultValue(-1)
                .HasColumnName("ID_Posicion");
            entity.Property(e => e.MateriaAbreviada)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("materia_abreviada");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValue("POR")
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo)
                .HasDefaultValue(1)
                .HasColumnName("periodo");
            entity.Property(e => e.PeriodoMateria)
                .HasDefaultValue(10)
                .HasColumnName("periodo_materia");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("salon");
        });

        modelBuilder.Entity<CursoOficialCruceMatriculadaPanama>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("curso_oficial_cruce_matriculada_panama");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<CursosCopia2>(entity =>
        {
            entity.HasKey(e => e.IdCurso);

            entity.ToTable("Cursos_copia2");

            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CantidadEstudiantes).HasColumnName("cantidad_estudiantes");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Cod1).HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod2");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodDeparatmento).HasColumnName("cod_deparatmento");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodFinanciero).HasColumnName("cod_financiero");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.CodProfesor).HasColumnName("cod_profesor");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.DirEspecial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("dir_especial");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus2");
            entity.Property(e => e.Grupo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.MateriaAbreviada)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("materia_abreviada");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.PeriodoMateria).HasColumnName("periodo_materia");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
        });

        modelBuilder.Entity<CursosCopium>(entity =>
        {
            entity.HasKey(e => e.IdCurso);

            entity.ToTable("Cursos_copia");

            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CantidadEstudiantes).HasColumnName("cantidad_estudiantes");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Cod1).HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod2");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodDeparatmento).HasColumnName("cod_deparatmento");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodFinanciero).HasColumnName("cod_financiero");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.CodProfesor).HasColumnName("cod_profesor");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.DirEspecial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("dir_especial");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus2");
            entity.Property(e => e.Grupo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.MateriaAbreviada)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("materia_abreviada");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.PeriodoMateria).HasColumnName("periodo_materia");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
        });

        modelBuilder.Entity<CursosOficialesXPeriodo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cursos_oficiales_X_Periodos");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<CursosXGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cursos_X_Grupo");

            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.CodDepartamento);

            entity.Property(e => e.CodDepartamento).HasColumnName("cod_departamento");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<DescripcionPeriodo>(entity =>
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("descripcion_periodos");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dia>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Dia1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("Dia");
            entity.Property(e => e.NumeroDia)
                .HasDefaultValue(-1)
                .HasColumnName("Numero_dia");
        });

        modelBuilder.Entity<DocenteConHor3Anio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DocenteConHor3Anios");

            entity.Property(e => e.Cant1).HasColumnName("cant1");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
        });

        modelBuilder.Entity<DocenteCsv>(entity =>
        {
            entity.ToTable("Docente_CSV");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(50)
                .HasColumnName("activo");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(50)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .HasColumnName("clave");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasColumnName("extension");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.Plataforma).HasMaxLength(50);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("telefono");
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .HasColumnName("version");
        });

        modelBuilder.Entity<Docentes2016>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Docentes2016");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Docentes2017>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Docentes2017");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Docentes2018>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Docentes2018");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<DocentesNuevos20182>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DocentesNuevos-2018-2");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Facultad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("facultad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<DocentesXCuenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Docentes_X_cuentas");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Clave)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(169)
                .IsUnicode(false);
            entity.Property(e => e.Expr1)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Expr2)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Expr3)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_extension");
            entity.Property(e => e.Telefono)
                .HasMaxLength(21)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Edificio>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodEntidad)
                .HasDefaultValue(-1)
                .HasColumnName("cod_entidad");
            entity.Property(e => e.CodExtension)
                .HasDefaultValue(-1)
                .HasColumnName("cod_extension");
            entity.Property(e => e.CodigoEdificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("codigo_edificio");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ubicacion");
        });

        modelBuilder.Entity<Emailcorregir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("emailcorregir");

            entity.Property(e => e.CedProfesor)
                .HasMaxLength(50)
                .HasColumnName("ced_profesor");
        });

        modelBuilder.Entity<Entidade>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodEntidad)
                .HasDefaultValue(-1)
                .HasColumnName("cod_entidad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("observacion");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ubicacion");
        });

        modelBuilder.Entity<Escuela>(entity =>
        {
            entity.HasKey(e => e.IdEscuela);

            entity.Property(e => e.IdEscuela).HasColumnName("id_escuela");
            entity.Property(e => e.CodEscuela)
                .HasDefaultValue(-1)
                .HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtension)
                .HasDefaultValue(-1)
                .HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad)
                .HasDefaultValue(-1)
                .HasColumnName("cod_facultad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Extensione>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CodExtension, "ID_cod_extension").IsClustered();

            entity.Property(e => e.CodExtension)
                .HasDefaultValue(-1)
                .HasColumnName("cod_extension");
            entity.Property(e => e.Distrito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("distrito");
            entity.Property(e => e.NombreExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre_extension");
            entity.Property(e => e.Provincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("provincia");
        });

        modelBuilder.Entity<Facultade>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CodFacultad, "ID_cod_facultad").IsClustered();

            entity.Property(e => e.CodExtension)
                .HasDefaultValue(-1)
                .HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad)
                .HasDefaultValue(-1)
                .HasColumnName("cod_facultad");
            entity.Property(e => e.CodNivel)
                .HasDefaultValue(1)
                .HasColumnName("cod_Nivel");
            entity.Property(e => e.Facultad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("facultad");
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity.HasKey(e => e.IdGrupo);

            entity.HasIndex(e => new { e.AnoMatricula, e.PeriodoMatricula, e.CodExtension, e.CodCarrera }, "ID_GrupoNONC1");

            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Cod1).HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod2");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodEsp)
                .HasComment("0: No; 1: Si *****\"código utilizado para las grupos de carreras fuera de periodo\"*****")
                .HasColumnName("cod_esp");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodHorPlantilla).HasColumnName("cod_hor_plantilla");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("estatus2");
            entity.Property(e => e.FechaMatricula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha_matricula");
            entity.Property(e => e.LetraGrupo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("letra_grupo");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.PeriodoMatricula).HasColumnName("periodo_matricula");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
            entity.Property(e => e.SemestreGrupo).HasColumnName("semestre_grupo");
            entity.Property(e => e.Turno).HasColumnName("turno");
            entity.Property(e => e.Turno2)
                .HasDefaultValue(0)
                .HasColumnName("turno2");
        });

        modelBuilder.Entity<GrupoCursoLibretum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Grupo_curso_libreta");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<GruposChoque>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Grupos_choques");

            entity.Property(e => e.AbrevMateria)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("abrev_materia");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.NumeroDia).HasColumnName("numero_dia");
            entity.Property(e => e.NumeroHora).HasColumnName("numero_hora");
            entity.Property(e => e.Salon)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("salon");
        });

        modelBuilder.Entity<GruposCopium>(entity =>
        {
            entity.HasKey(e => e.IdGrupo);

            entity.ToTable("Grupos_copia");

            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Cod1).HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod2");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodHorPlantilla).HasColumnName("cod_hor_plantilla");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus2");
            entity.Property(e => e.FechaMatricula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha_matricula");
            entity.Property(e => e.LetraGrupo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("letra_grupo");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.PeriodoMatricula).HasColumnName("periodo_matricula");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
            entity.Property(e => e.SemestreGrupo).HasColumnName("semestre_grupo");
            entity.Property(e => e.Turno).HasColumnName("turno");
        });

        modelBuilder.Entity<GruposEspeciale>(entity =>
        {
            entity.HasKey(e => e.Idr).HasName("PK_Grupo_especial");

            entity.ToTable("Grupos_especiales");

            entity.Property(e => e.Idr).ValueGeneratedNever();
            entity.Property(e => e.AnioActual).HasColumnName("Anio_actual");
            entity.Property(e => e.AnioAnterior).HasColumnName("Anio_anterior");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.GrupoActual)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Grupo_actual");
            entity.Property(e => e.GrupoAnterior)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Grupo_anterior");
            entity.Property(e => e.IdGrupoReferencia).HasColumnName("id_grupo_referencia");
            entity.Property(e => e.PeriodoActual).HasColumnName("Periodo_actual");
            entity.Property(e => e.PeriodoAnterior).HasColumnName("Periodo_anterior");
        });

        modelBuilder.Entity<HistoricoCurso>(entity =>
        {
            entity.HasKey(e => e.IdCurso);

            entity.Property(e => e.IdCurso)
                .ValueGeneratedNever()
                .HasColumnName("id_curso");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CantidadEstudiantes).HasColumnName("cantidad_estudiantes");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Cod1).HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod2");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodDeparatmento).HasColumnName("cod_deparatmento");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodFinanciero).HasColumnName("cod_financiero");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.CodProfesor).HasColumnName("cod_profesor");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.DirEspecial)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("dir_especial");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus2");
            entity.Property(e => e.Grupo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.MateriaAbreviada)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("materia_abreviada");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.PeriodoMateria).HasColumnName("periodo_materia");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
        });

        modelBuilder.Entity<HistoricoGrupo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Cod1).HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod2");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodHorPlantilla).HasColumnName("cod_hor_plantilla");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus2");
            entity.Property(e => e.FechaMatricula)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha_matricula");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.LetraGrupo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("letra_grupo");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("observacion");
            entity.Property(e => e.PeriodoMatricula).HasColumnName("periodo_matricula");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
            entity.Property(e => e.SemestreGrupo).HasColumnName("semestre_grupo");
            entity.Property(e => e.Turno).HasColumnName("turno");
        });

        modelBuilder.Entity<Hoja1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hoja1$");

            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Conexión)
                .HasMaxLength(50)
                .HasColumnName("conexión");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.IdHorario);

            entity.ToTable(tb => tb.HasTrigger("insert_ano_periodo"));

            entity.HasIndex(e => e.IdCurso, "ID_IDCURSOHorario");

            entity.Property(e => e.IdHorario).HasColumnName("id_horario");
            entity.Property(e => e.AbrevMateria)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("abrev_materia");
            entity.Property(e => e.AmPmF)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("am_pm_f");
            entity.Property(e => e.AmPmI)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("am_pm_i");
            entity.Property(e => e.Ano)
                .HasDefaultValue(9999)
                .HasColumnName("ano");
            entity.Property(e => e.Cod1)
                .HasDefaultValue(-1)
                .HasComment("En cantidad de semanas que debe darse, si es -1 se ajusta a lo señalado por periodo y se obvia la cantidad de este campo.")
                .HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("cod2");
            entity.Property(e => e.CodCurso)
                .HasDefaultValue(-1)
                .HasColumnName("cod_curso");
            entity.Property(e => e.CodHorarioPlantilla)
                .HasDefaultValue(-1)
                .HasColumnName("cod_horario_plantilla");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("estatus2");
            entity.Property(e => e.Fechamodificacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechamodificacion");
            entity.Property(e => e.Guidusuario).HasColumnName("guidusuario");
            entity.Property(e => e.HFinal)
                .HasDefaultValue(-1)
                .HasColumnName("h_final");
            entity.Property(e => e.HInicial)
                .HasDefaultValue(-1)
                .HasColumnName("h_inicial");
            entity.Property(e => e.IdCurso)
                .HasDefaultValue(-1)
                .HasColumnName("id_curso");
            entity.Property(e => e.IdGrupo)
                .HasDefaultValue(-1)
                .HasColumnName("id_grupo");
            entity.Property(e => e.IntermedioMinutos)
                .HasDefaultValue(-1)
                .HasColumnName("intermedio_minutos");
            entity.Property(e => e.MFinal)
                .HasDefaultValue(-1)
                .HasColumnName("m_final");
            entity.Property(e => e.MInicial)
                .HasDefaultValue(-1)
                .HasColumnName("m_inicial");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre_dia");
            entity.Property(e => e.NombreTipoClase)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre_tipo_clase");
            entity.Property(e => e.NumeroDia)
                .HasDefaultValue(-1)
                .HasColumnName("numero_dia");
            entity.Property(e => e.NumeroHora)
                .HasDefaultValue(-1)
                .HasColumnName("numero_hora");
            entity.Property(e => e.Periodo)
                .HasDefaultValue(3)
                .HasColumnName("periodo");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("salon");
            entity.Property(e => e.TipoHoraClase)
                .HasDefaultValue(1)
                .HasColumnName("tipo_hora_clase");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("tipo_pago");
        });

        modelBuilder.Entity<HorarioTipoPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("horario_tipo_pago");

            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.T).HasColumnName("t");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
        });

        modelBuilder.Entity<HorariosCopia1>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK_Horarios_copia");

            entity.ToTable("Horarios_copia1");

            entity.Property(e => e.IdHorario).HasColumnName("id_horario");
            entity.Property(e => e.AbrevMateria)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("abrev_materia");
            entity.Property(e => e.AmPmF)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("am_pm_f");
            entity.Property(e => e.AmPmI)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("am_pm_i");
            entity.Property(e => e.Cod1).HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod2");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodHorarioPlantilla).HasColumnName("cod_horario_plantilla");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus2");
            entity.Property(e => e.HFinal).HasColumnName("h_final");
            entity.Property(e => e.HInicial).HasColumnName("h_inicial");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.IntermedioMinutos).HasColumnName("intermedio_minutos");
            entity.Property(e => e.MFinal).HasColumnName("m_final");
            entity.Property(e => e.MInicial).HasColumnName("m_inicial");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nombre_dia");
            entity.Property(e => e.NombreTipoClase)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_tipo_clase");
            entity.Property(e => e.NumeroDia).HasColumnName("numero_dia");
            entity.Property(e => e.NumeroHora).HasColumnName("numero_hora");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
            entity.Property(e => e.TipoHoraClase).HasColumnName("tipo_hora_clase");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
        });

        modelBuilder.Entity<HorariosCopium>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK_Horarios_copia2");

            entity.ToTable("Horarios_copia");

            entity.Property(e => e.IdHorario).HasColumnName("id_horario");
            entity.Property(e => e.AbrevMateria)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("abrev_materia");
            entity.Property(e => e.AmPmF)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("am_pm_f");
            entity.Property(e => e.AmPmI)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("am_pm_i");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Cod1).HasColumnName("cod1");
            entity.Property(e => e.Cod2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("cod2");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodHorarioPlantilla).HasColumnName("cod_horario_plantilla");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Estatus1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus1");
            entity.Property(e => e.Estatus2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("estatus2");
            entity.Property(e => e.HFinal).HasColumnName("h_final");
            entity.Property(e => e.HInicial).HasColumnName("h_inicial");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.IntermedioMinutos).HasColumnName("intermedio_minutos");
            entity.Property(e => e.MFinal).HasColumnName("m_final");
            entity.Property(e => e.MInicial).HasColumnName("m_inicial");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nombre_dia");
            entity.Property(e => e.NombreTipoClase)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_tipo_clase");
            entity.Property(e => e.NumeroDia).HasColumnName("numero_dia");
            entity.Property(e => e.NumeroHora).HasColumnName("numero_hora");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
            entity.Property(e => e.TipoHoraClase).HasColumnName("tipo_hora_clase");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
        });

        modelBuilder.Entity<HorariosPlantilla>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Horarios_plantilla");

            entity.Property(e => e.CodPlantilla)
                .HasDefaultValue(-1)
                .HasColumnName("cod_plantilla");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("observacion");
        });

        modelBuilder.Entity<HorariosPlantillaDetalle>(entity =>
        {
            entity.HasKey(e => new { e.CodPlantilla, e.NumeroHora });

            entity.ToTable("Horarios_plantilla_detalles");

            entity.Property(e => e.CodPlantilla)
                .HasDefaultValue(-1)
                .HasColumnName("cod_plantilla");
            entity.Property(e => e.NumeroHora)
                .HasDefaultValue(-1)
                .HasColumnName("numero_hora");
            entity.Property(e => e.AmpmF)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ampm_f");
            entity.Property(e => e.AmpmI)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ampm_i");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.HFinal)
                .HasDefaultValue(-1)
                .HasColumnName("h_final");
            entity.Property(e => e.HInicial)
                .HasDefaultValue(-1)
                .HasColumnName("h_inicial");
            entity.Property(e => e.MFinal)
                .HasDefaultValue(-1)
                .HasColumnName("m_final");
            entity.Property(e => e.MInicial)
                .HasDefaultValue(-1)
                .HasColumnName("m_inicial");
            entity.Property(e => e.MinutosIntermedio)
                .HasDefaultValue(-1)
                .HasColumnName("minutos_intermedio");
        });

        modelBuilder.Entity<ListaCursoOficialesPma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Lista_curso_oficiales_pma");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<ListaCursosColegiadasPma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Lista_cursos_colegiadas_pma");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<ListadoAnioMayorDocente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Listado_anio_mayor_docentes");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Facultad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("facultad");
            entity.Property(e => e.NombreExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_extension");
        });

        modelBuilder.Entity<LsAmAm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_am_am");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsAmAmCarga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_am_am_Carga");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsAmPm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_am_pm");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsAmPmCarga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_am_pm_Carga");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsDocentesPorCarga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_Docentes_PorCarga");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsDocentesPorPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_Docentes_PorPago");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsPmPmMayora4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_pm_pm_mayora4");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsPmPmMayora4Carga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_pm_pm_mayora4_Carga");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsPmPmMenora4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_pm_pm_menora4");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<LsPmPmMenora4Carga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("LS_pm_pm_menora4_Carga");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<MCostosFijosGruposTemp>(entity =>
        {
            entity.HasKey(e => e.MCostosFijosGruposId);

            entity.ToTable("M_costos_fijos_grupos_TEMP");

            entity.Property(e => e.MCostosFijosGruposId).HasColumnName("M_costos_fijos_gruposID");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodContenedor).HasColumnName("cod_contenedor");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodPeriodoMatricula).HasColumnName("cod_periodo_matricula");
            entity.Property(e => e.TipoPeriodoMatricula).HasColumnName("tipo_periodo_matricula");
        });

        modelBuilder.Entity<MCurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("M_cursos");

            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Asignatura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("asignatura");
            entity.Property(e => e.Bloqueado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bloqueado");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Cerrado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cerrado");
            entity.Property(e => e.CodAsignatura).HasColumnName("cod_asignatura");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtensionRegional).HasColumnName("cod_extension_regional");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodPeriodoMatricula).HasColumnName("cod_periodo_matricula");
            entity.Property(e => e.CodProfesor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_profesor");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");
            entity.Property(e => e.MCursosId).HasColumnName("M_cursosID");
            entity.Property(e => e.Minimo).HasColumnName("minimo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoPeriodoMatricula).HasColumnName("tipo_periodo_matricula");
            entity.Property(e => e.Tope).HasColumnName("tope");
            entity.Property(e => e.VerEnInforme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ver_en_informe");
        });

        modelBuilder.Entity<MGrupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("M_grupos");

            entity.Property(e => e.AnoMatricula).HasColumnName("ano_matricula");
            entity.Property(e => e.Bloqueado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bloqueado");
            entity.Property(e => e.Cerrado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cerrado");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodEscuela).HasColumnName("cod_escuela");
            entity.Property(e => e.CodExtensionRegional).HasColumnName("cod_extension_regional");
            entity.Property(e => e.CodFacultad).HasColumnName("cod_facultad");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodPeriodoCarrera).HasColumnName("cod_periodo_carrera");
            entity.Property(e => e.CodPeriodoMatricula).HasColumnName("cod_periodo_matricula");
            entity.Property(e => e.CodTurno).HasColumnName("cod_turno");
            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.Grupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grupo");
            entity.Property(e => e.MGruposId).HasColumnName("M_gruposID");
            entity.Property(e => e.MesMatricula).HasColumnName("mes_matricula");
            entity.Property(e => e.Primeringreso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("primeringreso");
            entity.Property(e => e.Salon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("salon");
            entity.Property(e => e.TipoPeriodoCarrera).HasColumnName("tipo_periodo_carrera");
            entity.Property(e => e.TipoPeriodoMatricula).HasColumnName("tipo_periodo_matricula");
            entity.Property(e => e.VerEnInforme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ver_en_informe");
        });

        modelBuilder.Entity<MatPoCarreraFiltro>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mat_po_carrera_filtro");

            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
        });

        modelBuilder.Entity<Matcar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Matcar");

            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
        });

        modelBuilder.Entity<MateriasParaVerificarTecnico>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MATERIAS_PARA_VERIFICAR_TECNICO");

            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<MateriasPorCarrera>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Materias_por_carreras");

            entity.HasIndex(e => new { e.CodCarrera, e.Estatus }, "ID_MXCNOC1");

            entity.Property(e => e.Abreviatura)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("abreviatura");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCarrera2).HasColumnName("cod_carrera2");
            entity.Property(e => e.CodDepartamento).HasColumnName("cod_departamento");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estatus)
                .HasDefaultValue(1)
                .HasComment("1 - materia activa / 0 - materia desactivada")
                .HasColumnName("estatus");
            entity.Property(e => e.FlagPrerequisitos).HasColumnName("Flag_prerequisitos");
            entity.Property(e => e.Horaregistro)
                .HasDefaultValue(new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("horaregistro");
            entity.Property(e => e.HorasLab).HasColumnName("Horas_Lab");
            entity.Property(e => e.HorasOtros).HasColumnName("Horas_otros");
            entity.Property(e => e.HorasPracticas)
                .HasComment("Estatus para las materias Prácticas Universitarias: 0 No tiene horas prácticas, 1 si tiene horas prácticas (Lic)")
                .HasColumnName("horas_practicas");
            entity.Property(e => e.HorasTeoria).HasColumnName("Horas_teoria");
            entity.Property(e => e.HorasTotal).HasColumnName("Horas_total");
            entity.Property(e => e.IdMateria)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_materia");
            entity.Property(e => e.IdPlan).HasColumnName("ID_Plan");
            entity.Property(e => e.Observacion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Operador)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("sistema")
                .HasColumnName("operador");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.Tecnico).HasColumnName("tecnico");
            entity.Property(e => e.TipoPeriodo).HasColumnName("tipo_periodo");
        });

        modelBuilder.Entity<MateriasPractica>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Materias_Practicas");

            entity.Property(e => e.CodCarrera).HasColumnName("Cod_carrera");
            entity.Property(e => e.CodMateria).HasColumnName("Cod_materia");
            entity.Property(e => e.CompetenciaNivelPractica)
                .HasMaxLength(2500)
                .HasDefaultValue("N")
                .HasColumnName("Competencia_nivel_practica");
            entity.Property(e => e.Idmateria).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MateriasPreRequisito>(entity =>
        {
            entity.HasKey(e => new { e.CodMateria, e.IdMateriaAsociada });

            entity.ToTable("Materias_PreRequisitos");

            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.IdMateriaAsociada)
                .HasDefaultValue(-1)
                .HasColumnName("id_materia_asociada");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.NombreMateria)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("nombre_materia");
            entity.Property(e => e.PlanCarrera)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .HasColumnName("plan_carrera");
        });

        modelBuilder.Entity<NivelAcceso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nivel_acceso");

            entity.Property(e => e.CodAcceso)
                .HasDefaultValue(-1)
                .HasColumnName("cod_acceso");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<NivelDiplomado>(entity =>
        {
            entity.HasKey(e => e.IdNivelDip);

            entity.Property(e => e.DescripcionNivel).HasMaxLength(50);
        });

        modelBuilder.Entity<Notanoentregadum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NOTANOENTREGADA");

            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
        });

        modelBuilder.Entity<NotasCarrera>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Notas_carreras");

            entity.Property(e => e.Asunto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.Fecha)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.FirmaDe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("Firma_de");
            entity.Property(e => e.Nomenclatura)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .HasColumnName("plan_carrera");
            entity.Property(e => e.ResumenContenido)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("Resumen_contenido");
        });

        modelBuilder.Entity<NotasMaterium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Notas_materia");

            entity.Property(e => e.Asunto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.FirmaDe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("Firma_de");
            entity.Property(e => e.Nomenclatura)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.PlanCarrera)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("A")
                .HasColumnName("plan_carrera");
            entity.Property(e => e.ResumenContenido)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .HasColumnName("Resumen_contenido");
        });

        modelBuilder.Entity<Numero>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Numero1).HasColumnName("Numero");
        });

        modelBuilder.Entity<ObservacionesMaterium>(entity =>
        {
            entity.HasKey(e => e.IdMateria);

            entity.ToTable("Observaciones_materia");

            entity.Property(e => e.IdMateria)
                .ValueGeneratedNever()
                .HasColumnName("id_materia");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("Ninguna")
                .HasColumnName("observacion");
        });

        modelBuilder.Entity<OpcionesDePago>(entity =>
        {
            entity.HasKey(e => e.OpcionDePagoId);
        });

        modelBuilder.Entity<Parte1Reportesubhumano>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PARTE_1_reportesubhumanos");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
        });

        modelBuilder.Entity<Parte2Reportesubhumano>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("PARTE_2_reportesubhumano");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
            entity.Property(e => e.Total).HasColumnName("total");
        });

        modelBuilder.Entity<Periodo>(entity =>
        {
            entity.Property(e => e.Descripcion).HasMaxLength(50);
            entity.Property(e => e.GradoId).HasDefaultValue(-1);
            entity.Property(e => e.Periodo1).HasColumnName("Periodo");
        });

        modelBuilder.Entity<PeriodoPorDiplomado>(entity =>
        {
            entity.HasKey(e => e.IdPeriodoPorDiplomado);

            entity.Property(e => e.CodPeriodo).HasColumnName("codPeriodo");
            entity.Property(e => e.DescripcionDiplomado).HasMaxLength(300);
        });

        modelBuilder.Entity<PeriodosAcademico>(entity =>
        {
            entity.HasKey(e => new { e.CodTipoPeriodo, e.Numero });

            entity.ToTable("Periodos_academicos");

            entity.Property(e => e.CodTipoPeriodo).HasColumnName("Cod_tipo_periodo");
            entity.Property(e => e.Abreviado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("N");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PeriodosVigente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Periodos_vigentes");

            entity.Property(e => e.AnoVigente)
                .HasDefaultValue(-1)
                .HasColumnName("Ano_vigente");
            entity.Property(e => e.PeriodoCuatrimestre)
                .HasDefaultValue(-1)
                .HasColumnName("periodo_cuatrimestre");
            entity.Property(e => e.PeriodoModulo)
                .HasDefaultValue(-1)
                .HasColumnName("periodo_modulo");
            entity.Property(e => e.PeriodoSemestre)
                .HasDefaultValue(-1)
                .HasColumnName("periodo_semestre");
        });

        modelBuilder.Entity<ProfesoresEvaluacionCurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ProfesoresEvaluacionCursos");

            entity.Property(e => e.ActualperiodoEvaluacion)
                .HasMaxLength(50)
                .HasColumnName("actualperiodoEvaluacion");
            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<Resultado>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Carrera)
                .HasMaxLength(50)
                .HasColumnName("CARRERA");
            entity.Property(e => e.CodCarrer).HasColumnName("COD_CARRER");
            entity.Property(e => e.CodEscuel).HasColumnName("COD_ESCUEL");
            entity.Property(e => e.CodFacult).HasColumnName("COD_FACULT");
            entity.Property(e => e.CodSede).HasColumnName("COD_SEDE");
            entity.Property(e => e.NombreCor)
                .HasMaxLength(15)
                .HasColumnName("NOMBRE_COR");
        });

        modelBuilder.Entity<Salone>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodEdificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("cod_edificio");
            entity.Property(e => e.CodExtension)
                .HasDefaultValue(1)
                .HasColumnName("cod_extension");
            entity.Property(e => e.CodSalon)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("cod_salon");
            entity.Property(e => e.Condiciones)
                .HasDefaultValue(1)
                .HasColumnName("condiciones");
            entity.Property(e => e.Gg)
                .ValueGeneratedOnAdd()
                .HasColumnName("GG");
            entity.Property(e => e.NombreSalon)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre_salon");
            entity.Property(e => e.TipoSalon)
                .HasDefaultValue(1)
                .HasColumnName("tipo_salon");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ubicacion");
        });

        modelBuilder.Entity<SalonesChoque>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Salones_choque");

            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.NumeroDia).HasColumnName("numero_dia");
            entity.Property(e => e.NumeroHora).HasColumnName("numero_hora");
            entity.Property(e => e.Salon)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("salon");
        });

        modelBuilder.Entity<SalonesChoque1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Salones_choques");

            entity.Property(e => e.Edificio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("edificio");
            entity.Property(e => e.NumeroDia).HasColumnName("numero_dia");
            entity.Property(e => e.NumeroHora).HasColumnName("numero_hora");
            entity.Property(e => e.Salon)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("salon");
        });

        modelBuilder.Entity<SemMat>(entity =>
        {
            entity.HasKey(e => e.IdSemMat);

            entity.ToTable("Sem_mat");

            entity.Property(e => e.CodCarrera).HasColumnName("Cod_carrera");
            entity.Property(e => e.NomSemMateria)
                .HasMaxLength(50)
                .HasColumnName("Nom_sem_materia");
            entity.Property(e => e.Periodo).HasDefaultValue(1);
            entity.Property(e => e.TipoPeriodo).HasDefaultValue(4);
        });

        modelBuilder.Entity<Sesione>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("fecha");
            entity.Property(e => e.Hora)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("hora");
            entity.Property(e => e.IdSesion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("id_sesion");
            entity.Property(e => e.IdUsuario)
                .HasDefaultValue(-1)
                .HasColumnName("id_usuario");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ip");
            entity.Property(e => e.Macadress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("macadress");
            entity.Property(e => e.Maquina)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("maquina");
            entity.Property(e => e.TablasAfectadas)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("tablas_afectadas");
            entity.Property(e => e.TipoDeOperaciones)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("tipo_de_operaciones");
        });

        modelBuilder.Entity<SubTiposGrado>(entity =>
        {
            entity.HasKey(e => e.SubTipoGradoId);

            entity.Property(e => e.Descripcion).HasMaxLength(100);
        });

        modelBuilder.Entity<T3Horario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("T3_horarios");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.T)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("t");
        });

        modelBuilder.Entity<TablaModel>(entity =>
        {
            entity.ToTable("TablaModel");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CodAsignatura1)
                .HasMaxLength(50)
                .HasColumnName("cod_asignatura1");
            entity.Property(e => e.CodAsignatura2)
                .HasMaxLength(50)
                .HasColumnName("cod_asignatura2");
            entity.Property(e => e.CodAsignatura3)
                .HasMaxLength(50)
                .HasColumnName("cod_asignatura3");
            entity.Property(e => e.CodAsignatura4)
                .HasMaxLength(50)
                .HasColumnName("cod_asignatura4");
            entity.Property(e => e.Course1)
                .HasMaxLength(50)
                .HasColumnName("course1");
            entity.Property(e => e.Course2)
                .HasMaxLength(50)
                .HasColumnName("course2");
            entity.Property(e => e.Course3)
                .HasMaxLength(50)
                .HasColumnName("course3");
            entity.Property(e => e.Course4)
                .HasMaxLength(50)
                .HasColumnName("course4");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<TempD1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempD1");

            entity.Property(e => e.Apeprofe)
                .HasMaxLength(150)
                .HasColumnName("apeprofe");
            entity.Property(e => e.Cedprofe)
                .HasMaxLength(50)
                .HasColumnName("cedprofe");
            entity.Property(e => e.Codext).HasColumnName("codext");
            entity.Property(e => e.Nomprofe)
                .HasMaxLength(150)
                .HasColumnName("nomprofe");
        });

        modelBuilder.Entity<TempD2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempD2");

            entity.Property(e => e.Apeprofe)
                .HasMaxLength(150)
                .HasColumnName("apeprofe");
            entity.Property(e => e.Cedprofe)
                .HasMaxLength(50)
                .HasColumnName("cedprofe");
            entity.Property(e => e.Codext).HasColumnName("codext");
            entity.Property(e => e.Nomprofe)
                .HasMaxLength(150)
                .HasColumnName("nomprofe");
        });

        modelBuilder.Entity<TempDoc3Anio>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_Doc3Anios");

            entity.Property(e => e.Cedula).HasMaxLength(15);
            entity.Property(e => e.IdDoc).HasColumnName("Id_Doc");
        });

        modelBuilder.Entity<TempDocentesPendRevisar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempDocentes_PendRevisar");

            entity.Property(e => e.CedProfe)
                .HasMaxLength(13)
                .HasColumnName("Ced_profe");
        });

        modelBuilder.Entity<TempoDoceSs3a1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempoDoceSS3A1");

            entity.Property(e => e.Cedula1)
                .HasMaxLength(15)
                .HasColumnName("cedula1");
            entity.Property(e => e.CodSede1).HasColumnName("Cod_sede1");
            entity.Property(e => e.Sede1).HasMaxLength(30);
        });

        modelBuilder.Entity<TemporalDoceSs3a>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TemporalDoceSS3A");

            entity.Property(e => e.Cedula).HasMaxLength(15);
            entity.Property(e => e.Sede).HasMaxLength(30);
        });

        modelBuilder.Entity<TipoDocente>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tipo_docente");

            entity.Property(e => e.CodTipoDocente)
                .HasDefaultValue(-1)
                .HasColumnName("cod_tipo_docente");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("descripcion");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("observacion");
        });

        modelBuilder.Entity<TipoHoraclase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tipo_horaclase");

            entity.Property(e => e.CodTipoHora)
                .HasDefaultValue(-1)
                .HasColumnName("cod_tipo_hora");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("descripcion");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("observacion");
        });

        modelBuilder.Entity<TipoPago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tipo_pago");

            entity.Property(e => e.CodTipo)
                .HasDefaultValue(-1)
                .HasColumnName("cod_tipo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("descripcion");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("observacion");
        });

        modelBuilder.Entity<TipoPago1>(entity =>
        {
            entity.HasKey(e => e.IdTipoPago);

            entity.ToTable("Tipo_Pagos");

            entity.Property(e => e.IdTipoPago).HasColumnName("Id_Tipo_Pago");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(75)
                .HasDefaultValue("n");
            entity.Property(e => e.MontoHoras)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Horas");
            entity.Property(e => e.MontoVacaciones)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Monto_Vacaciones");
            entity.Property(e => e.Nivel).HasDefaultValue(1);
            entity.Property(e => e.SubTipoGrado).HasDefaultValue(-1);
            entity.Property(e => e.TipoEstudio)
                .HasDefaultValue(-1)
                .HasColumnName("Tipo_Estudio");
        });

        modelBuilder.Entity<TipoPeriodo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tipo_periodos");

            entity.Property(e => e.CodPeriodo)
                .HasDefaultValue(6)
                .HasColumnName("Cod_periodo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("Semestre")
                .IsFixedLength()
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<TiposGrado>(entity =>
        {
            entity.HasKey(e => e.GradoId);

            entity.Property(e => e.NombreGrado).HasMaxLength(50);
        });

        modelBuilder.Entity<TokenDocente>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Apellido).HasMaxLength(255);
            entity.Property(e => e.Cedula).HasMaxLength(255);
            entity.Property(e => e.Correo).HasMaxLength(255);
            entity.Property(e => e.Dni2)
                .HasMaxLength(255)
                .HasDefaultValue("N")
                .HasColumnName("DNI2");
            entity.Property(e => e.Nombre).HasMaxLength(255);
            entity.Property(e => e.Sede).HasMaxLength(255);
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.CodTurno, "ID_cod_turno").IsClustered();

            entity.Property(e => e.Abreviado)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("abreviado");
            entity.Property(e => e.CodTurno)
                .HasDefaultValue(-1)
                .HasColumnName("cod_turno");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre");
            entity.Property(e => e.Observacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("observacion");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("apellido");
            entity.Property(e => e.Cargo)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("cargo");
            entity.Property(e => e.Carreras)
                .HasDefaultValue(-1)
                .HasColumnName("carreras");
            entity.Property(e => e.Cedula)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("cedula");
            entity.Property(e => e.Codunidad).HasColumnName("codunidad");
            entity.Property(e => e.CreadorCuenta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("creador_cuenta");
            entity.Property(e => e.EntidadLabora)
                .HasDefaultValue(-1)
                .HasColumnName("entidad_labora");
            entity.Property(e => e.Escuela)
                .HasDefaultValue(-1)
                .HasColumnName("escuela");
            entity.Property(e => e.Extension)
                .HasDefaultValue(-1)
                .HasColumnName("extension");
            entity.Property(e => e.Facultad)
                .HasDefaultValue(-1)
                .HasColumnName("facultad");
            entity.Property(e => e.FechaCreacion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.Funciones)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("funciones");
            entity.Property(e => e.Guidusuario).HasColumnName("guidusuario");
            entity.Property(e => e.IdUsuario)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Ip)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ip");
            entity.Property(e => e.Macadress)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("macadress");
            entity.Property(e => e.Maquina)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("maquina");
            entity.Property(e => e.NivelAcceso)
                .HasDefaultValue(-1)
                .HasComment("0 no entra, 1 consulta, 5 operativo , 6 administrador")
                .HasColumnName("nivel_acceso");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("nombre");
            entity.Property(e => e.Observacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("observacion");
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("password");
            entity.Property(e => e.UbicacionFisica)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("ubicacion_fisica");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("n")
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<VerificarGruposCantEstPma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("verificar_grupos_cant_est_pma");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CantidadEstudiantes).HasColumnName("cantidad_estudiantes");
            entity.Property(e => e.Carrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("carrera");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_grupo");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Horas).HasColumnName("HORAS");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.R)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_2");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CantMaterias).HasColumnName("Cant_materias");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<View3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_3");

            entity.Property(e => e.Apellido)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Carrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("carrera");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.LetraGrupo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("letra_grupo");
            entity.Property(e => e.MateriaCompleta)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("materia_completa");
            entity.Property(e => e.Nombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.PeriodoMatricula).HasColumnName("periodo_matricula");
            entity.Property(e => e.SemestreGrupo).HasColumnName("semestre_grupo");
            entity.Property(e => e.TipoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipo_pago");
            entity.Property(e => e.TipoPeriodo).HasColumnName("Tipo_periodo");
            entity.Property(e => e.Turno).HasColumnName("turno");
        });

        modelBuilder.Entity<View4l>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_4LS");

            entity.Property(e => e.Cant)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("CANT");
            entity.Property(e => e.Carrera)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("carrera");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Cod_grupo");
            entity.Property(e => e.Facultad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("facultad");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ViewCantidadHorasCurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CantidadHorasCursos");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<ViewConPostgrado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ConPostgrado");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Postgrado)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewCuentasCreadasXcorte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CuentasCreadasXcortes");

            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasColumnName("extension");
            entity.Property(e => e.T).HasColumnName("t");
        });

        modelBuilder.Entity<ViewCursosnogendpc2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CURSOSNOGENDPC2023");

            entity.Property(e => e.CodCurso).HasColumnName("cod_curso");
        });

        modelBuilder.Entity<ViewDoc3A>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Doc3A");

            entity.Property(e => e.Cant1).HasColumnName("cant1");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
        });

        modelBuilder.Entity<ViewDoc3Aa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Doc3AA");

            entity.Property(e => e.Cant1).HasColumnName("cant1");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
        });

        modelBuilder.Entity<ViewDocent20222023>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Docent2022-2023");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ViewDocent2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Docent2024");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ViewDocente2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Docente-2023");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ViewDocenteVotantesUlt3Anio>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Docente_Votantes-Ult3Anios");

            entity.Property(e => e.Ano).HasColumnName("ano");
            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ViewDocentesPrelVoto24>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_DocentesPrelVoto24");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<ViewDocentesXCuenta>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Docentes_X_Cuentas");

            entity.Property(e => e.Activo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("activo");
            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Clave)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(169)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreExtension)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_extension");
            entity.Property(e => e.Telefono)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("version");
        });

        modelBuilder.Entity<ViewHorariosCurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_HorariosCurso");

            entity.Property(e => e.AmPmF)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("am_pm_f");
            entity.Property(e => e.AmPmI)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("am_pm_i");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.HFinal).HasColumnName("h_final");
            entity.Property(e => e.HInicial).HasColumnName("h_inicial");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdHorario)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_horario");
            entity.Property(e => e.MFinal).HasColumnName("m_final");
            entity.Property(e => e.MInicial).HasColumnName("m_inicial");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nombre_dia");
        });

        modelBuilder.Entity<ViewIltec1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Iltec1");

            entity.Property(e => e.CedProfesor)
                .HasMaxLength(50)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasColumnName("extension");
        });

        modelBuilder.Entity<ViewIltec2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Iltec2");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Extension)
                .HasMaxLength(50)
                .HasColumnName("extension");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<ViewMateriasXcarreraSemestre>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MateriasXCarreraSemestre");

            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.CodMateria).HasColumnName("cod_materia");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.IdPlan).HasColumnName("ID_Plan");
            entity.Property(e => e.NomSemMateria)
                .HasMaxLength(50)
                .HasColumnName("Nom_sem_materia");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<ViewNumCar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewNumCar");

            entity.Property(e => e.CodCarrera).HasColumnName("cod_carrera");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<ViewPorAutorizarConHorariosTurno>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PorAutorizarConHorariosTurnos");

            entity.Property(e => e.AmPmF)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("am_pm_f");
            entity.Property(e => e.AmPmI)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("am_pm_i");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.Expr1)
                .HasMaxLength(13)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HFinal).HasColumnName("h_final");
            entity.Property(e => e.HInicial).HasColumnName("h_inicial");
            entity.Property(e => e.IdHorario)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_horario");
            entity.Property(e => e.MFinal).HasColumnName("m_final");
            entity.Property(e => e.MInicial).HasColumnName("m_inicial");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NombreDia)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("nombre_dia");
        });

        modelBuilder.Entity<ViewPreliFinalDoce2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PreliFinalDoce2024");

            entity.Property(e => e.Cant).HasColumnName("cant");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
        });

        modelBuilder.Entity<ViewSinPostgrado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SinPostgrado");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Postgrado)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewUlt3AnioV2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Ult3Anio-V2");

            entity.Property(e => e.Apellido)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CedProfesor)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ced_profesor");
            entity.Property(e => e.CodExtension).HasColumnName("cod_extension");
            entity.Property(e => e.Nombre)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
