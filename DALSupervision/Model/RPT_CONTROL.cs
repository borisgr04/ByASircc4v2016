namespace DALSupervision.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SIRCC.RPT_CONTROL")]
    public partial class RPT_CONTROL
    {
        public decimal? VIG_RPT { get; set; }

        public decimal ID { get; set; }

        [StringLength(20)]
        public string IDE_RPT { get; set; }

        public decimal? VERSION { get; set; }

        public string SQL { get; set; }

        [StringLength(30)]
        public string DESC_RPT { get; set; }

        [StringLength(2)]
        public string EST_RPT { get; set; }

        [StringLength(20)]
        public string ENT_RPT { get; set; }
    }
}
