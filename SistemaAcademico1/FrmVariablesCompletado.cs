using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmVariablesCompletado : Form
    {
        public FrmVariablesCompletado()
        {
            InitializeComponent();
            pnlRepasar.Cursor = Cursors.Hand;
            pnlSiguienteTema.Cursor = Cursors.Hand;
            MenuLateralHelper.AgregarMenu(this, "Variables");
            ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
        }

        private void pnlRepasar_Click(object sender, EventArgs e)
        {
            FrmVariables frm = new FrmVariables();
            frm.Show();
            this.Close();
        }

        private void pnlSiguienteTema_Click(object sender, EventArgs e)
        {
            FrmTiposDatos frm = new FrmTiposDatos();
            frm.Show();
            this.Close();
        }
    }
}
