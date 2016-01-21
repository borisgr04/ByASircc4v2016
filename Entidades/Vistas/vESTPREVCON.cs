﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   
    
    public class vESTPREVCON
    {
        public decimal ID { get; set; }
        public string OBJE_EP { get; set; }
        public Nullable<decimal> PLAZ1_EP { get; set; }
        public string TPLA1_EP { get; set; }
        public Nullable<decimal> PLAZ2_EP { get; set; }
        public string TPLA2_EP { get; set; }
        public string LUGE_EP { get; set; }
        public Nullable<decimal> PLIQ_EP { get; set; }
        public string FJUR_EP { get; set; }
        public Nullable<decimal> VAL_ENT_EP { get; set; }
        public Nullable<decimal> VAL_ENT_EP_INI { get; set; }
        public Nullable<decimal> VAL_ENT_EP_FIN { get; set; }
        public Nullable<decimal> VAL_OTR_EP { get; set; }
        public string IDE_DIL_EP { get; set; }
        public string CAR_DIL_EP { get; set; }
        public string DEP_NEC_EP { get; set; }
        public string TIP_CON_EP { get; set; }
        public string NOM_TIP_CON_EP { get; set; }
        public string COD_PRO { get; set; }
        public string STIP_CON_EP { get; set; }
        public Nullable<System.DateTime> FEC_ELA_EP { get; set; }
        public Nullable<System.DateTime> FEC_ELA_EP_INI { get; set; }
        public Nullable<System.DateTime> FEC_ELA_EP_FIN { get; set; }
        public Nullable<System.DateTime> FEC_REG_EP { get; set; }
        public Nullable<System.DateTime> FEC_MOD_EP { get; set; }
        public string USAP_REG_EP { get; set; }
        public string USAP_MOD_EP { get; set; }
        public Nullable<System.DateTime> FEC_REV_EP { get; set; }
        public string USAP_REV_EP { get; set; }
        public string USAP_ELA_EP { get; set; }
        public Nullable<System.DateTime> FEC_ELAS_EP { get; set; }
        public string USAP_APR_EP { get; set; }
        public Nullable<System.DateTime> FEC_APR_EP { get; set; }
        public string USAP_ANU_EP { get; set; }
        public Nullable<System.DateTime> FEC_ANU_EP { get; set; }
        public string USAP_DAN_EP { get; set; }
        public Nullable<System.DateTime> FEC_DAN_EP { get; set; }
        public string DEP_SUP_EP { get; set; }
        public string CAR_SUP_EP { get; set; }
        public string VIG_EP { get; set; }
        public string IDE_APTE_EP { get; set; }
        public string CAR_APTE_EP { get; set; }
        public string CODIGO_EP { get; set; }
        public Nullable<decimal> GRUPOS_EP { get; set; }
        public Nullable<decimal> NUM_EMP_EP { get; set; }
       
        public string IDE_RES_EP { get; set; }
        public string CAR_RES_EP { get; set; }
        public string MOD_SEL_EP { get; set; }
        public Nullable<decimal> NRO_EP { get; set; }

        public string EST_EP { get; set; }
        public string TIPO { get; set; }
        public string EST_FLU_EP { get; set; }

        public string DEP_DEL_EP { get; set; }
        public string NOM_PLAZ1 { get; set; }
        public string NOM_PLAZ2 { get; set; }


        public string PLAZO
        {

            get
            {
                return PLAZ1_EP.ToString() +" "+ NOM_PLAZ1 +" "+ PLAZ2_EP.ToString() +" " +NOM_PLAZ2; 
            }
        }

        
    }
    
        
    
    
    
}
