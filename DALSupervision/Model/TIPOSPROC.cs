namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.TIPOSPROC")]
    public partial class TIPOSPROC
    {
        public TIPOSPROC()
        {
            CONS_PROC = new HashSet<CONS_PROC>();
            ESTPREV = new HashSet<ESTPREV>();
            GPROCESOS = new HashSet<GPROCESOS>();
            MOD_TIP_PLA = new HashSet<MOD_TIP_PLA>();
            PACTIVIDADES = new HashSet<PACTIVIDADES>();
            PCONTRATOS = new HashSet<PCONTRATOS>();
            PSOLICITUDES = new HashSet<PSOLICITUDES>();
        }

        [Key]
        [StringLength(5)]
        public string COD_TPROC { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_TPROC { get; set; }

        [StringLength(4)]
        public string ABRE_TPROC { get; set; }

        [Required]
        [StringLength(2)]
        public string ESTA_TPROC { get; set; }

        [StringLength(2)]
        public string COD_CTR { get; set; }

        [StringLength(30)]
        public string CTR_F20_1A { get; set; }

        public virtual ICollection<CONS_PROC> CONS_PROC { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV { get; set; }

        public virtual ICollection<GPROCESOS> GPROCESOS { get; set; }

        public virtual ICollection<MOD_TIP_PLA> MOD_TIP_PLA { get; set; }

        public virtual ICollection<PACTIVIDADES> PACTIVIDADES { get; set; }

        public virtual ICollection<PCONTRATOS> PCONTRATOS { get; set; }

        public virtual ICollection<PSOLICITUDES> PSOLICITUDES { get; set; }
    }
}
