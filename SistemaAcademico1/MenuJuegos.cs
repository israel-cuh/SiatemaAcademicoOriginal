using System;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuJuegos : Form
    {
        private readonly string rolUsuario;

        public MenuJuegos() : this("Docente")
        {
        }

        public MenuJuegos(string rol)
        {
            rolUsuario = string.IsNullOrWhiteSpace(rol) ? "Docente" : rol;
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Juego");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void btnOrdenarCodigo_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void btnJuego2_Click(object sender, EventArgs e)
        {
            MostrarPendiente("Juego 2");
        }

        private void btnJuego3_Click(object sender, EventArgs e)
        {
            MostrarPendiente("Juego 3");
        }

        private void btnJuego4_Click(object sender, EventArgs e)
        {
            MostrarPendiente("Juego 4");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEstructura estructura = new MenuEstructura(rolUsuario);
            estructura.Show();
            Hide();
        }

        private void MostrarPendiente(string nombreJuego)
        {
            MessageBox.Show(
                $"{nombreJuego} todavía está pendiente. Aquí podrá ir el juego de otro integrante del equipo.",
                "CodeNova - Juegos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
