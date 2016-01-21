namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PESTADOS")]
    public partial class PESTADOS
    {
        public PESTADOS()
        {
            GPROCESOS = new HashSet<GPROCESOS>();
            PACTIVIDADES = new HashSet<PACTIVIDADES>();
            PCONTRATOS = new HashSet<PCONTRATOS>();
        }

        [Key]
        [StringLength(2)]
        public string COD_EST { get; set; }

        [StringLength(30)]
        public string NOM_EST { get; set; }

        [StringLength(100)]
        public string IMAGEN { get; set; }

        [StringLength(6)]
        public string COLOR { get; set; }

        [StringLength(2)]
        public string FINAL { get; set; }

        public decimal? ORDEN { get; set; }

        public virtual ICollection<GPROCESOS> GPROCESOS { get; set; }

        public virtual ICollection<PACTIVIDADES> PACTIVIDADES { get; set; }

        public virtual ICollection<PCONTRATOS> PCONTRATOS { get; set; }
    }
}
