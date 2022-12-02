using Entidades;
using Negocio;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cliente> clienteLista = new List<Cliente>();
            Cliente cliente1 = new Cliente();
            cliente1.id = 0;
            cliente1.nombre = "Hola";
            cliente1.apellido = "test";
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