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
            lblLogo = new Label();
            lblNombre = new Label();
            lblSistema = new Label();
            btnInicio = new Button();
            btnVariables = new Button();
            btnCiclos = new Button();
            btnJuego = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Consolas", 34F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(55, 116, 255);
            lblLogo.Location = new Point(55, 25);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(160, 62);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "</>";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(25, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(220, 45);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "CodeNova";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSistema
            // 
            lblSistema.Font = new Font("Segoe UI", 10F);
            lblSistema.ForeColor = Color.Gainsboro;
            lblSistema.Location = new Point(30, 142);
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
            btnInicio.Location = new Point(20, 225);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(20, 0, 0, 0);
            btnInicio.Size = new Size(230, 48);
            btnInicio.TabIndex = 3;
            btnInicio.Text = "⌂    Inicio";
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
            btnVariables.Location = new Point(20, 282);
            btnVariables.Name = "btnVariables";
            btnVariables.Padding = new Padding(20, 0, 0, 0);
            btnVariables.Size = new Size(230, 48);
            btnVariables.TabIndex = 4;
            btnVariables.Text = "{ }   Variables";
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
            btnCiclos.Location = new Point(20, 339);
            btnCiclos.Name = "btnCiclos";
            btnCiclos.Padding = new Padding(20, 0, 0, 0);
            btnCiclos.Size = new Size(230, 48);
            btnCiclos.TabIndex = 5;
            btnCiclos.Text = "↻    Ciclos";
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
            btnJuego.Location = new Point(20, 396);
            btnJuego.Name = "btnJuego";
            btnJuego.Padding = new Padding(20, 0, 0, 0);
            btnJuego.Size = new Size(230, 48);
            btnJuego.TabIndex = 6;
            btnJuego.Text = "🎮   Juego";
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
            btnCerrarSesion.Location = new Point(20, 665);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(20, 0, 0, 0);
            btnCerrarSesion.Size = new Size(230, 48);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Text = "↪    Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MenuLateralControl
            // 
            BackColor = Color.FromArgb(6, 16, 45);
            Controls.Add(lblLogo);
            Controls.Add(lblNombre);
            Controls.Add(lblSistema);
            Controls.Add(btnInicio);
            Controls.Add(btnVariables);
            Controls.Add(btnCiclos);
            Controls.Add(btnJuego);
            Controls.Add(btnCerrarSesion);
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
    }
}
