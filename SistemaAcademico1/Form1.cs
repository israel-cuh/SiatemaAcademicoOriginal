using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class Login : Form

    {
        private bool mostrar = false;
        private Size tamanoBaseLogin;
        private readonly Dictionary<Control, Rectangle> posicionesOriginales = new();
        private readonly Dictionary<Control, float> fuentesOriginales = new();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Login()
        {
            InitializeComponent();
            GuardarDisenoOriginal();
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            AjustarLoginResponsivo();
            Resize += (_, _) =>
            {
                if (WindowState != FormWindowState.Minimized)
                    AjustarLoginResponsivo();
            };
            this.MouseDown += Login_MouseDown;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            txtClave.KeyDown += txtClave_KeyDown;
            txtClave.UseSystemPasswordChar = false;
            txtUsuario.Text = "Username";
            txtClave.Text = "Password";
        }

        private void GuardarDisenoOriginal()
        {
            tamanoBaseLogin = ClientSize;
            posicionesOriginales.Clear();
            fuentesOriginales.Clear();

            foreach (Control control in Controls)
            {
                if (control is VentanaControl)
                    continue;

                posicionesOriginales[control] = control.Bounds;
                fuentesOriginales[control] = control.Font.Size;
            }
        }

        private void AjustarLoginResponsivo()
        {
            if (tamanoBaseLogin.Width == 0 || tamanoBaseLogin.Height == 0)
                return;

            float escala = Math.Min(
                ClientSize.Width / (float)tamanoBaseLogin.Width,
                ClientSize.Height / (float)tamanoBaseLogin.Height);

            int anchoEscalado = (int)(tamanoBaseLogin.Width * escala);
            int altoEscalado = (int)(tamanoBaseLogin.Height * escala);
            int desplazamientoX = (ClientSize.Width - anchoEscalado) / 2;
            int desplazamientoY = (ClientSize.Height - altoEscalado) / 2;

            foreach (var item in posicionesOriginales)
            {
                Control control = item.Key;
                Rectangle original = item.Value;

                control.Bounds = new Rectangle(
                    desplazamientoX + (int)(original.X * escala),
                    desplazamientoY + (int)(original.Y * escala),
                    Math.Max(1, (int)(original.Width * escala)),
                    Math.Max(1, (int)(original.Height * escala)));

                if (fuentesOriginales.TryGetValue(control, out float tamanoFuente))
                    control.Font = new System.Drawing.Font(control.Font.FontFamily, Math.Max(7F, tamanoFuente * escala), control.Font.Style);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim().ToLower();
            string clave = txtClave.Text.Trim();

            if (usuario == "estudiante" && clave == "1234")
            {
                DashboardPrincipal frm = new DashboardPrincipal("Estudiante");
                frm.Show();
                Hide();
            }
            else if (usuario == "docente" && clave == "1234")
            {
                DashboardPrincipal dashboard = new DashboardPrincipal("Docente");
                dashboard.Show();
                Hide();
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
        // para activar y desactivar el texto de usuario
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
        // fin de activar y desactivar el texto de usuario

        // para activar y desactivar el texto de contraseña
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
            // fin de activar y desactivar el texto de contraseña
        }
    }
}
