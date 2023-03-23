using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "INGRESE EL CODIGO DE USUARIO");
                txtUsuario.Focus();
                return;
            }
            errorProvider1.Clear();


            if (txtContrasena.Text == string.Empty)
            {
                errorProvider1.SetError(txtContrasena, "INGRESE LA CONTRASEÑA");
                txtContrasena.Clear();
                txtContrasena.Focus();
                return;
            }
            errorProvider1.Clear();


            //Validar Base de Datos

            Login login = new Login(txtUsuario.Text, txtContrasena.Text);
            Usuario usuario = new Usuario();
            UsuarioDB usuarioDB = new UsuarioDB();

            usuario = usuarioDB.Auntenticar(login);

            if (usuario != null)
            {
                if (usuario.EstaActivo)
                {
                    //Mostramos el Menu

                    Menu menuFormulario = new Menu();
                    Hide();
                    menuFormulario.Show();
                }
                else
                {
                    MessageBox.Show("Datos de Usuario No esta Activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtContrasena.Clear();

                }
            }
            else
            {
                MessageBox.Show("Datos de Usuario Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContrasena.Clear();
                txtUsuario.Focus();
            }







        }

        private void btnVerContrasena_Click(object sender, EventArgs e)
        {
            if (txtContrasena.PasswordChar == '*')
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '*';
            }
        }
    }
}
