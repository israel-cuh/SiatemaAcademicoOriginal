using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuTutorialOrdenar : Form
    {
        public MenuTutorialOrdenar()
        {
            InitializeComponent();
        }

        private void btnOrdenarCodigo_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuEstructura estructura = new MenuEstructura();
            estructura.Show(this);
            Hide();
        }
    }
}
