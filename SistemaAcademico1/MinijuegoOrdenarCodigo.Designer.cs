namespace SistemaAcademico1
{
    partial class MinijuegoOrdenarCodigo
    {
        private System.ComponentModel.IContainer? components = null;

        private Label lblTiempo = null!;
        private Label lblPuntuacion = null!;
        private Label lblNivel = null!;
        private Label lblInstruccion = null!;
        private Label lblPista = null!;
        private Label lblResultado = null!;
        private Label lblProgreso = null!;
        private ListBox lstCodigo = null!;
        private ProgressBar progreso = null!;
        private Button btnVerificar = null!;
        private Button btnSiguiente = null!;
        private Button btnPausa = null!;
        private Button btnReiniciar = null!;
        private Button btnRegresar = null!;
        private Button btnSubir = null!;
        private Button btnBajar = null!;
        private System.Windows.Forms.Timer temporizador = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            temporizador = new System.Windows.Forms.Timer(components);
            lblTiempo = new Label();
            lblPuntuacion = new Label();
            lblNivel = new Label();
            lblInstruccion = new Label();
            lblPista = new Label();
            lblResultado = new Label();
            lblProgreso = new Label();
            lstCodigo = new ListBox();
            progreso = new ProgressBar();
            btnVerificar = new Button();
            btnSiguiente = new Button();
            btnPausa = new Button();
            btnReiniciar = new Button();
            btnRegresar = new Button();
            btnSubir = new Button();
            btnBajar = new Button();

            var tarjetaTiempo = new Panel();
            var iconoTiempo = new Label();
            var tituloTiempo = new Label();
            var tituloPrincipal = new Label();
            var subtitulo = new Label();
            var tarjetaPuntos = new Panel();
            var iconoPuntos = new Label();
            var tituloPuntos = new Label();
            var contenedor = new Panel();
            var panelLateral = new Panel();
            var tituloDesafio = new Label();
            var cajaPista = new Panel();
            var tituloPista = new Label();
            var panelCodigo = new Panel();
            var tituloBloques = new Label();
            var ayudaArrastre = new Label();

            SuspendLayout();
            tarjetaTiempo.SuspendLayout();
            tarjetaPuntos.SuspendLayout();
            contenedor.SuspendLayout();
            panelLateral.SuspendLayout();
            cajaPista.SuspendLayout();
            panelCodigo.SuspendLayout();

            // tarjetaTiempo
            tarjetaTiempo.BackColor = Color.FromArgb(20, 24, 66);
            tarjetaTiempo.BorderStyle = BorderStyle.FixedSingle;
            tarjetaTiempo.Location = new Point(30, 22);
            tarjetaTiempo.Size = new Size(230, 92);
            tarjetaTiempo.Controls.Add(iconoTiempo);
            tarjetaTiempo.Controls.Add(tituloTiempo);
            tarjetaTiempo.Controls.Add(lblTiempo);

            iconoTiempo.Text = "◷";
            iconoTiempo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            iconoTiempo.ForeColor = Color.FromArgb(56, 145, 255);
            iconoTiempo.Location = new Point(22, 25);
            iconoTiempo.Size = new Size(48, 48);

            tituloTiempo.Text = "TIEMPO";
            tituloTiempo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tituloTiempo.ForeColor = Color.LightSkyBlue;
            tituloTiempo.Location = new Point(78, 15);
            tituloTiempo.Size = new Size(120, 25);

            lblTiempo.Text = "00:60";
            lblTiempo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTiempo.ForeColor = Color.White;
            lblTiempo.Location = new Point(75, 38);
            lblTiempo.Size = new Size(135, 45);

            // Encabezado
            tituloPrincipal.Text = "ORDENA EL CÓDIGO";
            tituloPrincipal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            tituloPrincipal.ForeColor = Color.White;
            tituloPrincipal.Location = new Point(365, 25);
            tituloPrincipal.Size = new Size(500, 50);
            tituloPrincipal.TextAlign = ContentAlignment.MiddleCenter;

            subtitulo.Text = "Arrastra los bloques para construir el programa correcto.";
            subtitulo.Font = new Font("Segoe UI", 11F);
            subtitulo.ForeColor = Color.Gainsboro;
            subtitulo.Location = new Point(355, 75);
            subtitulo.Size = new Size(520, 30);
            subtitulo.TextAlign = ContentAlignment.MiddleCenter;

            // tarjetaPuntos
            tarjetaPuntos.BackColor = Color.FromArgb(20, 24, 66);
            tarjetaPuntos.BorderStyle = BorderStyle.FixedSingle;
            tarjetaPuntos.Location = new Point(935, 22);
            tarjetaPuntos.Size = new Size(205, 92);
            tarjetaPuntos.Controls.Add(iconoPuntos);
            tarjetaPuntos.Controls.Add(tituloPuntos);
            tarjetaPuntos.Controls.Add(lblPuntuacion);

            iconoPuntos.Text = "★";
            iconoPuntos.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            iconoPuntos.ForeColor = Color.Gold;
            iconoPuntos.Location = new Point(18, 25);
            iconoPuntos.Size = new Size(50, 50);

            tituloPuntos.Text = "PUNTAJE";
            tituloPuntos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tituloPuntos.ForeColor = Color.LightSkyBlue;
            tituloPuntos.Location = new Point(73, 15);
            tituloPuntos.Size = new Size(115, 25);

            lblPuntuacion.Text = "0";
            lblPuntuacion.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPuntuacion.ForeColor = Color.White;
            lblPuntuacion.Location = new Point(70, 38);
            lblPuntuacion.Size = new Size(120, 45);

            btnPausa.Text = "Ⅱ";
            btnPausa.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnPausa.BackColor = Color.FromArgb(30, 35, 88);
            btnPausa.ForeColor = Color.White;
            btnPausa.FlatStyle = FlatStyle.Flat;
            btnPausa.FlatAppearance.BorderSize = 0;
            btnPausa.Location = new Point(1155, 35);
            btnPausa.Size = new Size(50, 58);

            // Contenedor principal
            contenedor.BackColor = Color.FromArgb(20, 24, 66);
            contenedor.BorderStyle = BorderStyle.FixedSingle;
            contenedor.Location = new Point(30, 135);
            contenedor.Size = new Size(1175, 485);
            contenedor.Controls.Add(panelLateral);
            contenedor.Controls.Add(panelCodigo);

            // Panel lateral
            panelLateral.BackColor = Color.FromArgb(25, 25, 72);
            panelLateral.Location = new Point(18, 18);
            panelLateral.Size = new Size(315, 448);
            panelLateral.Controls.Add(tituloDesafio);
            panelLateral.Controls.Add(lblNivel);
            panelLateral.Controls.Add(lblInstruccion);
            panelLateral.Controls.Add(cajaPista);
            panelLateral.Controls.Add(btnReiniciar);
            panelLateral.Controls.Add(btnRegresar);

            tituloDesafio.Text = "DESAFÍO ACTUAL";
            tituloDesafio.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            tituloDesafio.ForeColor = Color.FromArgb(185, 115, 255);
            tituloDesafio.Location = new Point(22, 22);
            tituloDesafio.Size = new Size(270, 30);

            lblNivel.Text = "NIVEL 1\nCiclo while";
            lblNivel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblNivel.ForeColor = Color.White;
            lblNivel.Location = new Point(22, 63);
            lblNivel.Size = new Size(270, 70);

            lblInstruccion.Text = "Ordena los bloques para imprimir los números del 1 al 5.";
            lblInstruccion.Font = new Font("Segoe UI", 10.5F);
            lblInstruccion.ForeColor = Color.Gainsboro;
            lblInstruccion.Location = new Point(22, 135);
            lblInstruccion.Size = new Size(270, 75);

            cajaPista.BackColor = Color.FromArgb(34, 43, 92);
            cajaPista.Location = new Point(18, 235);
            cajaPista.Size = new Size(280, 125);
            cajaPista.Controls.Add(tituloPista);
            cajaPista.Controls.Add(lblPista);

            tituloPista.Text = "💡  PISTA";
            tituloPista.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tituloPista.ForeColor = Color.LightSkyBlue;
            tituloPista.Location = new Point(15, 12);
            tituloPista.Size = new Size(240, 28);

            lblPista.Text = "Primero inicializa i. Dentro del ciclo imprime y luego incrementa.";
            lblPista.ForeColor = Color.Gainsboro;
            lblPista.Location = new Point(15, 45);
            lblPista.Size = new Size(250, 68);

            btnReiniciar.Text = "↻  REINICIAR";
            btnReiniciar.BackColor = Color.FromArgb(38, 48, 100);
            btnReiniciar.ForeColor = Color.LightSkyBlue;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReiniciar.Location = new Point(18, 382);
            btnReiniciar.Size = new Size(135, 44);

            btnRegresar.Text = "←  REGRESAR";
            btnRegresar.BackColor = Color.FromArgb(70, 40, 83);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegresar.Location = new Point(163, 382);
            btnRegresar.Size = new Size(135, 44);

            // Panel de código
            panelCodigo.BackColor = Color.FromArgb(11, 14, 48);
            panelCodigo.Location = new Point(350, 18);
            panelCodigo.Size = new Size(805, 448);
            panelCodigo.Controls.Add(tituloBloques);
            panelCodigo.Controls.Add(ayudaArrastre);
            panelCodigo.Controls.Add(lstCodigo);
            panelCodigo.Controls.Add(btnSubir);
            panelCodigo.Controls.Add(btnBajar);
            panelCodigo.Controls.Add(lblResultado);

            tituloBloques.Text = "BLOQUES DE CÓDIGO";
            tituloBloques.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tituloBloques.ForeColor = Color.FromArgb(185, 115, 255);
            tituloBloques.Location = new Point(22, 15);
            tituloBloques.Size = new Size(240, 30);

            ayudaArrastre.Text = "Arrastra una línea para cambiar su posición.";
            ayudaArrastre.Font = new Font("Segoe UI", 9.5F);
            ayudaArrastre.ForeColor = Color.Silver;
            ayudaArrastre.Location = new Point(455, 17);
            ayudaArrastre.Size = new Size(320, 26);

            lstCodigo.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lstCodigo.BackColor = Color.FromArgb(12, 16, 52);
            lstCodigo.ForeColor = Color.White;
            lstCodigo.BorderStyle = BorderStyle.None;
            lstCodigo.DrawMode = DrawMode.OwnerDrawFixed;
            lstCodigo.ItemHeight = 50;
            lstCodigo.Location = new Point(22, 58);
            lstCodigo.Size = new Size(670, 335);
            lstCodigo.AllowDrop = true;
            lstCodigo.Items.AddRange(new object[]
            {
                "int i = 1;",
                "while (i <= 5)",
                "{",
                "    Console.WriteLine(i);",
                "    i++;",
                "}"
            });

            btnSubir.Text = "▲";
            btnSubir.BackColor = Color.FromArgb(67, 65, 160);
            btnSubir.ForeColor = Color.White;
            btnSubir.FlatStyle = FlatStyle.Flat;
            btnSubir.FlatAppearance.BorderSize = 0;
            btnSubir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubir.Location = new Point(715, 95);
            btnSubir.Size = new Size(62, 55);

            btnBajar.Text = "▼";
            btnBajar.BackColor = Color.FromArgb(67, 65, 160);
            btnBajar.ForeColor = Color.White;
            btnBajar.FlatStyle = FlatStyle.Flat;
            btnBajar.FlatAppearance.BorderSize = 0;
            btnBajar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBajar.Location = new Point(715, 165);
            btnBajar.Size = new Size(62, 55);

            lblResultado.Text = "Selecciona y arrastra los bloques hasta completar el código.";
            lblResultado.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblResultado.ForeColor = Color.LightSkyBlue;
            lblResultado.Location = new Point(22, 402);
            lblResultado.Size = new Size(755, 32);

            // Pie
            lblProgreso.Text = "PROGRESO  ·  NIVEL 1 DE 3";
            lblProgreso.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProgreso.ForeColor = Color.Gainsboro;
            lblProgreso.Location = new Point(35, 638);
            lblProgreso.Size = new Size(230, 25);

            progreso.Location = new Point(35, 665);
            progreso.Size = new Size(510, 18);
            progreso.Maximum = 3;

            btnSiguiente.Text = "SIGUIENTE NIVEL  →";
            btnSiguiente.BackColor = Color.FromArgb(132, 78, 255);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSiguiente.Location = new Point(615, 650);
            btnSiguiente.Size = new Size(220, 48);
            btnSiguiente.Enabled = false;

            btnVerificar.Text = "✓  VERIFICAR";
            btnVerificar.BackColor = Color.FromArgb(55, 174, 52);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVerificar.Location = new Point(925, 645);
            btnVerificar.Size = new Size(280, 55);

            temporizador.Interval = 1000;

            // Formulario
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 10, 38);
            ClientSize = new Size(1220, 720);
            Controls.Add(tarjetaTiempo);
            Controls.Add(tituloPrincipal);
            Controls.Add(subtitulo);
            Controls.Add(tarjetaPuntos);
            Controls.Add(btnPausa);
            Controls.Add(contenedor);
            Controls.Add(lblProgreso);
            Controls.Add(progreso);
            Controls.Add(btnSiguiente);
            Controls.Add(btnVerificar);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1120, 680);
            Name = "MinijuegoOrdenarCodigo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeNova - Ordena el código";

            panelCodigo.ResumeLayout(false);
            cajaPista.ResumeLayout(false);
            panelLateral.ResumeLayout(false);
            contenedor.ResumeLayout(false);
            tarjetaPuntos.ResumeLayout(false);
            tarjetaTiempo.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
