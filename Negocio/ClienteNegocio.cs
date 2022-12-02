using Datos;
using Entidades;

namespace Negocio
{
    public class ClienteNegocio
    {
        public static List<Cliente> Get(Cliente e)
        {
            try
            {
                return ClienteDatos.Get(e);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}