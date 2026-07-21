namespace SistemaAcademico1
{
    partial class FrmDeclaracionVariables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeclaracionVariables));
            panel1 = new Panel();
            lblPagina = new Label();
            label1 = new Label();
            pnlRegresar = new Panel();
            lblRegresar = new Label();
            pnlContenido = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            lblTitulo = new Label();
            panel2 = new Panel();
            pnlPractica = new Panel();
            lblResultado = new Label();
            btnComprobar = new Button();
            panel5 = new Panel();
            cmbLetra = new ComboBox();
            cmbActivo = new ComboBox();
            cmbPromedio = new ComboBox();
            cmbEdad = new ComboBox();
            cmbNombre = new ComboBox();
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
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 81);
            panel1.TabIndex = 1;
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
            lblPagina.Text = "2/5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(571, 27);
            label1.Name = "label1";
            label1.Size = new Size(165, 38);
            label1.TabIndex = 2;
            label1.Text = "VARIABLES";
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
            pnlContenido.Controls.Add(label4);
            pnlContenido.Controls.Add(label3);
            pnlContenido.Controls.Add(panel4);
            pnlContenido.Controls.Add(panel3);
            pnlContenido.Controls.Add(label2);
            pnlContenido.Controls.Add(lblTitulo);
            pnlContenido.Controls.Add(panel2);
            pnlContenido.Location = new Point(12, 108);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(755, 571);
            pnlContenido.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(172, 397);
            label4.Name = "label4";
            label4.Size = new Size(525, 50);
            label4.TabIndex = 6;
            label4.Text = "Cada variable debe tener un nombre que describa la información\r\nque almacena.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(163, 357);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 5;
            label3.Text = "Recuerda:";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(49, 362);
            panel4.Name = "panel4";
            panel4.Size = new Size(95, 84);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(160, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 188);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(150, 82);
            label2.Name = "label2";
            label2.Size = new Size(457, 28);
            label2.TabIndex = 2;
            label2.Text = "Una variable necesita un tipo de dato y un nombre.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Magenta;
            lblTitulo.Location = new Point(137, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(358, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = " Declaración de variables";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(24, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 112);
            panel2.TabIndex = 0;
            // 
            // pnlPractica
            // 
            pnlPractica.BackColor = Color.MidnightBlue;
            pnlPractica.Controls.Add(lblResultado);
            pnlPractica.Controls.Add(btnComprobar);
            pnlPractica.Controls.Add(panel5);
            pnlPractica.Controls.Add(label6);
            pnlPractica.Controls.Add(label5);
            pnlPractica.Location = new Point(773, 108);
            pnlPractica.Name = "pnlPractica";
            pnlPractica.Size = new Size(446, 571);
            pnlPractica.TabIndex = 3;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ButtonFace;
            lblResultado.Location = new Point(36, 491);
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
            btnComprobar.Location = new Point(131, 440);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(165, 40);
            btnComprobar.TabIndex = 3;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = false;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(cmbLetra);
            panel5.Controls.Add(cmbActivo);
            panel5.Controls.Add(cmbPromedio);
            panel5.Controls.Add(cmbEdad);
            panel5.Controls.Add(cmbNombre);
            panel5.Location = new Point(23, 134);
            panel5.Name = "panel5";
            panel5.Size = new Size(397, 300);
            panel5.TabIndex = 2;
            // 
            // cmbLetra
            // 
            cmbLetra.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLetra.FormattingEnabled = true;
            cmbLetra.Location = new Point(192, 258);
            cmbLetra.Name = "cmbLetra";
            cmbLetra.Size = new Size(172, 28);
            cmbLetra.TabIndex = 4;
            // 
            // cmbActivo
            // 
            cmbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivo.FormattingEnabled = true;
            cmbActivo.Location = new Point(190, 209);
            cmbActivo.Name = "cmbActivo";
            cmbActivo.Size = new Size(174, 28);
            cmbActivo.TabIndex = 3;
            // 
            // cmbPromedio
            // 
            cmbPromedio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPromedio.FormattingEnabled = true;
            cmbPromedio.Location = new Point(192, 159);
            cmbPromedio.Name = "cmbPromedio";
            cmbPromedio.Size = new Size(172, 28);
            cmbPromedio.TabIndex = 2;
            // 
            // cmbEdad
            // 
            cmbEdad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEdad.FormattingEnabled = true;
            cmbEdad.Location = new Point(192, 110);
            cmbEdad.Name = "cmbEdad";
            cmbEdad.Size = new Size(172, 28);
            cmbEdad.TabIndex = 1;
            // 
            // cmbNombre
            // 
            cmbNombre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNombre.FormattingEnabled = true;
            cmbNombre.Location = new Point(190, 59);
            cmbNombre.Name = "cmbNombre";
            cmbNombre.Size = new Size(174, 28);
            cmbNombre.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(23, 43);
            label6.Name = "label6";
            label6.Size = new Size(368, 75);
            label6.TabIndex = 1;
            label6.Text = "Completa la tabla asignando un tipo de dato\r\nadecuado a cada variable según la \r\ninformación que almacenará.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Fuchsia;
            label5.Location = new Point(36, 12);
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
            btnAnterior.Location = new Point(389, 697);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(183, 44);
            btnAnterior.TabIndex = 4;
            btnAnterior.Text = " <<Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.BlueViolet;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(598, 697);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(187, 44);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "Siguiente >>";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FrmDeclaracionVariables
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
            Name = "FrmDeclaracionVariables";
            Text = "FrmDeclaracionVariables";
            Load += FrmDeclaracionVariables_Load;
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
        private Panel pnlPractica;
        private Label lblTitulo;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Panel panel3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Panel panel5;
        private ComboBox cmbLetra;
        private ComboBox cmbActivo;
        private ComboBox cmbPromedio;
        private ComboBox cmbEdad;
        private ComboBox cmbNombre;
        private Label lblResultado;
        private Button btnComprobar;
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}