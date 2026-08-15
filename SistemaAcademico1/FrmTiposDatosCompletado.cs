using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class FrmTiposDatosCompletado : Form
    {
        public FrmTiposDatosCompletado()
        {
            InitializeComponent();
            pnlRepasar.Cursor = Cursors.Hand;
            pnlSiguienteTema.Cursor = Cursors.Hand;
        }

        //private void pnlRepasar_Click(object sender, EventArgs e)
        //{
        //    FrmTiposDatos frm = new FrmTiposDatos();
        //    frm.Show();
        //    this.Close();
        //}

        private void pnlRepasar_Click_1(object sender, EventArgs e)
        {
            FrmTiposDatos frm = new FrmTiposDatos();
            frm.Show();
            this.Close();
        }

        private void pnlSiguienteTema_Click(object sender, EventArgs e)
        {
            FrmOperadores frm = new FrmOperadores();
            frm.Show();
            this.Close();
        }
    }
}
