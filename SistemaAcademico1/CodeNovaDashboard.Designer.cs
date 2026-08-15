using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAcademico1
{
    partial class CodeNovaDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelSidebar;
        private Panel panelHeader;
        private Panel panelStats;
        private FlowLayoutPanel flowCards;
        private Label lblWelcome;
        private Panel stat1;
        private Panel stat2;
        private Panel stat3;
        private Panel stat4;
        private Button btnAcceso3;
        private Button btnAcceso4;
        private Button btnAcceso5;
        private Button btnAgregarTarea;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeNovaDashboard));
            panelSidebar = new Panel();
            tarjetaUsuario = new Panel();
            lblAvatar = new Label();
            lblUsuario = new Label();
            lblRol = new Label();
            btnCerrarSesion = new Button();
            lblCurso = new Label();
            lblSistema = new Label();
            lblNombre = new Label();
            lblLogo = new Label();
            panelHeader = new Panel();
            lblWelcome = new Label();
            panelStats = new Panel();
            stat1 = new Panel();
            s1Title = new Label();
            s1Value = new Label();
            stat2 = new Panel();
            s2Title = new Label();
            s2Value = new Label();
            stat3 = new Panel();
            s3Title = new Label();
            s3Value = new Label();
            stat4 = new Panel();
            s4Title = new Label();
            s4Value = new Label();
            flowCards = new FlowLayoutPanel();
            tarjetaAlgoritmos = new Panel();
            lblNumeroAlgoritmos = new Label();
            lblIconoAlgoritmos = new Label();
            lblTituloAlgoritmos = new Label();
            lblDescripcionAlgoritmos = new Label();
            btnSeudocodigo = new Button();
            tarjetaVariables = new Panel();
            lblNumeroVariables = new Label();
            lblIconoVariables = new Label();
            lblTituloVariables = new Label();
            lblDescripcionVariables = new Label();
            btnVariables = new Button();
            tarjetaCondicionales = new Panel();
            lblNumeroCondicionales = new Label();
            lblIconoCondicionales = new Label();
            lblTituloCondicionales = new Label();
            lblDescripcionCondicionales = new Label();
            btnCondicionales = new Button();
            tarjetaCiclos = new Panel();
            lblNumeroCiclos = new Label();
            lblIconoCiclos = new Label();
            lblTituloCiclos = new Label();
            lblDescripcionCiclos = new Label();
            btnCiclos = new Button();
            btnAcceso3 = new Button();
            btnAcceso4 = new Button();
            btnAcceso5 = new Button();
            btnAgregarTarea = new Button();
            panel1 = new Panel();
            lblAccesos = new Label();
            panelSidebar.SuspendLayout();
            tarjetaUsuario.SuspendLayout();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            stat1.SuspendLayout();
            stat2.SuspendLayout();
            stat3.SuspendLayout();
            stat4.SuspendLayout();
            flowCards.SuspendLayout();
            tarjetaAlgoritmos.SuspendLayout();
            tarjetaVariables.SuspendLayout();
            tarjetaCondicionales.SuspendLayout();
            tarjetaCiclos.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(9, 30, 55);
            panelSidebar.BackgroundImage = (Image)resources.GetObject("panelSidebar.BackgroundImage");
            panelSidebar.BackgroundImageLayout = ImageLayout.Stretch;
            panelSidebar.Controls.Add(tarjetaUsuario);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Controls.Add(lblCurso);
            panelSidebar.Controls.Add(lblSistema);
            panelSidebar.Controls.Add(lblNombre);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(20);
            panelSidebar.Size = new Size(254, 800);
            panelSidebar.TabIndex = 4;
            // 
            // tarjetaUsuario
            // 
            tarjetaUsuario.BackColor = Color.FromArgb(13, 29, 71);
            tarjetaUsuario.BackgroundImage = (Image)resources.GetObject("tarjetaUsuario.BackgroundImage");
            tarjetaUsuario.Controls.Add(lblAvatar);
            tarjetaUsuario.Controls.Add(lblUsuario);
            tarjetaUsuario.Controls.Add(lblRol);
            tarjetaUsuario.Location = new Point(18, 674);
            tarjetaUsuario.Name = "tarjetaUsuario";
            tarjetaUsuario.Size = new Size(230, 72);
            tarjetaUsuario.TabIndex = 9;
            // 
            // lblAvatar
            // 
            lblAvatar.BackColor = Color.Transparent;
            lblAvatar.Font = new Font("Segoe UI Emoji", 23F);
            lblAvatar.Location = new Point(12, 12);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(52, 50);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "👤";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = Color.Transparent;
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
            lblRol.BackColor = Color.Transparent;
            lblRol.ForeColor = Color.Silver;
            lblRol.Location = new Point(70, 40);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(140, 22);
            lblRol.TabIndex = 2;
            lblRol.Text = "Profesor";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11F);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Location = new Point(18, 604);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(20, 0, 0, 0);
            btnCerrarSesion.Size = new Size(230, 48);
            btnCerrarSesion.TabIndex = 8;
            btnCerrarSesion.Text = "↪    Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblCurso
            // 
            lblCurso.BackColor = Color.Transparent;
            lblCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCurso.ForeColor = Color.FromArgb(86, 139, 255);
            lblCurso.Location = new Point(23, 158);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(205, 25);
            lblCurso.TabIndex = 4;
            lblCurso.Text = "PROGRAMACIÓN I";
            lblCurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSistema
            // 
            lblSistema.BackColor = Color.Transparent;
            lblSistema.Font = new Font("Segoe UI", 10F);
            lblSistema.ForeColor = Color.Gainsboro;
            lblSistema.Location = new Point(26, 136);
            lblSistema.Name = "lblSistema";
            lblSistema.Size = new Size(205, 25);
            lblSistema.TabIndex = 3;
            lblSistema.Text = "Sistema Académico";
            lblSistema.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(12, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(236, 48);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "CodeNova";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Consolas", 36F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(55, 116, 255);
            lblLogo.Location = new Point(48, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(150, 68);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "</>";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(6, 24, 45);
            panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
            panelHeader.BackgroundImageLayout = ImageLayout.Stretch;
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(254, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20);
            panelHeader.Size = new Size(1033, 120);
            panelHeader.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Dock = DockStyle.Left;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(359, 46);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "¡Bienvenido docente!";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(10, 30, 55);
            panelStats.BackgroundImage = (Image)resources.GetObject("panelStats.BackgroundImage");
            panelStats.BackgroundImageLayout = ImageLayout.Stretch;
            panelStats.Controls.Add(stat1);
            panelStats.Controls.Add(stat2);
            panelStats.Controls.Add(stat3);
            panelStats.Controls.Add(stat4);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(254, 120);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(30);
            panelStats.Size = new Size(1033, 104);
            panelStats.TabIndex = 1;
            // 
            // stat1
            // 
            stat1.BackColor = Color.FromArgb(14, 36, 60);
            stat1.Controls.Add(s1Title);
            stat1.Controls.Add(s1Value);
            stat1.Location = new Point(33, 13);
            stat1.Margin = new Padding(12, 10, 12, 10);
            stat1.Name = "stat1";
            stat1.Size = new Size(221, 70);
            stat1.TabIndex = 0;
            // 
            // s1Title
            // 
            s1Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            s1Title.ForeColor = Color.FromArgb(130, 220, 140);
            s1Title.Location = new Point(58, 0);
            s1Title.Name = "s1Title";
            s1Title.Size = new Size(100, 23);
            s1Title.TabIndex = 0;
            s1Title.Text = "ESTUDIANTES";
            // 
            // s1Value
            // 
            s1Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            s1Value.ForeColor = Color.White;
            s1Value.Location = new Point(68, 17);
            s1Value.Name = "s1Value";
            s1Value.Size = new Size(100, 49);
            s1Value.TabIndex = 1;
            s1Value.Text = "24";
            // 
            // stat2
            // 
            stat2.BackColor = Color.FromArgb(14, 36, 60);
            stat2.Controls.Add(s2Title);
            stat2.Controls.Add(s2Value);
            stat2.Location = new Point(268, 13);
            stat2.Margin = new Padding(12, 10, 12, 10);
            stat2.Name = "stat2";
            stat2.Size = new Size(241, 70);
            stat2.TabIndex = 1;
            // 
            // s2Title
            // 
            s2Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            s2Title.ForeColor = Color.FromArgb(255, 200, 60);
            s2Title.Location = new Point(78, 0);
            s2Title.Name = "s2Title";
            s2Title.Size = new Size(100, 23);
            s2Title.TabIndex = 0;
            s2Title.Text = "MATERIAS";
            // 
            // s2Value
            // 
            s2Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            s2Value.ForeColor = Color.White;
            s2Value.Location = new Point(98, 23);
            s2Value.Name = "s2Value";
            s2Value.Size = new Size(100, 42);
            s2Value.TabIndex = 1;
            s2Value.Text = "1";
            // 
            // stat3
            // 
            stat3.BackColor = Color.FromArgb(14, 36, 60);
            stat3.Controls.Add(s3Title);
            stat3.Controls.Add(s3Value);
            stat3.Location = new Point(533, 13);
            stat3.Margin = new Padding(12, 10, 12, 10);
            stat3.Name = "stat3";
            stat3.Size = new Size(240, 70);
            stat3.TabIndex = 2;
            // 
            // s3Title
            // 
            s3Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            s3Title.ForeColor = Color.FromArgb(180, 120, 220);
            s3Title.Location = new Point(50, 0);
            s3Title.Name = "s3Title";
            s3Title.Size = new Size(153, 23);
            s3Title.TabIndex = 0;
            s3Title.Text = "EVALUACIONES";
            // 
            // s3Value
            // 
            s3Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            s3Value.ForeColor = Color.White;
            s3Value.Location = new Point(111, 18);
            s3Value.Name = "s3Value";
            s3Value.Size = new Size(100, 52);
            s3Value.TabIndex = 1;
            s3Value.Text = "3";
            // 
            // stat4
            // 
            stat4.BackColor = Color.FromArgb(14, 36, 60);
            stat4.Controls.Add(s4Title);
            stat4.Controls.Add(s4Value);
            stat4.Location = new Point(787, 13);
            stat4.Margin = new Padding(12, 10, 12, 10);
            stat4.Name = "stat4";
            stat4.Size = new Size(231, 70);
            stat4.TabIndex = 3;
            // 
            // s4Title
            // 
            s4Title.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            s4Title.ForeColor = Color.FromArgb(90, 170, 240);
            s4Title.Location = new Point(62, 0);
            s4Title.Name = "s4Title";
            s4Title.Size = new Size(100, 23);
            s4Title.TabIndex = 0;
            s4Title.Text = "ANUNCIOS";
            // 
            // s4Value
            // 
            s4Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            s4Value.ForeColor = Color.White;
            s4Value.Location = new Point(87, 17);
            s4Value.Name = "s4Value";
            s4Value.Size = new Size(100, 53);
            s4Value.TabIndex = 1;
            s4Value.Text = "2";
            // 
            // flowCards
            // 
            flowCards.BackColor = Color.Transparent;
            flowCards.BackgroundImage = (Image)resources.GetObject("flowCards.BackgroundImage");
            flowCards.Controls.Add(tarjetaAlgoritmos);
            flowCards.Controls.Add(tarjetaVariables);
            flowCards.Controls.Add(tarjetaCondicionales);
            flowCards.Controls.Add(tarjetaCiclos);
            flowCards.Location = new Point(267, 258);
            flowCards.Name = "flowCards";
            flowCards.Padding = new Padding(30);
            flowCards.Size = new Size(1000, 337);
            flowCards.TabIndex = 0;
            flowCards.WrapContents = false;
            // 
            // tarjetaAlgoritmos
            // 
            tarjetaAlgoritmos.BackColor = Color.FromArgb(11, 29, 68);
            tarjetaAlgoritmos.Controls.Add(lblNumeroAlgoritmos);
            tarjetaAlgoritmos.Controls.Add(lblIconoAlgoritmos);
            tarjetaAlgoritmos.Controls.Add(lblTituloAlgoritmos);
            tarjetaAlgoritmos.Controls.Add(lblDescripcionAlgoritmos);
            tarjetaAlgoritmos.Controls.Add(btnSeudocodigo);
            tarjetaAlgoritmos.Location = new Point(33, 33);
            tarjetaAlgoritmos.Name = "tarjetaAlgoritmos";
            tarjetaAlgoritmos.Size = new Size(230, 285);
            tarjetaAlgoritmos.TabIndex = 1;
            // 
            // lblNumeroAlgoritmos
            // 
            lblNumeroAlgoritmos.BackColor = Color.MediumPurple;
            lblNumeroAlgoritmos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroAlgoritmos.ForeColor = Color.White;
            lblNumeroAlgoritmos.Location = new Point(15, 15);
            lblNumeroAlgoritmos.Name = "lblNumeroAlgoritmos";
            lblNumeroAlgoritmos.Size = new Size(34, 34);
            lblNumeroAlgoritmos.TabIndex = 0;
            lblNumeroAlgoritmos.Text = "1";
            lblNumeroAlgoritmos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIconoAlgoritmos
            // 
            lblIconoAlgoritmos.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblIconoAlgoritmos.ForeColor = Color.MediumPurple;
            lblIconoAlgoritmos.Location = new Point(65, 55);
            lblIconoAlgoritmos.Name = "lblIconoAlgoritmos";
            lblIconoAlgoritmos.Size = new Size(105, 70);
            lblIconoAlgoritmos.TabIndex = 1;
            lblIconoAlgoritmos.Text = "📄 ";
            lblIconoAlgoritmos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloAlgoritmos
            // 
            lblTituloAlgoritmos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloAlgoritmos.ForeColor = Color.MediumPurple;
            lblTituloAlgoritmos.Location = new Point(15, 135);
            lblTituloAlgoritmos.Name = "lblTituloAlgoritmos";
            lblTituloAlgoritmos.Size = new Size(200, 35);
            lblTituloAlgoritmos.TabIndex = 2;
            lblTituloAlgoritmos.Text = "Crear contenido";
            lblTituloAlgoritmos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionAlgoritmos
            // 
            lblDescripcionAlgoritmos.ForeColor = Color.Gainsboro;
            lblDescripcionAlgoritmos.Location = new Point(18, 187);
            lblDescripcionAlgoritmos.Name = "lblDescripcionAlgoritmos";
            lblDescripcionAlgoritmos.Size = new Size(195, 55);
            lblDescripcionAlgoritmos.TabIndex = 3;
            lblDescripcionAlgoritmos.Text = "Crea y organiza lecciones, ejercicios y recursos para tus clases.\r\n";
            lblDescripcionAlgoritmos.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSeudocodigo
            // 
            btnSeudocodigo.BackColor = Color.Transparent;
            btnSeudocodigo.FlatStyle = FlatStyle.Flat;
            btnSeudocodigo.ForeColor = Color.MediumPurple;
            btnSeudocodigo.Location = new Point(18, 245);
            btnSeudocodigo.Name = "btnSeudocodigo";
            btnSeudocodigo.Size = new Size(194, 32);
            btnSeudocodigo.TabIndex = 4;
            btnSeudocodigo.Text = "Ir al módulo";
            btnSeudocodigo.UseVisualStyleBackColor = false;
            // 
            // tarjetaVariables
            // 
            tarjetaVariables.BackColor = Color.FromArgb(11, 29, 68);
            tarjetaVariables.Controls.Add(lblNumeroVariables);
            tarjetaVariables.Controls.Add(lblIconoVariables);
            tarjetaVariables.Controls.Add(lblTituloVariables);
            tarjetaVariables.Controls.Add(lblDescripcionVariables);
            tarjetaVariables.Controls.Add(btnVariables);
            tarjetaVariables.Location = new Point(269, 33);
            tarjetaVariables.Name = "tarjetaVariables";
            tarjetaVariables.Size = new Size(230, 285);
            tarjetaVariables.TabIndex = 2;
            // 
            // lblNumeroVariables
            // 
            lblNumeroVariables.BackColor = Color.MediumSeaGreen;
            lblNumeroVariables.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroVariables.ForeColor = Color.White;
            lblNumeroVariables.Location = new Point(15, 15);
            lblNumeroVariables.Name = "lblNumeroVariables";
            lblNumeroVariables.Size = new Size(34, 34);
            lblNumeroVariables.TabIndex = 0;
            lblNumeroVariables.Text = "2";
            lblNumeroVariables.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIconoVariables
            // 
            lblIconoVariables.Font = new Font("Consolas", 28F, FontStyle.Bold);
            lblIconoVariables.ForeColor = Color.MediumSeaGreen;
            lblIconoVariables.Location = new Point(55, 55);
            lblIconoVariables.Name = "lblIconoVariables";
            lblIconoVariables.Size = new Size(125, 70);
            lblIconoVariables.TabIndex = 1;
            lblIconoVariables.Text = "👥";
            lblIconoVariables.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloVariables
            // 
            lblTituloVariables.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloVariables.ForeColor = Color.MediumSeaGreen;
            lblTituloVariables.Location = new Point(18, 119);
            lblTituloVariables.Name = "lblTituloVariables";
            lblTituloVariables.Size = new Size(198, 67);
            lblTituloVariables.TabIndex = 2;
            lblTituloVariables.Text = " Gestionar estudiantes\r\n";
            lblTituloVariables.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionVariables
            // 
            lblDescripcionVariables.ForeColor = Color.Gainsboro;
            lblDescripcionVariables.Location = new Point(18, 187);
            lblDescripcionVariables.Name = "lblDescripcionVariables";
            lblDescripcionVariables.Size = new Size(209, 48);
            lblDescripcionVariables.TabIndex = 3;
            lblDescripcionVariables.Text = "Revisa el progreso, calificaciones y participación de tus estudiantes.";
            lblDescripcionVariables.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnVariables
            // 
            btnVariables.BackColor = Color.Transparent;
            btnVariables.FlatStyle = FlatStyle.Flat;
            btnVariables.ForeColor = Color.MediumSeaGreen;
            btnVariables.Location = new Point(18, 245);
            btnVariables.Name = "btnVariables";
            btnVariables.Size = new Size(194, 32);
            btnVariables.TabIndex = 4;
            btnVariables.Text = "Ir al módulo";
            btnVariables.UseVisualStyleBackColor = false;
            // 
            // tarjetaCondicionales
            // 
            tarjetaCondicionales.BackColor = Color.FromArgb(11, 29, 68);
            tarjetaCondicionales.Controls.Add(lblNumeroCondicionales);
            tarjetaCondicionales.Controls.Add(lblIconoCondicionales);
            tarjetaCondicionales.Controls.Add(lblTituloCondicionales);
            tarjetaCondicionales.Controls.Add(lblDescripcionCondicionales);
            tarjetaCondicionales.Controls.Add(btnCondicionales);
            tarjetaCondicionales.Location = new Point(505, 33);
            tarjetaCondicionales.Name = "tarjetaCondicionales";
            tarjetaCondicionales.Size = new Size(230, 285);
            tarjetaCondicionales.TabIndex = 3;
            // 
            // lblNumeroCondicionales
            // 
            lblNumeroCondicionales.BackColor = Color.Goldenrod;
            lblNumeroCondicionales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroCondicionales.ForeColor = Color.White;
            lblNumeroCondicionales.Location = new Point(15, 15);
            lblNumeroCondicionales.Name = "lblNumeroCondicionales";
            lblNumeroCondicionales.Size = new Size(34, 34);
            lblNumeroCondicionales.TabIndex = 0;
            lblNumeroCondicionales.Text = "3";
            lblNumeroCondicionales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIconoCondicionales
            // 
            lblIconoCondicionales.Font = new Font("Consolas", 30F, FontStyle.Bold);
            lblIconoCondicionales.ForeColor = Color.Goldenrod;
            lblIconoCondicionales.Location = new Point(65, 55);
            lblIconoCondicionales.Name = "lblIconoCondicionales";
            lblIconoCondicionales.Size = new Size(105, 70);
            lblIconoCondicionales.TabIndex = 1;
            lblIconoCondicionales.Text = "📊 ";
            lblIconoCondicionales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCondicionales
            // 
            lblTituloCondicionales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloCondicionales.ForeColor = Color.Goldenrod;
            lblTituloCondicionales.Location = new Point(15, 135);
            lblTituloCondicionales.Name = "lblTituloCondicionales";
            lblTituloCondicionales.Size = new Size(200, 35);
            lblTituloCondicionales.TabIndex = 2;
            lblTituloCondicionales.Text = "Reportes y análisis";
            lblTituloCondicionales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionCondicionales
            // 
            lblDescripcionCondicionales.ForeColor = Color.Gainsboro;
            lblDescripcionCondicionales.Location = new Point(18, 178);
            lblDescripcionCondicionales.Name = "lblDescripcionCondicionales";
            lblDescripcionCondicionales.Size = new Size(195, 55);
            lblDescripcionCondicionales.TabIndex = 3;
            lblDescripcionCondicionales.Text = "Visualiza estadísticas y reportes del desempeño del curso.";
            lblDescripcionCondicionales.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCondicionales
            // 
            btnCondicionales.BackColor = Color.Transparent;
            btnCondicionales.FlatStyle = FlatStyle.Flat;
            btnCondicionales.ForeColor = Color.Goldenrod;
            btnCondicionales.Location = new Point(18, 245);
            btnCondicionales.Name = "btnCondicionales";
            btnCondicionales.Size = new Size(194, 32);
            btnCondicionales.TabIndex = 4;
            btnCondicionales.Text = "Ir al módulo";
            btnCondicionales.UseVisualStyleBackColor = false;
            // 
            // tarjetaCiclos
            // 
            tarjetaCiclos.BackColor = Color.FromArgb(11, 29, 68);
            tarjetaCiclos.Controls.Add(lblNumeroCiclos);
            tarjetaCiclos.Controls.Add(lblIconoCiclos);
            tarjetaCiclos.Controls.Add(lblTituloCiclos);
            tarjetaCiclos.Controls.Add(lblDescripcionCiclos);
            tarjetaCiclos.Controls.Add(btnCiclos);
            tarjetaCiclos.Location = new Point(741, 33);
            tarjetaCiclos.Name = "tarjetaCiclos";
            tarjetaCiclos.Size = new Size(230, 285);
            tarjetaCiclos.TabIndex = 5;
            // 
            // lblNumeroCiclos
            // 
            lblNumeroCiclos.BackColor = Color.DodgerBlue;
            lblNumeroCiclos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumeroCiclos.ForeColor = Color.White;
            lblNumeroCiclos.Location = new Point(15, 15);
            lblNumeroCiclos.Name = "lblNumeroCiclos";
            lblNumeroCiclos.Size = new Size(34, 34);
            lblNumeroCiclos.TabIndex = 0;
            lblNumeroCiclos.Text = "4";
            lblNumeroCiclos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIconoCiclos
            // 
            lblIconoCiclos.Font = new Font("Segoe UI", 38F, FontStyle.Bold);
            lblIconoCiclos.ForeColor = Color.DodgerBlue;
            lblIconoCiclos.Location = new Point(67, 55);
            lblIconoCiclos.Name = "lblIconoCiclos";
            lblIconoCiclos.Size = new Size(103, 71);
            lblIconoCiclos.TabIndex = 1;
            lblIconoCiclos.Text = "📢";
            lblIconoCiclos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloCiclos
            // 
            lblTituloCiclos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloCiclos.ForeColor = Color.DodgerBlue;
            lblTituloCiclos.Location = new Point(-14, 135);
            lblTituloCiclos.Name = "lblTituloCiclos";
            lblTituloCiclos.Size = new Size(244, 35);
            lblTituloCiclos.TabIndex = 2;
            lblTituloCiclos.Text = "Foros y anuncios";
            lblTituloCiclos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcionCiclos
            // 
            lblDescripcionCiclos.ForeColor = Color.Gainsboro;
            lblDescripcionCiclos.Location = new Point(11, 178);
            lblDescripcionCiclos.Name = "lblDescripcionCiclos";
            lblDescripcionCiclos.Size = new Size(209, 55);
            lblDescripcionCiclos.TabIndex = 3;
            lblDescripcionCiclos.Text = "Publica anuncios y participa en foros con tus estudiantes.\r\n";
            lblDescripcionCiclos.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCiclos
            // 
            btnCiclos.BackColor = Color.Transparent;
            btnCiclos.FlatStyle = FlatStyle.Flat;
            btnCiclos.ForeColor = Color.DodgerBlue;
            btnCiclos.Location = new Point(18, 245);
            btnCiclos.Name = "btnCiclos";
            btnCiclos.Size = new Size(194, 32);
            btnCiclos.TabIndex = 4;
            btnCiclos.Text = "Ir al módulo";
            btnCiclos.UseVisualStyleBackColor = false;
            // 
            // btnAcceso3
            // 
            btnAcceso3.BackColor = Color.FromArgb(150, 90, 200);
            btnAcceso3.FlatStyle = FlatStyle.Flat;
            btnAcceso3.ForeColor = Color.White;
            btnAcceso3.Location = new Point(408, 50);
            btnAcceso3.Margin = new Padding(10);
            btnAcceso3.Name = "btnAcceso3";
            btnAcceso3.Size = new Size(200, 40);
            btnAcceso3.TabIndex = 2;
            btnAcceso3.Text = "Ver tareas";
            btnAcceso3.UseVisualStyleBackColor = false;
            // 
            // btnAcceso4
            // 
            btnAcceso4.BackColor = Color.FromArgb(45, 105, 200);
            btnAcceso4.FlatStyle = FlatStyle.Flat;
            btnAcceso4.ForeColor = Color.White;
            btnAcceso4.Location = new Point(16, 50);
            btnAcceso4.Margin = new Padding(10);
            btnAcceso4.Name = "btnAcceso4";
            btnAcceso4.Size = new Size(182, 40);
            btnAcceso4.TabIndex = 3;
            btnAcceso4.Text = "Calificaciones";
            btnAcceso4.UseVisualStyleBackColor = false;
            // 
            // btnAcceso5
            // 
            btnAcceso5.BackColor = Color.FromArgb(230, 120, 30);
            btnAcceso5.FlatStyle = FlatStyle.Flat;
            btnAcceso5.ForeColor = Color.White;
            btnAcceso5.Location = new Point(219, 50);
            btnAcceso5.Margin = new Padding(10);
            btnAcceso5.Name = "btnAcceso5";
            btnAcceso5.Size = new Size(156, 40);
            btnAcceso5.TabIndex = 4;
            btnAcceso5.Text = "Nuevo anuncio";
            btnAcceso5.UseVisualStyleBackColor = false;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.FromArgb(40, 180, 90);
            btnAgregarTarea.FlatStyle = FlatStyle.Flat;
            btnAgregarTarea.ForeColor = Color.White;
            btnAgregarTarea.Location = new Point(624, 50);
            btnAgregarTarea.Margin = new Padding(10);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(200, 40);
            btnAgregarTarea.TabIndex = 5;
            btnAgregarTarea.Text = "Agregar tarea";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAcceso4);
            panel1.Controls.Add(lblAccesos);
            panel1.Controls.Add(btnAcceso5);
            panel1.Controls.Add(btnAcceso3);
            panel1.Controls.Add(btnAgregarTarea);
            panel1.Location = new Point(258, 642);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 125);
            panel1.TabIndex = 5;
            // 
            // lblAccesos
            // 
            lblAccesos.BackColor = Color.Transparent;
            lblAccesos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAccesos.ForeColor = Color.White;
            lblAccesos.Location = new Point(3, 12);
            lblAccesos.Name = "lblAccesos";
            lblAccesos.Size = new Size(240, 28);
            lblAccesos.TabIndex = 1;
            lblAccesos.Text = "⚡  Accesos rápidos";
            // 
            // CodeNovaDashboard
            // 
            BackColor = Color.FromArgb(6, 18, 35);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1287, 800);
            Controls.Add(panel1);
            Controls.Add(flowCards);
            Controls.Add(panelStats);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CodeNovaDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            panelSidebar.ResumeLayout(false);
            tarjetaUsuario.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            stat1.ResumeLayout(false);
            stat2.ResumeLayout(false);
            stat3.ResumeLayout(false);
            stat4.ResumeLayout(false);
            flowCards.ResumeLayout(false);
            tarjetaAlgoritmos.ResumeLayout(false);
            tarjetaVariables.ResumeLayout(false);
            tarjetaCondicionales.ResumeLayout(false);
            tarjetaCiclos.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Label s1Title;
        private Label s1Value;
        private Label s2Title;
        private Label s2Value;
        private Label s3Title;
        private Label s3Value;
        private Label s4Title;
        private Label s4Value;
        private Label lblLogo;
        private Label lblNombre;
        private Label lblSistema;
        private Label lblCurso;
        private Panel tarjetaAlgoritmos;
        private Label lblNumeroAlgoritmos;
        private Label lblIconoAlgoritmos;
        private Label lblTituloAlgoritmos;
        private Label lblDescripcionAlgoritmos;
        private Button btnSeudocodigo;
        private Panel tarjetaVariables;
        private Label lblNumeroVariables;
        private Label lblIconoVariables;
        private Label lblTituloVariables;
        private Label lblDescripcionVariables;
        private Button btnVariables;
        private Panel tarjetaCondicionales;
        private Label lblNumeroCondicionales;
        private Label lblIconoCondicionales;
        private Label lblTituloCondicionales;
        private Label lblDescripcionCondicionales;
        private Button btnCondicionales;
        private Panel tarjetaCiclos;
        private Label lblNumeroCiclos;
        private Label lblIconoCiclos;
        private Label lblTituloCiclos;
        private Label lblDescripcionCiclos;
        private Button btnCiclos;
        private Panel panel1;
        private Label lblAccesos;
        private Button btnCerrarSesion;
        private Panel tarjetaUsuario;
        private Label lblAvatar;
        private Label lblUsuario;
        private Label lblRol;
    }
}
