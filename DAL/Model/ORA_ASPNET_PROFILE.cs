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
    
    public partial class ORA_ASPNET_PROFILE
    {
        public System.Guid USERID { get; set; }
        public string PROPERTYNAMES { get; set; }
        public string PROPERTYVALUESSTRING { get; set; }
        public byte[] PROPERTYVALUESBINARY { get; set; }
        public System.DateTime LASTUPDATEDDATE { get; set; }
    
        public virtual ORA_ASPNET_USERS ORA_ASPNET_USERS { get; set; }
    }
}
