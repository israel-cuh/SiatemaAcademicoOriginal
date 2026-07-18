using System;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuTemaDoWhile : Form
    {
        public MenuTemaDoWhile()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Ciclos");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void btnSubWhile_Click(object sender, EventArgs e)
        {
            MenuTemaCiclo ventana = new MenuTemaCiclo();
            ventana.Show();
            Hide();
        }

        private void btnSubFor_Click(object sender, EventArgs e)
        {
            MenuTemaFor ventana = new MenuTemaFor();
            ventana.Show();
            Hide();
        }

        private void btnSubDoWhile_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
        }

        private void btnSubAnidados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "El formulario de Ciclos Anidados todavía está pendiente.",
                "CodeNova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();

            int i = 1;
            do
            {
                txtSalida.AppendText(i + Environment.NewLine);
                i++;
            }
            while (i <= 5);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            btnSubFor_Click(sender, e);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            btnSubAnidados_Click(sender, e);
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }
    }
}
