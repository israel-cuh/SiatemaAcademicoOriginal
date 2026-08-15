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
    public partial class MenuPrinciDiagram : Form
    {
        public MenuPrinciDiagram()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                MenuLateralHelper.AgregarMenu(this, "Algoritmo");
                ControlesVentanaHelper.Agregar(this, cerrarAplicacion: true);
            }
        }

        private void btnIngresarDocenteDiagram_Click(object sender, EventArgs e)
        {
            ProfesorDiagramFlujoForm2 formDocente = new ProfesorDiagramFlujoForm2();

            // Mostrar el formulario del docente
            formDocente.Show();
            this.Hide();
        }

        private void btnComenzarJuego_Click(object sender, EventArgs e)
        {
            MenuLevelFlujogramForm menuNiveles = new MenuLevelFlujogramForm();
            menuNiveles.Show();
            this.Hide();
        }

        private void btnIngresarEstudianteDiagram_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la pantalla del estudiante
            EstudianteDiagramaForm formularioEstudiante = new EstudianteDiagramaForm();

            // Mostrar la pantalla
            formularioEstudiante.Show();
            this.Hide();

        }
    }
}

