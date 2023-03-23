using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuarioToolStripButton_Click(object sender, EventArgs e)
        {
            UsuariosForm userForm = new UsuariosForm();
            //abrir forulario usuario dentro de formulario Menu
            userForm.MdiParent = this;
            userForm.Show();

        }

        private void ReservarToolStripButton_Click(object sender, EventArgs e)
        {
            TicketsForm ticketsForm = new TicketsForm();
            //abrir forulario usuario dentro de formulario Menu
            ticketsForm.MdiParent = this;
            ticketsForm.Show();
        }
    }
}
