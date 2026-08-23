using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class Esructura_Swich7 : Form
    {
        public Esructura_Swich7()
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



        private void LimpiarBordes()
        {
            btnCase1.FlatAppearance.BorderColor = Color.FromArgb(140, 50, 200);
            btnCase2.FlatAppearance.BorderColor = Color.FromArgb(140, 50, 200);
            btnCase3.FlatAppearance.BorderColor = Color.FromArgb(140, 50, 200);
            btnCaseDefault.FlatAppearance.BorderColor = Color.FromArgb(140, 50, 200);
        }
        private void btnCase1_Click(object sender, EventArgs e)
        {
            LimpiarBordes();
            btnCase1.FlatAppearance.BorderColor = Color.Lime; // Ilumina el botón en verde
            rtbConsolaSwitch.Clear();

            rtbConsolaSwitch.AppendText("> Evaluando: switch (opcion = 1)\n");
            rtbConsolaSwitch.AppendText("> Opción seleccionada: 'Crear Perfil'\n");
            rtbConsolaSwitch.AppendText("> Mapeando a `case 1`:\n");
            rtbConsolaSwitch.AppendText(">>> Ejecutando código de creación de perfil...\n");
            rtbConsolaSwitch.AppendText("> break ejecutado. Fin del switch.\n");

            lblExplicacionSim.Text = "Opción: Crear Perfil (Valor = 1).\nEl programa ejecutó el 'case 1'\ny salió del switch usando 'break'.";
        }

        private void btnCase2_Click(object sender, EventArgs e)
        {
            LimpiarBordes();
            btnCase2.FlatAppearance.BorderColor = Color.Lime;
            rtbConsolaSwitch.Clear();

            rtbConsolaSwitch.AppendText("> Evaluando: switch (opcion = 2)\n");
            rtbConsolaSwitch.AppendText("> Opción seleccionada: 'Cargar Partida'\n");
            rtbConsolaSwitch.AppendText("> Mapeando a `case 2`:\n");
            rtbConsolaSwitch.AppendText(">>> Cargando datos del usuario desde la base de datos...\n");
            rtbConsolaSwitch.AppendText("> break ejecutado. Fin del switch.\n");

            lblExplicacionSim.Text = "Opción: Cargar Partida (Valor = 2).\nEl programa saltó directo al 'case 2',\nignorando los demás casos.";
        }

        private void btnCase3_Click(object sender, EventArgs e)
        {
            LimpiarBordes();
            btnCase3.FlatAppearance.BorderColor = Color.Lime;
            rtbConsolaSwitch.Clear();

            rtbConsolaSwitch.AppendText("> Evaluando: switch (opcion = 3)\n");
            rtbConsolaSwitch.AppendText("> Opción seleccionada: 'Ajustes'\n");
            rtbConsolaSwitch.AppendText("> Mapeando a `case 3`:\n");
            rtbConsolaSwitch.AppendText(">>> Abriendo el panel de configuración de opciones...\n");
            rtbConsolaSwitch.AppendText("> break ejecutado. Fin del switch.\n");

            lblExplicacionSim.Text = "Opción: Ajustes (Valor = 3).\nSe ejecutó el 'case 3'. El 'break' evita\nque se sigan evaluando más bloques.";
        }

        private void btnCaseDefault_Click(object sender, EventArgs e)
        {
            LimpiarBordes();
            btnCaseDefault.FlatAppearance.BorderColor = Color.OrangeRed; // Resalta en naranja/rojo
            rtbConsolaSwitch.Clear();

            rtbConsolaSwitch.AppendText("> Evaluando: switch (opcion = 4)\n");
            rtbConsolaSwitch.AppendText("> Opción seleccionada: 'Salir / Inválida'\n");
            rtbConsolaSwitch.AppendText("> Ningún case específico coincidió.\n");
            rtbConsolaSwitch.AppendText(">>> Ejecutando bloque `default`...\n");
            rtbConsolaSwitch.AppendText("> Fin del switch.\n");

            lblExplicacionSim.Text = "Opción no asignada a un caso.\nAl no coincidir con 1, 2 o 3, el programa\nejecuta el bloque 'default'.";
        }

        private void Esructura_Swich7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEstructura menuEstructura = new MenuEstructura();
            menuEstructura.ShowDialog();
            Hide();
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            CicloWhile1 cicloWhile1 = new CicloWhile1();
            cicloWhile1.Show(this);
            Hide();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            CicloFor2 cicloFor2 = new CicloFor2();
            cicloFor2.Show(this);
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
    }
}


