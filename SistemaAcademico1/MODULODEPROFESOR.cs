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
            // Restablecer el color original del texto en todos los RadioButtons
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;
            radioButton4.ForeColor = Color.Black;

            // Verificar si la respuesta correcta (Literal A) está marcada
            if (radioButton1.Checked)
            {
                radioButton1.ForeColor = Color.Green;
                button2.Enabled = true; // Desbloquea el botón Siguiente
            }
            else
            {
                // Marcar en rojo la opción incorrecta que haya seleccionado el usuario
                if (radioButton2.Checked) radioButton2.ForeColor = Color.Red;
                if (radioButton3.Checked) radioButton3.ForeColor = Color.Red;
                if (radioButton4.Checked) radioButton4.ForeColor = Color.Red;

                button2.Enabled = false; // Mantiene bloqueado el botón Siguiente
            }
        }
    }
}
