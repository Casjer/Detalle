using DetalleRegistro.Entidad;
using DetalleRegistro.UI.Registro;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DetalleRegistro.DAL
{
   public class Contexto : DbContext
    {
            public DbSet<Personas> persona { get; set; }
            public DbSet<TipoDeTelefono> Tipo { get; set; }
            public db() : base("ConStr")
              {

              }
        
    }
}
