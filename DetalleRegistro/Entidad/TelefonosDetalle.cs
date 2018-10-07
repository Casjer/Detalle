using System.ComponentModel.DataAnnotations;

namespace DetalleRegistro.Entidad
{
    public class TelefonosDetalle
    {
      
            [Key]
            public int id { get; set; }
            public int PersonaId { get; set; }
            public string TipoTelefono { get; set; }
            public string Telefono { get; set; }


            public TelefonosDetalle()
            {
                id = 0;
                PersonaId = 0;
                TipoTelefono = string.Empty;
                Telefono = string.Empty;
            }
    }
}