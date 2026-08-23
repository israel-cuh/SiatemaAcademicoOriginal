using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class CicloDoWhile3 : Form
    {
        public CicloDoWhile3()
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

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int aciertos = 0;
            int totalPreguntas = 3;

            // Validamos la Pregunta 1 (La respuesta correcta es la opción 'b')
            if (cmbPregunta1.SelectedItem != null && cmbPregunta1.SelectedItem.ToString().Contains("b)"))
            {
                aciertos++;
            }

            // Validamos la Pregunta 2 (La respuesta correcta es la opción 'a')
            if (cmbPregunta2.SelectedItem != null && cmbPregunta2.SelectedItem.ToString().Contains("a)"))
            {
                aciertos++;
            }

            // Validamos la Pregunta 3 (La respuesta correcta es la opción 'c')
            if (cmbPregunta3.SelectedItem != null && cmbPregunta3.SelectedItem.ToString().Contains("c)"))
            {
                aciertos++;
            }

            // Mostrar el resultado en pantalla (Asegúrate de tener un Label llamado lblResultado)
            lblResultado.Text = $"Relacionaste correctamente {aciertos} de {totalPreguntas} conceptos.";

            if (aciertos == totalPreguntas)
            {
                lblResultado.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResultado.ForeColor = System.Drawing.Color.Orange;
            }
        }

        private void btnSubWhile_Click(object sender, EventArgs e)
        {
            CicloWhile1 cicloWhile1 = new CicloWhile1();
            cicloWhile1.Show();
            Hide();
        }

        private void btnSubFor_Click(object sender, EventArgs e)
        {
            CicloFor2 cicloFor2 = new CicloFor2();
            cicloFor2.Show();
            Hide();
        }

        private void btnjuego_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuEstructura menuEstructura = new MenuEstructura();
            menuEstructura.Show();
            Hide();
        }

        private void btnSubAnidados_Click(object sender, EventArgs e)
        {
            CicloAnidados4 cicloAnidados4 = new CicloAnidados4();
            cicloAnidados4.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void CicloDoWhile3_Load(object sender, EventArgs e)
        {

        }
    }
}
