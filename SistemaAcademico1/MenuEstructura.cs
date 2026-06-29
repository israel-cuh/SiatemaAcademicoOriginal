using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuEstructura : Form
    {
        public MenuEstructura()
        {
            InitializeComponent();
            lblFecha.Text = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy\nhh:mm tt");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Login login = new();
                login.Show();
                Close();
            }
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            Menuvariables variables = new();
            variables.Show();
            Hide();
        }

        private void btnCiclos_Click(object sender, EventArgs e)
        {
            MenuTemaCiclo ciclos = new();
            ciclos.Show();
            Hide();
        }

        private void btnAlgoritmos_Click(object sender, EventArgs e)
        {
            MostrarProximamente("Algoritmos");
        }

        private void btnCondicionales_Click(object sender, EventArgs e)
        {
            MostrarProximamente("Condicionales");
        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            panelTemas.Focus();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new();
            juego.ShowDialog(this);
        }

        private void MostrarProximamente(string tema)
        {
            MessageBox.Show(
                $"El tema {tema} será agregado por otro integrante del equipo.",
                "Próximamente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
