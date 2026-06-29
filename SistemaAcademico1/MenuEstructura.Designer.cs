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
            barraSuperior = new Panel();
            lblMarca = new Label();
            barraLateral = new Panel();
            lblLogo = new Label();
            lblNombre = new Label();
            lblSistema = new Label();
            lblCurso = new Label();
            tarjetaUsuario = new Panel();
            lblAvatar = new Label();
            lblUsuario = new Label();
            lblRol = new Label();
            contenido = new Panel();
            lblBienvenida = new Label();
            lblSubtitulo = new Label();
            tarjetaFecha = new Panel();
            lblCalendario = new Label();
            estadisticas = new FlowLayoutPanel();
            lblTemas = new Label();
            accesos = new Panel();
            lblAccesos = new Label();
            btnAccesoJuego = new Button();
            btnAccesoVariables = new Button();
            btnAccesoCiclos = new Button();
            barraSuperior.SuspendLayout();
            barraLateral.SuspendLayout();
            tarjetaUsuario.SuspendLayout();
            contenido.SuspendLayout();
            tarjetaFecha.SuspendLayout();
            accesos.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(0, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 2;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Location = new Point(0, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(75, 23);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(0, 0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(75, 23);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 4;
            // 
            // btnTemas
            // 
            btnTemas.Location = new Point(0, 0);
            btnTemas.Name = "btnTemas";
            btnTemas.Size = new Size(75, 23);
            btnTemas.TabIndex = 5;
            btnTemas.Click += btnTemas_Click;
            // 
            // btnJuego
            // 
            btnJuego.Location = new Point(0, 0);
            btnJuego.Name = "btnJuego";
            btnJuego.Size = new Size(75, 23);
            btnJuego.TabIndex = 6;
            btnJuego.Click += btnJuego_Click;
            // 
            // btnVariables
            // 
            btnVariables.Location = new Point(0, 0);
            btnVariables.Name = "btnVariables";
            btnVariables.Size = new Size(75, 23);
            btnVariables.TabIndex = 0;
            btnVariables.Click += btnVariables_Click;
            // 
            // btnCiclos
            // 
            btnCiclos.Location = new Point(0, 0);
            btnCiclos.Name = "btnCiclos";
            btnCiclos.Size = new Size(75, 23);
            btnCiclos.TabIndex = 0;
            btnCiclos.Click += btnCiclos_Click;
            // 
            // btnAlgoritmos
            // 
            btnAlgoritmos.Location = new Point(0, 0);
            btnAlgoritmos.Name = "btnAlgoritmos";
            btnAlgoritmos.Size = new Size(75, 23);
            btnAlgoritmos.TabIndex = 0;
            btnAlgoritmos.Click += btnAlgoritmos_Click;
            // 
            // btnCondicionales
            // 
            btnCondicionales.Location = new Point(0, 0);
            btnCondicionales.Name = "btnCondicionales";
            btnCondicionales.Size = new Size(75, 23);
            btnCondicionales.TabIndex = 0;
            btnCondicionales.Click += btnCondicionales_Click;
            // 
            // lblFecha
            // 
            lblFecha.Font = new Font("Segoe UI", 9.5F);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(61, 8);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(120, 52);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha y hora";
            // 
            // panelTemas
            // 
            panelTemas.BackColor = Color.Transparent;
            panelTemas.Location = new Point(35, 295);
            panelTemas.Name = "panelTemas";
            panelTemas.Size = new Size(990, 300);
            panelTemas.TabIndex = 5;
            // 
            // barraSuperior
            // 
            barraSuperior.BackColor = Color.FromArgb(4, 9, 28);
            barraSuperior.Controls.Add(lblMarca);
            barraSuperior.Controls.Add(btnMinimizar);
            barraSuperior.Controls.Add(btnCerrar);
            barraSuperior.Dock = DockStyle.Top;
            barraSuperior.Location = new Point(0, 0);
            barraSuperior.Name = "barraSuperior";
            barraSuperior.Size = new Size(1329, 48);
            barraSuperior.TabIndex = 2;
            // 
            // lblMarca
            // 
            lblMarca.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMarca.ForeColor = Color.White;
            lblMarca.Location = new Point(18, 10);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(210, 30);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "</>  CodeNova";
            // 
            // barraLateral
            // 
            barraLateral.BackColor = Color.FromArgb(6, 16, 45);
            barraLateral.Controls.Add(lblLogo);
            barraLateral.Controls.Add(lblNombre);
            barraLateral.Controls.Add(lblSistema);
            barraLateral.Controls.Add(lblCurso);
            barraLateral.Controls.Add(btnInicio);
            barraLateral.Controls.Add(btnTemas);
            barraLateral.Controls.Add(btnJuego);
            barraLateral.Controls.Add(btnCerrarSesion);
            barraLateral.Controls.Add(tarjetaUsuario);
            barraLateral.Dock = DockStyle.Left;
            barraLateral.Location = new Point(0, 48);
            barraLateral.Name = "barraLateral";
            barraLateral.Size = new Size(270, 752);
            barraLateral.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Consolas", 36F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(55, 116, 255);
            lblLogo.Location = new Point(60, 28);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(150, 68);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "</>";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(30, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(215, 48);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "CodeNova";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSistema
            // 
            lblSistema.Font = new Font("Segoe UI", 10F);
            lblSistema.ForeColor = Color.Gainsboro;
            lblSistema.Location = new Point(35, 150);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(205, 25);
            lblSistema.TabIndex = 2;
            lblSistema.Text = "Sistema Académico";
            lblSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurso
            // 
            lblCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCurso.ForeColor = Color.FromArgb(86, 139, 255);
            lblCurso.Location = new Point(35, 176);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(205, 25);
            lblCurso.TabIndex = 3;
            lblCurso.Text = "PROGRAMACIÓN I";
            lblCurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tarjetaUsuario
            // 
            tarjetaUsuario.BackColor = Color.FromArgb(13, 29, 71);
            tarjetaUsuario.Controls.Add(lblAvatar);
            tarjetaUsuario.Controls.Add(lblUsuario);
            tarjetaUsuario.Controls.Add(lblRol);
            tarjetaUsuario.Location = new Point(20, 675);
            tarjetaUsuario.Name = "tarjetaUsuario";
            tarjetaUsuario.Size = new Size(230, 72);
            tarjetaUsuario.TabIndex = 8;
            // 
            // lblAvatar
            // 
            lblAvatar.Font = new Font("Segoe UI Emoji", 23F);
            lblAvatar.Location = new Point(12, 12);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(52, 50);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "👤";
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(70, 14);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(140, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Docente";
            // 
            // lblRol
            // 
            lblRol.ForeColor = Color.Silver;
            lblRol.Location = new Point(70, 40);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(140, 22);
            lblRol.TabIndex = 2;
            lblRol.Text = "Profesor";
            // 
            // contenido
            // 
            contenido.AutoScroll = true;
            contenido.BackColor = Color.FromArgb(5, 16, 43);
            contenido.Controls.Add(lblBienvenida);
            contenido.Controls.Add(lblSubtitulo);
            contenido.Controls.Add(tarjetaFecha);
            contenido.Controls.Add(estadisticas);
            contenido.Controls.Add(lblTemas);
            contenido.Controls.Add(panelTemas);
            contenido.Controls.Add(accesos);
            contenido.Dock = DockStyle.Fill;
            contenido.Location = new Point(270, 48);
            contenido.Name = "contenido";
            contenido.Size = new Size(1059, 752);
            contenido.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.White;
            lblBienvenida.Location = new Point(35, 25);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(550, 50);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Bienvenido a CodeNova!";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 11F);
            lblSubtitulo.ForeColor = Color.Silver;
            lblSubtitulo.Location = new Point(38, 75);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(430, 30);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema académico para Programación I";
            // 
            // tarjetaFecha
            // 
            tarjetaFecha.BackColor = Color.FromArgb(12, 28, 68);
            tarjetaFecha.Controls.Add(lblCalendario);
            tarjetaFecha.Controls.Add(lblFecha);
            tarjetaFecha.Location = new Point(800, 25);
            tarjetaFecha.Name = "tarjetaFecha";
            tarjetaFecha.Size = new Size(190, 75);
            tarjetaFecha.TabIndex = 2;
            // 
            // lblCalendario
            // 
            lblCalendario.Font = new Font("Segoe UI", 20F);
            lblCalendario.ForeColor = Color.LightSteelBlue;
            lblCalendario.Location = new Point(15, 20);
            lblCalendario.Name = "lblCalendario";
            lblCalendario.Size = new Size(40, 40);
            lblCalendario.TabIndex = 0;
            lblCalendario.Text = "▣";
            // 
            // estadisticas
            // 
            estadisticas.BackColor = Color.Transparent;
            estadisticas.Location = new Point(35, 125);
            estadisticas.Name = "estadisticas";
            estadisticas.Size = new Size(980, 105);
            estadisticas.TabIndex = 3;
            estadisticas.WrapContents = false;
            // 
            // lblTemas
            // 
            lblTemas.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTemas.ForeColor = Color.White;
            lblTemas.Location = new Point(35, 250);
            lblTemas.Name = "lblTemas";
            lblTemas.Size = new Size(430, 35);
            lblTemas.TabIndex = 4;
            lblTemas.Text = "</>  Temas de Programación I";
            // 
            // accesos
            // 
            accesos.BackColor = Color.FromArgb(10, 27, 64);
            accesos.Controls.Add(lblAccesos);
            accesos.Controls.Add(btnAccesoJuego);
            accesos.Controls.Add(btnAccesoVariables);
            accesos.Controls.Add(btnAccesoCiclos);
            accesos.Location = new Point(35, 615);
            accesos.Name = "accesos";
            accesos.Size = new Size(990, 105);
            accesos.TabIndex = 6;
            // 
            // lblAccesos
            // 
            lblAccesos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccesos.ForeColor = Color.White;
            lblAccesos.Location = new Point(18, 12);
            lblAccesos.Name = "lblAccesos";
            lblAccesos.Size = new Size(240, 28);
            lblAccesos.TabIndex = 0;
            lblAccesos.Text = "⚡  Accesos rápidos";
            // 
            // btnAccesoJuego
            // 
            btnAccesoJuego.Location = new Point(0, 0);
            btnAccesoJuego.Name = "btnAccesoJuego";
            btnAccesoJuego.Size = new Size(75, 23);
            btnAccesoJuego.TabIndex = 1;
            btnAccesoJuego.Click += btnJuego_Click;
            // 
            // btnAccesoVariables
            // 
            btnAccesoVariables.Location = new Point(0, 0);
            btnAccesoVariables.Name = "btnAccesoVariables";
            btnAccesoVariables.Size = new Size(75, 23);
            btnAccesoVariables.TabIndex = 2;
            btnAccesoVariables.Click += btnVariables_Click;
            // 
            // btnAccesoCiclos
            // 
            btnAccesoCiclos.Location = new Point(0, 0);
            btnAccesoCiclos.Name = "btnAccesoCiclos";
            btnAccesoCiclos.Size = new Size(75, 23);
            btnAccesoCiclos.TabIndex = 3;
            btnAccesoCiclos.Click += btnCiclos_Click;
            // 
            // MenuEstructura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 16, 43);
            ClientSize = new Size(1329, 800);
            Controls.Add(contenido);
            Controls.Add(barraLateral);
            Controls.Add(barraSuperior);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1180, 760);
            Name = "MenuEstructura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeNova - Menú principal";
            barraSuperior.ResumeLayout(false);
            barraLateral.ResumeLayout(false);
            tarjetaUsuario.ResumeLayout(false);
            contenido.ResumeLayout(false);
            tarjetaFecha.ResumeLayout(false);
            accesos.ResumeLayout(false);
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

        private Panel barraSuperior;
        private Label lblMarca;
        private Panel barraLateral;
        private Label lblLogo;
        private Label lblNombre;
        private Label lblSistema;
        private Label lblCurso;
        private Panel tarjetaUsuario;
        private Label lblAvatar;
        private Label lblUsuario;
        private Label lblRol;
        private Panel contenido;
        private Label lblBienvenida;
        private Label lblSubtitulo;
        private Panel tarjetaFecha;
        private Label lblCalendario;
        private FlowLayoutPanel estadisticas;
        private Label lblTemas;
        private Panel accesos;
        private Label lblAccesos;
        private Button btnAccesoJuego;
        private Button btnAccesoVariables;
        private Button btnAccesoCiclos;
    }
}
