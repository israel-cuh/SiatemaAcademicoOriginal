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
            estudiante estudiante = new estudiante();
            estudiante.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MODULODEPROFESOR mODULODEPROFESOR = new MODULODEPROFESOR();
            mODULODEPROFESOR.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Restablece el color del texto de las opciones a blanco (según tu diseño)
            radioButton1.ForeColor = Color.White;
            radioButton2.ForeColor = Color.White;
            radioButton3.ForeColor = Color.White;
            radioButton4.ForeColor = Color.White;

            // Evalúa si la respuesta correcta (Literal A) está marcada
            if (radioButton1.Checked)
            {
                radioButton1.ForeColor = Color.Green;
            }
            else
            {
                // Marca en rojo la opción incorrecta que seleccionó el usuario
                if (radioButton2.Checked) radioButton2.ForeColor = Color.Red;
                if (radioButton3.Checked) radioButton3.ForeColor = Color.Red;
                if (radioButton4.Checked) radioButton4.ForeColor = Color.Red;

               
            }
        }
    }
}
