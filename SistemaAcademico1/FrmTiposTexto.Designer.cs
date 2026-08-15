namespace SistemaAcademico1
{
    partial class FrmTiposTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiposTexto));
            panel1 = new Panel();
            lblPagina = new Label();
            label1 = new Label();
            pnlRegresar = new Panel();
            lblRegresar = new Label();
            pnlContenido = new Panel();
            panel11 = new Panel();
            panel9 = new Panel();
            label16 = new Label();
            label13 = new Label();
            panel10 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel8 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            lblTitulo = new Label();
            panel2 = new Panel();
            pnlPractica = new Panel();
            panel12 = new Panel();
            cmbA = new ComboBox();
            cmb7 = new ComboBox();
            cmb2026 = new ComboBox();
            cmbH = new ComboBox();
            cmbHola = new ComboBox();
            lblResultado = new Label();
            btnComprobar = new Button();
            label18 = new Label();
            label19 = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            panel1.SuspendLayout();
            pnlRegresar.SuspendLayout();
            pnlContenido.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            pnlPractica.SuspendLayout();
            panel12.SuspendLayout();
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
            lblPagina.Text = "3/5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(521, 27);
            label1.Name = "label1";
            label1.Size = new Size(239, 38);
            label1.TabIndex = 2;
            label1.Text = "TIPOS DE DATOS";
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
            pnlContenido.Controls.Add(panel11);
            pnlContenido.Controls.Add(panel9);
            pnlContenido.Controls.Add(panel6);
            pnlContenido.Controls.Add(panel3);
            pnlContenido.Controls.Add(label2);
            pnlContenido.Controls.Add(lblTitulo);
            pnlContenido.Controls.Add(panel2);
            pnlContenido.Location = new Point(12, 96);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(755, 591);
            pnlContenido.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.BackgroundImage = (Image)resources.GetObject("panel11.BackgroundImage");
            panel11.BackgroundImageLayout = ImageLayout.Stretch;
            panel11.Location = new Point(452, 267);
            panel11.Name = "panel11";
            panel11.Size = new Size(300, 321);
            panel11.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.Controls.Add(label16);
            panel9.Controls.Add(label13);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(470, 110);
            panel9.Name = "panel9";
            panel9.Size = new Size(262, 151);
            panel9.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(3, 55);
            label16.Name = "label16";
            label16.Size = new Size(243, 80);
            label16.TabIndex = 4;
            label16.Text = "Las comillas son importantes: \"A\" \r\nes un string porque utiliza comillas \r\ndobles, mientras que 'A' es un char \r\nporque utiliza comillas simples.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Yellow;
            label13.Location = new Point(60, 14);
            label13.Name = "label13";
            label13.Size = new Size(105, 28);
            label13.TabIndex = 1;
            label13.Text = "Recuerda:";
            // 
            // panel10
            // 
            panel10.BackgroundImage = (Image)resources.GetObject("panel10.BackgroundImage");
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Location = new Point(3, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(51, 49);
            panel10.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(18, 345);
            panel6.Name = "panel6";
            panel6.Size = new Size(428, 240);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Location = new Point(59, 131);
            panel7.Name = "panel7";
            panel7.Size = new Size(304, 106);
            panel7.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(59, 50);
            label10.Name = "label10";
            label10.Size = new Size(362, 69);
            label10.TabIndex = 3;
            label10.Text = "Permite almacenar un único carácter, como \r\nuna letra, número o símbolo. Los valores char \r\nse escriben entre comillas simples ' '.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(134, 19);
            label11.Name = "label11";
            label11.Size = new Size(218, 31);
            label11.TabIndex = 2;
            label11.Text = "—  Un solo carácter";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(128, 128, 255);
            label12.Location = new Point(66, 19);
            label12.Name = "label12";
            label12.Size = new Size(62, 31);
            label12.TabIndex = 1;
            label12.Text = "char";
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.BackgroundImageLayout = ImageLayout.Stretch;
            panel8.Location = new Point(16, 19);
            panel8.Name = "panel8";
            panel8.Size = new Size(35, 29);
            panel8.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(18, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 229);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(66, 122);
            panel5.Name = "panel5";
            panel5.Size = new Size(297, 104);
            panel5.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(66, 50);
            label5.Name = "label5";
            label5.Size = new Size(332, 69);
            label5.TabIndex = 3;
            label5.Text = "Permite almacenar una palabra, una frase \r\no varios caracteres. Los valores string se \r\nescriben entre comillas dobles \" \".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(141, 19);
            label4.Name = "label4";
            label4.Size = new Size(222, 31);
            label4.TabIndex = 2;
            label4.Text = "— Cadenas de texto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cyan;
            label3.Location = new Point(66, 19);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 1;
            label3.Text = "string";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(16, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(35, 29);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(120, 51);
            label2.Name = "label2";
            label2.Size = new Size(608, 56);
            label2.TabIndex = 2;
            label2.Text = "En C# podemos almacenar palabras, frases o caracteres individuales. \r\nPara ello utilizamos principalmente los tipos de datos string y char.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Magenta;
            lblTitulo.Location = new Point(120, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(261, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Texto y caracteres";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(34, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 70);
            panel2.TabIndex = 0;
            // 
            // pnlPractica
            // 
            pnlPractica.BackColor = Color.MidnightBlue;
            pnlPractica.Controls.Add(panel12);
            pnlPractica.Controls.Add(lblResultado);
            pnlPractica.Controls.Add(btnComprobar);
            pnlPractica.Controls.Add(label18);
            pnlPractica.Controls.Add(label19);
            pnlPractica.Location = new Point(770, 96);
            pnlPractica.Name = "pnlPractica";
            pnlPractica.Size = new Size(446, 588);
            pnlPractica.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.BackgroundImage = (Image)resources.GetObject("panel12.BackgroundImage");
            panel12.Controls.Add(cmbA);
            panel12.Controls.Add(cmb7);
            panel12.Controls.Add(cmb2026);
            panel12.Controls.Add(cmbH);
            panel12.Controls.Add(cmbHola);
            panel12.Location = new Point(12, 96);
            panel12.Name = "panel12";
            panel12.Size = new Size(420, 379);
            panel12.TabIndex = 5;
            // 
            // cmbA
            // 
            cmbA.FormattingEnabled = true;
            cmbA.Location = new Point(238, 331);
            cmbA.Name = "cmbA";
            cmbA.Size = new Size(151, 28);
            cmbA.TabIndex = 4;
            // 
            // cmb7
            // 
            cmb7.FormattingEnabled = true;
            cmb7.Location = new Point(238, 252);
            cmb7.Name = "cmb7";
            cmb7.Size = new Size(151, 28);
            cmb7.TabIndex = 3;
            // 
            // cmb2026
            // 
            cmb2026.FormattingEnabled = true;
            cmb2026.Location = new Point(238, 185);
            cmb2026.Name = "cmb2026";
            cmb2026.Size = new Size(151, 28);
            cmb2026.TabIndex = 2;
            // 
            // cmbH
            // 
            cmbH.FormattingEnabled = true;
            cmbH.Location = new Point(238, 108);
            cmbH.Name = "cmbH";
            cmbH.Size = new Size(151, 28);
            cmbH.TabIndex = 1;
            // 
            // cmbHola
            // 
            cmbHola.FormattingEnabled = true;
            cmbHola.Location = new Point(238, 29);
            cmbHola.Name = "cmbHola";
            cmbHola.Size = new Size(151, 28);
            cmbHola.TabIndex = 0;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ButtonFace;
            lblResultado.Location = new Point(23, 534);
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
            btnComprobar.Location = new Point(129, 481);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(165, 40);
            btnComprobar.TabIndex = 3;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = false;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(23, 43);
            label18.Name = "label18";
            label18.Size = new Size(320, 25);
            label18.TabIndex = 1;
            label18.Text = "Clasifica cada valor como string o char.";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Fuchsia;
            label19.Location = new Point(36, 12);
            label19.Name = "label19";
            label19.Size = new Size(281, 31);
            label19.TabIndex = 0;
            label19.Text = " 🎯 Practica lo aprendido";
            // 
            // btnAnterior
            // 
            btnAnterior.BackColor = Color.BlueViolet;
            btnAnterior.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.ForeColor = SystemColors.ButtonHighlight;
            btnAnterior.Location = new Point(441, 693);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(183, 44);
            btnAnterior.TabIndex = 10;
            btnAnterior.Text = " <<Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.BlueViolet;
            btnSiguiente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = SystemColors.ButtonHighlight;
            btnSiguiente.Location = new Point(669, 690);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(187, 44);
            btnSiguiente.TabIndex = 11;
            btnSiguiente.Text = "Siguiente >>";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // FrmTiposTexto
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
            Name = "FrmTiposTexto";
            Text = "FrmTiposTexto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlRegresar.ResumeLayout(false);
            pnlRegresar.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlPractica.ResumeLayout(false);
            pnlPractica.PerformLayout();
            panel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPagina;
        private Label label1;
        private Panel pnlRegresar;
        private Label lblRegresar;
        private Panel pnlContenido;
        private Panel panel9;
        private Label label16;
        private Label label13;
        private Panel panel10;
        private Panel panel6;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel8;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private Label lblTitulo;
        private Panel panel2;
        private Panel panel7;
        private Panel panel5;
        private Panel panel11;
        private Panel pnlPractica;
        private Label lblResultado;
        private Button btnComprobar;
        private Label label18;
        private Label label19;
        private Panel panel12;
        private ComboBox cmbH;
        private ComboBox cmbHola;
        private ComboBox cmbA;
        private ComboBox cmb7;
        private ComboBox cmb2026;
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}