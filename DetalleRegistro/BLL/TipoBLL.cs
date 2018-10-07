using DetalleRegistro.DAL;
using DetalleRegistro.UI.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DetalleRegistro.BLL
{
    class TipoBLL
    {
        public static bool Guardar(rTipodetelefono tipo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Tipo.Add(tipo) != null)
                {
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
    }
}
