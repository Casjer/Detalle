using DetalleRegistro.DAL;
using DetalleRegistro.Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace DetalleRegistro.BLL
{
    class PersonaBLL
    {
        public static bool Guardar(Personas Persona)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.persona.Add(Persona) != null) 
             
                   paso = db.SaveChanges() > 0 ;
                                
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


        public static bool Modificar(Personas Persona)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = db.persona.find(Persona.PersonaId)
                foreach (var item in Anterior.Telefonos)
                {
                    if (!Persona.Telefonos.Exist(d => d.Id == item.id))
                        db.Entry(item).state = EntityState.deleted;
                }

                db.Entry(Persona).State = EntityState.Modified;
                  paso = db.SaveChanges() > 0);
               
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


        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto db = new Contexto();
            try
            {
                var Persona = db.persona.Find(id);
                db.Entry(Persona).state = System.Data.Entity.Entitystate.Deleted;

                paso = (db.SaveChanges() > 0);
               
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


        public static Personas Buscar(int id)
        {
            Contexto db = new Contexto();
            Personas Persona = new Personas();
            try
            {
                Persona = db.persona.Find(id);
                db.Telefonos.count();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Persona;
        }

        public static List<Personas> GetList(Expression<Func<Personas, bool>> expression)
        {
            List<Personas> Persona = new List<Personas>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Personas.where.(Persona).Tolist();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Lista;
        }
    }
    
}
