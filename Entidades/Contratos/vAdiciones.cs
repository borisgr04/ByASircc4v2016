﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Contratos
{
    public class vAdiciones
    {
        public string NRO_ADI { get; set; }
        public System.DateTime FEC_SUS_ADI { get; set; }
        public int PLA_EJE_ADI { get; set; }
        public short VIG_ADI { get; set; }
        public decimal VAL_ADI { get; set; }

        public string DOC_ADI { get; set; }
        public string COD_CON { get; set; }
        public string TIP_ADI { get; set; }
        public string NOM_ADI { get; set; }
        public string LEGALIZADO { get; set; }
        public Nullable<System.DateTime> FEC_APR_POL { get; set; }
        public string OBSER { get; set; }
        public string EXENPOL { get; set; }
        public string TIPO_PLAZO1_ADI { get; set; }
        public Nullable<decimal> PLAZO2_ADI { get; set; }
        public string TIPO_PLAZO2_ADI { get; set; }
        public Nullable<decimal> VAL_APO_GOB_ADI { get; set; }
        public Nullable<decimal> VAL_SIN_IVA_ADI { get; set; }
        public string RES_APR_POL { get; set; }
        public Nullable<System.DateTime> FEC_REG { get; set; }
        public string USAP { get; set; }
        public string USBD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
        public string USBD_M { get; set; }
        public string USAP_M { get; set; }
        public string DES_MOD { get; set; }

        //public virtual CONTRATOS CONTRATOS { get; set; }
    }
}