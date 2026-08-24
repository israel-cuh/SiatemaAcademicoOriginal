using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class CicloFor2 : Form
    {
        public CicloFor2()
        {
            InitializeComponent();
            if (System.ComponentModel.LicenseManager.UsageMode != System.ComponentModel.LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Ciclos");

                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
                Resize += (_, _) =>
                {
                    if (WindowState != FormWindowState.Minimized) ;

                };
            }
        }

        private void lblSalida_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int aciertos = 0;
            int totalPreguntas = 3;

            // --- PREGUNTA 1 ---
            // Supongamos que la respuesta correcta es la opción 'a' (9)
            // Asegúrate de cambiar 'rbP1A' por el nombre de tu RadioButton real de la pregunta 1
            if (rbP1A.Checked)
            {
                aciertos++;
            }

            // --- PREGUNTA 2 ---
            // Supongamos que la respuesta correcta es la opción 'c' (Imprime del 10 al 1)
            if (rbP2C.Checked)
            {
                aciertos++;
            }

            // --- PREGUNTA 3 ---
            // Supongamos que la respuesta correcta es la opción 'd' (Bucle infinito)
            if (rbP3D.Checked)
            {
                aciertos++;
            }

            // Mostrar el resultado final en tu Label de resultados
            lblResultado.Text = $"Has acertado {aciertos} de {totalPreguntas} preguntas.";

            if (aciertos == totalPreguntas)
            {
                lblResultado.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Orange;
            }
        }

        private void btnjuego_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEstructura menuEstructura = new MenuEstructura();
            menuEstructura.Show();
            Hide();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            CicloWhile1 cicloWhile1 = new CicloWhile1();
            cicloWhile1.Show();
            Hide();
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            CicloDoWhile3 cicloDoWhile3 = new CicloDoWhile3();
            cicloDoWhile3.Show();
            Hide();
        }

        private void btnAnidados_Click(object sender, EventArgs e)
        {
            CicloAnidados4 cicloAnidados4 = new CicloAnidados4();
            cicloAnidados4.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estructura_If5 estructura_If5 = new Estructura_If5();
            estructura_If5.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Estructura_If_Else6 estructura_If_Else6 = new Estructura_If_Else6();
            estructura_If_Else6.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Esructura_Swich7 esructura_Swich7 = new Esructura_Swich7();
            esructura_Swich7.Show();
            Hide();
        }
    }
}
