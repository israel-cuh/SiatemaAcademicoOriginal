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

        private void button1_Click(object sender, EventArgs e)
        {
            //profe 4 codigo 
            // Restablecer el color original de todas las opciones
            radioButton1.ForeColor = Color.White; // O Black, según el color de tu fondo
            radioButton2.ForeColor = Color.White;
            radioButton3.ForeColor = Color.White;
            radioButton4.ForeColor = Color.White;

            // Validar si la respuesta correcta (Literal C / radioButton3) está seleccionada
            if (radioButton3.Checked)
            {
                radioButton3.ForeColor = Color.Green;
                button3.Enabled = true; // Desbloquea el botón Siguiente
            }
            else
            {
                // Marcar en rojo la opción incorrecta que haya elegido el usuario
                if (radioButton1.Checked) radioButton1.ForeColor = Color.Red;
                if (radioButton2.Checked) radioButton2.ForeColor = Color.Red;
                if (radioButton4.Checked) radioButton4.ForeColor = Color.Red;

                button3.Enabled = false; // Mantiene bloqueado el botón Siguiente
            }
        }
    }
}
