namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.EP_PAA")]
    public partial class EP_PAA
    {
        public EP_PAA()
        {
            EP_PAA_UNSPSC = new HashSet<EP_PAA_UNSPSC>();
            ESTPREV = new HashSet<ESTPREV>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public short? VIGENCIA { get; set; }

        [StringLength(400)]
        public string DESCRIPCION { get; set; }

        public DateTime? FEC_EST_INI { get; set; }

        public decimal? PLA1_EJE { get; set; }

        [StringLength(10)]
        public string TIP1_PLA { get; set; }

        public decimal? PLA2_EJE { get; set; }

        [StringLength(10)]
        public string TIP2_PLA { get; set; }

        [StringLength(10)]
        public string MOD_SEL { get; set; }

        [StringLength(2)]
        public string FUE_SEL { get; set; }

        public decimal? VAL_TOT_EST { get; set; }

        public decimal? VAL_VIG_EST { get; set; }

        [StringLength(2)]
        public string VIG_FUT { get; set; }

        [StringLength(2)]
        public string EST_SOL_VF { get; set; }

        [StringLength(200)]
        public string DAT_RESPONSABLE { get; set; }

        [StringLength(2)]
        public string COD_DEP { get; set; }

        public decimal? ID_EP_MPAA { get; set; }

        public virtual DEPENDENCIA DEPENDENCIA { get; set; }

        public virtual EP_MPAA EP_MPAA { get; set; }

        public virtual ICollection<EP_PAA_UNSPSC> EP_PAA_UNSPSC { get; set; }

        public virtual ICollection<ESTPREV> ESTPREV { get; set; }
    }
}
