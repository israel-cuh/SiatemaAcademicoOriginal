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
            AjustarTamanoComun();
            AjustarDashboardGrande();
            ConfigurarPantallaPrincipal();
            ConfigurarEventosDelMenu();
        }

        private void AjustarTamanoComun()
        {
            ClientSize = new Size(1560, 850);
            MinimumSize = new Size(1560, 850);
            btnMinimizar.Location = new Point(ClientSize.Width - 105, 4);
            btnCerrar.Location = new Point(ClientSize.Width - 55, 4);
        }

        private void AjustarDashboardGrande()
        {
            int anchoContenido = ClientSize.Width - panelLateral.Width;
            int margen = 45;
            int separacion = 24;
            int anchoDisponible = anchoContenido - (margen * 2);
            int anchoTarjeta = (anchoDisponible - (separacion * 3)) / 4;

            lblBienvenida.Location = new Point(margen, 28);
            lblBienvenida.Size = new Size(680, 50);
            lblSubtitulo.Location = new Point(margen + 3, 80);
            lblSubtitulo.Size = new Size(560, 30);
            tarjetaFecha.Location = new Point(anchoContenido - margen - tarjetaFecha.Width, 28);

            panelEstadisticas.Location = new Point(margen, 130);
            panelEstadisticas.Size = new Size(anchoDisponible, 105);
            tarjetaDocentes.Location = new Point(0, 0);
            tarjetaEquipo.Location = new Point(anchoTarjeta + separacion, 0);
            tarjetaMateria.Location = new Point((anchoTarjeta + separacion) * 2, 0);
            tarjetaCantidadTemas.Location = new Point((anchoTarjeta + separacion) * 3, 0);
            tarjetaDocentes.Size = new Size(anchoTarjeta, 95);
            tarjetaEquipo.Size = new Size(anchoTarjeta, 95);
            tarjetaMateria.Size = new Size(anchoTarjeta, 95);
            tarjetaCantidadTemas.Size = new Size(anchoTarjeta, 95);
            lblStatDocentes.Size = new Size(anchoTarjeta - 30, 75);
            lblStatEquipo.Size = new Size(anchoTarjeta - 30, 75);
            lblStatMateria.Size = new Size(anchoTarjeta - 30, 75);
            lblStatTemas.Size = new Size(anchoTarjeta - 30, 75);

            lblTituloTemas.Location = new Point(margen, 260);
            panelTemas.Location = new Point(margen, 305);
            panelTemas.Size = new Size(anchoDisponible, 305);

            tarjetaAlgoritmos.Location = new Point(0, 0);
            tarjetaVariables.Location = new Point(anchoTarjeta + separacion, 0);
            tarjetaCondicionales.Location = new Point((anchoTarjeta + separacion) * 2, 0);
            tarjetaCiclos.Location = new Point((anchoTarjeta + separacion) * 3, 0);
            tarjetaAlgoritmos.Size = new Size(anchoTarjeta, 285);
            tarjetaVariables.Size = new Size(anchoTarjeta, 285);
            tarjetaCondicionales.Size = new Size(anchoTarjeta, 285);
            tarjetaCiclos.Size = new Size(anchoTarjeta, 285);

            AjustarContenidoTarjetaTema(tarjetaAlgoritmos, lblIconoAlgoritmos, lblTituloAlgoritmos, lblDescripcionAlgoritmos, btnAlgoritmos, anchoTarjeta);
            AjustarContenidoTarjetaTema(tarjetaVariables, lblIconoVariables, lblTituloVariables, lblDescripcionVariables, btnVariables, anchoTarjeta);
            AjustarContenidoTarjetaTema(tarjetaCondicionales, lblIconoCondicionales, lblTituloCondicionales, lblDescripcionCondicionales, btnCondicionales, anchoTarjeta);
            AjustarContenidoTarjetaTema(tarjetaCiclos, lblIconoCiclos, lblTituloCiclos, lblDescripcionCiclos, btnCiclos, anchoTarjeta);

            panelAccesos.Location = new Point(margen, 635);
            panelAccesos.Size = new Size(anchoDisponible, 120);
            btnAccesoJuego.Location = new Point(25, 58);
            btnAccesoVariables.Location = new Point(240, 58);
            btnAccesoCiclos.Location = new Point(455, 58);
            btnAccesoJuego.Size = new Size(195, 45);
            btnAccesoVariables.Size = new Size(195, 45);
            btnAccesoCiclos.Size = new Size(195, 45);

            lblPie.Location = new Point((anchoContenido - lblPie.Width) / 2, 770);
        }

        private void AjustarContenidoTarjetaTema(Panel tarjeta, Label icono, Label titulo, Label descripcion, Button boton, int anchoTarjeta)
        {
            icono.Left = (anchoTarjeta - icono.Width) / 2;
            titulo.Location = new Point(15, titulo.Top);
            titulo.Size = new Size(anchoTarjeta - 30, titulo.Height);
            descripcion.Location = new Point(22, descripcion.Top);
            descripcion.Size = new Size(anchoTarjeta - 44, descripcion.Height + 8);
            boton.Location = new Point(22, boton.Top);
            boton.Size = new Size(anchoTarjeta - 44, boton.Height);
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
            MenuJuegos menuJuegos = new MenuJuegos();
            menuJuegos.Show();
            Hide();
        }

        private void btnCiclos_Click(object? sender, EventArgs e)
        {
            MenuTemaCiclo menutema = new MenuTemaCiclo();
            menutema.Show();
            Hide();
        }

        private void btnVariables_Click(object? sender, EventArgs e)
        {
            Menuvariables menutema = new Menuvariables();
            menutema.Show();
            Hide();
        }

        private void btnAlgoritmos_Click(object? sender, EventArgs e)
        {
            frmPrincipal ormaza = new frmPrincipal();
            ormaza.Show();
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

        private void contenido_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAlgoritmos_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
