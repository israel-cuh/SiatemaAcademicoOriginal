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
        }

        private void btnIrVariables_Click(object sender, EventArgs e)
        {
            FrmVariables frm = new FrmVariables();
            frm.Show();
            this.Hide();
        }
    }
}
