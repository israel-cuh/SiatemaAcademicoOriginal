namespace SistemaAcademico1
{
    partial class FrmAsignacionVariables
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignacionVariables));
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
            panel5 = new Panel();
            txtActivo = new TextBox();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            lblResultado = new Label();
            btnComprobar = new Button();
            label6 = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 81);
            panel1.TabIndex = 2;
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
            label1.Location = new Point(521, 27);
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
            pnlContenido.Location = new Point(12, 99);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(755, 571);
            pnlContenido.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(126, 442);
            label4.Name = "label4";
            label4.Size = new Size(578, 75);
            label4.TabIndex = 6;
            label4.Text = "Una variable puede cambiar su valor durante la ejecución del programa.\r\nEsto permite actualizar la información almacenada según \r\nlas acciones del usuario o las necesidades del programa.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(126, 397);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 5;
            label3.Text = "Recuerda:";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(58, 397);
            panel4.Name = "panel4";
            panel4.Size = new Size(62, 59);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(159, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 197);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(150, 82);
            label2.Name = "label2";
            label2.Size = new Size(501, 84);
            label2.TabIndex = 2;
            label2.Text = "Después de declarar una variable, puedes asignarle\r\nun valor utilizando el operador =.\r\nEl valor debe ser del mismo tipo de dato que la variable.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Magenta;
            lblTitulo.Location = new Point(137, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(340, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Asignación de variables";
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
            pnlPractica.Controls.Add(panel5);
            pnlPractica.Controls.Add(lblResultado);
            pnlPractica.Controls.Add(btnComprobar);
            pnlPractica.Controls.Add(label6);
            pnlPractica.Controls.Add(label5);
            pnlPractica.Location = new Point(773, 99);
            pnlPractica.Name = "pnlPractica";
            pnlPractica.Size = new Size(446, 571);
            pnlPractica.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(txtActivo);
            panel5.Controls.Add(txtNombre);
            panel5.Controls.Add(txtEdad);
            panel5.Location = new Point(3, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(441, 321);
            panel5.TabIndex = 6;
            // 
            // txtActivo
            // 
            txtActivo.Location = new Point(110, 227);
            txtActivo.Name = "txtActivo";
            txtActivo.Size = new Size(204, 27);
            txtActivo.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(93, 44);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(221, 27);
            txtEdad.TabIndex = 0;
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
            btnComprobar.Location = new Point(129, 434);
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
            label6.Location = new Point(23, 43);
            label6.Name = "label6";
            label6.Size = new Size(329, 50);
            label6.TabIndex = 1;
            label6.Text = "Completa el valor que debe asignarse a \r\ncada variable. ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Fuchsia;
            label5.Location = new Point(36, 12);
            label5.Name = "label5";
            label5.Size = new Size(281, 31);
            label5.TabIndex = 0;
            label5.Text = " 🎯 Practica lo aprendido";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.BlueViolet;
            btnAnterior.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = SystemColors.ButtonHighlight;
            btnAnterior.Location = new Point(412, 697);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(183, 44);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = " <<Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.BlueViolet;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(618, 697);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(187, 44);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Siguiente >>";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FrmAsignacionVariables
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
            Name = "FrmAsignacionVariables";
            Text = "FrmAsignacionVariables";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlRegresar.ResumeLayout(false);
            pnlRegresar.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            pnlPractica.ResumeLayout(false);
            pnlPractica.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPagina;
        private Label label1;
        private Panel pnlRegresar;
        private Label lblRegresar;
        private Panel pnlContenido;
        private Label label4;
        private Label label3;
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
        private Panel panel5;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtActivo;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}