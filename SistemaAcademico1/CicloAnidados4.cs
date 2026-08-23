using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class CicloAnidados4 : Form
    {
        public CicloAnidados4()
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
            int totalEspacios = 2;

            // Validar el primer espacio (El incremento del ciclo externo 'i' debe ser "i++")
            if (cmbEspacio1.SelectedItem != null && cmbEspacio1.SelectedItem.ToString() == "i++")
            {
                aciertos++;
            }

            // Validar el segundo espacio (El incremento del ciclo interno 'j' debe ser "j++")
            if (cmbEspacio2.SelectedItem != null && cmbEspacio2.SelectedItem.ToString() == "j++")
            {
                aciertos++;
            }

            // Mostrar el resultado en el Label de resultados (Asegúrate de tener un lblResultado)
            lblResultado.Text = $"Completaste correctamente {aciertos} de {totalEspacios} espacios.";

            if (aciertos == totalEspacios)
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

        private void btnSubDoWhile_Click(object sender, EventArgs e)
        {
            CicloDoWhile3 cicloDoWhile3 = new CicloDoWhile3();
            cicloDoWhile3.Show();
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
    }
}
