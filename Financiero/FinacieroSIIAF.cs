﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;

namespace Financiero
{
    class FinacieroSIIAF: IFinanciero
    {
        public SF_CDP GetCDP(string sNroCdp, string sVigCdp)
        {
            SF_CDP sf_cdp=null;
            MRESERVA siiaf_cdp = new MRESERVA();
            decimal dNroCdp=Convert.ToDecimal(sNroCdp);
            decimal dVigCdp=Convert.ToDecimal(sVigCdp);
            using (SIF_Entities ctx = new SIF_Entities()) {
                siiaf_cdp = ctx.MRESERVA.Where(t => t.NUM_CERTIFICADO == dNroCdp && t.VIGENCIA == dVigCdp).FirstOrDefault();
                if (siiaf_cdp != null)
                {
                    sf_cdp = new SF_CDP();
                    sf_cdp.nro_cdp = siiaf_cdp.NUM_CERTIFICADO.ToString();
                    sf_cdp.fec_cdp = siiaf_cdp.FEC_EXPEDICION;
                    sf_cdp.vig_cdp = siiaf_cdp.VIGENCIA.ToString();
                    sf_cdp.val_cdp = 0;
                    foreach (DRESERVA rub in siiaf_cdp.DRESERVA)
                    {
                        SF_RubrosCDP rubroCDP = new SF_RubrosCDP();
                        PPTO_GASTOS_V1 DatosRub = ctx.PPTO_GASTOS_V1.Where(t => t.COD_GASTO == rub.COD_GASTO && t.COD_RECURSO == rub.COD_RECURSO && t.COD_UNIDAD == rub.COD_UNIDAD).FirstOrDefault();
                        rubroCDP.cod_rub = DatosRub.RUBRO;
                        rubroCDP.nom_rub = DatosRub.NOM_GASTO;
                        rubroCDP.val_rub = (decimal)rub.VAL_CERTIFICADO;
                        rubroCDP.cod_gasto_rub = DatosRub.COD_GASTO;
                        rubroCDP.cod_recurso_rub = DatosRub.COD_RECURSO;
                        rubroCDP.cod_unidad_rub = DatosRub.COD_UNIDAD;
                        sf_cdp.val_cdp = rubroCDP.val_rub;
                        sf_cdp.Rubros.Add(rubroCDP);
                    }
                }
                return sf_cdp;

                //sf_cdp.Rubros.
                
            }
            
        }

        public SF_CDP GetRubros(string nro_cdp, string vigencia)
        {
            throw new NotImplementedException();
        }


        public SF_OP GetOP(string nro_op, string vigencia)
        {
            SF_OP sf_op=null ;
            decimal dNro_Op=Convert.ToDecimal(nro_op);
            decimal dVigOp=Convert.ToDecimal(vigencia);
            using (SIF_Entities ctx = new SIF_Entities())
            {
                MORDEN op = ctx.MORDEN.Where(t => t.NUM_ORDEN == dNro_Op && t.VIGENCIA == dVigOp).FirstOrDefault();
                if (op != null) {
                    sf_op=new SF_OP();
                    Mapper.CreateMap<MORDEN, SF_OP>();
                    Mapper.Map(op, sf_op);
                }
                return sf_op;
            }
               

        }
    }
}
