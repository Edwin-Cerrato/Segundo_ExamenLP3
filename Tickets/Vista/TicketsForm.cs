using Datos;
using Entidades;
using System;
using System.Collections.Generic;
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



        List<DetalleFactura> listaDetalles = new List<DetalleFactura>();
        FacturaDB facturaDB = new FacturaDB();
        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalAPagar = 0;
        decimal descuento = 0;



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

        private void txtDescripcionSolicitud_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Factura mifactura = new Factura();

            mifactura.Fecha = FechaDateTimePicker.Value;
            // mifactura.CodigoUsuario = System.Threading.CurrentPrincipal.Identity.Name;
            mifactura.Identidad = miCliente.Identidad;
            string text = Convert.ToString(txtImpuesto.Text);
            mifactura.ISV = isv;
            mifactura.Descuento = descuento;
            mifactura.TotalAPagar = totalAPagar;

            mifactura.DescripcionSolicitud = Convert.ToString(txtDescripcionSolicitud.Text);

            mifactura.TipoSoporte = Convert.ToString(TipoSoporteComboBox.Text);


            bool inserto = facturaDB.Guardar(mifactura, listaDetalles);

            if (inserto)
            {
                txtIdentidad.Focus();
                MessageBox.Show("Factura registrada exitosamente");
                // printPreviewDialog1.Document = printDocument1;
                // printPreviewDialog1.ShowDialog();
                //  LimpiarControles();
            }
            else
                MessageBox.Show("No se pudo registrar la factura");
        }


    }
}

