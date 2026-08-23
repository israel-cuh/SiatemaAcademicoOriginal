using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class profe4 : Form
    {
        public profe4()
        {
            InitializeComponent();
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: false);
            MenuLateralHelper.AgregarMenu(this, "Inicio");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuEstudiante menuEstudiante = new MenuEstudiante();
            menuEstudiante.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reglaspracticas reglaspracticas = new reglaspracticas();
            reglaspracticas.Show();
            Hide();
        }

        private void profe4_Load(object sender, EventArgs e)
        {

        }
    }
}
