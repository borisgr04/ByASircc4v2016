//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class INT_PPLANTILLAS_URL
    {
        public decimal IDE_PLA { get; set; }
        public string URL_FORM { get; set; }
        public string URL_RPTE { get; set; }
        public string URL_EST { get; set; }
        public string URL_DESC { get; set; }
        public Nullable<System.DateTime> URL_FECREG { get; set; }
        public string URL_USAP { get; set; }
        public string URL_USMD { get; set; }
        public Nullable<System.DateTime> URL_FECMD { get; set; }
    
        public virtual PPLANTILLAS PPLANTILLAS { get; set; }
    }
}
