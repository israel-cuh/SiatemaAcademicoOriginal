using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuEstructura : Form
    {
        private readonly string rolUsuario;

        public MenuEstructura() : this("Docente")
        {
        }

        public MenuEstructura(string rol)
        {
            rolUsuario = string.IsNullOrWhiteSpace(rol) ? "Docente" : rol;
            InitializeComponent();
            ConfigurarPantallaPrincipal();
            ConfigurarEventosDelMenu();
        }

        private void ConfigurarPantallaPrincipal()
        {
            lblFecha.Text = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy\nhh:mm tt", new CultureInfo("es-ES"));

            if (rolUsuario.Equals("Estudiante", StringComparison.OrdinalIgnoreCase))
            {
                lblUsuario.Text = "Estudiante";
                lblRol.Text = "Alumno";
                lblBienvenida.Text = "¡Bienvenido estudiante!";
                lblSubtitulo.Text = "Aprende y practica Programación I";
                lblStatDocentes.Text = "👥   DOCENTES\n       1\n       Disponible";
                lblStatEquipo.Text = "🎓   ESTUDIANTE\n       1\n       Activo";
            }
            else
            {
                lblUsuario.Text = "Docente";
                lblRol.Text = "Profesor";
                lblBienvenida.Text = "¡Bienvenido docente!";
                lblSubtitulo.Text = "Sistema académico para Programación I";
                lblStatDocentes.Text = "👥   DOCENTES\n       1\n       Registrado";
                lblStatEquipo.Text = "🎓   EQUIPO\n       4\n       Estudiantes";
            }
        }

        private void ConfigurarEventosDelMenu()
        {
            btnMinimizar.Click += btnMinimizar_Click;
            btnTemas.Click += btnTemas_Click;
            btnJuego.Click += btnJuego_Click;
            btnCiclos.Click += btnCiclos_Click;
            btnAlgoritmos.Click += btnAlgoritmos_Click;
            btnCondicionales.Click += btnCondicionales_Click;
            btnAccesoJuego.Click += btnJuego_Click;
            btnAccesoVariables.Click += btnVariables_Click;
            btnAccesoCiclos.Click += btnCiclos_Click;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object? sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                Close();
            }
        }

        private void btnTemas_Click(object? sender, EventArgs e)
        {
            panelTemas.Focus();
            lblTituloTemas.ForeColor = Color.FromArgb(132, 78, 255);
        }

        private void btnJuego_Click(object? sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void btnCiclos_Click(object? sender, EventArgs e)
        {
            MenuTemaCiclo menutema = new MenuTemaCiclo();
            menutema.ShowDialog(this);
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            Menuvariables menuvariables = new Menuvariables();
            menuvariables.ShowDialog(this);
        }

        private void btnAlgoritmos_Click(object? sender, EventArgs e)
        {
            MostrarProximamente("Algoritmos");
        }

        private void btnCondicionales_Click(object? sender, EventArgs e)
        {
            MostrarProximamente("Condicionales");
        }

        private void MostrarProximamente(string tema)
        {
            MessageBox.Show(
                $"El tema {tema} todavía está en preparación.",
                "CodeNova",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnVariables_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnCerrarSesion_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnCiclos_Click(sender, e);
        }
    }
}
