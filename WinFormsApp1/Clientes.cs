using Entidades;
using Negocio;

namespace WinFormsApp1
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cliente> clienteLista = new List<Cliente>();
            Cliente cliente1 = new Cliente();
            clienteLista = ClienteNegocio.Get(cliente1);
            try
            {
                ClienteBinding1.DataSource= clienteLista;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
        }


    }
}