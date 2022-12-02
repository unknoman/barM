using System.Collections.Immutable;

namespace Entidades
{
    public class Cliente
    {
        public int? id { get; set; }
       public string? nombre { get; set; }
       public string? apellido { get; set; }

        public Telefono? Telefono { get; set; }
        public string? NombreDepartamento
        {
            get
            {
                if (Telefono != null)
                    return Telefono.tel;
                else
                    return null;
            }
        }

    }
}