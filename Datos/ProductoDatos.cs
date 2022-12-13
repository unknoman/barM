
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class ProductoDatos
    {
        public static List<Producto> Get(Producto p)
        {
            List<Producto> list = new List<Producto>();

            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("productosGet", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (p.id != null)
                    command.Parameters.AddWithValue("@id", p.id);
                if (p.nombre != null)
                    command.Parameters.AddWithValue("@nombre", p.nombre);
                if (p.precio != null)
                    command.Parameters.AddWithValue("@apellido", p.precio);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Producto producto = new Producto();

                        producto.id = Convert.ToInt32(reader["IDPROD"]);
                        producto.nombre = Convert.ToString(reader["NOMBRE"]);


                        list.Add(producto);

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
