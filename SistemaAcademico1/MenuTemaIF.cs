using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuTemaIF : Form
    {
        public MenuTemaIF()
        {
            InitializeComponent();
            MenuLateralHelper.AgregarMenu(this, "Ciclos");
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            MenuTemaCiclo ventana = new MenuTemaCiclo();
            ventana.Show();
            Hide();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            MenuTemaFor ventana = new MenuTemaFor();
            ventana.Show(); Hide();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            MenuTemaDoWhile ventana = new MenuTemaDoWhile();
            ventana.Show(); Hide();

        }

        private void btnAnidados_Click(object sender, EventArgs e)
        {
            // Abrir el menú de Ciclos y seleccionar el tema "Anidados" para mantener la misma interfaz
            MenuTemaCiclo ventana = new MenuTemaCiclo();
            ventana.Show();
            ventana.SeleccionarTemaAnidados();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEstructura ventana = new MenuEstructura();
            ventana.Show();
            Hide();
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuTemaif_else menuTemaIfElse = new menuTemaif_else();
            menuTemaIfElse.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

