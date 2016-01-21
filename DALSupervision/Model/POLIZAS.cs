namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.POLIZAS")]
    public partial class POLIZAS
    {
        public POLIZAS()
        {
            C_POLIZAS2 = new HashSet<C_POLIZAS2>();
            EP_POLIZAS = new HashSet<EP_POLIZAS>();
            EP_POLIZAS2 = new HashSet<EP_POLIZAS2>();
            POLIZAS_CONTRATO = new HashSet<POLIZAS_CONTRATO>();
            POLIZAS_ADICIONES = new HashSet<POLIZAS_ADICIONES>();
            PPROPONENTESS = new HashSet<PPROPONENTESS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_POL { get; set; }

        [Required]
        [StringLength(100)]
        public string NOM_POL { get; set; }

        [StringLength(2)]
        public string EST_POL { get; set; }

        [StringLength(400)]
        public string DESCRIPCION { get; set; }

        [StringLength(10)]
        public string VALOR { get; set; }

        [StringLength(10)]
        public string PLAZO { get; set; }

        public virtual ICollection<C_POLIZAS2> C_POLIZAS2 { get; set; }

        public virtual ICollection<EP_POLIZAS> EP_POLIZAS { get; set; }

        public virtual ICollection<EP_POLIZAS2> EP_POLIZAS2 { get; set; }

        public virtual ICollection<POLIZAS_CONTRATO> POLIZAS_CONTRATO { get; set; }

        public virtual ICollection<POLIZAS_ADICIONES> POLIZAS_ADICIONES { get; set; }

        public virtual ICollection<PPROPONENTESS> PPROPONENTESS { get; set; }
    }
}
