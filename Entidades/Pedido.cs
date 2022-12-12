
namespace Entidades
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public Cliente? Cliente { get; set; }

        public Estado? EstadoNom { get; set; }
        public string? ClienteNombre
        {
            get
            {
                if (Cliente != null)
                    return Cliente.nombre;
                else
                    return null;
            }
        }

        public string? ClienteApellido
        {
            get
            {
                if (Cliente != null)
                    return Cliente.apellido;
                else
                    return null;
            }
        }

        public  DateTime? fecha { get; set; }

        public string? Estado
        {
            get
            {
                if (EstadoNom.estadonom != null)
                    return EstadoNom.estadonom;
                else
                    return null;
            }
        }

    }
}
