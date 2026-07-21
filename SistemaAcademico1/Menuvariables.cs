using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class Menuvariables : Form
    {
        public Menuvariables()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Variables");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }

            btnTiposDatos.Click += btnTiposDatos_Click;
            btnOperadores.Click += btnOperadores_Click;
            btnCodiMemo.Click += btnCodiMemo_Click;
        }

        private void btnIrVariables_Click(object sender, EventArgs e)
        {
            FrmVariables frm = new FrmVariables();
            frm.Show();
            Hide();
        }

        private void btnTiposDatos_Click(object? sender, EventArgs e)
        {
            MostrarPendiente("Tipos de Datos");
        }

        private void btnOperadores_Click(object? sender, EventArgs e)
        {
            MostrarPendiente("Operadores");
        }

        private void btnCodiMemo_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "El juego CodiMemo todavía está pendiente de conectar.",
                "CodeNova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void MostrarPendiente(string tema)
        {
            MessageBox.Show(
                $"El tema {tema} todavía está pendiente de crear.",
                "CodeNova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnCodiMemo_Click_1(object sender, EventArgs e)
        {
            FrmCodiMemo juego = new FrmCodiMemo();
            juego.Show();
            this.Hide();
        }
    }
}
