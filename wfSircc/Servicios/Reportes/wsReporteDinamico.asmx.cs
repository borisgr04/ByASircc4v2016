﻿using BLL.Oracle;
using Entidades.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace wfSircc.Servicios.Reportes
{
    /// <summary>
    /// Descripción breve de wsReporteDinamico
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class wsReporteDinamico : System.Web.Services.WebService
    {
        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public List<vRptaReporteDinamicoContratos> RealizarReporteDinamico(vConsultaContratosDinamicaDto Reg)
        {
            ReporteDinamico o = new ReporteDinamico();
            return o.Consultar(Reg);
        }
    }
}