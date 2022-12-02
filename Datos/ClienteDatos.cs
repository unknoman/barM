using Entidades;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace Datos
{
    public class ClienteDatos
    {
        public static List<Cliente> Get(Cliente c)
        {
            List<Cliente> list = new List<Cliente>();

            string conString = System.Configuration.ConfigurationManager.
            ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("clienteleadosGet", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (c.id != null)
                    command.Parameters.AddWithValue("@id", c.id);
                if (c.nombre != null)
                    command.Parameters.AddWithValue("@nombre_apellido", c.nombre);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.id = Convert.ToInt32(reader["id"]);
                        cliente.nombre = Convert.ToString(reader["NOMBRE"]);

                        //El SP tambien me devuelve datos del departamento
                        if (reader["nombre_dpto"].GetType() != typeof(DBNull))
                        {
                            //creo un objeto departamento
                            Telefono tel = new Telefono();
                           // tel.id = Convert.ToInt32(reader["IDTEL"]); ;
                            tel.tel = Convert.ToString(reader["TELEFONO"]);
                            //asigno el dpto al clienteleado
                            cliente.Telefono = tel;
                        }

                        list.Add(cliente);

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


