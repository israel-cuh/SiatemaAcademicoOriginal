using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuLevelFlujogramForm : Form
    {
        public MenuLevelFlujogramForm()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Juego");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void MenuLevelFlujogramForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar23_Click(object sender, EventArgs e)
        {
            MenuPrinciDiagram menuPrincipal = new MenuPrinciDiagram();
            menuPrincipal.Show();
            this.Close();
        }

        private void btnLeverSig1_Click(object sender, EventArgs e)
        {

            LogiFlowLvl1 nivel1 = new LogiFlowLvl1();

            nivel1.Show();

            this.Hide();
        }

        private void btnLeverSig2_Click(object sender, EventArgs e)
        {
            LogiFlowLvl2 ventanaNivel2 = new LogiFlowLvl2();

            ventanaNivel2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogiFlowLvl3 ventanaNivel3 = new LogiFlowLvl3();

            ventanaNivel3.Show();
            this.Hide();
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }
    }
}

