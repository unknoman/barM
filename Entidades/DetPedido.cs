
namespace Entidades
{
    public class DetPedido
    {
        public int idDet { get; set; }
        public Pedido? Pedido { get; set; }

        public Producto? Producto { get; set; }
        public string? NombreProd
        {
            get
            {
                if (Producto != null)
                    return Producto.nombre;
                else
                    return null;
            }
        }

        public TimeZoneInfo? Hora { get; set; }

        public int cantidad { get; set; }
        public Decimal? precioUnitario { get; set; }
    }
}
