using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class CicloFor : Form
    {
        public CicloFor()
        {
            InitializeComponent();

            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Ciclos");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();

            for (int i = 1; i <= 5; i++)
                txtSalida.AppendText(i + Environment.NewLine);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            MenuTemaCiclo ventana = new MenuTemaCiclo();
            ventana.Show();
            Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "El formulario de Ciclo Do While todavía está pendiente.",
                "CodeNova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }
    }
}
