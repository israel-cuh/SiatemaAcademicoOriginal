namespace SistemaAcademico1
{
    partial class ESTRUTURAS_Y_REGLAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESTRUTURAS_Y_REGLAS));
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            lBLREGLAS = new Label();
            groupBox1 = new GroupBox();
            lblestructura = new Label();
            lblexplicacion = new Label();
            label1titulo = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            rbIntalacion = new RadioButton();
            rbDEPURACION = new RadioButton();
            buttoncomprobar = new Button();
            rbcompilacion = new RadioButton();
            rbsecuencia = new RadioButton();
            lblpregunta = new Label();
            lblopcion = new Label();
            panel3 = new Panel();
            labelideadelsabias = new Label();
            labelsabias = new Label();
            labeltexpis = new Label();
            label = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lblexplicacion);
            panel1.Controls.Add(label1titulo);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(23, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 597);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lBLREGLAS);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(42, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(575, 159);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "📌Reglas basicas ";
            // 
            // lBLREGLAS
            // 
            lBLREGLAS.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lBLREGLAS.Location = new Point(24, 19);
            lBLREGLAS.Name = "lBLREGLAS";
            lBLREGLAS.Size = new Size(309, 137);
            lBLREGLAS.TabIndex = 0;
            lBLREGLAS.Text = resources.GetString("lBLREGLAS.Text");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblestructura);
            groupBox1.Location = new Point(42, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(575, 216);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estructuras basicas ";
            // 
            // lblestructura
            // 
            lblestructura.Location = new Point(15, 29);
            lblestructura.Name = "lblestructura";
            lblestructura.Size = new Size(259, 150);
            lblestructura.TabIndex = 0;
            lblestructura.Text = "1. SECUENCIA.\r\nLas instrucciones se ejecutan una tras otra.\r\n\r\n2. SELECCION.\r\nPermite tomar decisiones usando Si...Entonces.\r\n\r\n3. REPETICION\r\n\r\nRepite instrucciones mediante Mientras, Para o Repetir.";
            // 
            // lblexplicacion
            // 
            lblexplicacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblexplicacion.Location = new Point(167, 63);
            lblexplicacion.Name = "lblexplicacion";
            lblexplicacion.Size = new Size(460, 72);
            lblexplicacion.TabIndex = 3;
            lblexplicacion.Text = resources.GetString("lblexplicacion.Text");
            // 
            // label1titulo
            // 
            label1titulo.AutoSize = true;
            label1titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1titulo.Location = new Point(156, 16);
            label1titulo.Name = "label1titulo";
            label1titulo.Size = new Size(334, 32);
            label1titulo.TabIndex = 2;
            label1titulo.Text = "Estructuras y reglas basicas.";
            // 
            // pictureBox1
            // 
          //  pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_07_20_at_17_45_03;
            pictureBox1.Location = new Point(18, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label);
            panel2.Controls.Add(labeltexpis);
            panel2.Controls.Add(rbIntalacion);
            panel2.Controls.Add(rbDEPURACION);
            panel2.Controls.Add(buttoncomprobar);
            panel2.Controls.Add(rbcompilacion);
            panel2.Controls.Add(rbsecuencia);
            panel2.Controls.Add(lblpregunta);
            panel2.Controls.Add(lblopcion);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(688, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 597);
            panel2.TabIndex = 1;
            // 
            // rbIntalacion
            // 
            rbIntalacion.AutoSize = true;
            rbIntalacion.Location = new Point(49, 364);
            rbIntalacion.Name = "rbIntalacion";
            rbIntalacion.Size = new Size(94, 19);
            rbIntalacion.TabIndex = 9;
            rbIntalacion.TabStop = true;
            rbIntalacion.Text = "d) Intalacion ";
            rbIntalacion.UseVisualStyleBackColor = true;
            // 
            // rbDEPURACION
            // 
            rbDEPURACION.AutoSize = true;
            rbDEPURACION.Location = new Point(40, 327);
            rbDEPURACION.Name = "rbDEPURACION";
            rbDEPURACION.Size = new Size(99, 19);
            rbDEPURACION.TabIndex = 8;
            rbDEPURACION.TabStop = true;
            rbDEPURACION.Text = "c) Depuracion";
            rbDEPURACION.UseVisualStyleBackColor = true;
            // 
            // buttoncomprobar
            // 
            buttoncomprobar.Location = new Point(96, 417);
            buttoncomprobar.Name = "buttoncomprobar";
            buttoncomprobar.Size = new Size(91, 23);
            buttoncomprobar.TabIndex = 7;
            buttoncomprobar.Text = "Comprobar";
            buttoncomprobar.UseVisualStyleBackColor = true;
            // 
            // rbcompilacion
            // 
            rbcompilacion.AutoSize = true;
            rbcompilacion.Location = new Point(40, 291);
            rbcompilacion.Name = "rbcompilacion";
            rbcompilacion.Size = new Size(107, 19);
            rbcompilacion.TabIndex = 4;
            rbcompilacion.TabStop = true;
            rbcompilacion.Text = "b) Compilacion";
            rbcompilacion.UseVisualStyleBackColor = true;
            rbcompilacion.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbsecuencia
            // 
            rbsecuencia.AutoSize = true;
            rbsecuencia.Location = new Point(40, 250);
            rbsecuencia.Name = "rbsecuencia";
            rbsecuencia.Size = new Size(94, 19);
            rbsecuencia.TabIndex = 3;
            rbsecuencia.TabStop = true;
            rbsecuencia.Text = "a) Secuencia ";
            rbsecuencia.UseVisualStyleBackColor = true;
            // 
            // lblpregunta
            // 
            lblpregunta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpregunta.Location = new Point(29, 196);
            lblpregunta.Name = "lblpregunta";
            lblpregunta.Size = new Size(278, 39);
            lblpregunta.TabIndex = 2;
            lblpregunta.Text = "¿Cuál de las siguientes es una estructura básica del pseudocódigo?";
            // 
            // lblopcion
            // 
            lblopcion.AutoSize = true;
            lblopcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblopcion.Location = new Point(16, 157);
            lblopcion.Name = "lblopcion";
            lblopcion.Size = new Size(190, 17);
            lblopcion.TabIndex = 1;
            lblopcion.Text = "Selecciona la opcion correcta:";
            // 
            // panel3
            // 
            panel3.Controls.Add(labelideadelsabias);
            panel3.Controls.Add(labelsabias);
            panel3.Location = new Point(64, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 119);
            panel3.TabIndex = 0;
            // 
            // labelideadelsabias
            // 
            labelideadelsabias.Location = new Point(16, 29);
            labelideadelsabias.Name = "labelideadelsabias";
            labelideadelsabias.Size = new Size(181, 71);
            labelideadelsabias.TabIndex = 2;
            labelideadelsabias.Text = "Una buena estructura en el pseudocódigo facilita convertir el algoritmo a cualquier lenguaje de programación.";
            labelideadelsabias.Click += label2_Click;
            // 
            // labelsabias
            // 
            labelsabias.AutoSize = true;
            labelsabias.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsabias.Location = new Point(44, 12);
            labelsabias.Name = "labelsabias";
            labelsabias.Size = new Size(109, 17);
            labelsabias.TabIndex = 1;
            labelsabias.Text = "💡 ¿Sabías qué?";
            // 
            // labeltexpis
            // 
            labeltexpis.Location = new Point(24, 477);
            labeltexpis.Name = "labeltexpis";
            labeltexpis.Size = new Size(168, 49);
            labeltexpis.TabIndex = 11;
            labeltexpis.Text = "Las estructuras basicas son las que permiten organizar el flujo de un algoritmo";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(40, 460);
            label.Name = "label";
            label.Size = new Size(64, 17);
            label.TabIndex = 12;
            label.Text = "💡 Pista";
            label.Click += label_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 550);
            button1.Name = "button1";
            button1.Size = new Size(80, 23);
            button1.TabIndex = 13;
            button1.Text = "Anterior ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(227, 550);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 14;
            button2.Text = "Siguiente ";
            button2.UseVisualStyleBackColor = true;
            // 
            // ESTRUTURAS_Y_REGLAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 642);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ESTRUTURAS_Y_REGLAS";
            Text = "ESTRUTURAS_Y_REGLAS";
            Load += ESTRUTURAS_Y_REGLAS_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1titulo;
        private PictureBox pictureBox1;
        private Label lblexplicacion;
        private GroupBox groupBox1;
        private Label lblestructura;
        private GroupBox groupBox2;
        private Label lBLREGLAS;
        private Label labelideadelsabias;
        private Panel panel3;
        private Label labelsabias;
        private Label lblopcion;
        private Label lblpregunta;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton rbcompilacion;
        private RadioButton rbsecuencia;
        private RadioButton rbdepuracion;
        private RadioButton rbIntalacion;
        private Button buttoncomprobar;
        private RadioButton radioButton2;
        private RadioButton rbDEPURACION;
        private Label label;
        private Label labeltexpis;
        private Button button2;
        private Button button1;
    }
}