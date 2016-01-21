namespace DALSupervision.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=SirccXE")
        {
        }

        public virtual DbSet<ACTAPARCIAL> ACTAPARCIAL { get; set; }
        public virtual DbSet<ADICIONES> ADICIONES { get; set; }
        public virtual DbSet<AN_PCONTRATO> AN_PCONTRATO { get; set; }
        public virtual DbSet<ANX_CONTRATOS> ANX_CONTRATOS { get; set; }
        public virtual DbSet<ASEGURADORAS> ASEGURADORAS { get; set; }
        public virtual DbSet<AUDI_CONTRATOS> AUDI_CONTRATOS { get; set; }
        public virtual DbSet<AUDITORIA> AUDITORIA { get; set; }
        public virtual DbSet<C_FORMA_PAGO> C_FORMA_PAGO { get; set; }
        public virtual DbSet<C_POLIZAS2> C_POLIZAS2 { get; set; }
        public virtual DbSet<C_RUBROS_CDP> C_RUBROS_CDP { get; set; }
        public virtual DbSet<CAL_VIG_POL> CAL_VIG_POL { get; set; }
        public virtual DbSet<CALCULOPOL> CALCULOPOL { get; set; }
        public virtual DbSet<CDP_ADICIONES> CDP_ADICIONES { get; set; }
        public virtual DbSet<CDP_CONTRATOS> CDP_CONTRATOS { get; set; }
        public virtual DbSet<CESIONES> CESIONES { get; set; }
        public virtual DbSet<CFORMA_PAGO> CFORMA_PAGO { get; set; }
        public virtual DbSet<COBLIGACIONES> COBLIGACIONES { get; set; }
        public virtual DbSet<CON_POLIZAS> CON_POLIZAS { get; set; }
        public virtual DbSet<CONFIGURACION> CONFIGURACION { get; set; }
        public virtual DbSet<CONMUN> CONMUN { get; set; }
        public virtual DbSet<CONS_PROC> CONS_PROC { get; set; }
        public virtual DbSet<CONSORCIOSUTXC> CONSORCIOSUTXC { get; set; }
        public virtual DbSet<CONTRATOS> CONTRATOS { get; set; }
        public virtual DbSet<CORREOSE> CORREOSE { get; set; }
        public virtual DbSet<CPROYECTOS> CPROYECTOS { get; set; }
        public virtual DbSet<CUBRIMIENTO> CUBRIMIENTO { get; set; }
        public virtual DbSet<DEPENDENCIA> DEPENDENCIA { get; set; }
        public virtual DbSet<DOC_PLANTILLA> DOC_PLANTILLA { get; set; }
        public virtual DbSet<DOC_SECCIONES> DOC_SECCIONES { get; set; }
        public virtual DbSet<DOCPCONTRATOS> DOCPCONTRATOS { get; set; }
        public virtual DbSet<DOCU_PROC> DOCU_PROC { get; set; }
        public virtual DbSet<DT_PARAMETROS> DT_PARAMETROS { get; set; }
        public virtual DbSet<EP_CAP_JUR> EP_CAP_JUR { get; set; }
        public virtual DbSet<EP_CARGO> EP_CARGO { get; set; }
        public virtual DbSet<EP_CDP> EP_CDP { get; set; }
        public virtual DbSet<EP_CLAUSULAS> EP_CLAUSULAS { get; set; }
        public virtual DbSet<EP_CODIGOSUNSPSC> EP_CODIGOSUNSPSC { get; set; }
        public virtual DbSet<EP_CONMUN> EP_CONMUN { get; set; }
        public virtual DbSet<EP_DT_CAP_JUR> EP_DT_CAP_JUR { get; set; }
        public virtual DbSet<EP_DT_UNIDADES> EP_DT_UNIDADES { get; set; }
        public virtual DbSet<EP_ESPTEC> EP_ESPTEC { get; set; }
        public virtual DbSet<EP_ESTADOS> EP_ESTADOS { get; set; }
        public virtual DbSet<EP_ESTFLU> EP_ESTFLU { get; set; }
        public virtual DbSet<EP_FORMA_PAGO> EP_FORMA_PAGO { get; set; }
        public virtual DbSet<EP_HESTADOEP> EP_HESTADOEP { get; set; }
        public virtual DbSet<EP_MPAA> EP_MPAA { get; set; }
        public virtual DbSet<EP_OBLIGACIONESC> EP_OBLIGACIONESC { get; set; }
        public virtual DbSet<EP_OBLIGACIONESE> EP_OBLIGACIONESE { get; set; }
        public virtual DbSet<EP_PAA> EP_PAA { get; set; }
        public virtual DbSet<EP_PAA_UNSPSC> EP_PAA_UNSPSC { get; set; }
        public virtual DbSet<EP_POLIZAS> EP_POLIZAS { get; set; }
        public virtual DbSet<EP_POLIZAS2> EP_POLIZAS2 { get; set; }
        public virtual DbSet<EP_PROYECTOS> EP_PROYECTOS { get; set; }
        public virtual DbSet<EP_RIESGOS> EP_RIESGOS { get; set; }
        public virtual DbSet<EP_RUBROS_CDP> EP_RUBROS_CDP { get; set; }
        public virtual DbSet<EP_UNSPSC> EP_UNSPSC { get; set; }
        public virtual DbSet<ESTADOS> ESTADOS { get; set; }
        public virtual DbSet<ESTADOSGENERALES> ESTADOSGENERALES { get; set; }
        public virtual DbSet<ESTCONTRATOS> ESTCONTRATOS { get; set; }
        public virtual DbSet<ESTPREV> ESTPREV { get; set; }
        public virtual DbSet<ETAPAS> ETAPAS { get; set; }
        public virtual DbSet<GD_CT_OFICIOS> GD_CT_OFICIOS { get; set; }
        public virtual DbSet<GD_DDOCUMENTOS> GD_DDOCUMENTOS { get; set; }
        public virtual DbSet<GD_DOC_ACTAS> GD_DOC_ACTAS { get; set; }
        public virtual DbSet<GD_DOCUMENTOS> GD_DOCUMENTOS { get; set; }
        public virtual DbSet<GPOBLIGACIONES> GPOBLIGACIONES { get; set; }
        public virtual DbSet<GPPOLIZAS> GPPOLIZAS { get; set; }
        public virtual DbSet<GPPROPONENTES> GPPROPONENTES { get; set; }
        public virtual DbSet<GPPROYECTOS> GPPROYECTOS { get; set; }
        public virtual DbSet<GPROCESOS> GPROCESOS { get; set; }
        public virtual DbSet<GR_TIP_OFI> GR_TIP_OFI { get; set; }
        public virtual DbSet<HCONTRATOS> HCONTRATOS { get; set; }
        public virtual DbSet<HDEP_ABOGADOS> HDEP_ABOGADOS { get; set; }
        public virtual DbSet<HMOD_CONTRATOS> HMOD_CONTRATOS { get; set; }
        public virtual DbSet<HOJAS_RUTAS> HOJAS_RUTAS { get; set; }
        public virtual DbSet<HORAS> HORAS { get; set; }
        public virtual DbSet<HREVISADO> HREVISADO { get; set; }
        public virtual DbSet<IMP_CONTRATOS> IMP_CONTRATOS { get; set; }
        public virtual DbSet<IMPUESTOS> IMPUESTOS { get; set; }
        public virtual DbSet<INT_CONTROL_DOC> INT_CONTROL_DOC { get; set; }
        public virtual DbSet<INT_DETCUENTA> INT_DETCUENTA { get; set; }
        public virtual DbSet<INT_DETTRASLADO> INT_DETTRASLADO { get; set; }
        public virtual DbSet<INT_INFOCONT> INT_INFOCONT { get; set; }
        public virtual DbSet<INT_PAGOSST> INT_PAGOSST { get; set; }
        public virtual DbSet<INT_PPLANTILLAS_URL> INT_PPLANTILLAS_URL { get; set; }
        public virtual DbSet<INT_TRASLADOS> INT_TRASLADOS { get; set; }
        public virtual DbSet<INTERVENTORES_CONTRATO> INTERVENTORES_CONTRATO { get; set; }
        public virtual DbSet<INTTIPO_ESS> INTTIPO_ESS { get; set; }
        public virtual DbSet<MENU> MENU { get; set; }
        public virtual DbSet<MENU_PERFIL> MENU_PERFIL { get; set; }
        public virtual DbSet<MENU2> MENU2 { get; set; }
        public virtual DbSet<MENUMB> MENUMB { get; set; }
        public virtual DbSet<MIN_MOD_CONTRATO> MIN_MOD_CONTRATO { get; set; }
        public virtual DbSet<MOD_CDP_CONTRATOS> MOD_CDP_CONTRATOS { get; set; }
        public virtual DbSet<MOD_CFORMA_PAGO> MOD_CFORMA_PAGO { get; set; }
        public virtual DbSet<MOD_COBLIGACIONES> MOD_COBLIGACIONES { get; set; }
        public virtual DbSet<MOD_CON_POLIZAS> MOD_CON_POLIZAS { get; set; }
        public virtual DbSet<MOD_CONMUN> MOD_CONMUN { get; set; }
        public virtual DbSet<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }
        public virtual DbSet<MOD_PROPONENTES> MOD_PROPONENTES { get; set; }
        public virtual DbSet<MOD_TIP_PLA> MOD_TIP_PLA { get; set; }
        public virtual DbSet<MODULOS> MODULOS { get; set; }
        public virtual DbSet<MUNICIPIOS> MUNICIPIOS { get; set; }
        public virtual DbSet<NROCONVIG> NROCONVIG { get; set; }
        public virtual DbSet<NUMPROP> NUMPROP { get; set; }
        public virtual DbSet<ORA_ASPNET_APPLICATIONS> ORA_ASPNET_APPLICATIONS { get; set; }
        public virtual DbSet<ORA_ASPNET_MEMBERSHIP> ORA_ASPNET_MEMBERSHIP { get; set; }
        public virtual DbSet<ORA_ASPNET_PATHS> ORA_ASPNET_PATHS { get; set; }
        public virtual DbSet<ORA_ASPNET_PERSONALIZNPERUSER> ORA_ASPNET_PERSONALIZNPERUSER { get; set; }
        public virtual DbSet<ORA_ASPNET_PROFILE> ORA_ASPNET_PROFILE { get; set; }
        public virtual DbSet<ORA_ASPNET_ROLES> ORA_ASPNET_ROLES { get; set; }
        public virtual DbSet<ORA_ASPNET_SESSIONAPPLICATIONS> ORA_ASPNET_SESSIONAPPLICATIONS { get; set; }
        public virtual DbSet<ORA_ASPNET_SESSIONS> ORA_ASPNET_SESSIONS { get; set; }
        public virtual DbSet<ORA_ASPNET_SITEMAP> ORA_ASPNET_SITEMAP { get; set; }
        public virtual DbSet<ORA_ASPNET_USERS> ORA_ASPNET_USERS { get; set; }
        public virtual DbSet<PACTIVIDADES> PACTIVIDADES { get; set; }
        public virtual DbSet<PAGOS_GPROCESOS> PAGOS_GPROCESOS { get; set; }
        public virtual DbSet<PAGOS_PARCIALES> PAGOS_PARCIALES { get; set; }
        public virtual DbSet<PCLAUSULAS> PCLAUSULAS { get; set; }
        public virtual DbSet<PCONMUN> PCONMUN { get; set; }
        public virtual DbSet<PCONTRATOS> PCONTRATOS { get; set; }
        public virtual DbSet<PCRONO_DIAS> PCRONO_DIAS { get; set; }
        public virtual DbSet<PCRONOGRAMAS> PCRONOGRAMAS { get; set; }
        public virtual DbSet<PESTADOS> PESTADOS { get; set; }
        public virtual DbSet<PESTADOSACT> PESTADOSACT { get; set; }
        public virtual DbSet<PGCONTRATOSM> PGCONTRATOSM { get; set; }
        public virtual DbSet<PL_PLANTILLA> PL_PLANTILLA { get; set; }
        public virtual DbSet<PL_SECCIONES> PL_SECCIONES { get; set; }
        public virtual DbSet<PL_TIPOS_PLANTILLA> PL_TIPOS_PLANTILLA { get; set; }
        public virtual DbSet<PLANTILLAPPAL> PLANTILLAPPAL { get; set; }
        public virtual DbSet<POBLIGACIONES> POBLIGACIONES { get; set; }
        public virtual DbSet<POLIZAS> POLIZAS { get; set; }
        public virtual DbSet<POLIZAS_ADICIONES> POLIZAS_ADICIONES { get; set; }
        public virtual DbSet<POLIZAS_CONTRATO> POLIZAS_CONTRATO { get; set; }
        public virtual DbSet<PPLANTILLAS> PPLANTILLAS { get; set; }
        public virtual DbSet<PPLANTILLAS_CAMPOS> PPLANTILLAS_CAMPOS { get; set; }
        public virtual DbSet<PPLANTILLAS_FORMATO_TABLAS> PPLANTILLAS_FORMATO_TABLAS { get; set; }
        public virtual DbSet<PPOLIZAS> PPOLIZAS { get; set; }
        public virtual DbSet<PPROPONENTES> PPROPONENTES { get; set; }
        public virtual DbSet<PPROPONENTESS> PPROPONENTESS { get; set; }
        public virtual DbSet<PR_DB_CLAUSULAS> PR_DB_CLAUSULAS { get; set; }
        public virtual DbSet<PROYECTOS> PROYECTOS { get; set; }
        public virtual DbSet<PSOLICITUDES> PSOLICITUDES { get; set; }
        public virtual DbSet<PUNIDADES> PUNIDADES { get; set; }
        public virtual DbSet<RP_ADICIONES> RP_ADICIONES { get; set; }
        public virtual DbSet<RP_CONTRATOS> RP_CONTRATOS { get; set; }
        public virtual DbSet<RP_CONTRATOS_A> RP_CONTRATOS_A { get; set; }
        public virtual DbSet<RPT_CONTROL> RPT_CONTROL { get; set; }
        public virtual DbSet<RUBROS> RUBROS { get; set; }
        public virtual DbSet<RUBROS_ADICIONES> RUBROS_ADICIONES { get; set; }
        public virtual DbSet<RUBROS_CONTRATOS> RUBROS_CONTRATOS { get; set; }
        public virtual DbSet<RUBROS_GPROCESOS> RUBROS_GPROCESOS { get; set; }
        public virtual DbSet<RUBROS_PCONTRATOS> RUBROS_PCONTRATOS { get; set; }
        public virtual DbSet<RUBROS_RCONTRATOS> RUBROS_RCONTRATOS { get; set; }
        public virtual DbSet<SECTOR> SECTOR { get; set; }
        public virtual DbSet<SOL_ADICIONES> SOL_ADICIONES { get; set; }
        public virtual DbSet<SUBTIPOS> SUBTIPOS { get; set; }
        public virtual DbSet<TERCEROS> TERCEROS { get; set; }
        public virtual DbSet<TERCEROSDESKTOP> TERCEROSDESKTOP { get; set; }
        public virtual DbSet<TIP_DOC> TIP_DOC { get; set; }
        public virtual DbSet<TIPO_ADCIONES> TIPO_ADCIONES { get; set; }
        public virtual DbSet<TIPO_AGENT> TIPO_AGENT { get; set; }
        public virtual DbSet<TIPO_INTERVENTOR> TIPO_INTERVENTOR { get; set; }
        public virtual DbSet<TIPO_PAGO> TIPO_PAGO { get; set; }
        public virtual DbSet<TIPO_PLAZOS> TIPO_PLAZOS { get; set; }
        public virtual DbSet<TIPOSCONT> TIPOSCONT { get; set; }
        public virtual DbSet<TIPOSGASTOS> TIPOSGASTOS { get; set; }
        public virtual DbSet<TIPOSPROC> TIPOSPROC { get; set; }
        public virtual DbSet<TIPPLANTILLAS> TIPPLANTILLAS { get; set; }
        public virtual DbSet<TIPPROPONENTE> TIPPROPONENTE { get; set; }
        public virtual DbSet<USUARIOS> USUARIOS { get; set; }
        public virtual DbSet<VIGENCIAS> VIGENCIAS { get; set; }
        public virtual DbSet<CDP_GPROCESOS> CDP_GPROCESOS { get; set; }
        public virtual DbSet<CDP_PCONTRATOS> CDP_PCONTRATOS { get; set; }
        public virtual DbSet<CMINUTAS> CMINUTAS { get; set; }
        public virtual DbSet<CONSORCIOSUT> CONSORCIOSUT { get; set; }
        public virtual DbSet<CTRL_ENTIDAD> CTRL_ENTIDAD { get; set; }
        public virtual DbSet<HAUDITORIA> HAUDITORIA { get; set; }
        public virtual DbSet<HREVSOLADI> HREVSOLADI { get; set; }
        public virtual DbSet<IMP_ADICIONES> IMP_ADICIONES { get; set; }
        public virtual DbSet<MOD_CPROYECTOS> MOD_CPROYECTOS { get; set; }
        public virtual DbSet<ORA_ASPNET_PERSONALIZNALLUSERS> ORA_ASPNET_PERSONALIZNALLUSERS { get; set; }
        public virtual DbSet<PAGAUT> PAGAUT { get; set; }
        public virtual DbSet<RP> RP { get; set; }
        public virtual DbSet<RUBROS_CONTRATOS_2008_2010> RUBROS_CONTRATOS_2008_2010 { get; set; }
        public virtual DbSet<RUBROS_CONTRATOS_X> RUBROS_CONTRATOS_X { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACTAPARCIAL>()
                .Property(e => e.AUT_PAG)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAPARCIAL>()
                .Property(e => e.VAL_AUT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ACTAPARCIAL>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<ACTAPARCIAL>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.NRO_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.VAL_ADI)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.DOC_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.TIP_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.LEGALIZADO)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.OBSER)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.EXENPOL)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.TIPO_PLAZO1_ADI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.PLAZO2_ADI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.TIPO_PLAZO2_ADI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.VAL_APO_GOB_ADI)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.VAL_SIN_IVA_ADI)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.RES_APR_POL)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.USAP_M)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.USBD_M)
                .IsUnicode(false);

            modelBuilder.Entity<ADICIONES>()
                .Property(e => e.DES_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<AN_PCONTRATO>()
                .Property(e => e.PRO_SEL_NRO)
                .IsUnicode(false);

            modelBuilder.Entity<AN_PCONTRATO>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<ANX_CONTRATOS>()
                .Property(e => e.TIP_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<ANX_CONTRATOS>()
                .Property(e => e.NOM_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<ANX_CONTRATOS>()
                .Property(e => e.OBS_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<ANX_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<ANX_CONTRATOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ASEGURADORAS>()
                .Property(e => e.NOM_ASE)
                .IsUnicode(false);

            modelBuilder.Entity<ASEGURADORAS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ASEGURADORAS>()
                .HasMany(e => e.POLIZAS_CONTRATO)
                .WithRequired(e => e.ASEGURADORAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ASEGURADORAS>()
                .HasMany(e => e.POLIZAS_ADICIONES)
                .WithRequired(e => e.ASEGURADORAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ASEGURADORAS>()
                .HasMany(e => e.PPROPONENTESS)
                .WithOptional(e => e.ASEGURADORAS)
                .HasForeignKey(e => e.ASEGURADORA);

            modelBuilder.Entity<AUDI_CONTRATOS>()
                .Property(e => e.TABLA)
                .IsUnicode(false);

            modelBuilder.Entity<AUDI_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<AUDI_CONTRATOS>()
                .Property(e => e.CAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<AUDI_CONTRATOS>()
                .Property(e => e.VALOR_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<AUDI_CONTRATOS>()
                .Property(e => e.VALOR_NUEVO)
                .IsUnicode(false);

            modelBuilder.Entity<AUDI_CONTRATOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<AUDI_CONTRATOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<AUDI_CONTRATOS>()
                .Property(e => e.ID_AUDICON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.OBJ_AUD)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.ACC_AUD)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.USU_AUD)
                .IsUnicode(false);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.ORD_FPAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.TIP_FPAG)
                .IsUnicode(false);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.VAL_FPAG)
                .HasPrecision(17, 4);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.POR_FPAG)
                .HasPrecision(17, 4);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.CON_FPAG)
                .IsUnicode(false);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.PGEN_FPAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.USAP_REG)
                .IsUnicode(false);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<C_FORMA_PAGO>()
                .Property(e => e.CAN_PAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<C_POLIZAS2>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<C_POLIZAS2>()
                .Property(e => e.DES_POL)
                .IsUnicode(false);

            modelBuilder.Entity<C_POLIZAS2>()
                .Property(e => e.PLA_POL)
                .IsUnicode(false);

            modelBuilder.Entity<C_POLIZAS2>()
                .Property(e => e.VAL_POL)
                .IsUnicode(false);

            modelBuilder.Entity<C_POLIZAS2>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<C_RUBROS_CDP>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<C_RUBROS_CDP>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<C_RUBROS_CDP>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<C_RUBROS_CDP>()
                .Property(e => e.VALOR)
                .HasPrecision(17, 2);

            modelBuilder.Entity<C_RUBROS_CDP>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<C_RUBROS_CDP>()
                .Property(e => e.USAP_REG)
                .IsUnicode(false);

            modelBuilder.Entity<C_RUBROS_CDP>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<CAL_VIG_POL>()
                .Property(e => e.COD_CAL)
                .IsUnicode(false);

            modelBuilder.Entity<CAL_VIG_POL>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<CAL_VIG_POL>()
                .HasMany(e => e.EP_POLIZAS)
                .WithOptional(e => e.CAL_VIG_POL)
                .HasForeignKey(e => e.APARTIRDE);

            modelBuilder.Entity<CAL_VIG_POL>()
                .HasMany(e => e.PPOLIZAS)
                .WithOptional(e => e.CAL_VIG_POL)
                .HasForeignKey(e => e.APARTIRDE);

            modelBuilder.Entity<CALCULOPOL>()
                .Property(e => e.COD_CAL)
                .IsUnicode(false);

            modelBuilder.Entity<CALCULOPOL>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<CALCULOPOL>()
                .HasMany(e => e.EP_POLIZAS)
                .WithOptional(e => e.CALCULOPOL)
                .HasForeignKey(e => e.CAL_APARTIRDE);

            modelBuilder.Entity<CALCULOPOL>()
                .HasMany(e => e.PPOLIZAS)
                .WithOptional(e => e.CALCULOPOL)
                .HasForeignKey(e => e.CAL_APARTIRDE);

            modelBuilder.Entity<CDP_ADICIONES>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<CDP_ADICIONES>()
                .Property(e => e.NRO_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<CDP_CONTRATOS>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<CDP_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CDP_CONTRATOS>()
                .Property(e => e.VAL_CDP)
                .HasPrecision(17, 3);

            modelBuilder.Entity<CDP_CONTRATOS>()
                .Property(e => e.VIG_FUT)
                .IsUnicode(false);

            modelBuilder.Entity<CDP_CONTRATOS>()
                .HasMany(e => e.C_RUBROS_CDP)
                .WithOptional(e => e.CDP_CONTRATOS)
                .HasForeignKey(e => new { e.NRO_CDP, e.COD_CON });

            modelBuilder.Entity<CDP_CONTRATOS>()
                .HasMany(e => e.RP_CONTRATOS)
                .WithOptional(e => e.CDP_CONTRATOS)
                .HasForeignKey(e => new { e.NRO_CDP, e.COD_CON });

            modelBuilder.Entity<CESIONES>()
                .Property(e => e.NIT_ANT)
                .IsUnicode(false);

            modelBuilder.Entity<CESIONES>()
                .Property(e => e.NIT_NUE)
                .IsUnicode(false);

            modelBuilder.Entity<CESIONES>()
                .Property(e => e.RES_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<CESIONES>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.TIPO_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.VALOR_PAGO)
                .HasPrecision(17, 4);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.PORCENTAJE)
                .HasPrecision(17, 4);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.CONDICION_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<CFORMA_PAGO>()
                .Property(e => e.PAGA_GOBER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COBLIGACIONES>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<COBLIGACIONES>()
                .Property(e => e.DES_OBLIG2)
                .IsUnicode(false);

            modelBuilder.Entity<COBLIGACIONES>()
                .Property(e => e.DES_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<CON_POLIZAS>()
                .Property(e => e.COD_POL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CON_POLIZAS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CON_POLIZAS>()
                .Property(e => e.POR_SMMLV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CON_POLIZAS>()
                .Property(e => e.CAL_APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<CON_POLIZAS>()
                .Property(e => e.VIGENCIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CON_POLIZAS>()
                .Property(e => e.APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<CON_POLIZAS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURACION>()
                .Property(e => e.PROPIEDAD)
                .IsUnicode(false);

            modelBuilder.Entity<CONFIGURACION>()
                .Property(e => e.VALOR)
                .IsUnicode(false);

            modelBuilder.Entity<CONMUN>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<CONMUN>()
                .Property(e => e.NRO_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONS_PROC>()
                .Property(e => e.DEP_DEL)
                .IsUnicode(false);

            modelBuilder.Entity<CONS_PROC>()
                .Property(e => e.TIP_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<CONS_PROC>()
                .Property(e => e.INICIAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONS_PROC>()
                .Property(e => e.SIGUIENTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.IDE_TER)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.ID_MIEMBROS)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.ID_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.PORC_PART)
                .HasPrecision(10, 4);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONSORCIOSUTXC>()
                .Property(e => e.ID_PROP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.IDE_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.OBJ_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.PRO_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.DEP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.TIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.STIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.EST_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.VAL_CON)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.DOC_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.VAL_ADI)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.COD_SEC)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.TIP_FOR)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.OTR_CNS)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.COD_TPRO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.NRO_PLA_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.IDE_REP)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.OBS_DOC_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.URG_MAN)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.EST_CONV)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.EXO_IMP)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.EXO_OBS)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.PRO_SEL_NRO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.DEP_PCON)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.VAL_APO_GOB)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.COD_CON0)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.USER_ACT)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.LEGALIZADO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.PER_APO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.ANTICIPO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.AGOTAR_PPTO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.LUG_EJE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.TIPO_PLAZO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.TIP_RADICACION)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.ENCARGADO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.CONSIDERANDOS)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.APORTES)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.PLAZO2_EJE_CON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.TIPO_PLAZO2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.VAL_SIN_IVA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.INTERVENTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.EXENPOL)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.OBS_POLIZA)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.OBS_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.OBS_PROYECTOS)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.REVISADOPOR)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.RES_APR_POL)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.DEP_SUP)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.TIPO_FP)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.ANTI_PORC)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.PLIQ_EP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.OBLIGC)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .Property(e => e.OBLIGE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTRATOS>()
                .HasMany(e => e.ADICIONES)
                .WithRequired(e => e.CONTRATOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATOS>()
                .HasMany(e => e.CDP_CONTRATOS)
                .WithRequired(e => e.CONTRATOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATOS>()
                .HasMany(e => e.CFORMA_PAGO)
                .WithRequired(e => e.CONTRATOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATOS>()
                .HasMany(e => e.ESTCONTRATOS)
                .WithRequired(e => e.CONTRATOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATOS>()
                .HasMany(e => e.INTERVENTORES_CONTRATO)
                .WithRequired(e => e.CONTRATOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRATOS>()
                .HasMany(e => e.TERCEROS1)
                .WithMany(e => e.CONTRATOS1)
                .Map(m => m.ToTable("SUPERVISORES_CONTRATO", "SIRCC").MapLeftKey("COD_CON").MapRightKey("IDE_SUP"));

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_CODI)
                .IsUnicode(false);

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_NOMB)
                .IsUnicode(false);

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_DATO)
                .IsUnicode(false);

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_BODY)
                .IsUnicode(false);

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_ESTA)
                .IsUnicode(false);

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_USAP)
                .IsUnicode(false);

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_USBD)
                .IsUnicode(false);

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_CAMP)
                .IsUnicode(false);

            modelBuilder.Entity<CORREOSE>()
                .Property(e => e.CORR_VISTA)
                .IsUnicode(false);

            modelBuilder.Entity<CPROYECTOS>()
                .Property(e => e.PROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<CPROYECTOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<CPROYECTOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<CPROYECTOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<CPROYECTOS>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<CPROYECTOS>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<CPROYECTOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CUBRIMIENTO>()
                .Property(e => e.COD_CUB)
                .IsUnicode(false);

            modelBuilder.Entity<CUBRIMIENTO>()
                .Property(e => e.NOM_CUB)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.COD_DEP)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.NOM_DEP)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.DEP_DEL)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.DEP_ABR)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.IDE_TER)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.NORMA_DEL)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.CARGO_ENC)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .Property(e => e.INT_PRO)
                .IsUnicode(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.CONS_PROC)
                .WithRequired(e => e.DEPENDENCIA)
                .HasForeignKey(e => e.DEP_DEL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.CONTRATOS)
                .WithRequired(e => e.DEPENDENCIA)
                .HasForeignKey(e => e.DEP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.CONTRATOS1)
                .WithOptional(e => e.DEPENDENCIA1)
                .HasForeignKey(e => e.DEP_PCON);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.DEPENDENCIA)
                .HasForeignKey(e => e.DEP_NEC_EP);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.ESTPREV1)
                .WithOptional(e => e.DEPENDENCIA1)
                .HasForeignKey(e => e.DEP_DEL_EP);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.ESTPREV2)
                .WithOptional(e => e.DEPENDENCIA2)
                .HasForeignKey(e => e.DEP_SUP_EP);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.PSOLICITUDES)
                .WithRequired(e => e.DEPENDENCIA)
                .HasForeignKey(e => e.DEP_PSOL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.PSOLICITUDES1)
                .WithRequired(e => e.DEPENDENCIA1)
                .HasForeignKey(e => e.DEP_SOL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.MOD_CONTRATOS)
                .WithRequired(e => e.DEPENDENCIA)
                .HasForeignKey(e => e.DEP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.MOD_CONTRATOS1)
                .WithOptional(e => e.DEPENDENCIA1)
                .HasForeignKey(e => e.DEP_PCON);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.PCONTRATOS)
                .WithRequired(e => e.DEPENDENCIA)
                .HasForeignKey(e => e.DEP_PCON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DEPENDENCIA>()
                .HasMany(e => e.PCONTRATOS1)
                .WithRequired(e => e.DEPENDENCIA1)
                .HasForeignKey(e => e.DEP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.NRO_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.NRO_REV)
                .IsUnicode(false);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.EST_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.ID_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .Property(e => e.EST_COMPLETADO)
                .IsUnicode(false);

            modelBuilder.Entity<DOC_PLANTILLA>()
                .HasMany(e => e.DOC_SECCIONES)
                .WithOptional(e => e.DOC_PLANTILLA)
                .HasForeignKey(e => e.ID_DOC);

            modelBuilder.Entity<DOC_SECCIONES>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DOC_SECCIONES>()
                .Property(e => e.ID_DOC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DOC_SECCIONES>()
                .Property(e => e.HTML)
                .IsUnicode(false);

            modelBuilder.Entity<DOC_SECCIONES>()
                .Property(e => e.CRUZADO)
                .IsUnicode(false);

            modelBuilder.Entity<DOCPCONTRATOS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<DOCPCONTRATOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DOCPCONTRATOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<DOCPCONTRATOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<DOCPCONTRATOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<DOCPCONTRATOS>()
                .Property(e => e.TIPDOCUMENTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DOCPCONTRATOS>()
                .Property(e => e.EDITABLE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DOCPCONTRATOS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<DOCU_PROC>()
                .Property(e => e.COD_TPROC)
                .IsUnicode(false);

            modelBuilder.Entity<DOCU_PROC>()
                .Property(e => e.COD_ETAPA)
                .IsUnicode(false);

            modelBuilder.Entity<DOCU_PROC>()
                .Property(e => e.COD_TDOC)
                .IsUnicode(false);

            modelBuilder.Entity<DOCU_PROC>()
                .Property(e => e.DOC_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<DOCU_PROC>()
                .Property(e => e.DOC_EST)
                .IsUnicode(false);

            modelBuilder.Entity<DT_PARAMETROS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<DT_PARAMETROS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<DT_PARAMETROS>()
                .Property(e => e.VALOR)
                .IsUnicode(false);

            modelBuilder.Entity<DT_PARAMETROS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CAP_JUR>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CAP_JUR>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CAP_JUR>()
                .Property(e => e.ID_CAPJ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CAP_JUR>()
                .Property(e => e.DES_CAPJ)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CARGO>()
                .Property(e => e.COD_CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CARGO>()
                .Property(e => e.DES_CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CARGO>()
                .Property(e => e.VIG_CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CARGO>()
                .Property(e => e.EST_CARGO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CDP>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CDP>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CDP>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CDP>()
                .Property(e => e.VAL_CDP)
                .HasPrecision(17, 3);

            modelBuilder.Entity<EP_CDP>()
                .Property(e => e.VIG_FUT)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CDP>()
                .Property(e => e.GRUPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CDP>()
                .Property(e => e.USAP_REG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CDP>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CDP>()
                .HasMany(e => e.EP_RUBROS_CDP)
                .WithOptional(e => e.EP_CDP)
                .HasForeignKey(e => e.ID_EP_CDP);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.ID_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.TIP_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.CLA_TIT)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.CLA_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.CLA_CAM)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.CLA_PAR)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.IDE_PMIN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.TIP_PAR)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.IS_ENTER_FINAL)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.CLA_TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CLAUSULAS>()
                .Property(e => e.CLA_CRUZADA)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CODIGOSUNSPSC>()
                .Property(e => e.UNSPSC)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CODIGOSUNSPSC>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CODIGOSUNSPSC>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CODIGOSUNSPSC>()
                .Property(e => e.CLASIFICADOR)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CODIGOSUNSPSC>()
                .Property(e => e.PADRE)
                .IsUnicode(false);

            modelBuilder.Entity<EP_CODIGOSUNSPSC>()
                .HasMany(e => e.EP_CODIGOSUNSPSC1)
                .WithOptional(e => e.EP_CODIGOSUNSPSC2)
                .HasForeignKey(e => e.PADRE);

            modelBuilder.Entity<EP_CONMUN>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CONMUN>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_CONMUN>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<EP_DT_CAP_JUR>()
                .Property(e => e.EST_CAPJ)
                .IsUnicode(false);

            modelBuilder.Entity<EP_DT_CAP_JUR>()
                .Property(e => e.DES_CAPJ)
                .IsUnicode(false);

            modelBuilder.Entity<EP_DT_CAP_JUR>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_DT_CAP_JUR>()
                .HasMany(e => e.EP_CAP_JUR)
                .WithOptional(e => e.EP_DT_CAP_JUR)
                .HasForeignKey(e => e.ID_CAPJ);

            modelBuilder.Entity<EP_DT_UNIDADES>()
                .Property(e => e.COD_UNI)
                .IsUnicode(false);

            modelBuilder.Entity<EP_DT_UNIDADES>()
                .Property(e => e.NOM_UNI)
                .IsUnicode(false);

            modelBuilder.Entity<EP_DT_UNIDADES>()
                .HasMany(e => e.EP_ESPTEC)
                .WithOptional(e => e.EP_DT_UNIDADES)
                .HasForeignKey(e => e.UNI_ITEM);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.DESC_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.CANT_ITEM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.UNI_ITEM)
                .IsUnicode(false);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.VAL_UNI_ITEM)
                .HasPrecision(17, 2);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.PORC_IVA)
                .HasPrecision(5, 3);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.USAP_REG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<EP_ESPTEC>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_ESTADOS>()
                .Property(e => e.COD_EST)
                .IsUnicode(false);

            modelBuilder.Entity<EP_ESTADOS>()
                .Property(e => e.NOM_EST)
                .IsUnicode(false);

            modelBuilder.Entity<EP_ESTADOS>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.EP_ESTADOS)
                .HasForeignKey(e => e.EST_EP);

            modelBuilder.Entity<EP_ESTFLU>()
                .Property(e => e.COD_EST)
                .IsUnicode(false);

            modelBuilder.Entity<EP_ESTFLU>()
                .Property(e => e.NOM_EST)
                .IsUnicode(false);

            modelBuilder.Entity<EP_ESTFLU>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.EP_ESTFLU)
                .HasForeignKey(e => e.EST_FLU_EP);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.ORD_FPAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.TIP_FPAG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.VAL_FPAG)
                .HasPrecision(17, 4);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.POR_FPAG)
                .HasPrecision(17, 4);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.CON_FPAG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.PGEN_FPAG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.USAP_REG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<EP_FORMA_PAGO>()
                .Property(e => e.CAN_PAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_HESTADOEP>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_HESTADOEP>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_HESTADOEP>()
                .Property(e => e.USAP_EP)
                .IsUnicode(false);

            modelBuilder.Entity<EP_HESTADOEP>()
                .Property(e => e.OBS_EP)
                .IsUnicode(false);

            modelBuilder.Entity<EP_HESTADOEP>()
                .Property(e => e.TIP_EP)
                .IsUnicode(false);

            modelBuilder.Entity<EP_HESTADOEP>()
                .Property(e => e.EST_EP)
                .IsUnicode(false);

            modelBuilder.Entity<EP_HESTADOEP>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.EP_HESTADOEP)
                .HasForeignKey(e => e.ID_APR);

            modelBuilder.Entity<EP_HESTADOEP>()
                .HasMany(e => e.ESTPREV1)
                .WithOptional(e => e.EP_HESTADOEP1)
                .HasForeignKey(e => e.ID_REV);

            modelBuilder.Entity<EP_MPAA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_MPAA>()
                .Property(e => e.OBSERV)
                .IsUnicode(false);

            modelBuilder.Entity<EP_MPAA>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_MPAA>()
                .Property(e => e.COD_SECOP)
                .IsUnicode(false);

            modelBuilder.Entity<EP_MPAA>()
                .HasMany(e => e.EP_PAA)
                .WithOptional(e => e.EP_MPAA)
                .HasForeignKey(e => e.ID_EP_MPAA);

            modelBuilder.Entity<EP_OBLIGACIONESC>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_OBLIGACIONESC>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_OBLIGACIONESC>()
                .Property(e => e.DES_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_OBLIGACIONESC>()
                .Property(e => e.GRUPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_OBLIGACIONESE>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_OBLIGACIONESE>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_OBLIGACIONESE>()
                .Property(e => e.DES_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_OBLIGACIONESE>()
                .Property(e => e.GRUPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.PLA1_EJE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.TIP1_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.PLA2_EJE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.TIP2_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.MOD_SEL)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.FUE_SEL)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.VAL_TOT_EST)
                .HasPrecision(17, 2);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.VAL_VIG_EST)
                .HasPrecision(17, 2);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.VIG_FUT)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.EST_SOL_VF)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.DAT_RESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.COD_DEP)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PAA>()
                .Property(e => e.ID_EP_MPAA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_PAA>()
                .HasMany(e => e.EP_PAA_UNSPSC)
                .WithOptional(e => e.EP_PAA)
                .HasForeignKey(e => e.ID_EP_PAA);

            modelBuilder.Entity<EP_PAA>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.EP_PAA)
                .HasForeignKey(e => e.PAAID);

            modelBuilder.Entity<EP_PAA_UNSPSC>()
                .Property(e => e.UNSPSC)
                .IsUnicode(false);

            modelBuilder.Entity<EP_POLIZAS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_POLIZAS>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_POLIZAS>()
                .Property(e => e.POR_SMMLV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_POLIZAS>()
                .Property(e => e.CAL_APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<EP_POLIZAS>()
                .Property(e => e.VIGENCIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_POLIZAS>()
                .Property(e => e.APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<EP_POLIZAS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_POLIZAS2>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_POLIZAS2>()
                .Property(e => e.DES_POL)
                .IsUnicode(false);

            modelBuilder.Entity<EP_POLIZAS2>()
                .Property(e => e.PLA_POL)
                .IsUnicode(false);

            modelBuilder.Entity<EP_POLIZAS2>()
                .Property(e => e.VAL_POL)
                .IsUnicode(false);

            modelBuilder.Entity<EP_POLIZAS2>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_PROYECTOS>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_PROYECTOS>()
                .Property(e => e.COD_PRO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PROYECTOS>()
                .Property(e => e.USAP_REG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_PROYECTOS>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.N)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.FUENTE)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.ETAPA)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.CONSECUENCIAS)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.CATEGORIA_R)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.AQUIENSEASIGNA)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.TRATAMIENTO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.CATEGORIA_T)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.AFECTAEJECUCIONCTO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.RESPONSABLE)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.FORMA_MONITOREO)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RIESGOS>()
                .Property(e => e.PERIOCIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RUBROS_CDP>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_RUBROS_CDP>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_RUBROS_CDP>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RUBROS_CDP>()
                .Property(e => e.VALOR)
                .HasPrecision(17, 2);

            modelBuilder.Entity<EP_RUBROS_CDP>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RUBROS_CDP>()
                .Property(e => e.USAP_REG)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RUBROS_CDP>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<EP_RUBROS_CDP>()
                .Property(e => e.ID_EP_CDP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_UNSPSC>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_UNSPSC>()
                .Property(e => e.ID_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<EP_UNSPSC>()
                .Property(e => e.UNSPSC)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .Property(e => e.COD_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .Property(e => e.NOM_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .Property(e => e.TIP_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .Property(e => e.SIGLA)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.CONTRATOS)
                .WithRequired(e => e.ESTADOS)
                .HasForeignKey(e => e.EST_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.ESTCONTRATOS)
                .WithRequired(e => e.ESTADOS)
                .HasForeignKey(e => e.EST_FIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.ESTCONTRATOS1)
                .WithRequired(e => e.ESTADOS1)
                .HasForeignKey(e => e.EST_INI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.MOD_CONTRATOS)
                .WithRequired(e => e.ESTADOS)
                .HasForeignKey(e => e.EST_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTADOS>()
                .HasMany(e => e.ESTADOS1)
                .WithMany(e => e.ESTADOS2)
                .Map(m => m.ToTable("EST_RUTA", "SIRCC").MapLeftKey("EST_INI").MapRightKey("EST_FIN"));

            modelBuilder.Entity<ESTADOSGENERALES>()
                .Property(e => e.COD_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADOSGENERALES>()
                .Property(e => e.NOM_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.EST_INI)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.EST_FIN)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.DOC_ACT)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.OBS_EST)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.VAL_PAGO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.POR_EJE_FIS)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.POR_EJE_FIS_PER)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.SALDO_PER)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.SAL_ANT)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.CLA_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.EST_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .Property(e => e.ID_CTRDOC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTCONTRATOS>()
                .HasOptional(e => e.ACTAPARCIAL)
                .WithRequired(e => e.ESTCONTRATOS);

            modelBuilder.Entity<ESTCONTRATOS>()
                .HasMany(e => e.INT_CONTROL_DOC1)
                .WithOptional(e => e.ESTCONTRATOS1)
                .HasForeignKey(e => e.IDACTA);

            modelBuilder.Entity<ESTCONTRATOS>()
                .HasMany(e => e.INT_DETCUENTA)
                .WithRequired(e => e.ESTCONTRATOS)
                .HasForeignKey(e => e.IDACTA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTCONTRATOS>()
                .HasMany(e => e.INT_INFOCONT)
                .WithOptional(e => e.ESTCONTRATOS)
                .HasForeignKey(e => e.ID_ACTA);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.OBJE_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.PLAZ1_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.TPLA1_EP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.PLAZ2_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.TPLA2_EP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.LUGE_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.PLIQ_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.VAL_ENT_EP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.VAL_OTR_EP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.IDE_DIL_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.DEP_NEC_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.STIP_CON_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.USAP_REG_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.USAP_MOD_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.USAP_REV_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.USAP_ELA_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.USAP_APR_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.USAP_ANU_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.USAP_DAN_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.DEP_SUP_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.VIG_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CODIGO_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.GRUPOS_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.NUM_EMP_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.IDE_RES_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.MOD_SEL_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.NRO_EP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.EST_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.EST_FLU_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.ES_PLAN_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.DEP_DEL_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.ENPLANC_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.NOM_PLA_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.ID_REV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.ID_APR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.OBLIGC)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.OBLIGE)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.PERSONA_APOYO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.ANTI_PORC)
                .HasPrecision(17, 2);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.TIPO_FP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.IDE_CON_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.IDE_REP_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.NEC_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.OBLIGGRC)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.OBLIGGRE)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.JUST_VALOR_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CAP_JURIDICA_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CAP_FINANCIERA_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CAP_RESIDUAL_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.PERS_LEGAL_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.PERS_ORGA_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CAP_EXPERIENCA_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.NEC_CONT_INT_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.SOM_ACUE_COMER_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CONST_CUMP_DEBERES_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.IDE_SUP_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CAR_SUP_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.COD_UNSPSC_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.DES_UNSPSC_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.ESP_OBJ_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.AUTPERLIC_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.DOCTECNICOS_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.VARIABLESPPTO_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.IDONEIDAD_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CAP_ORGANIZACIONAL_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.FACTORES_EVALUACION_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.REGLAS_DESEMPATE_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.TIPO_PPTO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.PAADESC)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.FUN_JUR_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CONSIDERACIONES_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.ACT_CONT_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.DESC_APORTES_PROPIOS_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.REQ_CDP_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.OBS_CDP_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.OBS_POL_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.REQ_POL_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.INICIO_APARTIR_DE_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .Property(e => e.CAR_RES_EP)
                .IsUnicode(false);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_CAP_JUR)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_CDP)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_CLAUSULAS)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_CONMUN)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_ESPTEC)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_FORMA_PAGO)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_OBLIGACIONESC)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_OBLIGACIONESE)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_POLIZAS)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_POLIZAS2)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_PROYECTOS)
                .WithRequired(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_RIESGOS)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ESTPREV>()
                .HasMany(e => e.EP_UNSPSC)
                .WithOptional(e => e.ESTPREV)
                .HasForeignKey(e => e.ID_EP);

            modelBuilder.Entity<ETAPAS>()
                .Property(e => e.COD_ETA)
                .IsUnicode(false);

            modelBuilder.Entity<ETAPAS>()
                .Property(e => e.NOM_ETA)
                .IsUnicode(false);

            modelBuilder.Entity<ETAPAS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ETAPAS>()
                .Property(e => e.PROCESO)
                .IsUnicode(false);

            modelBuilder.Entity<ETAPAS>()
                .HasMany(e => e.TIP_DOC)
                .WithOptional(e => e.ETAPAS)
                .HasForeignKey(e => e.COD_ETAPA);

            modelBuilder.Entity<GD_CT_OFICIOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GD_CT_OFICIOS>()
                .Property(e => e.TIP_OFI)
                .IsUnicode(false);

            modelBuilder.Entity<GD_CT_OFICIOS>()
                .Property(e => e.EST_OFI)
                .IsUnicode(false);

            modelBuilder.Entity<GD_CT_OFICIOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GD_DDOCUMENTOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GD_DOC_ACTAS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GD_DOC_ACTAS>()
                .Property(e => e.ID_DOC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GD_DOC_ACTAS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOC_ACTAS>()
                .Property(e => e.ID_INF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GD_DOC_ACTAS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOC_ACTAS>()
                .Property(e => e.EST_REL)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOC_ACTAS>()
                .Property(e => e.TIP_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .Property(e => e.LONGITUD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<GD_DOCUMENTOS>()
                .HasOptional(e => e.GD_DDOCUMENTOS)
                .WithRequired(e => e.GD_DOCUMENTOS);

            modelBuilder.Entity<GPOBLIGACIONES>()
                .Property(e => e.NUM_PCON)
                .IsUnicode(false);

            modelBuilder.Entity<GPOBLIGACIONES>()
                .Property(e => e.DES_OBLIG2)
                .IsUnicode(false);

            modelBuilder.Entity<GPOBLIGACIONES>()
                .Property(e => e.DES_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<GPPOLIZAS>()
                .Property(e => e.COD_POL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPPOLIZAS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<GPPOLIZAS>()
                .Property(e => e.POR_SMMLV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPPOLIZAS>()
                .Property(e => e.CAL_APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<GPPOLIZAS>()
                .Property(e => e.VIGENCIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPPOLIZAS>()
                .Property(e => e.APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<GPPOLIZAS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.IDE_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.VAL_PROP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.ADJUDICADO)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.OBSERVACION_ADJUDICACION)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.APE1_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.DIR_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.TEL_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.EMAIL_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.APE2_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.NOM1_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.NOM2_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.TIP_IDE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.EXP_IDE)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.DV_TER)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.RAZON_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.ORD_GAS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.CAR_FUN)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.DOC_DEL)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.NUM_FOLIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.ID_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.NOM_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.COD_AUX)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.NUMPOLIZA)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.VALOR_POLIZA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.DENOMINACION)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROPONENTES>()
                .Property(e => e.APORTES)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROYECTOS>()
                .Property(e => e.PROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROYECTOS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROYECTOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROYECTOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROYECTOS>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<GPPROYECTOS>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.PRO_SEL_NRO)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.IDE_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.OBJ_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.PRO_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.DEP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.DEP_PCON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.TIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.STIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.VAL_CON)
                .HasPrecision(17, 2);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.VAL_APO_GOB)
                .HasPrecision(17, 2);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.COD_SEC)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.TIP_FOR)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.OTR_CNS)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.NRO_PLA_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.IDE_REP)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.URG_MAN)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.EST_CONV)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.APL_GAC)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.EST_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.LUG_EJE)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.USUENCARGADO)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.NUM_SOL)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.COD_TPRO)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.TIPO_PLAZO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.DESC_GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.PLAZO2_EJE_CON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.TIPO_PLAZO2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.VAL_SIN_IVA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.INTERVENTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.AGOTAR_PPTO)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.CONSIDERANDOS)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.APORTES)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.REVISADOPOR)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.OBS_PROYECTOS)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.OBS_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .Property(e => e.OBS_POLIZAS)
                .IsUnicode(false);

            modelBuilder.Entity<GPROCESOS>()
                .HasMany(e => e.GPOBLIGACIONES)
                .WithRequired(e => e.GPROCESOS)
                .HasForeignKey(e => new { e.NUM_PCON, e.GRUPO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GPROCESOS>()
                .HasMany(e => e.GPPOLIZAS)
                .WithRequired(e => e.GPROCESOS)
                .HasForeignKey(e => new { e.NUM_PROC, e.GRUPO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GPROCESOS>()
                .HasMany(e => e.GPPROPONENTES)
                .WithRequired(e => e.GPROCESOS)
                .HasForeignKey(e => new { e.NUM_PROC, e.GRUPO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GPROCESOS>()
                .HasMany(e => e.GPPROYECTOS)
                .WithRequired(e => e.GPROCESOS)
                .HasForeignKey(e => new { e.NUM_PROC, e.GRUPO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GPROCESOS>()
                .HasMany(e => e.RUBROS_GPROCESOS)
                .WithRequired(e => e.GPROCESOS)
                .HasForeignKey(e => new { e.NUM_PRO, e.GRUPO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GPROCESOS>()
                .HasMany(e => e.PAGOS_GPROCESOS)
                .WithRequired(e => e.GPROCESOS)
                .HasForeignKey(e => new { e.NUM_PROC, e.GRUPO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GPROCESOS>()
                .HasMany(e => e.MOD_PROPONENTES)
                .WithRequired(e => e.GPROCESOS)
                .HasForeignKey(e => new { e.NUM_PROC, e.GRUPO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GPROCESOS>()
                .HasMany(e => e.CDP_GPROCESOS)
                .WithOptional(e => e.GPROCESOS)
                .HasForeignKey(e => new { e.NUM_GPROC, e.GRUPO });

            modelBuilder.Entity<GR_TIP_OFI>()
                .Property(e => e.TIP_OFI)
                .IsUnicode(false);

            modelBuilder.Entity<GR_TIP_OFI>()
                .Property(e => e.NOM_OFI)
                .IsUnicode(false);

            modelBuilder.Entity<GR_TIP_OFI>()
                .Property(e => e.ETA_OFI)
                .IsUnicode(false);

            modelBuilder.Entity<HCONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<HCONTRATOS>()
                .Property(e => e.CAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<HCONTRATOS>()
                .Property(e => e.VALOR_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<HCONTRATOS>()
                .Property(e => e.VALOR_NUEVO)
                .IsUnicode(false);

            modelBuilder.Entity<HCONTRATOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<HCONTRATOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<HCONTRATOS>()
                .Property(e => e.ID_HCON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.COD_DEP)
                .IsUnicode(false);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.IDE_TER)
                .IsUnicode(false);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.USAP_RETIRO)
                .IsUnicode(false);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.ID_HDEP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.ASIG_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<HDEP_ABOGADOS>()
                .Property(e => e.COORDINADOR)
                .IsUnicode(false);

            modelBuilder.Entity<HMOD_CONTRATOS>()
                .Property(e => e.NUM_SOL_ADI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HMOD_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<HMOD_CONTRATOS>()
                .Property(e => e.CAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<HMOD_CONTRATOS>()
                .Property(e => e.VALOR_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<HMOD_CONTRATOS>()
                .Property(e => e.VALOR_NUEVO)
                .IsUnicode(false);

            modelBuilder.Entity<HMOD_CONTRATOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<HMOD_CONTRATOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<HMOD_CONTRATOS>()
                .Property(e => e.ID_HCON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HOJAS_RUTAS>()
                .Property(e => e.COD_HRUTA)
                .IsUnicode(false);

            modelBuilder.Entity<HOJAS_RUTAS>()
                .Property(e => e.COD_ETAPA)
                .IsUnicode(false);

            modelBuilder.Entity<HOJAS_RUTAS>()
                .Property(e => e.COD_TDOC)
                .IsUnicode(false);

            modelBuilder.Entity<HOJAS_RUTAS>()
                .Property(e => e.DOC_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<HOJAS_RUTAS>()
                .Property(e => e.DOC_EST)
                .IsUnicode(false);

            modelBuilder.Entity<HORAS>()
                .Property(e => e.COD_HOR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HORAS>()
                .Property(e => e.NOM_HOR)
                .IsUnicode(false);

            modelBuilder.Entity<HORAS>()
                .Property(e => e.JOR_HOR)
                .IsUnicode(false);

            modelBuilder.Entity<HORAS>()
                .Property(e => e.NOM_HMIL)
                .IsUnicode(false);

            modelBuilder.Entity<HORAS>()
                .Property(e => e.LABORALES)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.COD_SOL)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.RECIBIDO_ABOG)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.OBS_RECIBIDO_ABOG)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.OBS_REVISADO)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.CONCEPTO_REVISADO)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.ID_HREV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.NIT_ABOG_RECIBE)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.OBSERVACION_RECIBIDO)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.HOBS_REVISADO)
                .IsUnicode(false);

            modelBuilder.Entity<HREVISADO>()
                .Property(e => e.IDE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HREVISADO>()
                .HasMany(e => e.PSOLICITUDES1)
                .WithOptional(e => e.HREVISADO1)
                .HasForeignKey(e => e.ID_HREV);

            modelBuilder.Entity<IMP_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<IMP_CONTRATOS>()
                .Property(e => e.NRO_IMP)
                .IsUnicode(false);

            modelBuilder.Entity<IMP_CONTRATOS>()
                .Property(e => e.NRO_COM)
                .IsUnicode(false);

            modelBuilder.Entity<IMP_CONTRATOS>()
                .Property(e => e.COD_SOP)
                .IsUnicode(false);

            modelBuilder.Entity<IMP_CONTRATOS>()
                .Property(e => e.USER_REG)
                .IsUnicode(false);

            modelBuilder.Entity<IMP_CONTRATOS>()
                .Property(e => e.ID)
                .HasPrecision(17, 2);

            modelBuilder.Entity<IMPUESTOS>()
                .Property(e => e.NOM_IMP)
                .IsUnicode(false);

            modelBuilder.Entity<IMPUESTOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<IMPUESTOS>()
                .Property(e => e.NRO_IMP)
                .IsUnicode(false);

            modelBuilder.Entity<IMPUESTOS>()
                .HasMany(e => e.IMP_CONTRATOS)
                .WithRequired(e => e.IMPUESTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.OBS_REC)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.EST_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.ETA_DOC)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.OBS_REV)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.USAP_REC)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.USAP_REV)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.IDPADRE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .Property(e => e.EST_REG)
                .IsUnicode(false);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .HasMany(e => e.ESTCONTRATOS)
                .WithOptional(e => e.INT_CONTROL_DOC)
                .HasForeignKey(e => e.ID_CTRDOC);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .HasMany(e => e.INT_CONTROL_DOC1)
                .WithOptional(e => e.INT_CONTROL_DOC2)
                .HasForeignKey(e => e.IDPADRE);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .HasMany(e => e.INT_DETTRASLADO)
                .WithOptional(e => e.INT_CONTROL_DOC)
                .HasForeignKey(e => e.ID_CTRDOC);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .HasMany(e => e.INT_DETTRASLADO1)
                .WithOptional(e => e.INT_CONTROL_DOC1)
                .HasForeignKey(e => e.ID_CTRDOC2);

            modelBuilder.Entity<INT_CONTROL_DOC>()
                .HasMany(e => e.INT_DETCUENTA)
                .WithOptional(e => e.INT_CONTROL_DOC)
                .HasForeignKey(e => e.ID_CTRDOC);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.NRO_RP)
                .IsUnicode(false);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.NRO_OP)
                .IsUnicode(false);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.VAL_OP)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.NRO_EGR)
                .IsUnicode(false);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.EST_EGR)
                .IsUnicode(false);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.ID_CTRDOC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<INT_DETCUENTA>()
                .Property(e => e.USAPM)
                .IsUnicode(false);

            modelBuilder.Entity<INT_DETTRASLADO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_DETTRASLADO>()
                .Property(e => e.ID_TRASLADO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_DETTRASLADO>()
                .Property(e => e.ID_CTRDOC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_DETTRASLADO>()
                .Property(e => e.EST_TRA)
                .IsUnicode(false);

            modelBuilder.Entity<INT_DETTRASLADO>()
                .Property(e => e.ID_CTRDOC2)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.CAN_HOJ)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.NUM_INF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.EST_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.DES_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.NOT_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.VAL_PAG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.OBL_FAC)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.NOT2_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .Property(e => e.TIP_INF)
                .IsUnicode(false);

            modelBuilder.Entity<INT_INFOCONT>()
                .HasMany(e => e.GD_DOC_ACTAS)
                .WithOptional(e => e.INT_INFOCONT)
                .HasForeignKey(e => e.ID_INF);

            modelBuilder.Entity<INT_INFOCONT>()
                .HasMany(e => e.INT_PAGOSST)
                .WithOptional(e => e.INT_INFOCONT)
                .HasForeignKey(e => e.IDE_INF);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.TIPO_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.PLANILLAN)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.VAL_SALUD)
                .HasPrecision(17, 2);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.VAL_PENSION)
                .HasPrecision(17, 2);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.VAL_RIESGOS)
                .HasPrecision(17, 2);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.VAL_PARAF)
                .HasPrecision(17, 2);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.MES_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.YEAR_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.NRO_DOC)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.OBS)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.USBDM)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.USAPM)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PAGOSST>()
                .Property(e => e.IDE_INF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_PPLANTILLAS_URL>()
                .Property(e => e.IDE_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_PPLANTILLAS_URL>()
                .Property(e => e.URL_FORM)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PPLANTILLAS_URL>()
                .Property(e => e.URL_RPTE)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PPLANTILLAS_URL>()
                .Property(e => e.URL_EST)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PPLANTILLAS_URL>()
                .Property(e => e.URL_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PPLANTILLAS_URL>()
                .Property(e => e.URL_USAP)
                .IsUnicode(false);

            modelBuilder.Entity<INT_PPLANTILLAS_URL>()
                .Property(e => e.URL_USMD)
                .IsUnicode(false);

            modelBuilder.Entity<INT_TRASLADOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INT_TRASLADOS>()
                .Property(e => e.ORI_TRA)
                .IsUnicode(false);

            modelBuilder.Entity<INT_TRASLADOS>()
                .Property(e => e.DES_TRA)
                .IsUnicode(false);

            modelBuilder.Entity<INT_TRASLADOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<INT_TRASLADOS>()
                .Property(e => e.USAPM)
                .IsUnicode(false);

            modelBuilder.Entity<INT_TRASLADOS>()
                .Property(e => e.EST_TRA)
                .IsUnicode(false);

            modelBuilder.Entity<INT_TRASLADOS>()
                .Property(e => e.OBS_TRA)
                .IsUnicode(false);

            modelBuilder.Entity<INT_TRASLADOS>()
                .HasMany(e => e.INT_DETTRASLADO)
                .WithOptional(e => e.INT_TRASLADOS)
                .HasForeignKey(e => e.ID_TRASLADO);

            modelBuilder.Entity<INTERVENTORES_CONTRATO>()
                .Property(e => e.IDE_INT)
                .IsUnicode(false);

            modelBuilder.Entity<INTERVENTORES_CONTRATO>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<INTERVENTORES_CONTRATO>()
                .Property(e => e.TIP_INT)
                .IsUnicode(false);

            modelBuilder.Entity<INTERVENTORES_CONTRATO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<INTERVENTORES_CONTRATO>()
                .Property(e => e.EST_INT)
                .IsUnicode(false);

            modelBuilder.Entity<INTERVENTORES_CONTRATO>()
                .Property(e => e.OBS_INT)
                .IsUnicode(false);

            modelBuilder.Entity<INTERVENTORES_CONTRATO>()
                .Property(e => e.COD_CON_INT)
                .IsUnicode(false);

            modelBuilder.Entity<INTERVENTORES_CONTRATO>()
                .Property(e => e.IDE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<INTTIPO_ESS>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<INTTIPO_ESS>()
                .Property(e => e.NOM_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<INTTIPO_ESS>()
                .Property(e => e.EST_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.MENUID)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.PADREID)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.ICONO)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<MENU>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<MENU_PERFIL>()
                .Property(e => e.MENUID)
                .IsUnicode(false);

            modelBuilder.Entity<MENU_PERFIL>()
                .Property(e => e.PERFIL)
                .IsUnicode(false);

            modelBuilder.Entity<MENU_PERFIL>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<MENU_PERFIL>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<MENU_PERFIL>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.MENUID)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.PADREID)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.ICONO)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.MODULO)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.TARGET)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.PPAL)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MENU2>()
                .HasMany(e => e.MENU_PERFIL)
                .WithRequired(e => e.MENU2)
                .HasForeignKey(e => new { e.MENUID, e.MODULO })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MENU2>()
                .HasOptional(e => e.MENU21)
                .WithRequired(e => e.MENU22);

            modelBuilder.Entity<MENUMB>()
                .Property(e => e.MENUID)
                .IsUnicode(false);

            modelBuilder.Entity<MENUMB>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<MENUMB>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<MENUMB>()
                .Property(e => e.MODULOMB)
                .IsUnicode(false);

            modelBuilder.Entity<MENUMB>()
                .Property(e => e.PADREID)
                .IsUnicode(false);

            modelBuilder.Entity<MENUMB>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<MENUMB>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<MIN_MOD_CONTRATO>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MIN_MOD_CONTRATO>()
                .Property(e => e.CAMPO)
                .IsUnicode(false);

            modelBuilder.Entity<MIN_MOD_CONTRATO>()
                .Property(e => e.VALOR_NUEVO)
                .IsUnicode(false);

            modelBuilder.Entity<MIN_MOD_CONTRATO>()
                .Property(e => e.VALOR_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<MIN_MOD_CONTRATO>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MIN_MOD_CONTRATO>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CDP_CONTRATOS>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CDP_CONTRATOS>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CDP_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CDP_CONTRATOS>()
                .Property(e => e.VAL_CDP)
                .HasPrecision(17, 3);

            modelBuilder.Entity<MOD_CDP_CONTRATOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CDP_CONTRATOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.TIPO_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.VALOR_PAGO)
                .HasPrecision(17, 4);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.PORCENTAJE)
                .HasPrecision(17, 4);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.PAGA_GOBER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CFORMA_PAGO>()
                .Property(e => e.CONDICION_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_COBLIGACIONES>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_COBLIGACIONES>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_COBLIGACIONES>()
                .Property(e => e.DES_OBLIG2)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_COBLIGACIONES>()
                .Property(e => e.DES_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_COBLIGACIONES>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_COBLIGACIONES>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.COD_POL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.POR_SMMLV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.CAL_APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.VIGENCIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CON_POLIZAS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONMUN>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONMUN>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONMUN>()
                .Property(e => e.NRO_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.NUM_SOL_ADI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.IDE_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.OBJ_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.PRO_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.DEP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.TIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.STIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.EST_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.VAL_CON)
                .HasPrecision(17, 2);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.DOC_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.COD_SEC)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.TIP_FOR)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.OTR_CNS)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.COD_TPRO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.NRO_PLA_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.IDE_REP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.OBS_DOC_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.URG_MAN)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.EST_CONV)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.EXO_IMP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.EXO_OBS)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.PRO_SEL_NRO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.DEP_PCON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.VAL_APO_GOB)
                .HasPrecision(17, 2);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.COD_CON0)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.USER_ACT)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.LEGALIZADO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.PER_APO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.ANTICIPO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.AGOTAR_PPTO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.LUG_EJE)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.TIPO_PLAZO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.TIP_RADICACION)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.ENCARGADO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.MOD_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.PLAZO2_EJE_CON)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.TIPO_PLAZO2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.VAL_SIN_IVA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.INTERVENTORIA)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.CONSIDERANDOS)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.APORTES)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.SQL_UPDATE)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.PLAZO1_ADI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.TIPO_PLAZO1_ADI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.PLAZO2_ADI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.TIPO_PLAZO2_ADI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.VAL_CON_ADI)
                .HasPrecision(17, 2);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.VAL_APO_GOB_ADI)
                .HasPrecision(17, 2);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.VAL_SIN_IVA_ADI)
                .HasPrecision(17, 2);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.OBS_POLIZA)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.OBS_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.OBS_PROYECTOS)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CONTRATOS>()
                .Property(e => e.REVISADOPOR)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.IDE_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.VAL_PROP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.ADJUDICADO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.OBSERVACION_ADJUDICACION)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.APE1_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.DIR_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.TEL_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.EMAIL_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.APE2_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.NOM1_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.NOM2_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.TIP_IDE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.EXP_IDE)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.DV_TER)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.RAZON_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.ORD_GAS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.CAR_FUN)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.DOC_DEL)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.NUM_FOLIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.ID_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.NOM_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.COD_AUX)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.NUMPOLIZA)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.VALOR_POLIZA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.DENOMINACION)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.APORTES)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_PROPONENTES>()
                .Property(e => e.SQL_UPDATE)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_TIP_PLA>()
                .Property(e => e.COD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_TIP_PLA>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_TIP_PLA>()
                .Property(e => e.EST)
                .IsUnicode(false);

            modelBuilder.Entity<MODULOS>()
                .Property(e => e.COD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<MODULOS>()
                .Property(e => e.NOM_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<MODULOS>()
                .Property(e => e.ORD_MOD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<MODULOS>()
                .Property(e => e.EST_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<MODULOS>()
                .Property(e => e.DES_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIOS>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIOS>()
                .Property(e => e.NOM_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIOS>()
                .HasMany(e => e.EP_CONMUN)
                .WithRequired(e => e.MUNICIPIOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NROCONVIG>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<NROCONVIG>()
                .Property(e => e.POR_ADI_VIG)
                .HasPrecision(38, 0);

            modelBuilder.Entity<NUMPROP>()
                .Property(e => e.TIP_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<NUMPROP>()
                .Property(e => e.NUM_INI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<NUMPROP>()
                .Property(e => e.NUM_ACT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_APPLICATIONS>()
                .HasMany(e => e.ORA_ASPNET_ROLES)
                .WithRequired(e => e.ORA_ASPNET_APPLICATIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORA_ASPNET_APPLICATIONS>()
                .HasMany(e => e.ORA_ASPNET_MEMBERSHIP)
                .WithRequired(e => e.ORA_ASPNET_APPLICATIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORA_ASPNET_APPLICATIONS>()
                .HasMany(e => e.ORA_ASPNET_PATHS)
                .WithRequired(e => e.ORA_ASPNET_APPLICATIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORA_ASPNET_APPLICATIONS>()
                .HasMany(e => e.ORA_ASPNET_USERS)
                .WithRequired(e => e.ORA_ASPNET_APPLICATIONS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORA_ASPNET_MEMBERSHIP>()
                .Property(e => e.PASSWORDFORMAT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_MEMBERSHIP>()
                .Property(e => e.ISAPPROVED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_MEMBERSHIP>()
                .Property(e => e.ISLOCKEDOUT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_MEMBERSHIP>()
                .Property(e => e.FAILEDPWDATTEMPTCOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_MEMBERSHIP>()
                .Property(e => e.FAILEDPWDANSWERATTEMPTCOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_PATHS>()
                .HasMany(e => e.ORA_ASPNET_PERSONALIZNALLUSERS)
                .WithOptional(e => e.ORA_ASPNET_PATHS)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ORA_ASPNET_ROLES>()
                .HasMany(e => e.ORA_ASPNET_USERS)
                .WithMany(e => e.ORA_ASPNET_ROLES)
                .Map(m => m.ToTable("ORA_ASPNET_USERSINROLES", "SIRCC").MapLeftKey("ROLEID").MapRightKey("USERID"));

            modelBuilder.Entity<ORA_ASPNET_SESSIONS>()
                .Property(e => e.LOCKCOOKIE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_SESSIONS>()
                .Property(e => e.TIMEOUT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_SESSIONS>()
                .Property(e => e.LOCKED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_SESSIONS>()
                .Property(e => e.FLAGS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_USERS>()
                .Property(e => e.ISANONYMOUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ORA_ASPNET_USERS>()
                .HasOptional(e => e.ORA_ASPNET_MEMBERSHIP)
                .WithRequired(e => e.ORA_ASPNET_USERS);

            modelBuilder.Entity<ORA_ASPNET_USERS>()
                .HasOptional(e => e.ORA_ASPNET_PROFILE)
                .WithRequired(e => e.ORA_ASPNET_USERS);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.COD_ACT)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.NOM_ACT)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.COD_TPRO)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.VIGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.ORDEN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.OCUPADO)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.EST_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.OBLIGATORIO)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.DIA_NOHABIL)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.NOTIFICAR)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.MFECINI)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.MHORINI)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.MFECFIN)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.MHORFIN)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.UBICACION)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<PACTIVIDADES>()
                .Property(e => e.TIP_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.TIPO_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.VALOR_PAGO)
                .HasPrecision(17, 4);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.PORCENTAJE)
                .HasPrecision(17, 4);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.CONDICION_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_GPROCESOS>()
                .Property(e => e.PAGA_GOBER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_PARCIALES>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PAGOS_PARCIALES>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_PARCIALES>()
                .Property(e => e.TIPO_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_PARCIALES>()
                .Property(e => e.VALOR_PAGO)
                .HasPrecision(17, 4);

            modelBuilder.Entity<PAGOS_PARCIALES>()
                .Property(e => e.PORCENTAJE)
                .HasPrecision(17, 4);

            modelBuilder.Entity<PAGOS_PARCIALES>()
                .Property(e => e.CONDICION_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_PARCIALES>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGOS_PARCIALES>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.ID_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.TIP_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.CLA_TIT)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.CLA_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.CLA_CAM)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.CLA_PAR)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.CLA_TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.NUM_PRO)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.IDE_PMIN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.TIP_PAR)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.IS_ENTER_FINAL)
                .IsUnicode(false);

            modelBuilder.Entity<PCLAUSULAS>()
                .Property(e => e.CLA_CRUZADA)
                .IsUnicode(false);

            modelBuilder.Entity<PCONMUN>()
                .Property(e => e.COD_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<PCONMUN>()
                .Property(e => e.NRO_PCON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.PRO_SEL_NRO)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.IDE_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.OBJ_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.PRO_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.DEP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.DEP_PCON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.TIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.STIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.VAL_CON)
                .HasPrecision(17, 2);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.VAL_APO_GOB)
                .HasPrecision(17, 2);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.COD_SEC)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.TIP_FOR)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.OTR_CNS)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.NRO_PLA_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.IDE_REP)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.URG_MAN)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.EST_CONV)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.APL_GAC)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.EST_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.LUG_EJE)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.USUENCARGADO)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.NUM_SOL)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.COD_TPRO)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .Property(e => e.TIPO_PLAZO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCONTRATOS>()
                .HasOptional(e => e.AN_PCONTRATO)
                .WithRequired(e => e.PCONTRATOS);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.CONTRATOS)
                .WithOptional(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PROC);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.DOC_PLANTILLA)
                .WithOptional(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PROC);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.GPROCESOS)
                .WithRequired(e => e.PCONTRATOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.MOD_CONTRATOS)
                .WithOptional(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PROC);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.PAGOS_PARCIALES)
                .WithRequired(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PROC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.PCONMUN)
                .WithRequired(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NRO_PCON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.CDP_PCONTRATOS)
                .WithRequired(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PCON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.PPOLIZAS)
                .WithRequired(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PROC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.PCRONOGRAMAS)
                .WithOptional(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PROC);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.POBLIGACIONES)
                .WithRequired(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PCON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.PPROPONENTES)
                .WithRequired(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PROC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.PPROPONENTESS)
                .WithOptional(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PROC);

            modelBuilder.Entity<PCONTRATOS>()
                .HasMany(e => e.RUBROS_PCONTRATOS)
                .WithRequired(e => e.PCONTRATOS)
                .HasForeignKey(e => e.NUM_PRO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PCRONO_DIAS>()
                .Property(e => e.ID_CRONO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PCRONO_DIAS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONO_DIAS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.COD_ACT)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.NOM_ACT)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.COD_TPRO)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.HORAI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.HORAF)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.UBICACION)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.NOTAS)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.OCUPADO)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.EST_ACT)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.OBS_SEG)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.ID)
                .HasPrecision(20, 0);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.ANULADO)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.OBLIGATORIO)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.EST_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.DIAS_AVISO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.MIN_I)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.MIN_F)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.NOTIFICAR)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.MFECINI)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.MHORINI)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.MFECFIN)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.MHORFIN)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .Property(e => e.TIP_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PCRONOGRAMAS>()
                .HasMany(e => e.PCRONO_DIAS)
                .WithRequired(e => e.PCRONOGRAMAS)
                .HasForeignKey(e => e.ID_CRONO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESTADOS>()
                .Property(e => e.COD_EST)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOS>()
                .Property(e => e.NOM_EST)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOS>()
                .Property(e => e.IMAGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOS>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOS>()
                .Property(e => e.FINAL)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOS>()
                .Property(e => e.ORDEN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PESTADOS>()
                .HasMany(e => e.GPROCESOS)
                .WithRequired(e => e.PESTADOS)
                .HasForeignKey(e => e.EST_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESTADOS>()
                .HasMany(e => e.PACTIVIDADES)
                .WithOptional(e => e.PESTADOS)
                .HasForeignKey(e => e.EST_PROC);

            modelBuilder.Entity<PESTADOS>()
                .HasMany(e => e.PCONTRATOS)
                .WithRequired(e => e.PESTADOS)
                .HasForeignKey(e => e.EST_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESTADOSACT>()
                .Property(e => e.COD_EST)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOSACT>()
                .Property(e => e.NOM_EST)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOSACT>()
                .Property(e => e.IMAGEN)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOSACT>()
                .Property(e => e.COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOSACT>()
                .Property(e => e.IS_FINAL)
                .IsUnicode(false);

            modelBuilder.Entity<PESTADOSACT>()
                .HasMany(e => e.PCRONOGRAMAS)
                .WithOptional(e => e.PESTADOSACT)
                .HasForeignKey(e => e.EST_ACT);

            modelBuilder.Entity<PGCONTRATOSM>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PGCONTRATOSM>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PGCONTRATOSM>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PGCONTRATOSM>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PGCONTRATOSM>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<PGCONTRATOSM>()
                .Property(e => e.EDITABLE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PL_PLANTILLA>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PL_PLANTILLA>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<PL_PLANTILLA>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<PL_PLANTILLA>()
                .Property(e => e.NRO_REV)
                .IsUnicode(false);

            modelBuilder.Entity<PL_PLANTILLA>()
                .Property(e => e.EST_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PL_PLANTILLA>()
                .Property(e => e.DOC_MAX)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PL_PLANTILLA>()
                .HasMany(e => e.DOC_PLANTILLA)
                .WithOptional(e => e.PL_PLANTILLA)
                .HasForeignKey(e => e.ID_PLA);

            modelBuilder.Entity<PL_PLANTILLA>()
                .HasMany(e => e.PL_SECCIONES)
                .WithOptional(e => e.PL_PLANTILLA)
                .HasForeignKey(e => e.ID_PLA);

            modelBuilder.Entity<PL_SECCIONES>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PL_SECCIONES>()
                .Property(e => e.ID_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PL_SECCIONES>()
                .Property(e => e.HTML)
                .IsUnicode(false);

            modelBuilder.Entity<PL_TIPOS_PLANTILLA>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<PL_TIPOS_PLANTILLA>()
                .Property(e => e.NOM_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<PL_TIPOS_PLANTILLA>()
                .HasMany(e => e.MOD_TIP_PLA)
                .WithRequired(e => e.PL_TIPOS_PLANTILLA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PL_TIPOS_PLANTILLA>()
                .HasMany(e => e.PACTIVIDADES)
                .WithOptional(e => e.PL_TIPOS_PLANTILLA)
                .HasForeignKey(e => e.TIP_PLA);

            modelBuilder.Entity<PL_TIPOS_PLANTILLA>()
                .HasMany(e => e.PCRONOGRAMAS)
                .WithOptional(e => e.PL_TIPOS_PLANTILLA)
                .HasForeignKey(e => e.TIP_PLA);

            modelBuilder.Entity<PLANTILLAPPAL>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<PLANTILLAPPAL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<POBLIGACIONES>()
                .Property(e => e.NUM_PCON)
                .IsUnicode(false);

            modelBuilder.Entity<POBLIGACIONES>()
                .Property(e => e.DES_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS>()
                .Property(e => e.NOM_POL)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS>()
                .Property(e => e.EST_POL)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS>()
                .Property(e => e.VALOR)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS>()
                .Property(e => e.PLAZO)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS>()
                .HasMany(e => e.POLIZAS_CONTRATO)
                .WithRequired(e => e.POLIZAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<POLIZAS>()
                .HasMany(e => e.POLIZAS_ADICIONES)
                .WithRequired(e => e.POLIZAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<POLIZAS>()
                .HasMany(e => e.PPROPONENTESS)
                .WithOptional(e => e.POLIZAS)
                .HasForeignKey(e => e.NOM_POLIZA);

            modelBuilder.Entity<POLIZAS_ADICIONES>()
                .Property(e => e.NRO_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS_ADICIONES>()
                .Property(e => e.NRO_POL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<POLIZAS_CONTRATO>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS_CONTRATO>()
                .Property(e => e.VAL_POL)
                .HasPrecision(20, 0);

            modelBuilder.Entity<POLIZAS_CONTRATO>()
                .Property(e => e.NRO_POL)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS_CONTRATO>()
                .Property(e => e.TIP_POL)
                .IsUnicode(false);

            modelBuilder.Entity<POLIZAS_CONTRATO>()
                .Property(e => e.NRO_POL_AUX)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.IDE_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.TIP_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.NOM_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.EXT)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.EST_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.COD_STIP)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.CLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .Property(e => e.EDITABLE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS>()
                .HasOptional(e => e.INT_PPLANTILLAS_URL)
                .WithRequired(e => e.PPLANTILLAS);

            modelBuilder.Entity<PPLANTILLAS>()
                .HasMany(e => e.PPLANTILLAS_FORMATO_TABLAS)
                .WithRequired(e => e.PPLANTILLAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.NOM_CAM)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.NOM_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.DES_CAM)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.TIP_DAT)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.EST_CAM)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.GTABLA)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.NTABLA)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.ENCABEZADO_PIE)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.MOSTRAR_TITULOS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.MOSTRAR_BORDE)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.VISTA)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.MARCADOR)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.IDE_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.COL_FINAL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.TAGRUPADA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_CAMPOS>()
                .Property(e => e.COLS_GRUPO)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_FORMATO_TABLAS>()
                .Property(e => e.IDE_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPLANTILLAS_FORMATO_TABLAS>()
                .Property(e => e.NTABLA)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_FORMATO_TABLAS>()
                .Property(e => e.NOM_CAM)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_FORMATO_TABLAS>()
                .Property(e => e.DES_CAM)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_FORMATO_TABLAS>()
                .Property(e => e.TIP_DAT)
                .IsUnicode(false);

            modelBuilder.Entity<PPLANTILLAS_FORMATO_TABLAS>()
                .Property(e => e.ANCHO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPOLIZAS>()
                .Property(e => e.COD_POL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPOLIZAS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PPOLIZAS>()
                .Property(e => e.POR_SMMLV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPOLIZAS>()
                .Property(e => e.CAL_APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<PPOLIZAS>()
                .Property(e => e.VIGENCIA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPOLIZAS>()
                .Property(e => e.APARTIRDE)
                .IsUnicode(false);

            modelBuilder.Entity<PPOLIZAS>()
                .Property(e => e.CUBRIMIENTO)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.IDE_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.VAL_PROP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.ADJUDICADO)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.OBSERVACION_ADJUDICACION)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.APE1_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.DIR_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.TEL_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.EMAIL_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.APE2_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.NOM1_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.NOM2_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.TIP_IDE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.EXP_IDE)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.DV_TER)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.RAZON_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.ORD_GAS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.CAR_FUN)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.DOC_DEL)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.OBSERVACION)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.NUM_FOLIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.COD_AUX)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.ID_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.NOM_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTES>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.TIPO_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.NUM_PROC)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.VAL_PROP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.NUM_FOLIO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.IDE_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.TIP_IDE_PROP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.EXP_IDE_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.DV_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.TIP_PER_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.APE1_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.APE2_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.NOM1_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.NOM2_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.RAZ_SOC)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.DIR_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.TEL_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.EMA_PROP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.ADJUDICADO)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.OBS_ADJUDICACION)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.COD_AUX)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.ID_REP_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.APORTES)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.NUMPOLIZA)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.VALOR_POLIZA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.DENOMINACION)
                .IsUnicode(false);

            modelBuilder.Entity<PPROPONENTESS>()
                .Property(e => e.VAL_SIN_IVA)
                .HasPrecision(17, 2);

            modelBuilder.Entity<PPROPONENTESS>()
                .HasMany(e => e.CONSORCIOSUTXC)
                .WithOptional(e => e.PPROPONENTESS)
                .HasForeignKey(e => e.ID_PROP);

            modelBuilder.Entity<PR_DB_CLAUSULAS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_DB_CLAUSULAS>()
                .Property(e => e.ID_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_DB_CLAUSULAS>()
                .Property(e => e.TIP_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<PR_DB_CLAUSULAS>()
                .Property(e => e.CLA_TIT)
                .IsUnicode(false);

            modelBuilder.Entity<PR_DB_CLAUSULAS>()
                .Property(e => e.CLA_NUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PR_DB_CLAUSULAS>()
                .Property(e => e.CLA_CAM)
                .IsUnicode(false);

            modelBuilder.Entity<PR_DB_CLAUSULAS>()
                .Property(e => e.CLA_PAR)
                .IsUnicode(false);

            modelBuilder.Entity<PR_DB_CLAUSULAS>()
                .Property(e => e.CLA_TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.VIGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.PROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.NOMBRE_PROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.COMITE)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.VALOR)
                .HasPrecision(17, 2);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.APORTES_PROPIOS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.NOM_MUN)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.DEP_NOM)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.TIP_PRO)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.IDE_APORTANTE)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.NECESIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .Property(e => e.BPIN)
                .IsUnicode(false);

            modelBuilder.Entity<PROYECTOS>()
                .HasMany(e => e.EP_PROYECTOS)
                .WithRequired(e => e.PROYECTOS)
                .HasForeignKey(e => e.COD_PRO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROYECTOS>()
                .HasMany(e => e.GPPROYECTOS)
                .WithRequired(e => e.PROYECTOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROYECTOS>()
                .HasOptional(e => e.PROYECTOS1)
                .WithRequired(e => e.PROYECTOS2);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.NUM_SOL)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.COD_SOL)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.DEP_SOL)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.DEP_PSOL)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.TIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.STIP_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.COD_TPRO)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.OBJ_SOL)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.ID_ABOG_ENC)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.NUM_PLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.VAL_CON)
                .HasPrecision(17, 2);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.COD_EP)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.ID_HREV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PSOLICITUDES>()
                .Property(e => e.IDE_CON)
                .IsUnicode(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .HasMany(e => e.HREVISADO)
                .WithRequired(e => e.PSOLICITUDES)
                .HasForeignKey(e => e.COD_SOL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PSOLICITUDES>()
                .HasMany(e => e.PCONTRATOS)
                .WithOptional(e => e.PSOLICITUDES)
                .HasForeignKey(e => e.NUM_SOL);

            modelBuilder.Entity<PUNIDADES>()
                .Property(e => e.COD_UNIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<PUNIDADES>()
                .Property(e => e.NOM_UNIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<RP_ADICIONES>()
                .Property(e => e.NRO_RP)
                .IsUnicode(false);

            modelBuilder.Entity<RP_ADICIONES>()
                .Property(e => e.NRO_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS>()
                .Property(e => e.NRO_RP)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS>()
                .Property(e => e.DOC_SOP)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS>()
                .Property(e => e.VAL_RP)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RP_CONTRATOS>()
                .Property(e => e.VAL_PAGO)
                .HasPrecision(17, 3);

            modelBuilder.Entity<RP_CONTRATOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS>()
                .HasMany(e => e.RUBROS_CONTRATOS)
                .WithOptional(e => e.RP_CONTRATOS)
                .HasForeignKey(e => new { e.NRO_RP, e.COD_CON, e.VIGENCIA });

            modelBuilder.Entity<RP_CONTRATOS_A>()
                .Property(e => e.NRO_RP)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS_A>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<RP_CONTRATOS_A>()
                .Property(e => e.NRO_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<RPT_CONTROL>()
                .Property(e => e.VIG_RPT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RPT_CONTROL>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RPT_CONTROL>()
                .Property(e => e.IDE_RPT)
                .IsUnicode(false);

            modelBuilder.Entity<RPT_CONTROL>()
                .Property(e => e.VERSION)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RPT_CONTROL>()
                .Property(e => e.SQL)
                .IsUnicode(false);

            modelBuilder.Entity<RPT_CONTROL>()
                .Property(e => e.DESC_RPT)
                .IsUnicode(false);

            modelBuilder.Entity<RPT_CONTROL>()
                .Property(e => e.EST_RPT)
                .IsUnicode(false);

            modelBuilder.Entity<RPT_CONTROL>()
                .Property(e => e.ENT_RPT)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS>()
                .Property(e => e.DES_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS>()
                .Property(e => e.COD_UNIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS>()
                .Property(e => e.COD_RECURSO)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS>()
                .Property(e => e.CLASE)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS>()
                .HasMany(e => e.C_RUBROS_CDP)
                .WithOptional(e => e.RUBROS)
                .HasForeignKey(e => new { e.COD_RUB, e.VIG_CDP });

            modelBuilder.Entity<RUBROS>()
                .HasMany(e => e.EP_RUBROS_CDP)
                .WithOptional(e => e.RUBROS)
                .HasForeignKey(e => new { e.COD_RUB, e.VIG_CDP });

            modelBuilder.Entity<RUBROS_ADICIONES>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_ADICIONES>()
                .Property(e => e.NRO_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_ADICIONES>()
                .Property(e => e.NOM_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_ADICIONES>()
                .Property(e => e.VAL_COMPROMISO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<RUBROS_CONTRATOS>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS>()
                .Property(e => e.NOM_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS>()
                .Property(e => e.VAL_COMPROMISO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<RUBROS_CONTRATOS>()
                .Property(e => e.NRO_RP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RUBROS_GPROCESOS>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_GPROCESOS>()
                .Property(e => e.NUM_PRO)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_GPROCESOS>()
                .Property(e => e.VALOR)
                .HasPrecision(17, 2);

            modelBuilder.Entity<RUBROS_GPROCESOS>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_GPROCESOS>()
                .Property(e => e.VIGENCIA_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_PCONTRATOS>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_PCONTRATOS>()
                .Property(e => e.NUM_PRO)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_PCONTRATOS>()
                .Property(e => e.VALOR)
                .HasPrecision(17, 2);

            modelBuilder.Entity<RUBROS_PCONTRATOS>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_PCONTRATOS>()
                .Property(e => e.VIGENCIA_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_RCONTRATOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_RCONTRATOS>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_RCONTRATOS>()
                .Property(e => e.VALOR)
                .HasPrecision(17, 2);

            modelBuilder.Entity<RUBROS_RCONTRATOS>()
                .Property(e => e.NRO_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_RCONTRATOS>()
                .Property(e => e.VIGENCIA_CDP)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR>()
                .Property(e => e.COD_SEC)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR>()
                .Property(e => e.NOM_SEC)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SECTOR>()
                .HasMany(e => e.CONTRATOS)
                .WithRequired(e => e.SECTOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SECTOR>()
                .HasMany(e => e.MOD_CONTRATOS)
                .WithRequired(e => e.SECTOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .Property(e => e.TIP_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .Property(e => e.OBSER)
                .IsUnicode(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .Property(e => e.ID_ABOG_ENC)
                .IsUnicode(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .HasMany(e => e.MIN_MOD_CONTRATO)
                .WithRequired(e => e.SOL_ADICIONES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .HasMany(e => e.MOD_CDP_CONTRATOS)
                .WithRequired(e => e.SOL_ADICIONES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .HasMany(e => e.MOD_COBLIGACIONES)
                .WithRequired(e => e.SOL_ADICIONES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOL_ADICIONES>()
                .HasOptional(e => e.HREVSOLADI)
                .WithRequired(e => e.SOL_ADICIONES);

            modelBuilder.Entity<SOL_ADICIONES>()
                .HasOptional(e => e.MOD_CPROYECTOS)
                .WithRequired(e => e.SOL_ADICIONES);

            modelBuilder.Entity<SUBTIPOS>()
                .Property(e => e.COD_STIP)
                .IsUnicode(false);

            modelBuilder.Entity<SUBTIPOS>()
                .Property(e => e.NOM_STIP)
                .IsUnicode(false);

            modelBuilder.Entity<SUBTIPOS>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<SUBTIPOS>()
                .Property(e => e.CLA_CON_DEP)
                .IsUnicode(false);

            modelBuilder.Entity<SUBTIPOS>()
                .Property(e => e.CRT_F20_1A)
                .IsUnicode(false);

            modelBuilder.Entity<SUBTIPOS>()
                .Property(e => e.CLA_CON_DP)
                .IsUnicode(false);

            modelBuilder.Entity<SUBTIPOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<SUBTIPOS>()
                .HasMany(e => e.CONTRATOS)
                .WithRequired(e => e.SUBTIPOS)
                .HasForeignKey(e => e.STIP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUBTIPOS>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.SUBTIPOS)
                .HasForeignKey(e => e.STIP_CON_EP);

            modelBuilder.Entity<SUBTIPOS>()
                .HasMany(e => e.MOD_CONTRATOS)
                .WithRequired(e => e.SUBTIPOS)
                .HasForeignKey(e => e.STIP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUBTIPOS>()
                .HasMany(e => e.PSOLICITUDES)
                .WithRequired(e => e.SUBTIPOS)
                .HasForeignKey(e => e.STIP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.IDE_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.APE1_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.DIR_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.TEL_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.EMA_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.APE2_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.NOM1_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.NOM2_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.TIP_IDE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.EXP_IDE)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.DV_TER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.RAZ_SOC)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.ORD_GAS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.CAR_FUN)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.DOC_DEL)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.DEP_NEC)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.USAPM)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .Property(e => e.TIP_PER)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.CONSORCIOSUTXC)
                .WithOptional(e => e.TERCEROS)
                .HasForeignKey(e => e.ID_MIEMBROS);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.CONSORCIOSUTXC1)
                .WithOptional(e => e.TERCEROS1)
                .HasForeignKey(e => e.IDE_TER);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.CONTRATOS)
                .WithOptional(e => e.TERCEROS)
                .HasForeignKey(e => e.IDE_CON);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.TERCEROS)
                .HasForeignKey(e => e.USAP_APR_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV1)
                .WithOptional(e => e.TERCEROS1)
                .HasForeignKey(e => e.IDE_CON_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV2)
                .WithOptional(e => e.TERCEROS2)
                .HasForeignKey(e => e.USAP_DAN_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV3)
                .WithOptional(e => e.TERCEROS3)
                .HasForeignKey(e => e.USAP_ELA_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV4)
                .WithOptional(e => e.TERCEROS4)
                .HasForeignKey(e => e.IDE_DIL_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV5)
                .WithOptional(e => e.TERCEROS5)
                .HasForeignKey(e => e.IDE_REP_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV6)
                .WithOptional(e => e.TERCEROS6)
                .HasForeignKey(e => e.USAP_REV_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV7)
                .WithOptional(e => e.TERCEROS7)
                .HasForeignKey(e => e.IDE_SUP_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.ESTPREV8)
                .WithOptional(e => e.TERCEROS8)
                .HasForeignKey(e => e.IDE_RES_EP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.HREVISADO)
                .WithOptional(e => e.TERCEROS)
                .HasForeignKey(e => e.NIT_ABOG_RECIBE);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.INTERVENTORES_CONTRATO)
                .WithOptional(e => e.TERCEROS)
                .HasForeignKey(e => e.IDE_INT);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.PCONTRATOS)
                .WithOptional(e => e.TERCEROS)
                .HasForeignKey(e => e.USUENCARGADO);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.PPROPONENTESS)
                .WithOptional(e => e.TERCEROS)
                .HasForeignKey(e => e.IDE_PROP);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.PPROPONENTESS1)
                .WithOptional(e => e.TERCEROS1)
                .HasForeignKey(e => e.ID_REP_LEGAL);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.PSOLICITUDES)
                .WithOptional(e => e.TERCEROS)
                .HasForeignKey(e => e.ID_ABOG_ENC);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.PSOLICITUDES1)
                .WithOptional(e => e.TERCEROS1)
                .HasForeignKey(e => e.IDE_CON);

            modelBuilder.Entity<TERCEROS>()
                .HasMany(e => e.CONSORCIOSUT)
                .WithRequired(e => e.TERCEROS)
                .HasForeignKey(e => e.ID_MIEMBROS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TERCEROSDESKTOP>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TERCEROSDESKTOP>()
                .Property(e => e.ADMINISTRADOR)
                .IsUnicode(false);

            modelBuilder.Entity<TIP_DOC>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIP_DOC>()
                .Property(e => e.DES_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIP_DOC>()
                .Property(e => e.EST_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIP_DOC>()
                .Property(e => e.COD_ETAPA)
                .IsUnicode(false);

            modelBuilder.Entity<TIP_DOC>()
                .Property(e => e.ORIGEN)
                .IsUnicode(false);

            modelBuilder.Entity<TIP_DOC>()
                .Property(e => e.DOC_OBLIG)
                .IsUnicode(false);

            modelBuilder.Entity<TIP_DOC>()
                .HasMany(e => e.ANX_CONTRATOS)
                .WithRequired(e => e.TIP_DOC1)
                .HasForeignKey(e => e.TIP_DOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIP_DOC>()
                .HasMany(e => e.GD_DOC_ACTAS)
                .WithOptional(e => e.TIP_DOC1)
                .HasForeignKey(e => e.TIP_DOC);

            modelBuilder.Entity<TIPO_ADCIONES>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ADCIONES>()
                .Property(e => e.NOM_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_AGENT>()
                .Property(e => e.TAG_COD)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_AGENT>()
                .Property(e => e.TAG_NOM)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_AGENT>()
                .Property(e => e.TAG_EST)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_AGENT>()
                .Property(e => e.TAG_USAP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_AGENT>()
                .Property(e => e.TAG_USBD)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_AGENT>()
                .Property(e => e.TAG_ORD)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TIPO_INTERVENTOR>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TIPO_INTERVENTOR>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_INTERVENTOR>()
                .Property(e => e.NOM_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PAGO>()
                .Property(e => e.ID_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PAGO>()
                .Property(e => e.DES_PAGO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PAGO>()
                .Property(e => e.USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PAGO>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PAGO>()
                .HasMany(e => e.C_FORMA_PAGO)
                .WithOptional(e => e.TIPO_PAGO)
                .HasForeignKey(e => e.TIP_FPAG);

            modelBuilder.Entity<TIPO_PAGO>()
                .HasMany(e => e.CFORMA_PAGO)
                .WithOptional(e => e.TIPO_PAGO1)
                .HasForeignKey(e => e.TIPO_PAGO);

            modelBuilder.Entity<TIPO_PAGO>()
                .HasMany(e => e.EP_FORMA_PAGO)
                .WithOptional(e => e.TIPO_PAGO)
                .HasForeignKey(e => e.TIP_FPAG);

            modelBuilder.Entity<TIPO_PAGO>()
                .HasMany(e => e.MOD_CFORMA_PAGO)
                .WithOptional(e => e.TIPO_PAGO1)
                .HasForeignKey(e => e.TIPO_PAGO);

            modelBuilder.Entity<TIPO_PAGO>()
                .HasMany(e => e.PAGOS_GPROCESOS)
                .WithOptional(e => e.TIPO_PAGO1)
                .HasForeignKey(e => e.TIPO_PAGO);

            modelBuilder.Entity<TIPO_PAGO>()
                .HasMany(e => e.PAGOS_PARCIALES)
                .WithOptional(e => e.TIPO_PAGO1)
                .HasForeignKey(e => e.TIPO_PAGO);

            modelBuilder.Entity<TIPO_PLAZOS>()
                .Property(e => e.COD_TPLA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PLAZOS>()
                .Property(e => e.NOM_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PLAZOS>()
                .Property(e => e.ORD_TPLA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<TIPO_PLAZOS>()
                .Property(e => e.EST_TPLA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_PLAZOS>()
                .HasMany(e => e.CONTRATOS)
                .WithOptional(e => e.TIPO_PLAZOS)
                .HasForeignKey(e => e.TIPO_PLAZO);

            modelBuilder.Entity<TIPO_PLAZOS>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.TIPO_PLAZOS)
                .HasForeignKey(e => e.TPLA1_EP);

            modelBuilder.Entity<TIPO_PLAZOS>()
                .HasMany(e => e.ESTPREV1)
                .WithOptional(e => e.TIPO_PLAZOS1)
                .HasForeignKey(e => e.TPLA2_EP);

            modelBuilder.Entity<TIPO_PLAZOS>()
                .HasMany(e => e.MOD_CONTRATOS)
                .WithOptional(e => e.TIPO_PLAZOS)
                .HasForeignKey(e => e.TIPO_PLAZO);

            modelBuilder.Entity<TIPOSCONT>()
                .Property(e => e.COD_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSCONT>()
                .Property(e => e.NOM_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSCONT>()
                .Property(e => e.EST_TIP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSCONT>()
                .HasMany(e => e.CONTRATOS)
                .WithRequired(e => e.TIPOSCONT)
                .HasForeignKey(e => e.TIP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOSCONT>()
                .HasMany(e => e.MOD_CONTRATOS)
                .WithRequired(e => e.TIPOSCONT)
                .HasForeignKey(e => e.TIP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOSCONT>()
                .HasMany(e => e.NROCONVIG)
                .WithRequired(e => e.TIPOSCONT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOSCONT>()
                .HasMany(e => e.PSOLICITUDES)
                .WithRequired(e => e.TIPOSCONT)
                .HasForeignKey(e => e.TIP_CON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOSCONT>()
                .HasMany(e => e.SUBTIPOS)
                .WithRequired(e => e.TIPOSCONT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOSGASTOS>()
                .Property(e => e.COD_GASTO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSGASTOS>()
                .Property(e => e.DES_GASTO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSPROC>()
                .Property(e => e.COD_TPROC)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSPROC>()
                .Property(e => e.NOM_TPROC)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSPROC>()
                .Property(e => e.ABRE_TPROC)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSPROC>()
                .Property(e => e.ESTA_TPROC)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSPROC>()
                .Property(e => e.COD_CTR)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSPROC>()
                .Property(e => e.CTR_F20_1A)
                .IsUnicode(false);

            modelBuilder.Entity<TIPOSPROC>()
                .HasMany(e => e.CONS_PROC)
                .WithRequired(e => e.TIPOSPROC)
                .HasForeignKey(e => e.TIP_PROC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOSPROC>()
                .HasMany(e => e.ESTPREV)
                .WithOptional(e => e.TIPOSPROC)
                .HasForeignKey(e => e.MOD_SEL_EP);

            modelBuilder.Entity<TIPOSPROC>()
                .HasMany(e => e.GPROCESOS)
                .WithOptional(e => e.TIPOSPROC)
                .HasForeignKey(e => e.COD_TPRO);

            modelBuilder.Entity<TIPOSPROC>()
                .HasMany(e => e.MOD_TIP_PLA)
                .WithRequired(e => e.TIPOSPROC)
                .HasForeignKey(e => e.COD_MOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOSPROC>()
                .HasMany(e => e.PACTIVIDADES)
                .WithRequired(e => e.TIPOSPROC)
                .HasForeignKey(e => e.COD_TPRO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPOSPROC>()
                .HasMany(e => e.PCONTRATOS)
                .WithOptional(e => e.TIPOSPROC)
                .HasForeignKey(e => e.COD_TPRO);

            modelBuilder.Entity<TIPOSPROC>()
                .HasMany(e => e.PSOLICITUDES)
                .WithRequired(e => e.TIPOSPROC)
                .HasForeignKey(e => e.COD_TPRO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPPLANTILLAS>()
                .Property(e => e.ID_TIPPLA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPPLANTILLAS>()
                .Property(e => e.NOM_TIPPLA)
                .IsUnicode(false);

            modelBuilder.Entity<TIPPROPONENTE>()
                .Property(e => e.COD_TIPPROP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPPROPONENTE>()
                .Property(e => e.NOM_TIPPROP)
                .IsUnicode(false);

            modelBuilder.Entity<TIPPROPONENTE>()
                .HasMany(e => e.GPPROPONENTES)
                .WithOptional(e => e.TIPPROPONENTE)
                .HasForeignKey(e => e.TIPO);

            modelBuilder.Entity<TIPPROPONENTE>()
                .HasMany(e => e.MOD_PROPONENTES)
                .WithOptional(e => e.TIPPROPONENTE)
                .HasForeignKey(e => e.TIPO);

            modelBuilder.Entity<TIPPROPONENTE>()
                .HasMany(e => e.PPROPONENTES)
                .WithOptional(e => e.TIPPROPONENTE)
                .HasForeignKey(e => e.TIPO);

            modelBuilder.Entity<TIPPROPONENTE>()
                .HasMany(e => e.PPROPONENTESS)
                .WithOptional(e => e.TIPPROPONENTE)
                .HasForeignKey(e => e.TIPO_PROP);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.CED_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.APE_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.NOM_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.PER_USU)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIOS>()
                .HasMany(e => e.ANX_CONTRATOS)
                .WithOptional(e => e.USUARIOS)
                .HasForeignKey(e => e.USUARIO);

            modelBuilder.Entity<USUARIOS>()
                .HasMany(e => e.AUDITORIA)
                .WithRequired(e => e.USUARIOS)
                .HasForeignKey(e => e.USU_AUD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VIGENCIAS>()
                .Property(e => e.EST_VIG)
                .IsUnicode(false);

            modelBuilder.Entity<VIGENCIAS>()
                .Property(e => e.RAD_AUT)
                .IsUnicode(false);

            modelBuilder.Entity<CDP_GPROCESOS>()
                .Property(e => e.NUM_GPROC)
                .IsUnicode(false);

            modelBuilder.Entity<CDP_GPROCESOS>()
                .Property(e => e.VAL_CDP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CDP_PCONTRATOS>()
                .Property(e => e.NUM_PCON)
                .IsUnicode(false);

            modelBuilder.Entity<CDP_PCONTRATOS>()
                .Property(e => e.VAL_CDP)
                .HasPrecision(17, 2);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_CODI)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_NOMB)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_ENCA)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_BODY)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_PIEP)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_CAMP)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_VISTA)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_USBD)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_USAP)
                .IsUnicode(false);

            modelBuilder.Entity<CMINUTAS>()
                .Property(e => e.CMIN_ESTA)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUT>()
                .Property(e => e.IDE_TER)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUT>()
                .Property(e => e.ID_MIEMBROS)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUT>()
                .Property(e => e.ID_ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<CONSORCIOSUT>()
                .Property(e => e.PORC_PART)
                .HasPrecision(10, 4);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.COD_SECPRINCIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.NOM_SECPRINCIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.NIT)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.REPRESENTANTE_LEGAL)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.TELEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.DEPARTAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.CIUDAD)
                .IsUnicode(false);

            modelBuilder.Entity<CTRL_ENTIDAD>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<HAUDITORIA>()
                .Property(e => e.HAUDCODI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HAUDITORIA>()
                .Property(e => e.HAUDTABL)
                .IsUnicode(false);

            modelBuilder.Entity<HAUDITORIA>()
                .Property(e => e.HAUDIDEN)
                .IsUnicode(false);

            modelBuilder.Entity<HAUDITORIA>()
                .Property(e => e.HAUDTIPO)
                .IsUnicode(false);

            modelBuilder.Entity<HAUDITORIA>()
                .Property(e => e.HAUDDESC)
                .IsUnicode(false);

            modelBuilder.Entity<HAUDITORIA>()
                .Property(e => e.HAUDUSER)
                .IsUnicode(false);

            modelBuilder.Entity<HAUDITORIA>()
                .Property(e => e.HAUDUSBD)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.RECIBIDO_ABOG)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.OBS_RECIBIDO_ABOG)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.OBS_REVISADO)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.CONCEPTO_REVISADO)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.ID_HREV)
                .HasPrecision(38, 0);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.NIT_ABOG_RECIBE)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.OBSERVACION_RECIBIDO)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<HREVSOLADI>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<IMP_ADICIONES>()
                .Property(e => e.NRO_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<IMP_ADICIONES>()
                .Property(e => e.NRO_IMP)
                .IsUnicode(false);

            modelBuilder.Entity<IMP_ADICIONES>()
                .Property(e => e.NRO_COM)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CPROYECTOS>()
                .Property(e => e.NUM_SOL_ADI)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CPROYECTOS>()
                .Property(e => e.PROYECTO)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CPROYECTOS>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CPROYECTOS>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CPROYECTOS>()
                .Property(e => e.USAP)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CPROYECTOS>()
                .Property(e => e.USBD_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<MOD_CPROYECTOS>()
                .Property(e => e.USAP_MOD)
                .IsUnicode(false);

            modelBuilder.Entity<PAGAUT>()
                .Property(e => e.MENUID)
                .IsUnicode(false);

            modelBuilder.Entity<PAGAUT>()
                .Property(e => e.NOMPAG)
                .IsUnicode(false);

            modelBuilder.Entity<RP>()
                .Property(e => e.TIP_RP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_2008_2010>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_2008_2010>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_2008_2010>()
                .Property(e => e.NOM_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_2008_2010>()
                .Property(e => e.VAL_COMPROMISO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<RUBROS_CONTRATOS_2008_2010>()
                .Property(e => e.NRO_RP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_2008_2010>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_2008_2010>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<RUBROS_CONTRATOS_X>()
                .Property(e => e.COD_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_X>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_X>()
                .Property(e => e.NOM_RUB)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_X>()
                .Property(e => e.VAL_COMPROMISO)
                .HasPrecision(17, 2);

            modelBuilder.Entity<RUBROS_CONTRATOS_X>()
                .Property(e => e.NRO_RP)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_X>()
                .Property(e => e.USBD)
                .IsUnicode(false);

            modelBuilder.Entity<RUBROS_CONTRATOS_X>()
                .Property(e => e.ID)
                .HasPrecision(38, 0);
        }
    }
}
