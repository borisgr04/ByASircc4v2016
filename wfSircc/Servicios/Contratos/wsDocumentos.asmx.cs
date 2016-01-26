using BLL.CGestion;
using BLL.CGestion.Filtros;
using Entidades.VOficios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace wfSircc.Servicios.Contratos
{
    /// <summary>
    /// Summary description for wsDocumentos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class wsDocumentos : System.Web.Services.WebService
    {
        GDocumentos gd = new GDocumentos();

        [WebMethod]
        public vSolicitudRP GetContrato(string Cod_Con)
        {
            return gd.GetContratos(Cod_Con);
        }
        
    }
}
