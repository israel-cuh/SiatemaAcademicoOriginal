using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class reglaspracticas : Form
    {
        public reglaspracticas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            profe4 fmr = new profe4();
            fmr.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codigo = textBox5.Text.ToLower();

            bool nota1 = codigo.Contains("leer nota1") || codigo.Contains("leer nota 1");
            bool nota2 = codigo.Contains("leer nota2") || codigo.Contains("leer nota 2");
            bool nota3 = codigo.Contains("leer nota3") || codigo.Contains("leer nota 3");

            bool promedio = codigo.Contains("promedio");
            bool calculo = codigo.Contains("/3") || codigo.Contains("/ 3");
            bool mostrar = codigo.Contains("escribir") || codigo.Contains("mostrar");

            if (nota1 && nota2 && nota3 && promedio && calculo && mostrar)
            {
                textBox5.BackColor = Color.LightGreen;

                MessageBox.Show("¡Correcto! Has completado la práctica. GRACIAS POR PARTICIPAR",
                                "¡Felicidades!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // --- REDIRECCIÓN AL MENÚ PRINCIPAL ---

                // 1. Buscamos la instancia de frmPrincipal que ya está abierta
                frmPrincipal menu = Application.OpenForms.OfType<frmPrincipal>().FirstOrDefault();

                // 2. Si existe el menú, lo traemos al frente. Si no, lo creamos.
                if (menu != null)
                {
                    menu.Show();
                    menu.BringToFront();
                }
                else
                {
                    menu = new frmPrincipal();
                    menu.Show();
                }

                // 3. Cerramos ÚNICAMENTE esta ventana actual. 
                // Al no cerrar las otras, el programa sigue vivo y regresas al menú.
                this.Close();
            }
            else
            {
                textBox5.BackColor = Color.LightCoral;

                MessageBox.Show("Incorrecto. Revisa tu pseudocódigo.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                button4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                textBox5.Clear();

                textBox5.BackColor = Color.White;

                button4.Enabled = false;
            }
        }
    }
}
