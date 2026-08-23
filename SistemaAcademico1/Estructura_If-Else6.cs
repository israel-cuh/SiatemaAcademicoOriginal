using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class Estructura_If_Else6 : Form
    {
        public Estructura_If_Else6()
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

        private void tbEdad_Scroll(object sender, EventArgs e)
        {
            int edadActual = tbEdad.Value;
            lblVariable.Text = $"int edad = {edadActual};";
            lblValorEdad.Text = $"Valor Actual: {edadActual}";

            // Restablecer el color oscuro de ambos paneles mientras el usuario mueve la barra
            pnlIf.BackColor = Color.FromArgb(30, 30, 45);
            pnlElse.BackColor = Color.FromArgb(30, 30, 45);
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            int edad = tbEdad.Value;
            rtbConsola.Clear();

            rtbConsola.AppendText($"> Evaluación de condición: {edad} >= 18\n");

            if (edad >= 18)
            {
                // Encender Bloque IF en verde y apagar Bloque ELSE
                pnlIf.BackColor = Color.FromArgb(0, 150, 60);
                pnlElse.BackColor = Color.FromArgb(30, 30, 45);

                rtbConsola.AppendText("> Resultado: VERDADERO\n");
                rtbConsola.AppendText("> Ejecutando Bloque IF...\n");
                rtbConsola.AppendText(">>> Salida: 'Acceso Permitido'\n");
            }
            else
            {
                // Encender Bloque ELSE en naranja y apagar Bloque IF
                pnlElse.BackColor = Color.FromArgb(200, 90, 0);
                pnlIf.BackColor = Color.FromArgb(30, 30, 45);

                rtbConsola.AppendText("> Resultado: FALSO\n");
                rtbConsola.AppendText("> Saltando Bloque IF...\n");
                rtbConsola.AppendText("> Ejecutando Bloque ELSE...\n");
                rtbConsola.AppendText(">>> Salida: 'Acceso Denegado'\n");
            }
        }

        private void Estructura_If_Else6_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Estructura_If5 estructura_If5 = new Estructura_If5();
            estructura_If5.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEstructura menuEstructura = new MenuEstructura();
            menuEstructura.Show();
            Hide();
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }
    }
}
