using Entidades.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Contratos.Gestion;
using DAL.Model;

namespace BLL.Contratos
{
    public class GDocumentos
    {
        mContratos Cmanager = new mContratos();
        
        Entities ctx = new Entities();

        public List<vCONTRATOS> GetContrato(string Cod_Con)
        {
            List<vCONTRATOS> List = new List<vCONTRATOS>();
            using (ctx = new Entities())
            {
                var query = ctx.CONTRATOS.Where(t => t.COD_CON == Cod_Con)
                    .Select(
                        t => new vCONTRATOS
                        { 
                         COD_CON= t.COD_CON
                         //,
                         //DependenciaNec = t.DEPENDENCIA.NOM_DEP,

                        
                        }
                    );

                
            }
            
            
            return Cmanager.GetContrato(Cod_Con);

        }

    }
}
