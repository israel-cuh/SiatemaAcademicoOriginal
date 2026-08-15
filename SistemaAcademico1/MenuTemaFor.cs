using System;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuTemaFor : Form
    {
        public MenuTemaFor()
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
            txtSalida.Clear();
        }

        private void btnSubDoWhile_Click(object sender, EventArgs e)
        {
            MenuTemaDoWhile ventana = new MenuTemaDoWhile();
            ventana.Show();
            Hide();
        }

        private void btnSubAnidados_Click(object sender, EventArgs e)
        {
            // Abrir el menú de Ciclos y seleccionar el tema "Anidados" para mantener la misma interfaz
            MenuTemaCiclo ventana = new MenuTemaCiclo();
            ventana.Show();
            ventana.SeleccionarTemaAnidados();
            Hide();
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
            btnSubWhile_Click(sender, e);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            btnSubDoWhile_Click(sender, e);
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuTemaIF menuTemaIF = new MenuTemaIF();
            menuTemaIF.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuTemaif_else menuTemaIfElse = new menuTemaif_else();
            menuTemaIfElse.Show(this);
            Hide();
        }
    }
}
