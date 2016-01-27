using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.VOficios
{
    public class vSolicitudRP
    {
        public vSolicitudRP(){
            this.CDP_CONTRATOS = new List<vCDP_CONTRATOS>();
        }
        
        public string COD_CON { get; set; }
        public string TIP_CON { get; set; }
        public string OBJ_CON { get; set; }
        public string IDE_CON { get; set; }

        public decimal? VAL_APO_GOB { get; set; }
        public decimal VAL_CON { get; set; }
        public DateTime FEC_SUS_CON { get; set; }
        public string EST_CON { get; set; }
        public string DEP_NEC_NOM { get; set; }
        public string DEP_DEL_NOM { get; set; }
        public string IDE_INT { get; set; }
        public string NOM_INT { get; set; }
        public short Vigencia { get; set; }
        public string DEP_NEC { get; set; }
        public string DEP_DEL { get; set; }
        public string COD_TIP { get; set; }
        public string COD_STIP { get; set; }
        public string Contratista { 
            get {
                if (CONTRATISTA != null) return CONTRATISTA.NOMBRE;
                else return "";
            }
            set { string a = value; }
        }
        public string Supervisor
        {
            get
            {
                if (SUPERVISOR != null) return SUPERVISOR.NOMBRE;
                else return "";
            }
            set { string a = value; }
        }
        public string Interventor
        {
            get
            {
                if (INTERVENTOR != null) return INTERVENTOR.NOMBRE;
                else return "";
            }
            set { string a = value; }
        }
        public vTerceros CONTRATISTA { get; set; }
        public vTerceros SUPERVISOR { get; set; }
        public vTerceros INTERVENTOR { get; set; }

        public virtual List<vCDP_CONTRATOS> CDP_CONTRATOS { get; set; }
    }

    public partial class vCDP_CONTRATOS
    {
        public string NRO_CDP { get; set; }
        public string COD_CON { get; set; }
        public System.DateTime FEC_CDP { get; set; }
        public Nullable<decimal> VAL_CDP { get; set; }
        public string VIG_FUT { get; set; }
    }
}
