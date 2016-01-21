namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.INT_PPLANTILLAS_URL")]
    public partial class INT_PPLANTILLAS_URL
    {
        [Key]
        public decimal IDE_PLA { get; set; }

        [StringLength(200)]
        public string URL_FORM { get; set; }

        [StringLength(200)]
        public string URL_RPTE { get; set; }

        [StringLength(2)]
        public string URL_EST { get; set; }

        [StringLength(200)]
        public string URL_DESC { get; set; }

        public DateTime? URL_FECREG { get; set; }

        [StringLength(20)]
        public string URL_USAP { get; set; }

        [StringLength(20)]
        public string URL_USMD { get; set; }

        public DateTime? URL_FECMD { get; set; }

        public virtual PPLANTILLAS PPLANTILLAS { get; set; }
    }
}
