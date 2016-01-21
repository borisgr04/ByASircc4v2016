﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.Entity;
using DAL.Model;

namespace BLL.EstPrev
{
    
    public class mEP_CDP : absBLL
    {
        public EP_CDP reg { get; set; }

        #region Insert

        protected  override bool esValidoInsert()
        {
            return true;
        }
        protected override void AntesInsert()
        {
            //reg.FEC_REG = DateTime.Now;
            decimal ultId;
            try
            {
                ultId = ctx.EP_CDP.Max(t => t.ID);
            }
            catch
            {
                ultId = 0;
            }
            reg.ID = ultId + 1;
            byaRpt.id = ultId.ToString();
            ctx.Entry(reg).State = EntityState.Added; //Adicionar Registro
            
        }
        //protected override void DespuesInsert();
        #endregion

        #region Update

        protected override bool esValidoUpdate()
        {
            return true;
        }
        protected override void AntesUpdate()
        {
            //reg.FEC_MOD = DateTime.Now;

            var found = ctx.EP_CDP.Find(reg.ID);
            if (found != null)
            {
                var entry = ctx.Entry(found);
                entry.OriginalValues.SetValues(found);
                entry.CurrentValues.SetValues(reg);
            }
            else
            {
                throw new Exception("No se encontro el registró");
            }


        }
        //protected override void DespuesUpdate();
        #endregion

        #region Delete

        protected override bool esValidoDelete()
        {
            return true;
        }

        protected  override void AntesDelete()
        {

            ctx.Entry(reg).State = EntityState.Deleted;
        }
        //protected override void DespuesInsert();
        #endregion

    }
}
