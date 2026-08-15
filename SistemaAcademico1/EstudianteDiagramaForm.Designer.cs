using System.Windows.Forms;

namespace SistemaAcademico1
{
    partial class EstudianteDiagramaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar22 = new System.Windows.Forms.Button();
            this.panelTeoria = new System.Windows.Forms.Panel();
            this.btnVerEjemplo = new System.Windows.Forms.Button();
            this.txtTeoriaEstudiante = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConcepto01 = new System.Windows.Forms.Button();
            this.btnInicio_Fin01 = new System.Windows.Forms.Button();
            this.btnProceso01 = new System.Windows.Forms.Button();
            this.btnLinea01 = new System.Windows.Forms.Button();
            this.btnEntrada_Salida01 = new System.Windows.Forms.Button();
            this.btnDesición01 = new System.Windows.Forms.Button();
            this.btnImpresora01 = new System.Windows.Forms.Button();
            this.btnPantalla01 = new System.Windows.Forms.Button();
            this.btnEntrada01 = new System.Windows.Forms.Button();
            this.btnTeclado01 = new System.Windows.Forms.Button();
            this.btnConectorEnPagina01 = new System.Windows.Forms.Button();
            this.btnConectorFuera01 = new System.Windows.Forms.Button();
            this.picSimboloEstudiante = new System.Windows.Forms.PictureBox();
            this.lblTituloTeoria = new System.Windows.Forms.Label();
            this.panelQuiz = new System.Windows.Forms.Panel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.SigcheckBox4 = new System.Windows.Forms.CheckBox();
            this.SigcheckBox3 = new System.Windows.Forms.CheckBox();
            this.SigcheckBox2 = new System.Windows.Forms.CheckBox();
            this.SigcheckBox1 = new System.Windows.Forms.CheckBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblTituloQuiz = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelTeoria.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSimboloEstudiante)).BeginInit();
            this.panelQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panelHeader.Controls.Add(this.lblContador);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.btnRegresar22);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1244, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.ForeColor = System.Drawing.Color.White;
            this.lblContador.Location = new System.Drawing.Point(1070, 12);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(50, 31);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "1/5";
            this.lblContador.Click += new System.EventHandler(this.lblContador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIAGRAMAS DE FLUJO";
            // 
            // btnRegresar22
            // 
            this.btnRegresar22.AutoSize = true;
            this.btnRegresar22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar22.ForeColor = System.Drawing.Color.Magenta;
            this.btnRegresar22.Location = new System.Drawing.Point(49, 12);
            this.btnRegresar22.Name = "btnRegresar22";
            this.btnRegresar22.Size = new System.Drawing.Size(162, 35);
            this.btnRegresar22.TabIndex = 0;
            this.btnRegresar22.Text = "← Regresar";
            this.btnRegresar22.UseVisualStyleBackColor = true;
            this.btnRegresar22.Click += new System.EventHandler(this.btnRegresar22_Click);
            // 
            // panelTeoria
            // 
            this.panelTeoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panelTeoria.Controls.Add(this.btnVerEjemplo);
            this.panelTeoria.Controls.Add(this.txtTeoriaEstudiante);
            this.panelTeoria.Controls.Add(this.flowLayoutPanel1);
            this.panelTeoria.Controls.Add(this.picSimboloEstudiante);
            this.panelTeoria.Controls.Add(this.lblTituloTeoria);
            this.panelTeoria.Location = new System.Drawing.Point(21, 66);
            this.panelTeoria.Name = "panelTeoria";
            this.panelTeoria.Size = new System.Drawing.Size(667, 480);
            this.panelTeoria.TabIndex = 1;
            this.panelTeoria.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTeoria_Paint);
            // 
            // btnVerEjemplo
            // 
            this.btnVerEjemplo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.btnVerEjemplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEjemplo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnVerEjemplo.ForeColor = System.Drawing.Color.Magenta;
            this.btnVerEjemplo.Location = new System.Drawing.Point(500, 344);
            this.btnVerEjemplo.Name = "btnVerEjemplo";
            this.btnVerEjemplo.Size = new System.Drawing.Size(122, 59);
            this.btnVerEjemplo.TabIndex = 4;
            this.btnVerEjemplo.Text = "Ver Ejemplo 👁️";
            this.btnVerEjemplo.UseVisualStyleBackColor = false;
            this.btnVerEjemplo.Click += new System.EventHandler(this.btnVerEjemplo_Click);
            // 
            // txtTeoriaEstudiante
            // 
            this.txtTeoriaEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.txtTeoriaEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeoriaEstudiante.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTeoriaEstudiante.ForeColor = System.Drawing.Color.White;
            this.txtTeoriaEstudiante.Location = new System.Drawing.Point(227, 78);
            this.txtTeoriaEstudiante.Multiline = true;
            this.txtTeoriaEstudiante.Name = "txtTeoriaEstudiante";
            this.txtTeoriaEstudiante.ReadOnly = true;
            this.txtTeoriaEstudiante.Size = new System.Drawing.Size(433, 218);
            this.txtTeoriaEstudiante.TabIndex = 3;
            this.txtTeoriaEstudiante.TextChanged += new System.EventHandler(this.txtTeoriaEstudiante_TextChanged_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.btnConcepto01);
            this.flowLayoutPanel1.Controls.Add(this.btnInicio_Fin01);
            this.flowLayoutPanel1.Controls.Add(this.btnProceso01);
            this.flowLayoutPanel1.Controls.Add(this.btnLinea01);
            this.flowLayoutPanel1.Controls.Add(this.btnEntrada_Salida01);
            this.flowLayoutPanel1.Controls.Add(this.btnDesición01);
            this.flowLayoutPanel1.Controls.Add(this.btnImpresora01);
            this.flowLayoutPanel1.Controls.Add(this.btnPantalla01);
            this.flowLayoutPanel1.Controls.Add(this.btnEntrada01);
            this.flowLayoutPanel1.Controls.Add(this.btnTeclado01);
            this.flowLayoutPanel1.Controls.Add(this.btnConectorEnPagina01);
            this.flowLayoutPanel1.Controls.Add(this.btnConectorFuera01);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 350);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnConcepto01
            // 
            this.btnConcepto01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcepto01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnConcepto01.ForeColor = System.Drawing.Color.White;
            this.btnConcepto01.Location = new System.Drawing.Point(3, 3);
            this.btnConcepto01.Name = "btnConcepto01";
            this.btnConcepto01.Size = new System.Drawing.Size(180, 35);
            this.btnConcepto01.TabIndex = 3;
            this.btnConcepto01.Text = "[CONCEPTO]";
            this.btnConcepto01.UseVisualStyleBackColor = true;
            this.btnConcepto01.Click += new System.EventHandler(this.btnConcepto01_Click);
            // 
            // btnInicio_Fin01
            // 
            this.btnInicio_Fin01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio_Fin01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnInicio_Fin01.ForeColor = System.Drawing.Color.White;
            this.btnInicio_Fin01.Location = new System.Drawing.Point(3, 44);
            this.btnInicio_Fin01.Name = "btnInicio_Fin01";
            this.btnInicio_Fin01.Size = new System.Drawing.Size(180, 35);
            this.btnInicio_Fin01.TabIndex = 4;
            this.btnInicio_Fin01.Text = "[INICIO / FIN]";
            this.btnInicio_Fin01.UseVisualStyleBackColor = true;
            this.btnInicio_Fin01.Click += new System.EventHandler(this.btnInicio_Fin01_Click);
            // 
            // btnProceso01
            // 
            this.btnProceso01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceso01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnProceso01.ForeColor = System.Drawing.Color.White;
            this.btnProceso01.Location = new System.Drawing.Point(3, 85);
            this.btnProceso01.Name = "btnProceso01";
            this.btnProceso01.Size = new System.Drawing.Size(180, 35);
            this.btnProceso01.TabIndex = 6;
            this.btnProceso01.Text = "[PROCESO]";
            this.btnProceso01.UseVisualStyleBackColor = true;
            this.btnProceso01.Click += new System.EventHandler(this.btnProceso01_Click);
            // 
            // btnLinea01
            // 
            this.btnLinea01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinea01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnLinea01.ForeColor = System.Drawing.Color.White;
            this.btnLinea01.Location = new System.Drawing.Point(3, 126);
            this.btnLinea01.Name = "btnLinea01";
            this.btnLinea01.Size = new System.Drawing.Size(180, 35);
            this.btnLinea01.TabIndex = 5;
            this.btnLinea01.Text = "[LINEA DE FLUJO]";
            this.btnLinea01.UseVisualStyleBackColor = true;
            this.btnLinea01.Click += new System.EventHandler(this.btnLinea01_Click);
            // 
            // btnEntrada_Salida01
            // 
            this.btnEntrada_Salida01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada_Salida01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntrada_Salida01.ForeColor = System.Drawing.Color.White;
            this.btnEntrada_Salida01.Location = new System.Drawing.Point(3, 167);
            this.btnEntrada_Salida01.Name = "btnEntrada_Salida01";
            this.btnEntrada_Salida01.Size = new System.Drawing.Size(180, 35);
            this.btnEntrada_Salida01.TabIndex = 7;
            this.btnEntrada_Salida01.Text = "[ENTRADA/SALIDA]";
            this.btnEntrada_Salida01.UseVisualStyleBackColor = true;
            this.btnEntrada_Salida01.Click += new System.EventHandler(this.btnEntrada_Salida01_Click);
            // 
            // btnDesición01
            // 
            this.btnDesición01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesición01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnDesición01.ForeColor = System.Drawing.Color.White;
            this.btnDesición01.Location = new System.Drawing.Point(3, 208);
            this.btnDesición01.Name = "btnDesición01";
            this.btnDesición01.Size = new System.Drawing.Size(180, 35);
            this.btnDesición01.TabIndex = 8;
            this.btnDesición01.Text = "[DECISIÓN]";
            this.btnDesición01.UseVisualStyleBackColor = true;
            this.btnDesición01.Click += new System.EventHandler(this.btnDesición01_Click);
            // 
            // btnImpresora01
            // 
            this.btnImpresora01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresora01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnImpresora01.ForeColor = System.Drawing.Color.White;
            this.btnImpresora01.Location = new System.Drawing.Point(3, 249);
            this.btnImpresora01.Name = "btnImpresora01";
            this.btnImpresora01.Size = new System.Drawing.Size(180, 35);
            this.btnImpresora01.TabIndex = 9;
            this.btnImpresora01.Text = "[IMPRESORA]";
            this.btnImpresora01.UseVisualStyleBackColor = true;
            this.btnImpresora01.Click += new System.EventHandler(this.btnImpresora01_Click);
            // 
            // btnPantalla01
            // 
            this.btnPantalla01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantalla01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnPantalla01.ForeColor = System.Drawing.Color.White;
            this.btnPantalla01.Location = new System.Drawing.Point(3, 290);
            this.btnPantalla01.Name = "btnPantalla01";
            this.btnPantalla01.Size = new System.Drawing.Size(180, 35);
            this.btnPantalla01.TabIndex = 10;
            this.btnPantalla01.Text = "[PANTALLA]";
            this.btnPantalla01.UseVisualStyleBackColor = true;
            this.btnPantalla01.Click += new System.EventHandler(this.btnPantalla01_Click);
            // 
            // btnEntrada01
            // 
            this.btnEntrada01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnEntrada01.ForeColor = System.Drawing.Color.White;
            this.btnEntrada01.Location = new System.Drawing.Point(3, 331);
            this.btnEntrada01.Name = "btnEntrada01";
            this.btnEntrada01.Size = new System.Drawing.Size(180, 35);
            this.btnEntrada01.TabIndex = 11;
            this.btnEntrada01.Text = "[ENTRADA]";
            this.btnEntrada01.UseVisualStyleBackColor = true;
            this.btnEntrada01.Click += new System.EventHandler(this.btnEntrada01_Click);
            // 
            // btnTeclado01
            // 
            this.btnTeclado01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeclado01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnTeclado01.ForeColor = System.Drawing.Color.White;
            this.btnTeclado01.Location = new System.Drawing.Point(3, 372);
            this.btnTeclado01.Name = "btnTeclado01";
            this.btnTeclado01.Size = new System.Drawing.Size(180, 35);
            this.btnTeclado01.TabIndex = 12;
            this.btnTeclado01.Text = "[TECLADO]";
            this.btnTeclado01.UseVisualStyleBackColor = true;
            this.btnTeclado01.Click += new System.EventHandler(this.btnTeclado01_Click);
            // 
            // btnConectorEnPagina01
            // 
            this.btnConectorEnPagina01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectorEnPagina01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnConectorEnPagina01.ForeColor = System.Drawing.Color.White;
            this.btnConectorEnPagina01.Location = new System.Drawing.Point(3, 413);
            this.btnConectorEnPagina01.Name = "btnConectorEnPagina01";
            this.btnConectorEnPagina01.Size = new System.Drawing.Size(180, 35);
            this.btnConectorEnPagina01.TabIndex = 13;
            this.btnConectorEnPagina01.Text = "[CONECTOR ◯]";
            this.btnConectorEnPagina01.UseVisualStyleBackColor = true;
            this.btnConectorEnPagina01.Click += new System.EventHandler(this.btnConectorEnPagina01_Click);
            // 
            // btnConectorFuera01
            // 
            this.btnConectorFuera01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectorFuera01.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnConectorFuera01.ForeColor = System.Drawing.Color.White;
            this.btnConectorFuera01.Location = new System.Drawing.Point(3, 454);
            this.btnConectorFuera01.Name = "btnConectorFuera01";
            this.btnConectorFuera01.Size = new System.Drawing.Size(180, 35);
            this.btnConectorFuera01.TabIndex = 14;
            this.btnConectorFuera01.Text = "[CONECTOR ∇]";
            this.btnConectorFuera01.UseVisualStyleBackColor = true;
            this.btnConectorFuera01.Click += new System.EventHandler(this.btnConectorFuera01_Click);
            // 
            // picSimboloEstudiante
            // 
            this.picSimboloEstudiante.Location = new System.Drawing.Point(261, 302);
            this.picSimboloEstudiante.Name = "picSimboloEstudiante";
            this.picSimboloEstudiante.Size = new System.Drawing.Size(208, 162);
            this.picSimboloEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSimboloEstudiante.TabIndex = 1;
            this.picSimboloEstudiante.TabStop = false;
            // 
            // lblTituloTeoria
            // 
            this.lblTituloTeoria.AutoSize = true;
            this.lblTituloTeoria.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTeoria.ForeColor = System.Drawing.Color.Cyan;
            this.lblTituloTeoria.Location = new System.Drawing.Point(91, 13);
            this.lblTituloTeoria.Name = "lblTituloTeoria";
            this.lblTituloTeoria.Size = new System.Drawing.Size(357, 31);
            this.lblTituloTeoria.TabIndex = 0;
            this.lblTituloTeoria.Text = "¿Qué es un Diagrama de Flujo?";
            // 
            // panelQuiz
            // 
            this.panelQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panelQuiz.Controls.Add(this.btnAnterior);
            this.panelQuiz.Controls.Add(this.btnSiguiente);
            this.panelQuiz.Controls.Add(this.btnComprobar);
            this.panelQuiz.Controls.Add(this.SigcheckBox4);
            this.panelQuiz.Controls.Add(this.SigcheckBox3);
            this.panelQuiz.Controls.Add(this.SigcheckBox2);
            this.panelQuiz.Controls.Add(this.SigcheckBox1);
            this.panelQuiz.Controls.Add(this.lblPregunta);
            this.panelQuiz.Controls.Add(this.lblTituloQuiz);
            this.panelQuiz.Location = new System.Drawing.Point(705, 66);
            this.panelQuiz.Name = "panelQuiz";
            this.panelQuiz.Size = new System.Drawing.Size(516, 480);
            this.panelQuiz.TabIndex = 2;
            this.panelQuiz.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuiz_Paint);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(292, 390);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(61, 38);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.Text = "◀◀";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(359, 390);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(61, 38);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "▶▶";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobar.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnComprobar.ForeColor = System.Drawing.Color.White;
            this.btnComprobar.Location = new System.Drawing.Point(112, 390);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(143, 38);
            this.btnComprobar.TabIndex = 6;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click_1);
            // 
            // SigcheckBox4
            // 
            this.SigcheckBox4.AutoSize = true;
            this.SigcheckBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SigcheckBox4.ForeColor = System.Drawing.Color.White;
            this.SigcheckBox4.Location = new System.Drawing.Point(45, 241);
            this.SigcheckBox4.Name = "SigcheckBox4";
            this.SigcheckBox4.Size = new System.Drawing.Size(149, 27);
            this.SigcheckBox4.TabIndex = 5;
            this.SigcheckBox4.Text = "Paralelogramo";
            this.SigcheckBox4.UseVisualStyleBackColor = true;
            // 
            // SigcheckBox3
            // 
            this.SigcheckBox3.AutoSize = true;
            this.SigcheckBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SigcheckBox3.ForeColor = System.Drawing.Color.White;
            this.SigcheckBox3.Location = new System.Drawing.Point(46, 208);
            this.SigcheckBox3.Name = "SigcheckBox3";
            this.SigcheckBox3.Size = new System.Drawing.Size(78, 27);
            this.SigcheckBox3.TabIndex = 4;
            this.SigcheckBox3.Text = "Óvalo";
            this.SigcheckBox3.UseVisualStyleBackColor = true;
            // 
            // SigcheckBox2
            // 
            this.SigcheckBox2.AutoSize = true;
            this.SigcheckBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SigcheckBox2.ForeColor = System.Drawing.Color.White;
            this.SigcheckBox2.Location = new System.Drawing.Point(45, 167);
            this.SigcheckBox2.Name = "SigcheckBox2";
            this.SigcheckBox2.Size = new System.Drawing.Size(122, 27);
            this.SigcheckBox2.TabIndex = 3;
            this.SigcheckBox2.Text = "Rectángulo";
            this.SigcheckBox2.UseVisualStyleBackColor = true;
            // 
            // SigcheckBox1
            // 
            this.SigcheckBox1.AutoSize = true;
            this.SigcheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SigcheckBox1.ForeColor = System.Drawing.Color.White;
            this.SigcheckBox1.Location = new System.Drawing.Point(45, 127);
            this.SigcheckBox1.Name = "SigcheckBox1";
            this.SigcheckBox1.Size = new System.Drawing.Size(90, 27);
            this.SigcheckBox1.TabIndex = 2;
            this.SigcheckBox1.Text = "Rombo";
            this.SigcheckBox1.UseVisualStyleBackColor = true;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblPregunta.Location = new System.Drawing.Point(15, 57);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(472, 25);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "Selecciona los símbolos que representan una decisión:";
            this.lblPregunta.Click += new System.EventHandler(this.lblPregunta_Click);
            // 
            // lblTituloQuiz
            // 
            this.lblTituloQuiz.AutoSize = true;
            this.lblTituloQuiz.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTituloQuiz.ForeColor = System.Drawing.Color.Cyan;
            this.lblTituloQuiz.Location = new System.Drawing.Point(147, 13);
            this.lblTituloQuiz.Name = "lblTituloQuiz";
            this.lblTituloQuiz.Size = new System.Drawing.Size(273, 31);
            this.lblTituloQuiz.TabIndex = 0;
            this.lblTituloQuiz.Text = "¡Practica lo aprendido!";
            // 
            // EstudianteDiagramaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1244, 555);
            this.Controls.Add(this.panelQuiz);
            this.Controls.Add(this.panelTeoria);
            this.Controls.Add(this.panelHeader);
            this.Name = "EstudianteDiagramaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstudianteDiagramaForm";
            this.Load += new System.EventHandler(this.EstudianteDiagramaForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTeoria.ResumeLayout(false);
            this.panelTeoria.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSimboloEstudiante)).EndInit();
            this.panelQuiz.ResumeLayout(false);
            this.panelQuiz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelTeoria;
        private System.Windows.Forms.Panel panelQuiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar22;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.PictureBox picSimboloEstudiante;
        private System.Windows.Forms.Label lblTituloTeoria;
        private System.Windows.Forms.Label lblTituloQuiz;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.CheckBox SigcheckBox1;
        private System.Windows.Forms.CheckBox SigcheckBox4;
        private System.Windows.Forms.CheckBox SigcheckBox3;
        private System.Windows.Forms.CheckBox SigcheckBox2;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConcepto01;
        private System.Windows.Forms.Button btnInicio_Fin01;
        private System.Windows.Forms.Button btnLinea01;
        private System.Windows.Forms.Button btnProceso01;
        private System.Windows.Forms.Button btnEntrada_Salida01;
        private System.Windows.Forms.Button btnDesición01;
        private System.Windows.Forms.Button btnImpresora01;
        private System.Windows.Forms.Button btnPantalla01;
        private System.Windows.Forms.Button btnEntrada01;
        private System.Windows.Forms.Button btnTeclado01;
        private System.Windows.Forms.Button btnConectorEnPagina01;
        private System.Windows.Forms.Button btnConectorFuera01;
        private System.Windows.Forms.TextBox txtTeoriaEstudiante;
        private System.Windows.Forms.Button btnVerEjemplo;
    }
}
