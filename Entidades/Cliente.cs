using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Cliente
    {
        public int? id { get; set; }
       public string? nombre { get; set; }
       public string? apellido { get; set; }

        public Telefono? Telefono { get; set; }

        public int? IDTel
        {
            get
            {
                if (Telefono != null)
                    return Telefono.id;
                else
                    return null;
            }
        } 

        public string? NumeroTel
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