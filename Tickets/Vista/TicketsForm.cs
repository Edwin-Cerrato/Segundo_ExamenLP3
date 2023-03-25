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
            txtIdentidad.Focus();
            txtEmpleado.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void txtDescripcionSolicitud_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            Factura mifactura = new Factura();
            miCliente = new Cliente();

            DetalleFactura detalle = new DetalleFactura();

            mifactura.Fecha = FechaDateTimePicker.Value;
            mifactura.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            mifactura.IdentidadCliente = miCliente.Identidad;
            mifactura.ISV = isv;
            mifactura.Descuento = descuento;
            mifactura.TotalAPagar = totalAPagar;
            //mifactura.DescripcionSolicitud = mifactura.DescripcionSolicitud;
            //mifactura.TipoSoporte = mifactura.TipoSoporte;
            mifactura.DescripcionSolicitud = Convert.ToString(txtDescripcionSolicitud.Text);
            mifactura.TipoSoporte = Convert.ToString(txtTipoSoporte.Text);



            bool inserto = facturaDB.Guardar(mifactura, listaDetalles);

            if (inserto)
            {
                txtIdentidad.Focus();
                MessageBox.Show("Factura registrada exitosamente");

                LimpiarControles();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la factura");
            }


        }


        private void LimpiarControles()
        {
            miCliente = null;

            listaDetalles = null;
            FechaDateTimePicker.Value = DateTime.Now;
            txtIdentidad.Clear();
            txtCliente.Clear();
            txtPrecio.Clear();
            txtDescripcionRespuesta.Clear();
            txtDescripcionSolicitud.Clear();

            isv = 0;
            txtImpuesto.Clear();
            descuento = 0;
            txtDescuento.Clear();
            totalAPagar = 0;
            txtTotalAPagar.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDescripcionRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoSoporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDescripcionSolicitud.Text = Convert.ToString(txtTipoSoporte.Text);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }


        private void Operacion()
        {
            DetalleFactura detalle = new DetalleFactura();



            isv = Convert.ToDecimal(txtPrecio.Text) * 0.15M;
            descuento = Convert.ToDecimal(txtPrecio.Text) * 0.10M;
            txtDescuento.Text = descuento.ToString();
            totalAPagar = Convert.ToDecimal(txtPrecio.Text) - isv + descuento;


            detalle.Precio = Convert.ToDecimal(txtPrecio.Text);
            listaDetalles.Add(detalle);
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = listaDetalles;

            txtImpuesto.Text = isv.ToString();

            txtTotalAPagar.Text = totalAPagar.ToString();

        }

        private void txtTotalAPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operacion();
        }
    }
}


