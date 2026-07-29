using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class pseudocodigoprof : Form
    {
        public pseudocodigoprof()
        {
            InitializeComponent();
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: false);
            MenuLateralHelper.AgregarMenu(this, "Inicio");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            profe4 frm = new profe4();
            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ESTRUTURAS_Y_REGLAS frm = new ESTRUTURAS_Y_REGLAS();
            frm.Show();
            Hide();
        }
    }
}
