using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class CicloWhile1 : Form
    {
        public CicloWhile1()
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

        private void btnjuego_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            // Verificamos cuál RadioButton está seleccionado
            if (rbOpcionA.Checked)
            {
                // Supongamos que la opción 'a' es la correcta (ajusta según tu lógica)
                lblResultado.Text = "¡Respuesta correcta!";
                lblResultado.ForeColor = System.Drawing.Color.Green;
            }
            else if (rbOpcionB.Checked || rbOpcionC.Checked || rbOpcionD.Checked)
            {
                lblResultado.Text = "Respuesta incorrecta. Inténtalo de nuevo.";
                lblResultado.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                // Por si el usuario hace clic en comprobar sin seleccionar nada
                lblResultado.Text = "Por favor, selecciona una opción.";
                lblResultado.ForeColor = System.Drawing.Color.Yellow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEstructura menuEstructura = new MenuEstructura();
            menuEstructura.Show();
            Hide();

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            CicloFor2 cicloFor2 = new CicloFor2();
            cicloFor2.Show();
            Hide();
        }

        private void CicloWhile1_Load(object sender, EventArgs e)
        {

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
    }
}
