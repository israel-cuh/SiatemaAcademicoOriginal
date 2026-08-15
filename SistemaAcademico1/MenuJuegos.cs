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
            CodeMemo2 juego = new CodeMemo2();
            juego.Show();

        }

        private void btnJuego3_Click(object sender, EventArgs e)
        {
            MenuLevelFlujogramForm menuNiveles = new MenuLevelFlujogramForm();
            menuNiveles.Show();
            this.Hide();
        }

        private void btnJuego4_Click(object sender, EventArgs e)
        {
            ahorcadocs juego = new ahorcadocs();
            juego.Show();
            Hide();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEstructura estructura = new MenuEstructura(rolUsuario);
            estructura.Show();
            Hide();
        }

        private void MostrarPendiente(string nombreJuego)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuTutorialOrdenar menuTutorial = new MenuTutorialOrdenar();
            menuTutorial.Show();
            Hide();
        }
    }
}
