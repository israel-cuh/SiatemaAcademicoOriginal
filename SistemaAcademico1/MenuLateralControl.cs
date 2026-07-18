using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuLateralControl : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Form? FormularioActual { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OpcionActiva { get; set; } = "Inicio";

        public MenuLateralControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MarcarOpcionActiva();
        }

        private void MarcarOpcionActiva()
        {
            Color activo = Color.FromArgb(18, 38, 111);
            Color normal = Color.Transparent;

            btnInicio.BackColor = OpcionActiva == "Inicio" ? activo : normal;
            button1.BackColor = OpcionActiva == "Algoritmo" ? activo : normal;
            btnVariables.BackColor = OpcionActiva == "Variables" ? activo : normal;
            button2.BackColor = OpcionActiva == "Condicionales" ? activo : normal;
            btnCiclos.BackColor = OpcionActiva == "Ciclos" ? activo : normal;
            btnJuego.BackColor = OpcionActiva == "Juego" ? activo : normal;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuEstructura(), OpcionActiva == "Inicio");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarEnPreparacion("Algoritmo");
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Menuvariables(), OpcionActiva == "Variables");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarEnPreparacion("Condicionales");
        }

        private void btnCiclos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new MenuTemaCiclo(), OpcionActiva == "Ciclos");
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(FormularioActual ?? FindForm());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                (FormularioActual ?? FindForm())?.Close();
            }
        }

        private void MostrarEnPreparacion(string tema)
        {
            MessageBox.Show(
                $"La sección de {tema} todavía está en preparación.",
                "CodeNova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void AbrirFormulario(Form siguiente, bool yaEstoyAqui)
        {
            if (yaEstoyAqui)
            {
                siguiente.Dispose();
                return;
            }

            siguiente.StartPosition = FormStartPosition.CenterScreen;
            siguiente.Show();
            (FormularioActual ?? FindForm())?.Close();
        }
    }
}
