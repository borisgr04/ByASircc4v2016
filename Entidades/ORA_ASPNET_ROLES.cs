//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class ORA_ASPNET_ROLES
    {
        public ORA_ASPNET_ROLES()
        {
            this.ORA_ASPNET_USERS = new HashSet<ORA_ASPNET_USERS>();
        }
    
        public System.Guid APPLICATIONID { get; set; }
        public System.Guid ROLEID { get; set; }
        public string ROLENAME { get; set; }
        public string LOWEREDROLENAME { get; set; }
        public string DESCRIPTION { get; set; }
    
        public virtual ORA_ASPNET_APPLICATIONS ORA_ASPNET_APPLICATIONS { get; set; }
        public virtual ICollection<ORA_ASPNET_USERS> ORA_ASPNET_USERS { get; set; }
    }
    
}
