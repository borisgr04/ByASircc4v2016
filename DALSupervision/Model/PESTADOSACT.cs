namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.PESTADOSACT")]
    public partial class PESTADOSACT
    {
        public PESTADOSACT()
        {
            PCRONOGRAMAS = new HashSet<PCRONOGRAMAS>();
        }

        [Key]
        [StringLength(4)]
        public string COD_EST { get; set; }

        [StringLength(30)]
        public string NOM_EST { get; set; }

        [StringLength(100)]
        public string IMAGEN { get; set; }

        [StringLength(6)]
        public string COLOR { get; set; }

        [StringLength(2)]
        public string IS_FINAL { get; set; }

        public virtual ICollection<PCRONOGRAMAS> PCRONOGRAMAS { get; set; }
    }
}
