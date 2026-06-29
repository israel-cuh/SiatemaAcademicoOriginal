namespace SistemaAcademico1
{
    partial class MenuEstructura
    {
        private System.ComponentModel.IContainer? components = null;

        private Panel panelSuperior = null!;
        private Panel panelLateral = null!;
        private Panel panelContenido = null!;
        private Panel panelEstadisticas = null!;
        private Panel panelTemas = null!;
        private Panel panelAccesos = null!;
        private Panel tarjetaFecha = null!;
        private Panel tarjetaUsuario = null!;
        private Panel tarjetaDocentes = null!;
        private Panel tarjetaEquipo = null!;
        private Panel tarjetaMateria = null!;
        private Panel tarjetaCantidadTemas = null!;
        private Panel tarjetaAlgoritmos = null!;
        private Panel tarjetaVariables = null!;
        private Panel tarjetaCondicionales = null!;
        private Panel tarjetaCiclos = null!;

        private Label lblMarca = null!;
        private Label lblLogo = null!;
        private Label lblNombre = null!;
        private Label lblSistema = null!;
        private Label lblCurso = null!;
        private Label lblAvatar = null!;
        private Label lblUsuario = null!;
        private Label lblRol = null!;
        private Label lblBienvenida = null!;
        private Label lblSubtitulo = null!;
        private Label lblFecha = null!;
        private Label lblCalendario = null!;
        private Label lblTituloTemas = null!;
        private Label lblAccesos = null!;
        private Label lblPie = null!;
        private Label lblStatDocentes = null!;
        private Label lblStatEquipo = null!;
        private Label lblStatMateria = null!;
        private Label lblStatTemas = null!;
        private Label lblNumeroAlgoritmos = null!;
        private Label lblIconoAlgoritmos = null!;
        private Label lblTituloAlgoritmos = null!;
        private Label lblDescripcionAlgoritmos = null!;
        private Label lblNumeroVariables = null!;
        private Label lblIconoVariables = null!;
        private Label lblTituloVariables = null!;
        private Label lblDescripcionVariables = null!;
        private Label lblNumeroCondicionales = null!;
        private Label lblIconoCondicionales = null!;
        private Label lblTituloCondicionales = null!;
        private Label lblDescripcionCondicionales = null!;
        private Label lblNumeroCiclos = null!;
        private Label lblIconoCiclos = null!;
        private Label lblTituloCiclos = null!;
        private Label lblDescripcionCiclos = null!;

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
        private Button btnAccesoJuego = null!;
        private Button btnAccesoVariables = null!;
        private Button btnAccesoCiclos = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            panelSuperior = new Panel();
            panelLateral = new Panel();
            panelContenido = new Panel();
            panelEstadisticas = new Panel();
            panelTemas = new Panel();
            panelAccesos = new Panel();
            tarjetaFecha = new Panel();
            tarjetaUsuario = new Panel();
            tarjetaDocentes = new Panel();
            tarjetaEquipo = new Panel();
            tarjetaMateria = new Panel();
            tarjetaCantidadTemas = new Panel();
            tarjetaAlgoritmos = new Panel();
            tarjetaVariables = new Panel();
            tarjetaCondicionales = new Panel();
            tarjetaCiclos = new Panel();

            lblMarca = new Label();
            lblLogo = new Label();
            lblNombre = new Label();
            lblSistema = new Label();
            lblCurso = new Label();
            lblAvatar = new Label();
            lblUsuario = new Label();
            lblRol = new Label();
            lblBienvenida = new Label();
            lblSubtitulo = new Label();
            lblFecha = new Label();
            lblCalendario = new Label();
            lblTituloTemas = new Label();
            lblAccesos = new Label();
            lblPie = new Label();
            lblStatDocentes = new Label();
            lblStatEquipo = new Label();
            lblStatMateria = new Label();
            lblStatTemas = new Label();
            lblNumeroAlgoritmos = new Label();
            lblIconoAlgoritmos = new Label();
            lblTituloAlgoritmos = new Label();
            lblDescripcionAlgoritmos = new Label();
            lblNumeroVariables = new Label();
            lblIconoVariables = new Label();
            lblTituloVariables = new Label();
            lblDescripcionVariables = new Label();
            lblNumeroCondicionales = new Label();
            lblIconoCondicionales = new Label();
            lblTituloCondicionales = new Label();
            lblDescripcionCondicionales = new Label();
            lblNumeroCiclos = new Label();
            lblIconoCiclos = new Label();
            lblTituloCiclos = new Label();
            lblDescripcionCiclos = new Label();

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
            btnAccesoJuego = new Button();
            btnAccesoVariables = new Button();
            btnAccesoCiclos = new Button();

            SuspendLayout();

            // Barra superior
            panelSuperior.BackColor = Color.FromArgb(4, 9, 28);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Height = 48;
            panelSuperior.Controls.Add(lblMarca);
            panelSuperior.Controls.Add(btnMinimizar);
            panelSuperior.Controls.Add(btnCerrar);

            lblMarca.Text = "</>  CodeNova";
            lblMarca.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(18, 10);
            lblMarca.Size = new Size(210, 30);

            btnMinimizar.Text = "—";
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.Location = new Point(1175, 4);
            btnMinimizar.Size = new Size(45, 38);
            btnMinimizar.Click += btnMinimizar_Click;

            btnCerrar.Text = "✕";
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Location = new Point(1225, 4);
            btnCerrar.Size = new Size(45, 38);
            btnCerrar.Click += btnCerrar_Click;

            // Barra lateral
            panelLateral.BackColor = Color.FromArgb(6, 16, 45);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Width = 270;
            panelLateral.Controls.Add(lblLogo);
            panelLateral.Controls.Add(lblNombre);
            panelLateral.Controls.Add(lblSistema);
            panelLateral.Controls.Add(lblCurso);
            panelLateral.Controls.Add(btnInicio);
            panelLateral.Controls.Add(btnTemas);
            panelLateral.Controls.Add(btnJuego);
            panelLateral.Controls.Add(btnCerrarSesion);
            panelLateral.Controls.Add(tarjetaUsuario);

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

            btnInicio.Text = "⌂    Inicio";
            btnInicio.BackColor = Color.FromArgb(18, 38, 111);
            btnInicio.ForeColor = Color.Gainsboro;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.Font = new Font("Segoe UI", 11F);
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.Padding = new Padding(20, 0, 0, 0);
            btnInicio.Location = new Point(20, 225);
            btnInicio.Size = new Size(230, 48);

            btnTemas.Text = "☷    Temas";
            btnTemas.BackColor = Color.Transparent;
            btnTemas.ForeColor = Color.Gainsboro;
            btnTemas.FlatStyle = FlatStyle.Flat;
            btnTemas.FlatAppearance.BorderSize = 0;
            btnTemas.Font = new Font("Segoe UI", 11F);
            btnTemas.TextAlign = ContentAlignment.MiddleLeft;
            btnTemas.Padding = new Padding(20, 0, 0, 0);
            btnTemas.Location = new Point(20, 282);
            btnTemas.Size = new Size(230, 48);
            btnTemas.Click += btnTemas_Click;

            btnJuego.Text = "🎮   Juego interactivo";
            btnJuego.BackColor = Color.Transparent;
            btnJuego.ForeColor = Color.Gainsboro;
            btnJuego.FlatStyle = FlatStyle.Flat;
            btnJuego.FlatAppearance.BorderSize = 0;
            btnJuego.Font = new Font("Segoe UI", 11F);
            btnJuego.TextAlign = ContentAlignment.MiddleLeft;
            btnJuego.Padding = new Padding(20, 0, 0, 0);
            btnJuego.Location = new Point(20, 339);
            btnJuego.Size = new Size(230, 48);
            btnJuego.Click += btnJuego_Click;

            btnCerrarSesion.Text = "↪    Cerrar sesión";
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.Font = new Font("Segoe UI", 11F);
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Padding = new Padding(20, 0, 0, 0);
            btnCerrarSesion.Location = new Point(20, 610);
            btnCerrarSesion.Size = new Size(230, 48);
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
            panelContenido.BackColor = Color.FromArgb(5, 16, 43);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.AutoScroll = false;
            panelContenido.Controls.Add(lblBienvenida);
            panelContenido.Controls.Add(lblSubtitulo);
            panelContenido.Controls.Add(tarjetaFecha);
            panelContenido.Controls.Add(panelEstadisticas);
            panelContenido.Controls.Add(lblTituloTemas);
            panelContenido.Controls.Add(panelTemas);
            panelContenido.Controls.Add(panelAccesos);
            panelContenido.Controls.Add(lblPie);

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

            // Estadísticas
            panelEstadisticas.BackColor = Color.Transparent;
            panelEstadisticas.Location = new Point(35, 125);
            panelEstadisticas.Size = new Size(990, 105);
            panelEstadisticas.Controls.Add(tarjetaDocentes);
            panelEstadisticas.Controls.Add(tarjetaEquipo);
            panelEstadisticas.Controls.Add(tarjetaMateria);
            panelEstadisticas.Controls.Add(tarjetaCantidadTemas);

            tarjetaDocentes.BackColor = Color.FromArgb(12, 28, 68);
            tarjetaDocentes.Location = new Point(0, 0);
            tarjetaDocentes.Size = new Size(230, 95);
            tarjetaDocentes.Controls.Add(lblStatDocentes);
            lblStatDocentes.Text = "👥   DOCENTES\n       4\n       Integrantes";
            lblStatDocentes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatDocentes.ForeColor = Color.MediumPurple;
            lblStatDocentes.Location = new Point(15, 12);
            lblStatDocentes.Size = new Size(200, 75);

            tarjetaEquipo.BackColor = Color.FromArgb(12, 28, 68);
            tarjetaEquipo.Location = new Point(246, 0);
            tarjetaEquipo.Size = new Size(230, 95);
            tarjetaEquipo.Controls.Add(lblStatEquipo);
            lblStatEquipo.Text = "🎓   EQUIPO\n       4\n       Estudiantes";
            lblStatEquipo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatEquipo.ForeColor = Color.MediumSeaGreen;
            lblStatEquipo.Location = new Point(15, 12);
            lblStatEquipo.Size = new Size(200, 75);

            tarjetaMateria.BackColor = Color.FromArgb(12, 28, 68);
            tarjetaMateria.Location = new Point(492, 0);
            tarjetaMateria.Size = new Size(230, 95);
            tarjetaMateria.Controls.Add(lblStatMateria);
            lblStatMateria.Text = "▣   MATERIAS\n      1\n      Programación I";
            lblStatMateria.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatMateria.ForeColor = Color.Goldenrod;
            lblStatMateria.Location = new Point(15, 12);
            lblStatMateria.Size = new Size(200, 75);

            tarjetaCantidadTemas.BackColor = Color.FromArgb(12, 28, 68);
            tarjetaCantidadTemas.Location = new Point(738, 0);
            tarjetaCantidadTemas.Size = new Size(230, 95);
            tarjetaCantidadTemas.Controls.Add(lblStatTemas);
            lblStatTemas.Text = "☷   TEMAS\n      4\n      Disponibles";
            lblStatTemas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatTemas.ForeColor = Color.DodgerBlue;
            lblStatTemas.Location = new Point(15, 12);
            lblStatTemas.Size = new Size(200, 75);

            lblTituloTemas.Text = "</>  Temas de Programación I";
            lblTituloTemas.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTituloTemas.ForeColor = Color.White;
            lblTituloTemas.Location = new Point(35, 250);
            lblTituloTemas.Size = new Size(430, 35);

            // Tarjetas de temas
            panelTemas.BackColor = Color.Transparent;
            panelTemas.Location = new Point(35, 295);
            panelTemas.Size = new Size(990, 300);
            panelTemas.Controls.Add(tarjetaAlgoritmos);
            panelTemas.Controls.Add(tarjetaVariables);
            panelTemas.Controls.Add(tarjetaCondicionales);
            panelTemas.Controls.Add(tarjetaCiclos);

            tarjetaAlgoritmos.BackColor = Color.FromArgb(11, 29, 68);
            tarjetaAlgoritmos.Location = new Point(0, 0);
            tarjetaAlgoritmos.Size = new Size(230, 285);
            tarjetaAlgoritmos.Controls.Add(lblNumeroAlgoritmos);
            tarjetaAlgoritmos.Controls.Add(lblIconoAlgoritmos);
            tarjetaAlgoritmos.Controls.Add(lblTituloAlgoritmos);
            tarjetaAlgoritmos.Controls.Add(lblDescripcionAlgoritmos);
            tarjetaAlgoritmos.Controls.Add(btnAlgoritmos);
            lblNumeroAlgoritmos.Text = "1";
            lblNumeroAlgoritmos.BackColor = Color.MediumPurple;
            lblNumeroAlgoritmos.ForeColor = Color.White;
            lblNumeroAlgoritmos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroAlgoritmos.Location = new Point(15, 15);
            lblNumeroAlgoritmos.Size = new Size(34, 34);
            lblNumeroAlgoritmos.TextAlign = ContentAlignment.MiddleCenter;
            lblIconoAlgoritmos.Text = "◇";
            lblIconoAlgoritmos.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblIconoAlgoritmos.ForeColor = Color.MediumPurple;
            lblIconoAlgoritmos.Location = new Point(65, 55);
            lblIconoAlgoritmos.Size = new Size(105, 70);
            lblIconoAlgoritmos.TextAlign = ContentAlignment.MiddleCenter;
            lblTituloAlgoritmos.Text = "Algoritmos";
            lblTituloAlgoritmos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloAlgoritmos.ForeColor = Color.MediumPurple;
            lblTituloAlgoritmos.Location = new Point(15, 135);
            lblTituloAlgoritmos.Size = new Size(200, 35);
            lblTituloAlgoritmos.TextAlign = ContentAlignment.MiddleCenter;
            lblDescripcionAlgoritmos.Text = "Diseño de pasos lógicos para resolver problemas.";
            lblDescripcionAlgoritmos.ForeColor = Color.Gainsboro;
            lblDescripcionAlgoritmos.Location = new Point(18, 178);
            lblDescripcionAlgoritmos.Size = new Size(195, 55);
            lblDescripcionAlgoritmos.TextAlign = ContentAlignment.TopCenter;
            btnAlgoritmos.Text = "Ver tema";
            btnAlgoritmos.BackColor = Color.Transparent;
            btnAlgoritmos.ForeColor = Color.MediumPurple;
            btnAlgoritmos.FlatStyle = FlatStyle.Flat;
            btnAlgoritmos.Location = new Point(18, 245);
            btnAlgoritmos.Size = new Size(194, 32);
            btnAlgoritmos.Click += btnAlgoritmos_Click;

            tarjetaVariables.BackColor = Color.FromArgb(11, 29, 68);
            tarjetaVariables.Location = new Point(247, 0);
            tarjetaVariables.Size = new Size(230, 285);
            tarjetaVariables.Controls.Add(lblNumeroVariables);
            tarjetaVariables.Controls.Add(lblIconoVariables);
            tarjetaVariables.Controls.Add(lblTituloVariables);
            tarjetaVariables.Controls.Add(lblDescripcionVariables);
            tarjetaVariables.Controls.Add(btnVariables);
            lblNumeroVariables.Text = "2";
            lblNumeroVariables.BackColor = Color.MediumSeaGreen;
            lblNumeroVariables.ForeColor = Color.White;
            lblNumeroVariables.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroVariables.Location = new Point(15, 15);
            lblNumeroVariables.Size = new Size(34, 34);
            lblNumeroVariables.TextAlign = ContentAlignment.MiddleCenter;
            lblIconoVariables.Text = "{ }";
            lblIconoVariables.Font = new Font("Consolas", 28F, FontStyle.Bold);
            lblIconoVariables.ForeColor = Color.MediumSeaGreen;
            lblIconoVariables.Location = new Point(55, 55);
            lblIconoVariables.Size = new Size(125, 70);
            lblIconoVariables.TextAlign = ContentAlignment.MiddleCenter;
            lblTituloVariables.Text = "Variables y tipos de datos";
            lblTituloVariables.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloVariables.ForeColor = Color.MediumSeaGreen;
            lblTituloVariables.Location = new Point(15, 130);
            lblTituloVariables.Size = new Size(200, 52);
            lblTituloVariables.TextAlign = ContentAlignment.MiddleCenter;
            lblDescripcionVariables.Text = "Almacenamiento y manejo de datos en diferentes tipos.";
            lblDescripcionVariables.ForeColor = Color.Gainsboro;
            lblDescripcionVariables.Location = new Point(18, 187);
            lblDescripcionVariables.Size = new Size(195, 48);
            lblDescripcionVariables.TextAlign = ContentAlignment.TopCenter;
            btnVariables.Text = "Ver tema";
            btnVariables.BackColor = Color.Transparent;
            btnVariables.ForeColor = Color.MediumSeaGreen;
            btnVariables.FlatStyle = FlatStyle.Flat;
            btnVariables.Location = new Point(18, 245);
            btnVariables.Size = new Size(194, 32);
            btnVariables.Click += btnVariables_Click;

            tarjetaCondicionales.BackColor = Color.FromArgb(11, 29, 68);
            tarjetaCondicionales.Location = new Point(494, 0);
            tarjetaCondicionales.Size = new Size(230, 285);
            tarjetaCondicionales.Controls.Add(lblNumeroCondicionales);
            tarjetaCondicionales.Controls.Add(lblIconoCondicionales);
            tarjetaCondicionales.Controls.Add(lblTituloCondicionales);
            tarjetaCondicionales.Controls.Add(lblDescripcionCondicionales);
            tarjetaCondicionales.Controls.Add(btnCondicionales);
            lblNumeroCondicionales.Text = "3";
            lblNumeroCondicionales.BackColor = Color.Goldenrod;
            lblNumeroCondicionales.ForeColor = Color.White;
            lblNumeroCondicionales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroCondicionales.Location = new Point(15, 15);
            lblNumeroCondicionales.Size = new Size(34, 34);
            lblNumeroCondicionales.TextAlign = ContentAlignment.MiddleCenter;
            lblIconoCondicionales.Text = "if";
            lblIconoCondicionales.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblIconoCondicionales.ForeColor = Color.Goldenrod;
            lblIconoCondicionales.Location = new Point(65, 55);
            lblIconoCondicionales.Size = new Size(105, 70);
            lblIconoCondicionales.TextAlign = ContentAlignment.MiddleCenter;
            lblTituloCondicionales.Text = "Condicionales";
            lblTituloCondicionales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloCondicionales.ForeColor = Color.Goldenrod;
            lblTituloCondicionales.Location = new Point(15, 135);
            lblTituloCondicionales.Size = new Size(200, 35);
            lblTituloCondicionales.TextAlign = ContentAlignment.MiddleCenter;
            lblDescripcionCondicionales.Text = "Estructuras para tomar decisiones en el programa.";
            lblDescripcionCondicionales.ForeColor = Color.Gainsboro;
            lblDescripcionCondicionales.Location = new Point(18, 178);
            lblDescripcionCondicionales.Size = new Size(195, 55);
            lblDescripcionCondicionales.TextAlign = ContentAlignment.TopCenter;
            btnCondicionales.Text = "Ver tema";
            btnCondicionales.BackColor = Color.Transparent;
            btnCondicionales.ForeColor = Color.Goldenrod;
            btnCondicionales.FlatStyle = FlatStyle.Flat;
            btnCondicionales.Location = new Point(18, 245);
            btnCondicionales.Size = new Size(194, 32);
            btnCondicionales.Click += btnCondicionales_Click;

            tarjetaCiclos.BackColor = Color.FromArgb(11, 29, 68);
            tarjetaCiclos.Location = new Point(741, 0);
            tarjetaCiclos.Size = new Size(230, 285);
            tarjetaCiclos.Controls.Add(lblNumeroCiclos);
            tarjetaCiclos.Controls.Add(lblIconoCiclos);
            tarjetaCiclos.Controls.Add(lblTituloCiclos);
            tarjetaCiclos.Controls.Add(lblDescripcionCiclos);
            tarjetaCiclos.Controls.Add(btnCiclos);
            lblNumeroCiclos.Text = "4";
            lblNumeroCiclos.BackColor = Color.DodgerBlue;
            lblNumeroCiclos.ForeColor = Color.White;
            lblNumeroCiclos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroCiclos.Location = new Point(15, 15);
            lblNumeroCiclos.Size = new Size(34, 34);
            lblNumeroCiclos.TextAlign = ContentAlignment.MiddleCenter;
            lblIconoCiclos.Text = "↻";
            lblIconoCiclos.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
            lblIconoCiclos.ForeColor = Color.DodgerBlue;
            lblIconoCiclos.Location = new Point(65, 48);
            lblIconoCiclos.Size = new Size(105, 78);
            lblIconoCiclos.TextAlign = ContentAlignment.MiddleCenter;
            lblTituloCiclos.Text = "Ciclos o bucles";
            lblTituloCiclos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloCiclos.ForeColor = Color.DodgerBlue;
            lblTituloCiclos.Location = new Point(15, 135);
            lblTituloCiclos.Size = new Size(200, 35);
            lblTituloCiclos.TextAlign = ContentAlignment.MiddleCenter;
            lblDescripcionCiclos.Text = "Estructuras para repetir instrucciones varias veces.";
            lblDescripcionCiclos.ForeColor = Color.Gainsboro;
            lblDescripcionCiclos.Location = new Point(18, 178);
            lblDescripcionCiclos.Size = new Size(195, 55);
            lblDescripcionCiclos.TextAlign = ContentAlignment.TopCenter;
            btnCiclos.Text = "Ver tema";
            btnCiclos.BackColor = Color.Transparent;
            btnCiclos.ForeColor = Color.DodgerBlue;
            btnCiclos.FlatStyle = FlatStyle.Flat;
            btnCiclos.Location = new Point(18, 245);
            btnCiclos.Size = new Size(194, 32);
            btnCiclos.Click += btnCiclos_Click;

            // Accesos rápidos
            panelAccesos.BackColor = Color.FromArgb(10, 27, 64);
            panelAccesos.Location = new Point(35, 615);
            panelAccesos.Size = new Size(990, 105);
            panelAccesos.Controls.Add(lblAccesos);
            panelAccesos.Controls.Add(btnAccesoJuego);
            panelAccesos.Controls.Add(btnAccesoVariables);
            panelAccesos.Controls.Add(btnAccesoCiclos);
            lblAccesos.Text = "⚡  Accesos rápidos";
            lblAccesos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccesos.ForeColor = Color.White;
            lblAccesos.Location = new Point(18, 12);
            lblAccesos.Size = new Size(240, 28);

            btnAccesoJuego.Text = "🎮  Jugar";
            btnAccesoJuego.BackColor = Color.FromArgb(121, 67, 225);
            btnAccesoJuego.ForeColor = Color.White;
            btnAccesoJuego.FlatStyle = FlatStyle.Flat;
            btnAccesoJuego.FlatAppearance.BorderSize = 0;
            btnAccesoJuego.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAccesoJuego.Location = new Point(20, 50);
            btnAccesoJuego.Size = new Size(185, 42);
            btnAccesoJuego.Click += btnJuego_Click;

            btnAccesoVariables.Text = "{ }  Variables";
            btnAccesoVariables.BackColor = Color.FromArgb(30, 152, 79);
            btnAccesoVariables.ForeColor = Color.White;
            btnAccesoVariables.FlatStyle = FlatStyle.Flat;
            btnAccesoVariables.FlatAppearance.BorderSize = 0;
            btnAccesoVariables.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAccesoVariables.Location = new Point(225, 50);
            btnAccesoVariables.Size = new Size(185, 42);
            btnAccesoVariables.Click += btnVariables_Click;

            btnAccesoCiclos.Text = "↻  Ciclos";
            btnAccesoCiclos.BackColor = Color.FromArgb(43, 104, 224);
            btnAccesoCiclos.ForeColor = Color.White;
            btnAccesoCiclos.FlatStyle = FlatStyle.Flat;
            btnAccesoCiclos.FlatAppearance.BorderSize = 0;
            btnAccesoCiclos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAccesoCiclos.Location = new Point(430, 50);
            btnAccesoCiclos.Size = new Size(185, 42);
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
            Controls.Add(panelContenido);
            Controls.Add(panelLateral);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1180, 760);
            Name = "MenuEstructura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeNova - Menú principal";
            ResumeLayout(false);
        }
    }
}
