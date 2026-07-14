namespace SistemaAcademico1
{
    partial class MenuLateralControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLateralControl));
            lblLogo = new Label();
            lblNombre = new Label();
            lblSistema = new Label();
            btnInicio = new Button();
            btnVariables = new Button();
            btnCiclos = new Button();
            btnJuego = new Button();
            btnCerrarSesion = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Consolas", 34F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(55, 116, 255);
            lblLogo.Image = (Image)resources.GetObject("lblLogo.Image");
            lblLogo.Location = new Point(54, 13);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(160, 62);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "</>";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Image = (Image)resources.GetObject("lblNombre.Image");
            lblNombre.Location = new Point(25, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(220, 45);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "CodeNova";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSistema
            // 
            lblSistema.BackColor = Color.Transparent;
            lblSistema.Font = new Font("Segoe UI", 10F);
            lblSistema.ForeColor = Color.Gainsboro;
            lblSistema.Image = (Image)resources.GetObject("lblSistema.Image");
            lblSistema.ImageAlign = ContentAlignment.TopCenter;
            lblSistema.Location = new Point(25, 120);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(210, 55);
            lblSistema.TabIndex = 2;
            lblSistema.Text = "Sistema Académico\nProgramación I";
            lblSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.Transparent;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 11F);
            btnInicio.ForeColor = Color.Gainsboro;
            btnInicio.Location = new Point(20, 191);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(20, 0, 0, 0);
            btnInicio.Size = new Size(230, 48);
            btnInicio.TabIndex = 3;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnVariables
            // 
            btnVariables.BackColor = Color.Transparent;
            btnVariables.FlatAppearance.BorderSize = 0;
            btnVariables.FlatStyle = FlatStyle.Flat;
            btnVariables.Font = new Font("Segoe UI", 11F);
            btnVariables.ForeColor = Color.Gainsboro;
            btnVariables.Location = new Point(20, 334);
            btnVariables.Name = "btnVariables";
            btnVariables.Padding = new Padding(20, 0, 0, 0);
            btnVariables.Size = new Size(230, 48);
            btnVariables.TabIndex = 4;
            btnVariables.Text = "Variables";
            btnVariables.TextAlign = ContentAlignment.MiddleLeft;
            btnVariables.UseVisualStyleBackColor = false;
            btnVariables.Click += btnVariables_Click;
            // 
            // btnCiclos
            // 
            btnCiclos.BackColor = Color.Transparent;
            btnCiclos.FlatAppearance.BorderSize = 0;
            btnCiclos.FlatStyle = FlatStyle.Flat;
            btnCiclos.Font = new Font("Segoe UI", 11F);
            btnCiclos.ForeColor = Color.Gainsboro;
            btnCiclos.Location = new Point(20, 495);
            btnCiclos.Name = "btnCiclos";
            btnCiclos.Padding = new Padding(20, 0, 0, 0);
            btnCiclos.Size = new Size(230, 48);
            btnCiclos.TabIndex = 5;
            btnCiclos.Text = "Ciclos";
            btnCiclos.TextAlign = ContentAlignment.MiddleLeft;
            btnCiclos.UseVisualStyleBackColor = false;
            btnCiclos.Click += btnCiclos_Click;
            // 
            // btnJuego
            // 
            btnJuego.BackColor = Color.Transparent;
            btnJuego.FlatAppearance.BorderSize = 0;
            btnJuego.FlatStyle = FlatStyle.Flat;
            btnJuego.Font = new Font("Segoe UI", 11F);
            btnJuego.ForeColor = Color.Gainsboro;
            btnJuego.Location = new Point(20, 579);
            btnJuego.Name = "btnJuego";
            btnJuego.Padding = new Padding(20, 0, 0, 0);
            btnJuego.Size = new Size(230, 48);
            btnJuego.TabIndex = 6;
            btnJuego.Text = "Juegos";
            btnJuego.TextAlign = ContentAlignment.MiddleLeft;
            btnJuego.UseVisualStyleBackColor = false;
            btnJuego.Click += btnJuego_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11F);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Location = new Point(20, 681);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(20, 0, 0, 0);
            btnCerrarSesion.Size = new Size(230, 48);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "↪    Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(20, 255);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(230, 48);
            button1.TabIndex = 8;
            button1.Text = "Algoritmo";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(20, 410);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(230, 48);
            button2.TabIndex = 9;
            button2.Text = "Condicionales";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MenuLateralControl
            // 
            BackColor = Color.FromArgb(6, 16, 45);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblLogo);
            Controls.Add(lblNombre);
            Controls.Add(lblSistema);
            Controls.Add(btnInicio);
            Controls.Add(btnVariables);
            Controls.Add(btnCiclos);
            Controls.Add(btnJuego);
            Controls.Add(btnCerrarSesion);
            DoubleBuffered = true;
            Name = "MenuLateralControl";
            Size = new Size(270, 752);
            ResumeLayout(false);
        }

        private Label lblLogo;
        private Label lblNombre;
        private Label lblSistema;
        private Button btnInicio;
        private Button btnVariables;
        private Button btnCiclos;
        private Button btnJuego;
        private Button btnCerrarSesion;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label1;
    }
}
