using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    public partial class MenuEstructura : Form
    {
        private readonly string rolUsuario;
        private readonly List<Control> controlesInicio = new();
        private readonly Color colorFondo = Color.FromArgb(5, 16, 43);
        private readonly Color colorTarjeta = Color.FromArgb(12, 28, 68);
        private readonly Color colorMorado = Color.FromArgb(132, 78, 255);
        private readonly Color colorAzul = Color.FromArgb(55, 116, 255);

        public MenuEstructura() : this("Docente")
        {
        }

        public MenuEstructura(string rol)
        {
            rolUsuario = string.IsNullOrWhiteSpace(rol) ? "Docente" : rol;
            InitializeComponent();
            controlesInicio.AddRange(panelContenido.Controls.Cast<Control>());
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
            btnInicio.Click += btnInicio_Click;
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

        private void btnInicio_Click(object? sender, EventArgs e)
        {
            MostrarInicio();
        }

        private void btnTemas_Click(object? sender, EventArgs e)
        {
            MostrarInicio();
            panelTemas.Focus();
            lblTituloTemas.ForeColor = colorMorado;
        }

        private void btnJuego_Click(object? sender, EventArgs e)
        {
            using MinijuegoOrdenarCodigo juego = new MinijuegoOrdenarCodigo();
            juego.ShowDialog(this);
        }

        private void btnCiclos_Click(object? sender, EventArgs e)
        {
            MostrarVistaCiclos();
        }

        private void btnVariables_Click(object? sender, EventArgs e)
        {
            MostrarVistaVariables();
        }

        private void btnAlgoritmos_Click(object? sender, EventArgs e)
        {
            MostrarVistaProximamente("Algoritmos", "Diseño de pasos lógicos para resolver problemas.", Color.MediumPurple);
        }

        private void btnCondicionales_Click(object? sender, EventArgs e)
        {
            MostrarVistaProximamente("Condicionales", "Estructuras que permiten tomar decisiones en el programa.", Color.Goldenrod);
        }

        private void MostrarInicio()
        {
            panelContenido.Controls.Clear();

            foreach (Control control in controlesInicio)
                panelContenido.Controls.Add(control);

            ConfigurarPantallaPrincipal();
        }

        private void PrepararVistaInterna(string titulo, string subtitulo, Color colorTitulo)
        {
            panelContenido.Controls.Clear();
            panelContenido.BackColor = colorFondo;

            Label lblTituloVista = CrearLabel(titulo, 35, 25, 700, 48, new Font("Segoe UI", 24F, FontStyle.Bold), colorTitulo);
            Label lblSubtituloVista = CrearLabel(subtitulo, 38, 78, 850, 32, new Font("Segoe UI", 11F), Color.Gainsboro);

            panelContenido.Controls.Add(lblTituloVista);
            panelContenido.Controls.Add(lblSubtituloVista);
        }

        private void MostrarVistaVariables()
        {
            PrepararVistaInterna("Variables y tipos de datos", "Aprende cómo guardar información y utilizar diferentes tipos de datos.", Color.MediumSeaGreen);

            Panel tarjetaTexto = CrearTarjeta(35, 130, 930, 235);
            tarjetaTexto.Controls.Add(CrearLabel("¿Qué es una variable?", 25, 22, 500, 34, new Font("Segoe UI", 16F, FontStyle.Bold), Color.White));
            tarjetaTexto.Controls.Add(CrearLabel("Una variable es un espacio donde guardamos un dato para usarlo después en el programa.", 25, 68, 850, 32, new Font("Segoe UI", 11F), Color.Gainsboro));
            tarjetaTexto.Controls.Add(CrearLabel("Ejemplo:", 25, 112, 180, 30, new Font("Segoe UI", 12F, FontStyle.Bold), Color.MediumSeaGreen));

            RichTextBox codigo = CrearCajaCodigo(25, 148, 860, 62);
            codigo.Text = "int edad = 18;\nstring nombre = \"Ana\";";
            tarjetaTexto.Controls.Add(codigo);
            panelContenido.Controls.Add(tarjetaTexto);

            Panel tipos = CrearTarjeta(35, 395, 930, 190);
            tipos.Controls.Add(CrearLabel("Tipos comunes", 25, 20, 400, 32, new Font("Segoe UI", 16F, FontStyle.Bold), Color.White));
            tipos.Controls.Add(CrearLabel("int", 35, 72, 120, 30, new Font("Segoe UI", 12F, FontStyle.Bold), Color.MediumSeaGreen));
            tipos.Controls.Add(CrearLabel("Números enteros: 1, 20, 150", 130, 72, 360, 30, new Font("Segoe UI", 11F), Color.Gainsboro));
            tipos.Controls.Add(CrearLabel("double", 35, 108, 120, 30, new Font("Segoe UI", 12F, FontStyle.Bold), Color.MediumSeaGreen));
            tipos.Controls.Add(CrearLabel("Números decimales: 3.14, 9.5", 130, 108, 360, 30, new Font("Segoe UI", 11F), Color.Gainsboro));
            tipos.Controls.Add(CrearLabel("string", 500, 72, 120, 30, new Font("Segoe UI", 12F, FontStyle.Bold), Color.MediumSeaGreen));
            tipos.Controls.Add(CrearLabel("Texto: \"Hola\", \"CodeNova\"", 610, 72, 280, 30, new Font("Segoe UI", 11F), Color.Gainsboro));
            tipos.Controls.Add(CrearLabel("bool", 500, 108, 120, 30, new Font("Segoe UI", 12F, FontStyle.Bold), Color.MediumSeaGreen));
            tipos.Controls.Add(CrearLabel("Verdadero o falso: true / false", 610, 108, 280, 30, new Font("Segoe UI", 11F), Color.Gainsboro));
            panelContenido.Controls.Add(tipos);
        }

        private void MostrarVistaCiclos()
        {
            PrepararVistaInterna("Ciclos o bucles", "Elige un tipo de ciclo y mira su sintaxis, ejemplo y salida.", Color.DodgerBlue);

            Panel panelBotones = CrearTarjeta(35, 130, 220, 420);
            Panel panelDetalle = CrearTarjeta(280, 130, 685, 470);

            Label tituloTema = CrearLabel("Ciclo while", 25, 22, 520, 38, new Font("Segoe UI", 17F, FontStyle.Bold), Color.White);
            Label descripcionTema = CrearLabel("Repite instrucciones mientras una condición sea verdadera.", 25, 62, 620, 32, new Font("Segoe UI", 11F), Color.Gainsboro);
            RichTextBox sintaxis = CrearCajaCodigo(25, 112, 620, 92);
            RichTextBox ejemplo = CrearCajaCodigo(25, 245, 620, 135);
            Label salida = CrearLabel("Salida: 1  2  3  4  5", 25, 402, 620, 32, new Font("Segoe UI", 12F, FontStyle.Bold), Color.LightGreen);

            panelDetalle.Controls.Add(tituloTema);
            panelDetalle.Controls.Add(descripcionTema);
            panelDetalle.Controls.Add(CrearLabel("Sintaxis", 25, 88, 200, 24, new Font("Segoe UI", 10F, FontStyle.Bold), Color.DodgerBlue));
            panelDetalle.Controls.Add(sintaxis);
            panelDetalle.Controls.Add(CrearLabel("Ejemplo", 25, 220, 200, 24, new Font("Segoe UI", 10F, FontStyle.Bold), Color.DodgerBlue));
            panelDetalle.Controls.Add(ejemplo);
            panelDetalle.Controls.Add(salida);

            void CambiarTema(string titulo, string descripcion, string textoSintaxis, string textoEjemplo, string textoSalida)
            {
                tituloTema.Text = titulo;
                descripcionTema.Text = descripcion;
                sintaxis.Text = textoSintaxis;
                ejemplo.Text = textoEjemplo;
                salida.Text = textoSalida;
            }

            Button btnWhileVista = CrearBotonMenuInterno("While", 20, 35, Color.DodgerBlue);
            Button btnForVista = CrearBotonMenuInterno("For", 20, 100, Color.MediumPurple);
            Button btnDoWhileVista = CrearBotonMenuInterno("Do While", 20, 165, Color.MediumSeaGreen);
            Button btnAnidadosVista = CrearBotonMenuInterno("Anidados", 20, 230, Color.Goldenrod);
            Button btnPracticar = CrearBotonMenuInterno("Practicar", 20, 330, colorMorado);

            btnWhileVista.Click += (_, _) => CambiarTema("Ciclo while", "Repite instrucciones mientras una condición sea verdadera.", "while (condicion)\n{\n    instrucciones;\n}", "int i = 1;\nwhile (i <= 5)\n{\n    Console.WriteLine(i);\n    i++;\n}", "Salida: 1  2  3  4  5");
            btnForVista.Click += (_, _) => CambiarTema("Ciclo for", "Se usa cuando sabemos cuántas veces queremos repetir.", "for (inicio; condicion; incremento)\n{\n    instrucciones;\n}", "for (int i = 1; i <= 5; i++)\n{\n    Console.WriteLine(i);\n}", "Salida: 1  2  3  4  5");
            btnDoWhileVista.Click += (_, _) => CambiarTema("Ciclo do while", "Ejecuta primero y luego revisa la condición.", "do\n{\n    instrucciones;\n}\nwhile (condicion);", "int i = 1;\ndo\n{\n    Console.WriteLine(i);\n    i++;\n}\nwhile (i <= 5);", "Salida: 1  2  3  4  5");
            btnAnidadosVista.Click += (_, _) => CambiarTema("Ciclos anidados", "Un ciclo puede estar dentro de otro ciclo.", "for (...)\n{\n    for (...)\n    {\n        instrucciones;\n    }\n}", "for (int i = 1; i <= 2; i++)\n{\n    for (int j = 1; j <= 2; j++)\n    {\n        Console.WriteLine($\"i={i}, j={j}\");\n    }\n}", "Salida: i=1,j=1  i=1,j=2  i=2,j=1  i=2,j=2");
            btnPracticar.Click += btnJuego_Click;

            panelBotones.Controls.Add(btnWhileVista);
            panelBotones.Controls.Add(btnForVista);
            panelBotones.Controls.Add(btnDoWhileVista);
            panelBotones.Controls.Add(btnAnidadosVista);
            panelBotones.Controls.Add(btnPracticar);

            panelContenido.Controls.Add(panelBotones);
            panelContenido.Controls.Add(panelDetalle);

            btnWhileVista.PerformClick();
        }

        private void MostrarVistaProximamente(string titulo, string descripcion, Color color)
        {
            PrepararVistaInterna(titulo, descripcion, color);

            Panel tarjeta = CrearTarjeta(35, 145, 930, 220);
            tarjeta.Controls.Add(CrearLabel("Contenido en preparación", 25, 35, 600, 38, new Font("Segoe UI", 18F, FontStyle.Bold), Color.White));
            tarjeta.Controls.Add(CrearLabel("Esta sección puede ser desarrollada por otro integrante del equipo.", 25, 88, 820, 32, new Font("Segoe UI", 11F), Color.Gainsboro));
            tarjeta.Controls.Add(CrearLabel("Mientras tanto, el menú izquierdo se mantiene fijo y la información aparece aquí mismo.", 25, 125, 820, 32, new Font("Segoe UI", 11F), Color.LightSkyBlue));
            panelContenido.Controls.Add(tarjeta);
        }

        private Panel CrearTarjeta(int x, int y, int ancho, int alto)
        {
            return new Panel
            {
                BackColor = colorTarjeta,
                Location = new Point(x, y),
                Size = new Size(ancho, alto)
            };
        }

        private Label CrearLabel(string texto, int x, int y, int ancho, int alto, Font fuente, Color color)
        {
            return new Label
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                Font = fuente,
                ForeColor = color,
                BackColor = Color.Transparent
            };
        }

        private RichTextBox CrearCajaCodigo(int x, int y, int ancho, int alto)
        {
            return new RichTextBox
            {
                Location = new Point(x, y),
                Size = new Size(ancho, alto),
                BackColor = Color.FromArgb(6, 16, 41),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None,
                Font = new Font("Consolas", 11F, FontStyle.Bold),
                ReadOnly = true
            };
        }

        private Button CrearBotonMenuInterno(string texto, int x, int y, Color color)
        {
            return new Button
            {
                Text = texto,
                Location = new Point(x, y),
                Size = new Size(175, 46),
                BackColor = color,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                UseVisualStyleBackColor = false
            };
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
    }
}
