namespace SistemaAcademico1
{
    partial class FrmVariables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVariables));
            panel1 = new Panel();
            lblPagina = new Label();
            label1 = new Label();
            pnlRegresar = new Panel();
            lblRegresar = new Label();
            panelContenido = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            panelCodigo = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblCodigo = new Label();
            lblExplicacion = new Label();
            panel2 = new Panel();
            lblTitulo = new Label();
            panelPractica = new Panel();
            btnComprobar = new Button();
            lblResultado = new Label();
            chkEdad = new CheckBox();
            chkMiNombre = new CheckBox();
            chkTotalCompra = new CheckBox();
            chk2Edad = new CheckBox();
            chkNombreAlumno = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            btnSiguiente = new Button();
            panel1.SuspendLayout();
            pnlRegresar.SuspendLayout();
            panelContenido.SuspendLayout();
            panel3.SuspendLayout();
            panelCodigo.SuspendLayout();
            panelPractica.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblPagina);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pnlRegresar);
            panel1.Location = new Point(30, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 81);
            panel1.TabIndex = 0;
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
            lblPagina.Text = "1/5";
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
            pnlRegresar.Paint += pnlRegresar_Paint;
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
            // panelContenido
            // 
            panelContenido.BackColor = Color.MidnightBlue;
            panelContenido.Controls.Add(panel3);
            panelContenido.Controls.Add(panelCodigo);
            panelContenido.Controls.Add(lblExplicacion);
            panelContenido.Controls.Add(panel2);
            panelContenido.Controls.Add(lblTitulo);
            panelContenido.Location = new Point(30, 115);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(736, 577);
            panelContenido.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(42, 413);
            panel3.Name = "panel3";
            panel3.Size = new Size(640, 120);
            panel3.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(104, 46);
            label8.Name = "label8";
            label8.Size = new Size(446, 50);
            label8.TabIndex = 2;
            label8.Text = "Si guardas el nombre de un estudiante, puedes utilizar \r\nesa información más adelante en el programa.";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(104, 14);
            label7.Name = "label7";
            label7.Size = new Size(98, 31);
            label7.TabIndex = 1;
            label7.Text = "Ejemplo";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(14, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(84, 82);
            panel4.TabIndex = 0;
            // 
            // panelCodigo
            // 
            panelCodigo.Controls.Add(label6);
            panelCodigo.Controls.Add(label5);
            panelCodigo.Controls.Add(label4);
            panelCodigo.Controls.Add(label3);
            panelCodigo.Controls.Add(label2);
            panelCodigo.Controls.Add(lblCodigo);
            panelCodigo.Location = new Point(107, 232);
            panelCodigo.Name = "panelCodigo";
            panelCodigo.Size = new Size(575, 141);
            panelCodigo.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(311, 97);
            label6.Name = "label6";
            label6.Size = new Size(145, 25);
            label6.TabIndex = 5;
            label6.Text = "// verdad o falso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(311, 58);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 4;
            label5.Text = "// texto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(308, 14);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 3;
            label4.Text = "// numero entero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(56, 99);
            label3.Name = "label3";
            label3.Size = new Size(219, 23);
            label3.TabIndex = 2;
            label3.Text = "bool activo = true;";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(53, 60);
            label2.Name = "label2";
            label2.Size = new Size(252, 23);
            label2.TabIndex = 1;
            label2.Text = "string nombre = \"Ana\";";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Yellow;
            lblCodigo.Location = new Point(53, 14);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(164, 46);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "int edad = 20;\r\n\r\n";
            // 
            // lblExplicacion
            // 
            lblExplicacion.AutoSize = true;
            lblExplicacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExplicacion.ForeColor = SystemColors.ButtonFace;
            lblExplicacion.Location = new Point(176, 103);
            lblExplicacion.Name = "lblExplicacion";
            lblExplicacion.Size = new Size(460, 75);
            lblExplicacion.TabIndex = 2;
            lblExplicacion.Text = "Una variable es un espacio en memoria donde se \r\nalmacena información que puede utilizarse y modificarse\r\ndurante la ejecución de un programa.";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(8, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 148);
            panel2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Magenta;
            lblTitulo.Location = new Point(176, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(324, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "¿Qué es una variable?";
            // 
            // panelPractica
            // 
            panelPractica.BackColor = Color.MidnightBlue;
            panelPractica.Controls.Add(btnComprobar);
            panelPractica.Controls.Add(lblResultado);
            panelPractica.Controls.Add(chkEdad);
            panelPractica.Controls.Add(chkMiNombre);
            panelPractica.Controls.Add(chkTotalCompra);
            panelPractica.Controls.Add(chk2Edad);
            panelPractica.Controls.Add(chkNombreAlumno);
            panelPractica.Controls.Add(label10);
            panelPractica.Controls.Add(label9);
            panelPractica.Location = new Point(772, 115);
            panelPractica.Name = "panelPractica";
            panelPractica.Size = new Size(465, 577);
            panelPractica.TabIndex = 2;
            panelPractica.Paint += panelPractica_Paint;
            // 
            // btnComprobar
            // 
            btnComprobar.BackColor = Color.FromArgb(128, 128, 255);
            btnComprobar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprobar.ForeColor = SystemColors.ButtonHighlight;
            btnComprobar.Location = new Point(167, 413);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(159, 45);
            btnComprobar.TabIndex = 8;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = false;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(82, 489);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 7;
            lblResultado.Visible = false;
            // 
            // chkEdad
            // 
            chkEdad.AutoSize = true;
            chkEdad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEdad.ForeColor = SystemColors.ButtonFace;
            chkEdad.Location = new Point(82, 366);
            chkEdad.Name = "chkEdad";
            chkEdad.Size = new Size(88, 35);
            chkEdad.TabIndex = 6;
            chkEdad.Text = "edad";
            chkEdad.UseVisualStyleBackColor = true;
            // 
            // chkMiNombre
            // 
            chkMiNombre.AutoSize = true;
            chkMiNombre.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMiNombre.ForeColor = SystemColors.ButtonHighlight;
            chkMiNombre.Location = new Point(82, 308);
            chkMiNombre.Name = "chkMiNombre";
            chkMiNombre.Size = new Size(150, 35);
            chkMiNombre.TabIndex = 5;
            chkMiNombre.Text = "mi nombre";
            chkMiNombre.UseVisualStyleBackColor = true;
            // 
            // chkTotalCompra
            // 
            chkTotalCompra.AutoSize = true;
            chkTotalCompra.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkTotalCompra.ForeColor = SystemColors.ButtonFace;
            chkTotalCompra.Location = new Point(82, 257);
            chkTotalCompra.Name = "chkTotalCompra";
            chkTotalCompra.Size = new Size(174, 35);
            chkTotalCompra.TabIndex = 4;
            chkTotalCompra.Text = "total_compra";
            chkTotalCompra.UseVisualStyleBackColor = true;
            chkTotalCompra.CheckedChanged += chkTotalCompra_CheckedChanged;
            // 
            // chk2Edad
            // 
            chk2Edad.AutoSize = true;
            chk2Edad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chk2Edad.ForeColor = SystemColors.ButtonFace;
            chk2Edad.Location = new Point(82, 209);
            chk2Edad.Name = "chk2Edad";
            chk2Edad.Size = new Size(101, 35);
            chk2Edad.TabIndex = 3;
            chk2Edad.Text = "2edad";
            chk2Edad.UseVisualStyleBackColor = true;
            // 
            // chkNombreAlumno
            // 
            chkNombreAlumno.AutoSize = true;
            chkNombreAlumno.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkNombreAlumno.ForeColor = SystemColors.ButtonFace;
            chkNombreAlumno.Location = new Point(82, 157);
            chkNombreAlumno.Name = "chkNombreAlumno";
            chkNombreAlumno.Size = new Size(199, 35);
            chkNombreAlumno.TabIndex = 2;
            chkNombreAlumno.Text = "nombreAlumno";
            chkNombreAlumno.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(32, 83);
            label10.Name = "label10";
            label10.Size = new Size(383, 50);
            label10.TabIndex = 1;
            label10.Text = "1. Selecciona cuáles de las siguientes opciones \r\nson variables válidas:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.MediumSpringGreen;
            label9.Location = new Point(32, 21);
            label9.Name = "label9";
            label9.Size = new Size(352, 38);
            label9.TabIndex = 0;
            label9.Text = "🎯 ¡Practica lo aprendido!";
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.DarkViolet;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(601, 717);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(190, 53);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Suiguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FrmVariables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1267, 791);
            Controls.Add(btnSiguiente);
            Controls.Add(panelPractica);
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            Name = "FrmVariables";
            Text = "FrmVariables";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlRegresar.ResumeLayout(false);
            pnlRegresar.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelCodigo.ResumeLayout(false);
            panelCodigo.PerformLayout();
            panelPractica.ResumeLayout(false);
            panelPractica.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelContenido;
        private Panel panelPractica;
        private Panel pnlRegresar;
        private Label lblRegresar;
        private Label label1;
        private Label lblPagina;
        private Label lblTitulo;
        private Panel panel2;
        private Label lblExplicacion;
        private Panel panelCodigo;
        private Label lblCodigo;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Panel panel4;
        private Label label10;
        private Label label9;
        private CheckBox chkEdad;
        private CheckBox chkMiNombre;
        private CheckBox chkTotalCompra;
        private CheckBox chk2Edad;
        private CheckBox chkNombreAlumno;
        private Label lblResultado;
        private Button btnComprobar;
        private Button btnSiguiente;
    }
}