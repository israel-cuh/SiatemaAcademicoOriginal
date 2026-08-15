namespace SistemaAcademico1
{
    partial class FrmUsoCondiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsoCondiciones));
            panel1 = new Panel();
            lblPagina = new Label();
            label1 = new Label();
            pnlRegresar = new Panel();
            lblRegresar = new Label();
            pnlContenido = new Panel();
            panel10 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            lblTitulo = new Label();
            panel2 = new Panel();
            pnlPractica = new Panel();
            panel5 = new Panel();
            cmbPregunta5 = new ComboBox();
            cmbPregunta4 = new ComboBox();
            cmbPregunta3 = new ComboBox();
            cmbPregunta2 = new ComboBox();
            cmbPregunta1 = new ComboBox();
            lblResultado = new Label();
            btnComprobar = new Button();
            label6 = new Label();
            label5 = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            panel1.SuspendLayout();
            pnlRegresar.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlPractica.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblPagina);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pnlRegresar);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 81);
            panel1.TabIndex = 5;
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagina.ForeColor = SystemColors.ButtonFace;
            lblPagina.Location = new Point(1076, 32);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(50, 31);
            lblPagina.TabIndex = 3;
            lblPagina.Text = "4/5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(506, 21);
            label1.Name = "label1";
            label1.Size = new Size(324, 38);
            label1.TabIndex = 2;
            label1.Text = "OPERADORES LÓGICOS";
            // 
            // pnlRegresar
            // 
            pnlRegresar.BackColor = Color.Transparent;
            pnlRegresar.Controls.Add(lblRegresar);
            pnlRegresar.Location = new Point(18, 21);
            pnlRegresar.Name = "pnlRegresar";
            pnlRegresar.Size = new Size(164, 44);
            pnlRegresar.TabIndex = 1;
            pnlRegresar.Click += pnlRegresar_Click;
            // 
            // lblRegresar
            // 
            lblRegresar.AutoSize = true;
            lblRegresar.BackColor = Color.Transparent;
            lblRegresar.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegresar.ForeColor = Color.DarkViolet;
            lblRegresar.Location = new Point(16, 6);
            lblRegresar.Name = "lblRegresar";
            lblRegresar.Size = new Size(126, 27);
            lblRegresar.TabIndex = 1;
            lblRegresar.Text = "← Regresar ";
            lblRegresar.Click += lblRegresar_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.BackColor = Color.MidnightBlue;
            pnlContenido.Controls.Add(panel10);
            pnlContenido.Controls.Add(panel3);
            pnlContenido.Controls.Add(label2);
            pnlContenido.Controls.Add(lblTitulo);
            pnlContenido.Controls.Add(panel2);
            pnlContenido.Location = new Point(12, 99);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(714, 599);
            pnlContenido.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackgroundImage = (Image)resources.GetObject("panel10.BackgroundImage");
            panel10.BackgroundImageLayout = ImageLayout.Zoom;
            panel10.Location = new Point(45, 438);
            panel10.Name = "panel10";
            panel10.Size = new Size(492, 148);
            panel10.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(133, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(475, 288);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(124, 59);
            label2.Name = "label2";
            label2.Size = new Size(535, 56);
            label2.TabIndex = 2;
            label2.Text = "Las condiciones permiten tomar decisiones en un programa \r\nsegún se cumpla o no una expresión lógica.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Magenta;
            lblTitulo.Location = new Point(124, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(444, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "¿QUÉ SON LAS CONDICIONES?";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(24, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 104);
            panel2.TabIndex = 0;
            // 
            // pnlPractica
            // 
            pnlPractica.BackColor = Color.MidnightBlue;
            pnlPractica.Controls.Add(panel5);
            pnlPractica.Controls.Add(lblResultado);
            pnlPractica.Controls.Add(btnComprobar);
            pnlPractica.Controls.Add(label6);
            pnlPractica.Controls.Add(label5);
            pnlPractica.Location = new Point(732, 99);
            pnlPractica.Name = "pnlPractica";
            pnlPractica.Size = new Size(487, 599);
            pnlPractica.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Controls.Add(cmbPregunta5);
            panel5.Controls.Add(cmbPregunta4);
            panel5.Controls.Add(cmbPregunta3);
            panel5.Controls.Add(cmbPregunta2);
            panel5.Controls.Add(cmbPregunta1);
            panel5.Location = new Point(10, 84);
            panel5.Name = "panel5";
            panel5.Size = new Size(477, 371);
            panel5.TabIndex = 5;
            // 
            // cmbPregunta5
            // 
            cmbPregunta5.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPregunta5.FormattingEnabled = true;
            cmbPregunta5.Location = new Point(88, 318);
            cmbPregunta5.Name = "cmbPregunta5";
            cmbPregunta5.Size = new Size(74, 28);
            cmbPregunta5.TabIndex = 4;
            // 
            // cmbPregunta4
            // 
            cmbPregunta4.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPregunta4.FormattingEnabled = true;
            cmbPregunta4.Location = new Point(176, 247);
            cmbPregunta4.Name = "cmbPregunta4";
            cmbPregunta4.Size = new Size(74, 28);
            cmbPregunta4.TabIndex = 3;
            // 
            // cmbPregunta3
            // 
            cmbPregunta3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPregunta3.FormattingEnabled = true;
            cmbPregunta3.Location = new Point(88, 187);
            cmbPregunta3.Name = "cmbPregunta3";
            cmbPregunta3.Size = new Size(74, 28);
            cmbPregunta3.TabIndex = 2;
            // 
            // cmbPregunta2
            // 
            cmbPregunta2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPregunta2.FormattingEnabled = true;
            cmbPregunta2.Location = new Point(214, 124);
            cmbPregunta2.Name = "cmbPregunta2";
            cmbPregunta2.Size = new Size(74, 28);
            cmbPregunta2.TabIndex = 1;
            // 
            // cmbPregunta1
            // 
            cmbPregunta1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPregunta1.FormattingEnabled = true;
            cmbPregunta1.Location = new Point(167, 61);
            cmbPregunta1.Name = "cmbPregunta1";
            cmbPregunta1.Size = new Size(74, 28);
            cmbPregunta1.TabIndex = 0;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ButtonFace;
            lblResultado.Location = new Point(10, 506);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(18, 23);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "ll";
            // 
            // btnComprobar
            // 
            btnComprobar.BackColor = Color.DarkOrchid;
            btnComprobar.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprobar.ForeColor = SystemColors.ButtonHighlight;
            btnComprobar.Location = new Point(147, 461);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(165, 40);
            btnComprobar.TabIndex = 3;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = false;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(24, 31);
            label6.Name = "label6";
            label6.Size = new Size(372, 50);
            label6.TabIndex = 1;
            label6.Text = "Completa el operador lógico que falta en \r\ncada condición. Selecciona la opción correcta.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Fuchsia;
            label5.Location = new Point(37, 0);
            label5.Name = "label5";
            label5.Size = new Size(275, 31);
            label5.TabIndex = 0;
            label5.Text = "🎯 Practica lo aprendido";
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.BlueViolet;
            btnAnterior.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = SystemColors.ButtonHighlight;
            btnAnterior.Location = new Point(426, 704);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(183, 44);
            btnAnterior.TabIndex = 14;
            btnAnterior.Text = " <<Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.BlueViolet;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(639, 704);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(187, 44);
            btnSiguiente.TabIndex = 15;
            btnSiguiente.Text = "Siguiente >>";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FrmUsoCondiciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1231, 753);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(pnlPractica);
            Controls.Add(pnlContenido);
            Controls.Add(panel1);
            Name = "FrmUsoCondiciones";
            Text = "FrmUsoCondiciones";
            Load += FrmUsoCondiciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlRegresar.ResumeLayout(false);
            pnlRegresar.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            pnlPractica.ResumeLayout(false);
            pnlPractica.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPagina;
        private Label label1;
        private Panel pnlRegresar;
        private Label lblRegresar;
        private Panel pnlContenido;
        private Panel panel10;
        private Panel panel3;
        private Label label2;
        private Label lblTitulo;
        private Panel panel2;
        private Panel pnlPractica;
        private Panel panel5;
        private Label lblResultado;
        private Button btnComprobar;
        private Label label6;
        private Label label5;
        private ComboBox cmbPregunta5;
        private ComboBox cmbPregunta4;
        private ComboBox cmbPregunta3;
        private ComboBox cmbPregunta2;
        private ComboBox cmbPregunta1;
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}