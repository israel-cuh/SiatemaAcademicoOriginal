using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class Estructura_If5 : Form
    {
        public Estructura_If5()
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
            int totalPreguntas = 4;

            // 1. Validar if (temperatura < 0) -> Respuesta B
            if (cmbOpcion1.SelectedItem != null && cmbOpcion1.SelectedItem.ToString().StartsWith("B"))
            {
                aciertos++;
            }

            // 2. Validar if (edad >= 18) -> Respuesta C
            if (cmbOpcion2.SelectedItem != null && cmbOpcion2.SelectedItem.ToString().StartsWith("C"))
            {
                aciertos++;
            }

            // 3. Validar if (!seHaPagado) -> Respuesta A
            if (cmbOpcion3.SelectedItem != null && cmbOpcion3.SelectedItem.ToString().StartsWith("A"))
            {
                aciertos++;
            }

            // 4. Validar if (esEstudiante && tieneBeca) -> Respuesta D
            if (cmbOpcion4.SelectedItem != null && cmbOpcion4.SelectedItem.ToString().StartsWith("D"))
            {
                aciertos++;
            }

            // Evaluacion final
            if (aciertos == totalPreguntas)
            {
                lblResultado.Text = "RESULTADO: ¡Bien Hecho! Respuestas correctas: 4/4";
                lblResultado.ForeColor = System.Drawing.Color.LimeGreen;
            }
            else
            {
                lblResultado.Text = $"Completaste correctamente {aciertos} de {totalPreguntas}. ¡Inténtalo de nuevo!";
                lblResultado.ForeColor = System.Drawing.Color.Orange;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Restablecer los ComboBox
            cmbOpcion1.SelectedIndex = 0;
            cmbOpcion2.SelectedIndex = 0;
            cmbOpcion3.SelectedIndex = 0;
            cmbOpcion4.SelectedIndex = 0;

            // Limpiar mensaje de resultado
            lblResultado.Text = "";
        }

        private void Estructura_If5_Load(object sender, EventArgs e)
        {

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            CicloWhile1 cicloWhile1 = new CicloWhile1();
            cicloWhile1.Show();
            Hide();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            CicloFor2 cicloFor2 = new CicloFor2();
            cicloFor2.Show();
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

        private void btnPracticar_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Estructura_If_Else6 estructura_If_Else6 = new Estructura_If_Else6();
            estructura_If_Else6.Show();
            Hide();
        }
    }
}
