using Datos;
using Entidades;
using System.Windows.Forms;

namespace Vista
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();

        }
        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();



        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(txtIdentidad.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorIdentidad(txtIdentidad.Text);
                txtCliente.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                txtCliente.Clear();
            }
        }

        private void btnBuscarCliente_Click(object sender, System.EventArgs e)
        {
            BuscarClienteForm form = new BuscarClienteForm();
            form.ShowDialog();
            miCliente = new Cliente();
            miCliente = form.cliente;
            txtIdentidad.Text = miCliente.Identidad;
            txtCliente.Text = miCliente.Nombre;
        }

        private void TicketsForm_Load(object sender, System.EventArgs e)
        {
            //txtEmpleado.Text = System.Threading.CurrentPrincipal.Identity.Name;
        }
    }
}
