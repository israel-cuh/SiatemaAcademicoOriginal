using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class menuTemaif_else : Form
    {
        public menuTemaif_else()
        {
            InitializeComponent();
            MenuLateralHelper.AgregarMenu(this, "Ciclos");
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
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

        private void button2_Click(object sender, EventArgs e)
        {
            MenuTemaIF ventana = new MenuTemaIF();
            ventana.Show();
            Hide();
        }

        private void menuTemaif_else_Load(object sender, EventArgs e)
        {

        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEstructura ventana = new MenuEstructura();
            ventana.Show();
            Hide();
        }
    }
    }

