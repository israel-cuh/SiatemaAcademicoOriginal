namespace SistemaAcademico1
{
    partial class MenuEstructura
    {
        private System.ComponentModel.IContainer? components = null;
        private Panel panelTemas = null!;
        private Label lblFecha = null!;
        private Button btnCerrar = null!;
        private Button btnMinimizar = null!;
        private Button btnCerrarSesion = null!;
        private Button btnInicio = null!;
        private Button btnTemas = null!;
        private Button btnJuego = null!;
        private Button btnVariables = null!;
        private Button btnCiclos = null!;
        private Button btnAlgoritmos = null!;
        private Button btnCondicionales = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnCerrar = new Button();
            btnMinimizar = new Button();
            btnCerrarSesion = new Button();
            btnInicio = new Button();
            btnTemas = new Button();
            btnJuego = new Button();
            btnVariables = new Button();
            btnCiclos = new Button();
            btnAlgoritmos = new Button();
            btnCondicionales = new Button();
            lblFecha = new Label();
            panelTemas = new Panel();

            var barraSuperior = new Panel();
            var barraLateral = new Panel();
            var contenido = new Panel();
            var lblMarca = new Label();
            var lblLogo = new Label();
            var lblNombre = new Label();
            var lblSistema = new Label();
            var lblCurso = new Label();
            var tarjetaUsuario = new Panel();
            var lblAvatar = new Label();
            var lblUsuario = new Label();
            var lblRol = new Label();
            var lblBienvenida = new Label();
            var lblSubtitulo = new Label();
            var tarjetaFecha = new Panel();
            var lblCalendario = new Label();
            var estadisticas = new FlowLayoutPanel();
            var lblTemas = new Label();
            var accesos = new Panel();
            var lblAccesos = new Label();
            var btnAccesoJuego = new Button();
            var btnAccesoVariables = new Button();
            var btnAccesoCiclos = new Button();
            var lblPie = new Label();

            SuspendLayout();

            // Barra superior
            barraSuperior.BackColor = Color.FromArgb(4, 9, 28);
            barraSuperior.Dock = DockStyle.Top;
            barraSuperior.Height = 48;
            barraSuperior.Controls.Add(lblMarca);
            barraSuperior.Controls.Add(btnMinimizar);
            barraSuperior.Controls.Add(btnCerrar);

            lblMarca.Text = "</>  CodeNova";
            lblMarca.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(18, 10);
            lblMarca.Size = new Size(210, 30);

            ConfigurarBotonVentana(btnMinimizar, "—", new Point(1175, 4));
            ConfigurarBotonVentana(btnCerrar, "✕", new Point(1225, 4));
            btnMinimizar.Click += btnMinimizar_Click;
            btnCerrar.Click += btnCerrar_Click;

            // Barra lateral
            barraLateral.BackColor = Color.FromArgb(6, 16, 45);
            barraLateral.Dock = DockStyle.Left;
            barraLateral.Width = 270;
            barraLateral.Controls.Add(lblLogo);
            barraLateral.Controls.Add(lblNombre);
            barraLateral.Controls.Add(lblSistema);
            barraLateral.Controls.Add(lblCurso);
            barraLateral.Controls.Add(btnInicio);
            barraLateral.Controls.Add(btnTemas);
            barraLateral.Controls.Add(btnJuego);
            barraLateral.Controls.Add(btnCerrarSesion);
            barraLateral.Controls.Add(tarjetaUsuario);

            lblLogo.Text = "</>";
            lblLogo.Font = new Font("Consolas", 36F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(55, 116, 255);
            lblLogo.Location = new Point(60, 28);
            lblLogo.Size = new Size(150, 68);
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;

            lblNombre.Text = "CodeNova";
            lblNombre.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(30, 98);
            lblNombre.Size = new Size(215, 48);
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;

            lblSistema.Text = "Sistema Académico";
            lblSistema.Font = new Font("Segoe UI", 10F);
            lblSistema.ForeColor = Color.Gainsboro;
            lblSistema.Location = new Point(35, 150);
            lblSistema.Size = new Size(205, 25);
            lblSistema.TextAlign = ContentAlignment.MiddleCenter;

            lblCurso.Text = "PROGRAMACIÓN I";
            lblCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCurso.ForeColor = Color.FromArgb(86, 139, 255);
            lblCurso.Location = new Point(35, 176);
            lblCurso.Size = new Size(205, 25);
            lblCurso.TextAlign = ContentAlignment.MiddleCenter;

            ConfigurarBotonMenu(btnInicio, "⌂    Inicio", 225, Color.FromArgb(18, 38, 111));
            ConfigurarBotonMenu(btnTemas, "☷    Temas", 282, Color.Transparent);
            ConfigurarBotonMenu(btnJuego, "🎮   Juego interactivo", 339, Color.Transparent);
            ConfigurarBotonMenu(btnCerrarSesion, "↪    Cerrar sesión", 610, Color.Transparent);
            btnTemas.Click += btnTemas_Click;
            btnJuego.Click += btnJuego_Click;
            btnCerrarSesion.Click += btnCerrarSesion_Click;

            tarjetaUsuario.BackColor = Color.FromArgb(13, 29, 71);
            tarjetaUsuario.Location = new Point(20, 675);
            tarjetaUsuario.Size = new Size(230, 72);
            tarjetaUsuario.Controls.Add(lblAvatar);
            tarjetaUsuario.Controls.Add(lblUsuario);
            tarjetaUsuario.Controls.Add(lblRol);

            lblAvatar.Text = "👤";
            lblAvatar.Font = new Font("Segoe UI Emoji", 23F);
            lblAvatar.Location = new Point(12, 12);
            lblAvatar.Size = new Size(52, 50);

            lblUsuario.Text = "Docente";
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(70, 14);
            lblUsuario.Size = new Size(140, 25);

            lblRol.Text = "Profesor";
            lblRol.ForeColor = Color.Silver;
            lblRol.Location = new Point(70, 40);
            lblRol.Size = new Size(140, 22);

            // Contenido principal
            contenido.BackColor = Color.FromArgb(5, 16, 43);
            contenido.Dock = DockStyle.Fill;
            contenido.AutoScroll = true;
            contenido.Controls.Add(lblBienvenida);
            contenido.Controls.Add(lblSubtitulo);
            contenido.Controls.Add(tarjetaFecha);
            contenido.Controls.Add(estadisticas);
            contenido.Controls.Add(lblTemas);
            contenido.Controls.Add(panelTemas);
            contenido.Controls.Add(accesos);
            contenido.Controls.Add(lblPie);

            lblBienvenida.Text = "¡Bienvenido a CodeNova!";
            lblBienvenida.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(35, 25);
            lblBienvenida.Size = new Size(550, 50);

            lblSubtitulo.Text = "Sistema académico para Programación I";
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.Silver;
            lblSubtitulo.Location = new Point(38, 75);
            lblSubtitulo.Size = new Size(430, 30);

            tarjetaFecha.BackColor = Color.FromArgb(12, 28, 68);
            tarjetaFecha.Location = new Point(800, 25);
            tarjetaFecha.Size = new Size(190, 75);
            tarjetaFecha.Controls.Add(lblCalendario);
            tarjetaFecha.Controls.Add(lblFecha);

            lblCalendario.Text = "▣";
            lblCalendario.Font = new Font("Segoe UI", 20F);
            lblCalendario.ForeColor = Color.LightSteelBlue;
            lblCalendario.Location = new Point(15, 20);
            lblCalendario.Size = new Size(40, 40);

            lblFecha.Text = "Fecha y hora";
            lblFecha.Font = new Font("Segoe UI", 9.5F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(60, 14);
            lblFecha.Size = new Size(120, 52);

            estadisticas.Location = new Point(35, 125);
            estadisticas.Size = new Size(980, 105);
            estadisticas.BackColor = Color.Transparent;
            estadisticas.WrapContents = false;
            estadisticas.Controls.Add(CrearEstadistica("👥", "DOCENTES", "4", "Integrantes", Color.MediumPurple));
            estadisticas.Controls.Add(CrearEstadistica("🎓", "EQUIPO", "4", "Estudiantes", Color.MediumSeaGreen));
            estadisticas.Controls.Add(CrearEstadistica("▣", "MATERIAS", "1", "Programación I", Color.Goldenrod));
            estadisticas.Controls.Add(CrearEstadistica("☷", "TEMAS", "4", "Disponibles", Color.DodgerBlue));

            lblTemas.Text = "</>  Temas de Programación I";
            lblTemas.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTemas.ForeColor = Color.White;
            lblTemas.Location = new Point(35, 250);
            lblTemas.Size = new Size(430, 35);

            panelTemas.Location = new Point(35, 295);
            panelTemas.Size = new Size(990, 300);
            panelTemas.BackColor = Color.Transparent;
            panelTemas.Controls.Add(CrearTema(0, "1", "◇", "Algoritmos", "Diseño de pasos lógicos para resolver problemas.", Color.MediumPurple, btnAlgoritmos));
            panelTemas.Controls.Add(CrearTema(247, "2", "{ }", "Variables y tipos de datos", "Almacenamiento y manejo de datos en diferentes tipos.", Color.MediumSeaGreen, btnVariables));
            panelTemas.Controls.Add(CrearTema(494, "3", "if", "Condicionales", "Estructuras para tomar decisiones en el programa.", Color.Goldenrod, btnCondicionales));
            panelTemas.Controls.Add(CrearTema(741, "4", "↻", "Ciclos o bucles", "Estructuras para repetir instrucciones varias veces.", Color.DodgerBlue, btnCiclos));
            btnAlgoritmos.Click += btnAlgoritmos_Click;
            btnVariables.Click += btnVariables_Click;
            btnCondicionales.Click += btnCondicionales_Click;
            btnCiclos.Click += btnCiclos_Click;

            accesos.BackColor = Color.FromArgb(10, 27, 64);
            accesos.Location = new Point(35, 615);
            accesos.Size = new Size(990, 105);
            accesos.Controls.Add(lblAccesos);
            accesos.Controls.Add(btnAccesoJuego);
            accesos.Controls.Add(btnAccesoVariables);
            accesos.Controls.Add(btnAccesoCiclos);

            lblAccesos.Text = "⚡  Accesos rápidos";
            lblAccesos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccesos.ForeColor = Color.White;
            lblAccesos.Location = new Point(18, 12);
            lblAccesos.Size = new Size(240, 28);

            ConfigurarAcceso(btnAccesoJuego, "🎮  Jugar", new Point(20, 50), Color.FromArgb(121, 67, 225));
            ConfigurarAcceso(btnAccesoVariables, "{ }  Variables", new Point(225, 50), Color.FromArgb(30, 152, 79));
            ConfigurarAcceso(btnAccesoCiclos, "↻  Ciclos", new Point(430, 50), Color.FromArgb(43, 104, 224));
            btnAccesoJuego.Click += btnJuego_Click;
            btnAccesoVariables.Click += btnVariables_Click;
            btnAccesoCiclos.Click += btnCiclos_Click;

            lblPie.Text = "CodeNova  •  Aprende  •  Practica  •  Innova";
            lblPie.ForeColor = Color.FromArgb(110, 130, 190);
            lblPie.Location = new Point(320, 735);
            lblPie.Size = new Size(430, 25);
            lblPie.TextAlign = ContentAlignment.MiddleCenter;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 16, 43);
            ClientSize = new Size(1280, 800);
            Controls.Add(contenido);
            Controls.Add(barraLateral);
            Controls.Add(barraSuperior);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1180, 760);
            Name = "MenuEstructura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeNova - Menú principal";
            ResumeLayout(false);
        }

        private static Panel CrearEstadistica(string icono, string titulo, string valor, string detalle, Color acento)
        {
            var tarjeta = new Panel { BackColor = Color.FromArgb(12, 28, 68), Size = new Size(230, 95), Margin = new Padding(0, 0, 16, 0) };
            var a = new Label { Text = icono, Font = new Font("Segoe UI Emoji", 20F), ForeColor = acento, Location = new Point(14, 22), Size = new Size(52, 50) };
            var b = new Label { Text = titulo, ForeColor = Color.Silver, Location = new Point(72, 12), Size = new Size(135, 22) };
            var c = new Label { Text = valor, Font = new Font("Segoe UI", 19F, FontStyle.Bold), ForeColor = Color.White, Location = new Point(70, 31), Size = new Size(135, 38) };
            var d = new Label { Text = detalle, ForeColor = acento, Location = new Point(72, 68), Size = new Size(140, 20) };
            tarjeta.Controls.AddRange(new Control[] { a, b, c, d });
            return tarjeta;
        }

        private static Panel CrearTema(int x, string numero, string icono, string titulo, string descripcion, Color acento, Button boton)
        {
            var tarjeta = new Panel { BackColor = Color.FromArgb(11, 29, 68), Location = new Point(x, 0), Size = new Size(230, 285) };
            var a = new Label { Text = numero, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.White, BackColor = acento, Location = new Point(15, 15), Size = new Size(34, 34), TextAlign = ContentAlignment.MiddleCenter };
            var b = new Label { Text = icono, Font = new Font("Consolas", 30F, FontStyle.Bold), ForeColor = acento, Location = new Point(65, 55), Size = new Size(105, 70), TextAlign = ContentAlignment.MiddleCenter };
            var c = new Label { Text = titulo, Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = acento, Location = new Point(15, 135), Size = new Size(200, 52), TextAlign = ContentAlignment.MiddleCenter };
            var d = new Label { Text = descripcion, ForeColor = Color.Gainsboro, Location = new Point(18, 190), Size = new Size(195, 50), TextAlign = ContentAlignment.TopCenter };
            boton.Text = "Ver tema";
            boton.BackColor = Color.Transparent;
            boton.ForeColor = acento;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = acento;
            boton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            boton.Location = new Point(18, 245);
            boton.Size = new Size(194, 32);
            tarjeta.Controls.AddRange(new Control[] { a, b, c, d, boton });
            return tarjeta;
        }

        private static void ConfigurarBotonVentana(Button boton, string texto, Point ubicacion)
        {
            boton.Text = texto;
            boton.BackColor = Color.Transparent;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Location = ubicacion;
            boton.Size = new Size(45, 38);
        }

        private static void ConfigurarBotonMenu(Button boton, string texto, int y, Color fondo)
        {
            boton.Text = texto;
            boton.BackColor = fondo;
            boton.ForeColor = Color.Gainsboro;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font("Segoe UI", 11F);
            boton.TextAlign = ContentAlignment.MiddleLeft;
            boton.Padding = new Padding(20, 0, 0, 0);
            boton.Location = new Point(20, y);
            boton.Size = new Size(230, 48);
        }

        private static void ConfigurarAcceso(Button boton, string texto, Point ubicacion, Color fondo)
        {
            boton.Text = texto;
            boton.BackColor = fondo;
            boton.ForeColor = Color.White;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            boton.Location = ubicacion;
            boton.Size = new Size(185, 42);
        }
    }
}
