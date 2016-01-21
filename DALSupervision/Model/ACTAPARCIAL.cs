namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ACTAPARCIAL")]
    public partial class ACTAPARCIAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_ACTA { get; set; }

        public DateTime? FEC_PINI { get; set; }

        public DateTime? FEC_PFIN { get; set; }

        [StringLength(2)]
        public string AUT_PAG { get; set; }

        public decimal? VAL_AUT { get; set; }

        public DateTime? FEC_REG { get; set; }

        [StringLength(20)]
        public string USAP { get; set; }

        public DateTime? FEC_MOD { get; set; }

        [StringLength(20)]
        public string USAP_MOD { get; set; }

        public virtual ESTCONTRATOS ESTCONTRATOS { get; set; }
    }
}
