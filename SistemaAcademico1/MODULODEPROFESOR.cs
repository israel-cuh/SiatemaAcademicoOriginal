using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MODULODEPROFESOR : Form
    {
        public MODULODEPROFESOR()
        {
            InitializeComponent();
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: false);
            MenuLateralHelper.AgregarMenu(this, "Inicio");
        }

        private void lbltexto_Click(object sender, EventArgs e)
        {

        }

        private void lbltextosabias_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ESTRUTURAS_Y_REGLAS frms = new ESTRUTURAS_Y_REGLAS();
            frms.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
