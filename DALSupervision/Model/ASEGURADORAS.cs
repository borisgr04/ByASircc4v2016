namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.ASEGURADORAS")]
    public partial class ASEGURADORAS
    {
        public ASEGURADORAS()
        {
            POLIZAS_CONTRATO = new HashSet<POLIZAS_CONTRATO>();
            POLIZAS_ADICIONES = new HashSet<POLIZAS_ADICIONES>();
            PPROPONENTESS = new HashSet<PPROPONENTESS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_ASE { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_ASE { get; set; }

        [StringLength(2)]
        public string ESTADO { get; set; }

        public virtual ICollection<POLIZAS_CONTRATO> POLIZAS_CONTRATO { get; set; }

        public virtual ICollection<POLIZAS_ADICIONES> POLIZAS_ADICIONES { get; set; }

        public virtual ICollection<PPROPONENTESS> PPROPONENTESS { get; set; }
    }
}
