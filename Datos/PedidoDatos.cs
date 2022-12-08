
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class PedidoDatos
    {
         public static List<Pedido> Get(Pedido p)
         {
            List<Pedido> list = new List<Pedido>();

             string conString = System.Configuration.ConfigurationManager.
             ConnectionStrings["conexionDB"].ConnectionString;

             using (SqlConnection connection = new SqlConnection(conString))
             {
                 SqlCommand command = new SqlCommand("pedidosGet", connection);
                 command.CommandType = System.Data.CommandType.StoredProcedure;
                 if (p.idPedido != null)
                     command.Parameters.AddWithValue("@id", p.idPedido);
                if (p.ClienteNombre != null)
                    command.Parameters.AddWithValue("@nombre", p.ClienteNombre);
                if (p.ClienteNombre != null)
                    command.Parameters.AddWithValue("@apellido", p.ClienteApellido);

                try
                 {
                     connection.Open();
                     SqlDataReader reader = command.ExecuteReader();
                     while (reader.Read())
                     {
                         Pedido pedido = new Pedido();

                         pedido.idPedido = Convert.ToInt32(reader["IDPEDIDO"]);
                         pedido.fecha = Convert.ToDateTime(reader["FECHA"]);

                         if (reader["CLIENTE"].GetType() != typeof(DBNull))
                         {
                             Cliente cliente = new Cliente();
                             cliente.nombre = Convert.ToString(reader["NOMBRE"]); ;
                             cliente.apellido = Convert.ToString(reader["APELLIDO"]);
                         }

                         list.Add(pedido);

                     }
                     reader.Close();
                 }
                 catch (Exception)
                 {
                     throw;
                 }

             }
             return list;

         } 
    }

}
