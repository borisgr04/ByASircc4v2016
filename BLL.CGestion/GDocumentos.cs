using Entidades.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using BLL.CGestion;
using BLL.CGestion.Filtros;
using Entidades.VOficios;
using Entidades;

namespace BLL.CGestion
{
    public class GDocumentos
    {
        CGContratos o = new CGContratos();
        
        Entities ctx = new Entities();

        public vSolicitudRP GetContratos(string COD_CON)
        {
            using (ctx = new Entities())
            {
                vSolicitudRP srp= (from ic in ctx.INTERVENTORES_CONTRATO
                                            join c in ctx.CONTRATOS on ic.COD_CON equals c.COD_CON
                                            where ic.COD_CON == COD_CON
                                                    && ic.TIP_INT == "S"
                                                    && ic.EST_INT == "AC"
                                            orderby c.COD_CON
                                           select (new vSolicitudRP
                                            {
                                                COD_CON= c.COD_CON,
                                                TIP_CON = c.TIPOSCONT.NOM_TIP + " " + c.SUBTIPOS.NOM_STIP,
                                                OBJ_CON = c.OBJ_CON,
                                                FEC_SUS_CON = c.FEC_SUS_CON,
                                                VAL_CON = c.VAL_CON,
                                                CONTRATISTA = new vTerceros{ APE1_TER= c.TERCEROS.APE1_TER.Trim(), APE2_TER= c.TERCEROS.APE2_TER.Trim(), NOM1_TER=c.TERCEROS.NOM1_TER.Trim(), NOM2_TER =c.TERCEROS.NOM2_TER.Trim()},
                                                SUPERVISOR = new vTerceros { APE1_TER = ic.TERCEROS.APE1_TER.Trim(), APE2_TER = ic.TERCEROS.APE2_TER.Trim(), NOM1_TER = ic.TERCEROS.NOM1_TER.Trim(), NOM2_TER = ic.TERCEROS.NOM2_TER.Trim() },
                                                CDP_CONTRATOS = c.CDP_CONTRATOS.Select(t => new vCDP_CONTRATOS
                                                {
                                                    COD_CON = t.COD_CON,
                                                    FEC_CDP = t.FEC_CDP,
                                                    NRO_CDP = t.NRO_CDP,
                                                    VAL_CDP = t.VAL_CDP,
                                                    VIG_FUT = t.VIG_FUT
                                                }).ToList(),
                                            })).FirstOrDefault();
                

                return srp;
            }
        }

       
        public vSolicitudRP GetContrato0(string Cod_Con)
        {
            vSolicitudRP srp;
            srp= ctx.CONTRATOS.Where(t => t.COD_CON == Cod_Con).Select(
               c => new vSolicitudRP
               {
                   COD_CON = c.COD_CON,
                   DEP_DEL_NOM = c.DEPENDENCIA.NOM_DEP,
                   TIP_CON = c.TIPOSCONT.NOM_TIP + " " + c.SUBTIPOS.NOM_STIP,
                   OBJ_CON = c.OBJ_CON,
                   FEC_SUS_CON = c.FEC_SUS_CON,
                   VAL_APO_GOB = c.VAL_APO_GOB,
                   CONTRATISTA = new vTerceros {
                      APE1_TER = c.TERCEROS.APE1_TER,
                      APE2_TER = c.TERCEROS.APE2_TER,
                      NOM1_TER = c.TERCEROS.NOM1_TER,
                      NOM2_TER = c.TERCEROS.NOM2_TER,
                   },
                   
                   CDP_CONTRATOS = c.CDP_CONTRATOS.Select(t => new vCDP_CONTRATOS{
                       COD_CON = t.COD_CON,
                       FEC_CDP = t.FEC_CDP,
                       NRO_CDP = t.NRO_CDP,
                       VAL_CDP = t.VAL_CDP,
                       VIG_FUT = t.VIG_FUT
                   }).ToList(),
               }
           ).FirstOrDefault();

            srp.SUPERVISOR = ctx.INTERVENTORES_CONTRATO.Where(ic=> ic.COD_CON==srp.COD_CON && ic.TIP_INT=="S" && ic.EST_INT=="AC").Select(t=> 
                       new vTerceros {
                           APE1_TER = t.TERCEROS.APE1_TER,
                           APE2_TER = t.TERCEROS.APE2_TER,
                           NOM1_TER = t.TERCEROS.NOM1_TER,
                           NOM2_TER = t.TERCEROS.NOM2_TER,
                       }).FirstOrDefault();
            srp.INTERVENTOR = ctx.INTERVENTORES_CONTRATO.Where(ic => ic.COD_CON == srp.COD_CON && ic.TIP_INT == "I" && ic.EST_INT == "AC").Select(t =>
                   new vTerceros
                   {
                       APE1_TER = t.TERCEROS.APE1_TER,
                       APE2_TER = t.TERCEROS.APE2_TER,
                       NOM1_TER = t.TERCEROS.NOM1_TER,
                       NOM2_TER = t.TERCEROS.NOM2_TER,
             }).FirstOrDefault();
            return srp;
   
        }


    }
}
