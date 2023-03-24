using System.Windows.Forms;

namespace Vista
{
    public partial class TicketsForm : Form
    {
        public TicketsForm()
        {
            InitializeComponent();

        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }
    }
}
