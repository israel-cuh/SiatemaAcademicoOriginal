namespace SistemaAcademico1
{
    partial class FrmTiposDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiposDatos));
            panel1 = new Panel();
            lblPagina = new Label();
            label1 = new Label();
            pnlRegresar = new Panel();
            lblRegresar = new Label();
            pnlContenido = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            lblTitulo = new Label();
            panel2 = new Panel();
            pnlPractica = new Panel();
            pnlConexiones = new Panel();
            btnPuntoBool = new Button();
            btnPuntoChar = new Button();
            btnPuntoDouble = new Button();
            btnPuntoString = new Button();
            btnPuntoInt = new Button();
            btnPuntoTrue = new Button();
            btnPuntoA = new Button();
            btnPunto95 = new Button();
            btnPuntoMaria = new Button();
            btnPunto18 = new Button();
            lblBool = new Label();
            lblChar = new Label();
            lblDouble = new Label();
            lblString = new Label();
            lblInt = new Label();
            lblA = new Label();
            lblTrue = new Label();
            lbl95 = new Label();
            lblMaria = new Label();
            lbl18 = new Label();
            lblTipoDato = new Label();
            lblValor = new Label();
            lblResultado = new Label();
            btnComprobar = new Button();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            pnlRegresar.SuspendLayout();
            pnlContenido.SuspendLayout();
            pnlPractica.SuspendLayout();
            pnlConexiones.SuspendLayout();
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
            panel1.TabIndex = 3;
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
            pnlContenido.Controls.Add(panel5);
            pnlContenido.Controls.Add(panel4);
            pnlContenido.Controls.Add(label3);
            pnlContenido.Controls.Add(panel3);
            pnlContenido.Controls.Add(label2);
            pnlContenido.Controls.Add(lblTitulo);
            pnlContenido.Controls.Add(panel2);
            pnlContenido.Location = new Point(12, 99);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(755, 598);
            pnlContenido.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.Location = new Point(56, 540);
            panel5.Name = "panel5";
            panel5.Size = new Size(568, 54);
            panel5.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(49, 342);
            panel4.Name = "panel4";
            panel4.Size = new Size(583, 190);
            panel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(49, 311);
            label3.Name = "label3";
            label3.Size = new Size(196, 28);
            label3.TabIndex = 5;
            label3.Text = "Tipos más utilizados";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(120, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(541, 170);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(137, 51);
            label2.Name = "label2";
            label2.Size = new Size(595, 84);
            label2.TabIndex = 2;
            label2.Text = "Los tipos de datos indican qué clase de información puede guardar\r\nuna variable. Cada tipo está preparado para \r\nalmacenar un tipo específico de valor.";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Magenta;
            lblTitulo.Location = new Point(137, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(407, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "¿Qué son los tipos de datos?";
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
            pnlPractica.Controls.Add(pnlConexiones);
            pnlPractica.Controls.Add(lblResultado);
            pnlPractica.Controls.Add(btnComprobar);
            pnlPractica.Controls.Add(label6);
            pnlPractica.Controls.Add(label5);
            pnlPractica.Location = new Point(773, 99);
            pnlPractica.Name = "pnlPractica";
            pnlPractica.Size = new Size(446, 598);
            pnlPractica.TabIndex = 5;
            // 
            // pnlConexiones
            // 
            pnlConexiones.Controls.Add(btnPuntoBool);
            pnlConexiones.Controls.Add(btnPuntoChar);
            pnlConexiones.Controls.Add(btnPuntoDouble);
            pnlConexiones.Controls.Add(btnPuntoString);
            pnlConexiones.Controls.Add(btnPuntoInt);
            pnlConexiones.Controls.Add(btnPuntoTrue);
            pnlConexiones.Controls.Add(btnPuntoA);
            pnlConexiones.Controls.Add(btnPunto95);
            pnlConexiones.Controls.Add(btnPuntoMaria);
            pnlConexiones.Controls.Add(btnPunto18);
            pnlConexiones.Controls.Add(lblBool);
            pnlConexiones.Controls.Add(lblChar);
            pnlConexiones.Controls.Add(lblDouble);
            pnlConexiones.Controls.Add(lblString);
            pnlConexiones.Controls.Add(lblInt);
            pnlConexiones.Controls.Add(lblA);
            pnlConexiones.Controls.Add(lblTrue);
            pnlConexiones.Controls.Add(lbl95);
            pnlConexiones.Controls.Add(lblMaria);
            pnlConexiones.Controls.Add(lbl18);
            pnlConexiones.Controls.Add(lblTipoDato);
            pnlConexiones.Controls.Add(lblValor);
            pnlConexiones.Location = new Point(14, 106);
            pnlConexiones.Name = "pnlConexiones";
            pnlConexiones.Size = new Size(418, 364);
            pnlConexiones.TabIndex = 5;
            pnlConexiones.Click += PuntoDerecha_Click;
            pnlConexiones.Paint += pnlConexiones_Paint;
            // 
            // btnPuntoBool
            // 
            btnPuntoBool.Cursor = Cursors.Hand;
            btnPuntoBool.FlatStyle = FlatStyle.Flat;
            btnPuntoBool.ForeColor = Color.Blue;
            btnPuntoBool.Location = new Point(254, 307);
            btnPuntoBool.Name = "btnPuntoBool";
            btnPuntoBool.Size = new Size(14, 14);
            btnPuntoBool.TabIndex = 21;
            btnPuntoBool.UseVisualStyleBackColor = true;
            btnPuntoBool.Click += PuntoDerecha_Click;
            // 
            // btnPuntoChar
            // 
            btnPuntoChar.Cursor = Cursors.Hand;
            btnPuntoChar.FlatStyle = FlatStyle.Flat;
            btnPuntoChar.ForeColor = Color.Blue;
            btnPuntoChar.Location = new Point(254, 243);
            btnPuntoChar.Name = "btnPuntoChar";
            btnPuntoChar.Size = new Size(14, 14);
            btnPuntoChar.TabIndex = 20;
            btnPuntoChar.UseVisualStyleBackColor = true;
            btnPuntoChar.Click += PuntoDerecha_Click;
            // 
            // btnPuntoDouble
            // 
            btnPuntoDouble.Cursor = Cursors.Hand;
            btnPuntoDouble.FlatStyle = FlatStyle.Flat;
            btnPuntoDouble.ForeColor = Color.Blue;
            btnPuntoDouble.Location = new Point(254, 184);
            btnPuntoDouble.Name = "btnPuntoDouble";
            btnPuntoDouble.Size = new Size(14, 14);
            btnPuntoDouble.TabIndex = 19;
            btnPuntoDouble.UseVisualStyleBackColor = true;
            btnPuntoDouble.Click += PuntoDerecha_Click;
            // 
            // btnPuntoString
            // 
            btnPuntoString.Cursor = Cursors.Hand;
            btnPuntoString.FlatStyle = FlatStyle.Flat;
            btnPuntoString.ForeColor = Color.Blue;
            btnPuntoString.Location = new Point(254, 136);
            btnPuntoString.Name = "btnPuntoString";
            btnPuntoString.Size = new Size(14, 14);
            btnPuntoString.TabIndex = 18;
            btnPuntoString.UseVisualStyleBackColor = true;
            btnPuntoString.Click += PuntoDerecha_Click;
            // 
            // btnPuntoInt
            // 
            btnPuntoInt.Cursor = Cursors.Hand;
            btnPuntoInt.FlatStyle = FlatStyle.Flat;
            btnPuntoInt.ForeColor = Color.Blue;
            btnPuntoInt.Location = new Point(254, 79);
            btnPuntoInt.Name = "btnPuntoInt";
            btnPuntoInt.Size = new Size(14, 14);
            btnPuntoInt.TabIndex = 17;
            btnPuntoInt.UseVisualStyleBackColor = true;
            btnPuntoInt.Click += PuntoDerecha_Click;
            // 
            // btnPuntoTrue
            // 
            btnPuntoTrue.Cursor = Cursors.Hand;
            btnPuntoTrue.FlatStyle = FlatStyle.Flat;
            btnPuntoTrue.ForeColor = Color.Blue;
            btnPuntoTrue.Location = new Point(125, 307);
            btnPuntoTrue.Name = "btnPuntoTrue";
            btnPuntoTrue.Size = new Size(14, 14);
            btnPuntoTrue.TabIndex = 16;
            btnPuntoTrue.UseVisualStyleBackColor = true;
            btnPuntoTrue.Click += PuntoIzquierda_Click;
            // 
            // btnPuntoA
            // 
            btnPuntoA.Cursor = Cursors.Hand;
            btnPuntoA.FlatStyle = FlatStyle.Flat;
            btnPuntoA.ForeColor = Color.Blue;
            btnPuntoA.Location = new Point(125, 243);
            btnPuntoA.Name = "btnPuntoA";
            btnPuntoA.Size = new Size(14, 14);
            btnPuntoA.TabIndex = 15;
            btnPuntoA.UseVisualStyleBackColor = true;
            btnPuntoA.Click += PuntoIzquierda_Click;
            // 
            // btnPunto95
            // 
            btnPunto95.Cursor = Cursors.Hand;
            btnPunto95.FlatStyle = FlatStyle.Flat;
            btnPunto95.ForeColor = Color.Blue;
            btnPunto95.Location = new Point(125, 188);
            btnPunto95.Name = "btnPunto95";
            btnPunto95.Size = new Size(14, 14);
            btnPunto95.TabIndex = 14;
            btnPunto95.UseVisualStyleBackColor = true;
            btnPunto95.Click += PuntoIzquierda_Click;
            // 
            // btnPuntoMaria
            // 
            btnPuntoMaria.Cursor = Cursors.Hand;
            btnPuntoMaria.FlatStyle = FlatStyle.Flat;
            btnPuntoMaria.ForeColor = Color.Blue;
            btnPuntoMaria.Location = new Point(125, 136);
            btnPuntoMaria.Name = "btnPuntoMaria";
            btnPuntoMaria.Size = new Size(14, 14);
            btnPuntoMaria.TabIndex = 13;
            btnPuntoMaria.UseVisualStyleBackColor = true;
            btnPuntoMaria.Click += PuntoIzquierda_Click;
            // 
            // btnPunto18
            // 
            btnPunto18.Cursor = Cursors.Hand;
            btnPunto18.FlatStyle = FlatStyle.Flat;
            btnPunto18.ForeColor = Color.Blue;
            btnPunto18.Location = new Point(125, 80);
            btnPunto18.Name = "btnPunto18";
            btnPunto18.Size = new Size(14, 14);
            btnPunto18.TabIndex = 12;
            btnPunto18.UseVisualStyleBackColor = true;
            btnPunto18.Click += PuntoIzquierda_Click;
            // 
            // lblBool
            // 
            lblBool.AutoSize = true;
            lblBool.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBool.ForeColor = SystemColors.ButtonFace;
            lblBool.Location = new Point(301, 296);
            lblBool.Name = "lblBool";
            lblBool.Size = new Size(49, 25);
            lblBool.TabIndex = 11;
            lblBool.Text = "bool";
            // 
            // lblChar
            // 
            lblChar.AutoSize = true;
            lblChar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChar.ForeColor = SystemColors.ButtonFace;
            lblChar.Location = new Point(301, 236);
            lblChar.Name = "lblChar";
            lblChar.Size = new Size(45, 25);
            lblChar.TabIndex = 10;
            lblChar.Text = "char";
            // 
            // lblDouble
            // 
            lblDouble.AutoSize = true;
            lblDouble.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDouble.ForeColor = SystemColors.ButtonFace;
            lblDouble.Location = new Point(289, 177);
            lblDouble.Name = "lblDouble";
            lblDouble.Size = new Size(68, 25);
            lblDouble.TabIndex = 9;
            lblDouble.Text = "double";
            // 
            // lblString
            // 
            lblString.AutoSize = true;
            lblString.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblString.ForeColor = SystemColors.ButtonFace;
            lblString.Location = new Point(289, 125);
            lblString.Name = "lblString";
            lblString.Size = new Size(57, 25);
            lblString.TabIndex = 8;
            lblString.Text = "string";
            // 
            // lblInt
            // 
            lblInt.AutoSize = true;
            lblInt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInt.ForeColor = SystemColors.ButtonFace;
            lblInt.Location = new Point(301, 68);
            lblInt.Name = "lblInt";
            lblInt.Size = new Size(32, 25);
            lblInt.TabIndex = 7;
            lblInt.Text = "int";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA.ForeColor = SystemColors.ButtonFace;
            lblA.Location = new Point(52, 236);
            lblA.Name = "lblA";
            lblA.Size = new Size(32, 25);
            lblA.TabIndex = 6;
            lblA.Text = "'A'";
            // 
            // lblTrue
            // 
            lblTrue.AutoSize = true;
            lblTrue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrue.ForeColor = SystemColors.ButtonFace;
            lblTrue.Location = new Point(52, 296);
            lblTrue.Name = "lblTrue";
            lblTrue.Size = new Size(43, 25);
            lblTrue.TabIndex = 5;
            lblTrue.Text = "true";
            lblTrue.Click += label7_Click;
            // 
            // lbl95
            // 
            lbl95.AutoSize = true;
            lbl95.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl95.ForeColor = SystemColors.ButtonFace;
            lbl95.Location = new Point(48, 177);
            lbl95.Name = "lbl95";
            lbl95.Size = new Size(36, 25);
            lbl95.TabIndex = 4;
            lbl95.Text = "9.5";
            lbl95.Click += lbl95_Click;
            // 
            // lblMaria
            // 
            lblMaria.AutoSize = true;
            lblMaria.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaria.ForeColor = SystemColors.ButtonFace;
            lblMaria.Location = new Point(35, 125);
            lblMaria.Name = "lblMaria";
            lblMaria.Size = new Size(70, 25);
            lblMaria.TabIndex = 3;
            lblMaria.Text = "\"María\"";
            // 
            // lbl18
            // 
            lbl18.AutoSize = true;
            lbl18.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl18.ForeColor = SystemColors.ButtonFace;
            lbl18.Location = new Point(52, 68);
            lbl18.Name = "lbl18";
            lbl18.Size = new Size(32, 25);
            lbl18.TabIndex = 2;
            lbl18.Text = "18";
            // 
            // lblTipoDato
            // 
            lblTipoDato.AutoSize = true;
            lblTipoDato.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoDato.ForeColor = SystemColors.ButtonHighlight;
            lblTipoDato.Location = new Point(264, 16);
            lblTipoDato.Name = "lblTipoDato";
            lblTipoDato.Size = new Size(120, 25);
            lblTipoDato.TabIndex = 1;
            lblTipoDato.Text = "Tipo de Dato";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.ForeColor = SystemColors.ButtonHighlight;
            lblValor.Location = new Point(52, 16);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(60, 25);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor ";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ButtonFace;
            lblResultado.Location = new Point(23, 527);
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
            btnComprobar.Location = new Point(128, 476);
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
            // FrmTiposDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1231, 753);
            Controls.Add(pnlPractica);
            Controls.Add(pnlContenido);
            Controls.Add(panel1);
            Name = "FrmTiposDatos";
            Text = "FrmTiposDatos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlRegresar.ResumeLayout(false);
            pnlRegresar.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            pnlPractica.ResumeLayout(false);
            pnlPractica.PerformLayout();
            pnlConexiones.ResumeLayout(false);
            pnlConexiones.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPagina;
        private Label label1;
        private Panel pnlRegresar;
        private Label lblRegresar;
        private Panel pnlContenido;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Label lblTitulo;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel pnlPractica;
        private Label lblResultado;
        private Button btnComprobar;
        private Label label6;
        private Label label5;
        private Panel pnlConexiones;
        private Label lblMaria;
        private Label lbl18;
        private Label lblTipoDato;
        private Label lblValor;
        private Label lblA;
        private Label lblTrue;
        private Label lbl95;
        private Label lblBool;
        private Label lblChar;
        private Label lblDouble;
        private Label lblString;
        private Label lblInt;
        private Button btnPunto18;
        private Button btnPuntoBool;
        private Button btnPuntoChar;
        private Button btnPuntoDouble;
        private Button btnPuntoString;
        private Button btnPuntoInt;
        private Button btnPuntoTrue;
        private Button btnPuntoA;
        private Button btnPunto95;
        private Button btnPuntoMaria;
    }
}