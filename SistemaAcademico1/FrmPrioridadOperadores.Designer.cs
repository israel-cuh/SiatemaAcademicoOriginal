namespace SistemaAcademico1
{
    partial class FrmPrioridadOperadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrioridadOperadores));
            panel1 = new Panel();
            lblPagina = new Label();
            label1 = new Label();
            pnlRegresar = new Panel();
            lblRegresar = new Label();
            pnlContenido = new Panel();
            panel13 = new Panel();
            panel12 = new Panel();
            panel10 = new Panel();
            label11 = new Label();
            panel11 = new Panel();
            label10 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            lblTitulo = new Label();
            panel2 = new Panel();
            pnlPractica = new Panel();
            panel5 = new Panel();
            cmbOr = new ComboBox();
            cmbAnd = new ComboBox();
            cmbNot = new ComboBox();
            cmbParentesis = new ComboBox();
            lblResultado = new Label();
            btnComprobar = new Button();
            label6 = new Label();
            label5 = new Label();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            panel1.SuspendLayout();
            pnlRegresar.SuspendLayout();
            pnlContenido.SuspendLayout();
            panel10.SuspendLayout();
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
            panel1.TabIndex = 4;
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
            lblPagina.Text = "3/5";
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
            pnlContenido.Controls.Add(panel13);
            pnlContenido.Controls.Add(panel12);
            pnlContenido.Controls.Add(panel10);
            pnlContenido.Controls.Add(panel4);
            pnlContenido.Controls.Add(panel3);
            pnlContenido.Controls.Add(label2);
            pnlContenido.Controls.Add(lblTitulo);
            pnlContenido.Controls.Add(panel2);
            pnlContenido.Location = new Point(12, 99);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(755, 599);
            pnlContenido.TabIndex = 5;
            // 
            // panel13
            // 
            panel13.BackgroundImage = (Image)resources.GetObject("panel13.BackgroundImage");
            panel13.BackgroundImageLayout = ImageLayout.Zoom;
            panel13.Location = new Point(368, 146);
            panel13.Name = "panel13";
            panel13.Size = new Size(158, 281);
            panel13.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.BackgroundImage = (Image)resources.GetObject("panel12.BackgroundImage");
            panel12.BackgroundImageLayout = ImageLayout.Zoom;
            panel12.Location = new Point(190, 146);
            panel12.Name = "panel12";
            panel12.Size = new Size(158, 281);
            panel12.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.Controls.Add(label11);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(label10);
            panel10.Location = new Point(532, 234);
            panel10.Name = "panel10";
            panel10.Size = new Size(201, 236);
            panel10.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(6, 67);
            label11.Name = "label11";
            label11.Size = new Size(170, 120);
            label11.TabIndex = 2;
            label11.Text = "• Primero paréntesis y \r\nel NOT (!).\r\n• Luego el AND (&&).\r\n• Finalmente el OR (||).\r\n• Los paréntesis pueden \r\ncambiar el resultado.";
            // 
            // panel11
            // 
            panel11.BackgroundImage = (Image)resources.GetObject("panel11.BackgroundImage");
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.Location = new Point(6, 9);
            panel11.Name = "panel11";
            panel11.Size = new Size(52, 52);
            panel11.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Fuchsia;
            label10.Location = new Point(64, 21);
            label10.Name = "label10";
            label10.Size = new Size(115, 28);
            label10.TabIndex = 0;
            label10.Text = "RECUERDA";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(3, 146);
            panel4.Name = "panel4";
            panel4.Size = new Size(181, 281);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(18, 438);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 158);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(124, 59);
            label2.Name = "label2";
            label2.Size = new Size(622, 84);
            label2.TabIndex = 2;
            label2.Text = "Cuando usamos varios operadores en una misma expresión, debemos \r\nseguir un orden para resolverlos. Si hay paréntesis, se resuelven \r\nprimero y pueden cambiar el orden de evaluación.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Magenta;
            lblTitulo.Location = new Point(124, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(357, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "¿QUÉ ES LA PRIORIDAD?";
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
            pnlPractica.Location = new Point(773, 99);
            pnlPractica.Name = "pnlPractica";
            pnlPractica.Size = new Size(446, 599);
            pnlPractica.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Controls.Add(cmbOr);
            panel5.Controls.Add(cmbAnd);
            panel5.Controls.Add(cmbNot);
            panel5.Controls.Add(cmbParentesis);
            panel5.Location = new Point(3, 132);
            panel5.Name = "panel5";
            panel5.Size = new Size(443, 305);
            panel5.TabIndex = 5;
            // 
            // cmbOr
            // 
            cmbOr.FormattingEnabled = true;
            cmbOr.Location = new Point(256, 252);
            cmbOr.Name = "cmbOr";
            cmbOr.Size = new Size(151, 28);
            cmbOr.TabIndex = 3;
            // 
            // cmbAnd
            // 
            cmbAnd.FormattingEnabled = true;
            cmbAnd.Location = new Point(256, 191);
            cmbAnd.Name = "cmbAnd";
            cmbAnd.Size = new Size(151, 28);
            cmbAnd.TabIndex = 2;
            // 
            // cmbNot
            // 
            cmbNot.FormattingEnabled = true;
            cmbNot.Location = new Point(256, 127);
            cmbNot.Name = "cmbNot";
            cmbNot.Size = new Size(151, 28);
            cmbNot.TabIndex = 1;
            // 
            // cmbParentesis
            // 
            cmbParentesis.FormattingEnabled = true;
            cmbParentesis.Location = new Point(256, 61);
            cmbParentesis.Name = "cmbParentesis";
            cmbParentesis.Size = new Size(151, 28);
            cmbParentesis.TabIndex = 0;
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
            btnComprobar.Location = new Point(127, 461);
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
            label6.Size = new Size(353, 75);
            label6.TabIndex = 1;
            label6.Text = "Ordena los operadores según su prioridad.\r\nEscribe del 1 al 4, donde 1 es el que se \r\nevalúa primero.";
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
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.BlueViolet;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(608, 704);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(187, 44);
            btnSiguiente.TabIndex = 8;
            btnSiguiente.Text = "Siguiente >>";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.BlueViolet;
            btnAnterior.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = SystemColors.ButtonHighlight;
            btnAnterior.Location = new Point(401, 704);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(183, 44);
            btnAnterior.TabIndex = 13;
            btnAnterior.Text = " <<Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // FrmPrioridadOperadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1231, 753);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(pnlPractica);
            Controls.Add(pnlContenido);
            Controls.Add(panel1);
            Name = "FrmPrioridadOperadores";
            Text = "FrmPrioridadOperadores";
            Load += FrmPrioridadOperadores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlRegresar.ResumeLayout(false);
            pnlRegresar.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
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
        private Label label11;
        private Panel panel11;
        private Label label10;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private Label lblTitulo;
        private Panel panel2;
        private Panel pnlPractica;
        private Label lblResultado;
        private Button btnComprobar;
        private Label label6;
        private Label label5;
        private Panel panel13;
        private Panel panel12;
        private Panel panel5;
        private ComboBox cmbOr;
        private ComboBox cmbAnd;
        private ComboBox cmbNot;
        private ComboBox cmbParentesis;
        private Button btnSiguiente;
        private Button btnAnterior;
    }
}