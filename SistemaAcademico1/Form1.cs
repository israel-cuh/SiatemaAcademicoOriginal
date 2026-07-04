using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SistemaAcademico1
{
    public partial class Login : Form

    {
        private bool mostrar = false;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Login()
        {
            InitializeComponent();
            this.MouseDown += Login_MouseDown;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            txtClave.KeyDown += txtClave_KeyDown;
            txtClave.UseSystemPasswordChar = false;
            txtUsuario.Text = "Username";
            txtClave.Text = "Password";
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "estudiante" && txtClave.Text == "1234")
            {
               MenuEstructura frm = new MenuEstructura ();
                frm.Show();
                this.Hide();
            }
            else if (txtUsuario.Text == "docente" && txtClave.Text == "1234")
            {
                MenuEstructura frm = new MenuEstructura();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Username")
            {

            }
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtClave.Focus();
            }
        }
        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Salir",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        private void picOjo_Click(object sender, EventArgs e)
        {
            if (mostrar == false)
            {
                txtClave.UseSystemPasswordChar = false;
                mostrar = true;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
                mostrar = false;
            }
        }
        // paara activar y desaptivar el texto de usuario 
        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Username")
            {
                txtUsuario.Text = string.Empty;
            }
        }
        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                txtUsuario.Text = "Username";
            }
        }
        //fin de activar y desaptivar el texto de usuario

        // para activar y desaptivar el texto de contraseña
        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Password")
            {
                txtClave.Text = string.Empty;
                txtClave.UseSystemPasswordChar = true;
            }
        }
        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {

                txtClave.Text = "Password";
                txtClave.UseSystemPasswordChar = false;
            }
            // fin de activar y desaptivar el texto de contraseña
        }
    }
}
