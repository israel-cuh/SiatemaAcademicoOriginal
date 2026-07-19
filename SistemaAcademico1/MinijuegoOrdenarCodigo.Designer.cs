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
            tarjetaTiempo = new Panel();
            iconoTiempo = new Label();
            tituloTiempo = new Label();
            tituloPrincipal = new Label();
            subtitulo = new Label();
            tarjetaPuntos = new Panel();
            iconoPuntos = new Label();
            tituloPuntos = new Label();
            contenedor = new Panel();
            panelLateral = new Panel();
            tituloDesafio = new Label();
            cajaPista = new Panel();
            tituloPista = new Label();
            panelCodigo = new Panel();
            tituloBloques = new Label();
            ayudaArrastre = new Label();
            tarjetaTiempo.SuspendLayout();
            tarjetaPuntos.SuspendLayout();
            contenedor.SuspendLayout();
            panelLateral.SuspendLayout();
            cajaPista.SuspendLayout();
            panelCodigo.SuspendLayout();
            SuspendLayout();
            // 
            // temporizador
            // 
            temporizador.Interval = 1000;
            // 
            // lblTiempo
            // 
            lblTiempo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTiempo.ForeColor = Color.White;
            lblTiempo.Location = new Point(75, 38);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(135, 45);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "00:60";
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPuntuacion.ForeColor = Color.White;
            lblPuntuacion.Location = new Point(74, 35);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(120, 45);
            lblPuntuacion.TabIndex = 2;
            lblPuntuacion.Text = "0";
            // 
            // lblNivel
            // 
            lblNivel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblNivel.ForeColor = Color.White;
            lblNivel.Location = new Point(22, 55);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(270, 78);
            lblNivel.TabIndex = 1;
            lblNivel.Text = "NIVEL 1\nCiclo while";
            // 
            // lblInstruccion
            // 
            lblInstruccion.Font = new Font("Segoe UI", 10.5F);
            lblInstruccion.ForeColor = Color.Gainsboro;
            lblInstruccion.Location = new Point(22, 135);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(270, 75);
            lblInstruccion.TabIndex = 2;
            lblInstruccion.Text = "Ordena los bloques para imprimir los números del 1 al 5.";
            // 
            // lblPista
            // 
            lblPista.ForeColor = Color.Gainsboro;
            lblPista.Location = new Point(15, 45);
            lblPista.Name = "lblPista";
            lblPista.Size = new Size(250, 68);
            lblPista.TabIndex = 1;
            lblPista.Text = "Primero inicializa i. Dentro del ciclo imprime y luego incrementa.";
            // 
            // lblResultado
            // 
            lblResultado.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblResultado.ForeColor = Color.LightSkyBlue;
            lblResultado.Location = new Point(22, 402);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(755, 32);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Selecciona y arrastra los bloques hasta completar el código.";
            // 
            // lblProgreso
            // 
            lblProgreso.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProgreso.ForeColor = Color.Gainsboro;
            lblProgreso.Location = new Point(35, 638);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(230, 25);
            lblProgreso.TabIndex = 6;
            lblProgreso.Text = "PROGRESO  ·  NIVEL 1 DE 3";
            // 
            // lstCodigo
            // 
            lstCodigo.AllowDrop = true;
            lstCodigo.BackColor = Color.FromArgb(12, 16, 52);
            lstCodigo.BorderStyle = BorderStyle.None;
            lstCodigo.DrawMode = DrawMode.OwnerDrawFixed;
            lstCodigo.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lstCodigo.ForeColor = Color.White;
            lstCodigo.ItemHeight = 50;
            lstCodigo.Items.AddRange(new object[] { "int i = 1;", "while (i <= 5)", "{", "    Console.WriteLine(i);", "    i++;", "}" });
            lstCodigo.Location = new Point(22, 55);
            lstCodigo.Name = "lstCodigo";
            lstCodigo.Size = new Size(670, 300);
            lstCodigo.TabIndex = 2;
            // 
            // progreso
            // 
            progreso.Location = new Point(35, 665);
            progreso.Maximum = 3;
            progreso.Name = "progreso";
            progreso.Size = new Size(510, 18);
            progreso.TabIndex = 7;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(55, 174, 52);
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(925, 645);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(280, 55);
            btnVerificar.TabIndex = 9;
            btnVerificar.Text = "✓  VERIFICAR";
            btnVerificar.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(132, 78, 255);
            btnSiguiente.Enabled = false;
            btnSiguiente.FlatAppearance.BorderSize = 0;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(615, 650);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(220, 48);
            btnSiguiente.TabIndex = 8;
            btnSiguiente.Text = "SIGUIENTE NIVEL  →";
            btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnPausa
            // 
            btnPausa.BackColor = Color.FromArgb(30, 35, 88);
            btnPausa.FlatAppearance.BorderSize = 0;
            btnPausa.FlatStyle = FlatStyle.Flat;
            btnPausa.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnPausa.ForeColor = Color.White;
            btnPausa.Location = new Point(1155, 57);
            btnPausa.Name = "btnPausa";
            btnPausa.Size = new Size(50, 58);
            btnPausa.TabIndex = 4;
            btnPausa.Text = "Ⅱ";
            btnPausa.UseVisualStyleBackColor = false;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(38, 48, 100);
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReiniciar.ForeColor = Color.LightSkyBlue;
            btnReiniciar.Location = new Point(18, 382);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(135, 44);
            btnReiniciar.TabIndex = 4;
            btnReiniciar.Text = "↻  REINICIAR";
            btnReiniciar.UseVisualStyleBackColor = false;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.FromArgb(70, 40, 83);
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(163, 382);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(135, 44);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "←  REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            // 
            // btnSubir
            // 
            btnSubir.BackColor = Color.FromArgb(67, 65, 160);
            btnSubir.FlatAppearance.BorderSize = 0;
            btnSubir.FlatStyle = FlatStyle.Flat;
            btnSubir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubir.ForeColor = Color.White;
            btnSubir.Location = new Point(715, 95);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(62, 55);
            btnSubir.TabIndex = 3;
            btnSubir.Text = "▲";
            btnSubir.UseVisualStyleBackColor = false;
            // 
            // btnBajar
            // 
            btnBajar.BackColor = Color.FromArgb(67, 65, 160);
            btnBajar.FlatAppearance.BorderSize = 0;
            btnBajar.FlatStyle = FlatStyle.Flat;
            btnBajar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBajar.ForeColor = Color.White;
            btnBajar.Location = new Point(715, 165);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(62, 55);
            btnBajar.TabIndex = 4;
            btnBajar.Text = "▼";
            btnBajar.UseVisualStyleBackColor = false;
            // 
            // tarjetaTiempo
            // 
            tarjetaTiempo.BackColor = Color.FromArgb(20, 24, 66);
            tarjetaTiempo.BorderStyle = BorderStyle.FixedSingle;
            tarjetaTiempo.Controls.Add(iconoTiempo);
            tarjetaTiempo.Controls.Add(tituloTiempo);
            tarjetaTiempo.Controls.Add(lblTiempo);
            tarjetaTiempo.Location = new Point(30, 22);
            tarjetaTiempo.Name = "tarjetaTiempo";
            tarjetaTiempo.Size = new Size(230, 92);
            tarjetaTiempo.TabIndex = 0;
            // 
            // iconoTiempo
            // 
            iconoTiempo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            iconoTiempo.ForeColor = Color.FromArgb(56, 145, 255);
            iconoTiempo.Location = new Point(22, 25);
            iconoTiempo.Name = "iconoTiempo";
            iconoTiempo.Size = new Size(48, 48);
            iconoTiempo.TabIndex = 0;
            iconoTiempo.Text = "◷";
            // 
            // tituloTiempo
            // 
            tituloTiempo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tituloTiempo.ForeColor = Color.LightSkyBlue;
            tituloTiempo.Location = new Point(78, 15);
            tituloTiempo.Name = "tituloTiempo";
            tituloTiempo.Size = new Size(120, 25);
            tituloTiempo.TabIndex = 1;
            tituloTiempo.Text = "TIEMPO";
            tituloTiempo.Click += tituloTiempo_Click;
            // 
            // tituloPrincipal
            // 
            tituloPrincipal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            tituloPrincipal.ForeColor = Color.White;
            tituloPrincipal.Location = new Point(365, 25);
            tituloPrincipal.Name = "tituloPrincipal";
            tituloPrincipal.Size = new Size(500, 50);
            tituloPrincipal.TabIndex = 1;
            tituloPrincipal.Text = "ORDENA EL CÓDIGO";
            tituloPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitulo
            // 
            subtitulo.Font = new Font("Segoe UI", 11F);
            subtitulo.ForeColor = Color.Gainsboro;
            subtitulo.Location = new Point(355, 75);
            subtitulo.Name = "subtitulo";
            subtitulo.Size = new Size(520, 30);
            subtitulo.TabIndex = 2;
            subtitulo.Text = "Arrastra los bloques para construir el programa correcto.";
            subtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tarjetaPuntos
            // 
            tarjetaPuntos.BackColor = Color.FromArgb(20, 24, 66);
            tarjetaPuntos.BorderStyle = BorderStyle.FixedSingle;
            tarjetaPuntos.Controls.Add(iconoPuntos);
            tarjetaPuntos.Controls.Add(tituloPuntos);
            tarjetaPuntos.Controls.Add(lblPuntuacion);
            tarjetaPuntos.Location = new Point(935, 37);
            tarjetaPuntos.Name = "tarjetaPuntos";
            tarjetaPuntos.Size = new Size(205, 92);
            tarjetaPuntos.TabIndex = 3;
            // 
            // iconoPuntos
            // 
            iconoPuntos.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            iconoPuntos.ForeColor = Color.Gold;
            iconoPuntos.Location = new Point(3, 35);
            iconoPuntos.Name = "iconoPuntos";
            iconoPuntos.Size = new Size(50, 50);
            iconoPuntos.TabIndex = 0;
            iconoPuntos.Text = "★";
            // 
            // tituloPuntos
            // 
            tituloPuntos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tituloPuntos.ForeColor = Color.LightSkyBlue;
            tituloPuntos.Location = new Point(39, 10);
            tituloPuntos.Name = "tituloPuntos";
            tituloPuntos.Size = new Size(115, 25);
            tituloPuntos.TabIndex = 1;
            tituloPuntos.Text = "PUNTAJE";
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.FromArgb(20, 24, 66);
            contenedor.BorderStyle = BorderStyle.FixedSingle;
            contenedor.Controls.Add(panelLateral);
            contenedor.Controls.Add(panelCodigo);
            contenedor.Location = new Point(30, 135);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1175, 485);
            contenedor.TabIndex = 5;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = Color.FromArgb(25, 25, 72);
            panelLateral.Controls.Add(tituloDesafio);
            panelLateral.Controls.Add(lblNivel);
            panelLateral.Controls.Add(lblInstruccion);
            panelLateral.Controls.Add(cajaPista);
            panelLateral.Controls.Add(btnReiniciar);
            panelLateral.Controls.Add(btnRegresar);
            panelLateral.Location = new Point(18, 18);
            panelLateral.Name = "panelLateral";
            panelLateral.Size = new Size(315, 448);
            panelLateral.TabIndex = 0;
            // 
            // tituloDesafio
            // 
            tituloDesafio.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            tituloDesafio.ForeColor = Color.FromArgb(185, 115, 255);
            tituloDesafio.Location = new Point(22, 22);
            tituloDesafio.Name = "tituloDesafio";
            tituloDesafio.Size = new Size(270, 30);
            tituloDesafio.TabIndex = 0;
            tituloDesafio.Text = "DESAFÍO ACTUAL";
            // 
            // cajaPista
            // 
            cajaPista.BackColor = Color.FromArgb(34, 43, 92);
            cajaPista.Controls.Add(tituloPista);
            cajaPista.Controls.Add(lblPista);
            cajaPista.Location = new Point(18, 235);
            cajaPista.Name = "cajaPista";
            cajaPista.Size = new Size(280, 125);
            cajaPista.TabIndex = 3;
            // 
            // tituloPista
            // 
            tituloPista.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            tituloPista.ForeColor = Color.LightSkyBlue;
            tituloPista.Location = new Point(15, 12);
            tituloPista.Name = "tituloPista";
            tituloPista.Size = new Size(240, 28);
            tituloPista.TabIndex = 0;
            tituloPista.Text = "💡  PISTA";
            // 
            // panelCodigo
            // 
            panelCodigo.BackColor = Color.FromArgb(11, 14, 48);
            panelCodigo.Controls.Add(tituloBloques);
            panelCodigo.Controls.Add(ayudaArrastre);
            panelCodigo.Controls.Add(lstCodigo);
            panelCodigo.Controls.Add(btnSubir);
            panelCodigo.Controls.Add(btnBajar);
            panelCodigo.Controls.Add(lblResultado);
            panelCodigo.Location = new Point(350, 18);
            panelCodigo.Name = "panelCodigo";
            panelCodigo.Size = new Size(805, 448);
            panelCodigo.TabIndex = 1;
            // 
            // tituloBloques
            // 
            tituloBloques.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tituloBloques.ForeColor = Color.FromArgb(185, 115, 255);
            tituloBloques.Location = new Point(22, 15);
            tituloBloques.Name = "tituloBloques";
            tituloBloques.Size = new Size(240, 30);
            tituloBloques.TabIndex = 0;
            tituloBloques.Text = "BLOQUES DE CÓDIGO";
            // 
            // ayudaArrastre
            // 
            ayudaArrastre.Font = new Font("Segoe UI", 9.5F);
            ayudaArrastre.ForeColor = Color.Silver;
            ayudaArrastre.Location = new Point(455, 17);
            ayudaArrastre.Name = "ayudaArrastre";
            ayudaArrastre.Size = new Size(320, 26);
            ayudaArrastre.TabIndex = 1;
            ayudaArrastre.Text = "Arrastra una línea para cambiar su posición.";
            // 
            // MinijuegoOrdenarCodigo
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
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
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1120, 680);
            Name = "MinijuegoOrdenarCodigo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeNova - Ordena el código";
            Load += MinijuegoOrdenarCodigo_Load;
            tarjetaTiempo.ResumeLayout(false);
            tarjetaPuntos.ResumeLayout(false);
            contenedor.ResumeLayout(false);
            panelLateral.ResumeLayout(false);
            cajaPista.ResumeLayout(false);
            panelCodigo.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel tarjetaTiempo;
        private Label iconoTiempo;
        private Label tituloTiempo;
        private Label tituloPrincipal;
        private Label subtitulo;
        private Panel tarjetaPuntos;
        private Label iconoPuntos;
        private Label tituloPuntos;
        private Panel contenedor;
        private Panel panelLateral;
        private Label tituloDesafio;
        private Panel cajaPista;
        private Label tituloPista;
        private Panel panelCodigo;
        private Label tituloBloques;
        private Label ayudaArrastre;
    }
}
