using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class ESTRUTURAS_Y_REGLAS : Form
    {
        public ESTRUTURAS_Y_REGLAS()
        {
            InitializeComponent();
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: false);
            MenuLateralHelper.AgregarMenu(this, "Inicio");
        }

        private void ESTRUTURAS_Y_REGLAS_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MODULODEPROFESOR form = new MODULODEPROFESOR();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pseudocodigoprof frm = new pseudocodigoprof();
            frm.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MODULODEPROFESOR frms = new MODULODEPROFESOR();
            frms.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pseudocodigoprof frmsa = new pseudocodigoprof();
            frmsa.Show();
            Hide();
        }
    }
}
