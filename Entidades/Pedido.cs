
namespace Entidades
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public Cliente? Cliente
        { get; set; }
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
        public  DateTime? fecha { get; set; }

    }
}
