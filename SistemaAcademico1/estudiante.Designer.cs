namespace SistemaAcademico1
{
    partial class estudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estudiante));
            pictureBox1 = new PictureBox();
            lblejercicio = new Label();
            lbldescripcion = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            btnsiguiente = new Button();
            btnanterior = new Button();
            panel3 = new Panel();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            lblconcepto = new Label();
            panelpregunta = new Panel();
            lblpregunta = new Label();
            lbl = new Label();
            lblenunciado = new Label();
            lbltitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panelpregunta.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_07_20_at_22_38_38;
            pictureBox1.Location = new Point(17, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblejercicio
            // 
            lblejercicio.AutoSize = true;
            lblejercicio.BackColor = Color.Transparent;
            lblejercicio.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblejercicio.ForeColor = SystemColors.ButtonFace;
            lblejercicio.Location = new Point(152, 25);
            lblejercicio.Name = "lblejercicio";
            lblejercicio.Size = new Size(343, 50);
            lblejercicio.TabIndex = 1;
            lblejercicio.Text = "Ejercicios guiados ";
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.BackColor = Color.Transparent;
            lbldescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldescripcion.ForeColor = SystemColors.ButtonFace;
            lbldescripcion.Location = new Point(165, 75);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(388, 15);
            lbldescripcion.TabIndex = 2;
            lbldescripcion.Text = "Practica tus conocimientos sobre pseudocodigo y estructuras basicas.";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbldescripcion);
            panel1.Controls.Add(lblejercicio);
            panel1.Location = new Point(45, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 148);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.WhatsApp_Image_2026_07_20_at_22_39_32;
            pictureBox2.Location = new Point(793, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 125);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnsiguiente);
            panel2.Controls.Add(btnanterior);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblconcepto);
            panel2.Controls.Add(panelpregunta);
            panel2.Controls.Add(lbl);
            panel2.Controls.Add(lblenunciado);
            panel2.Controls.Add(lbltitulo);
            panel2.Location = new Point(45, 186);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 429);
            panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.WhatsApp_Image_2026_07_20_at_22_39_08;
            pictureBox3.Location = new Point(742, 83);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 172);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btnsiguiente
            // 
            btnsiguiente.BackgroundImage = (Image)resources.GetObject("btnsiguiente.BackgroundImage");
            btnsiguiente.FlatStyle = FlatStyle.Popup;
            btnsiguiente.ForeColor = Color.Transparent;
            btnsiguiente.Location = new Point(823, 381);
            btnsiguiente.Name = "btnsiguiente";
            btnsiguiente.Size = new Size(75, 23);
            btnsiguiente.TabIndex = 7;
            btnsiguiente.Text = "Siguiente";
            btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            btnanterior.BackgroundImage = (Image)resources.GetObject("btnanterior.BackgroundImage");
            btnanterior.FlatStyle = FlatStyle.Popup;
            btnanterior.ForeColor = Color.Transparent;
            btnanterior.Location = new Point(70, 381);
            btnanterior.Name = "btnanterior";
            btnanterior.Size = new Size(75, 23);
            btnanterior.TabIndex = 6;
            btnanterior.Text = "Anterior";
            btnanterior.UseVisualStyleBackColor = true;
            btnanterior.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(rb4);
            panel3.Controls.Add(rb3);
            panel3.Controls.Add(rb2);
            panel3.Controls.Add(rb1);
            panel3.ForeColor = SystemColors.ButtonFace;
            panel3.Location = new Point(80, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(518, 141);
            panel3.TabIndex = 5;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(29, 97);
            rb4.Name = "rb4";
            rb4.Size = new Size(89, 19);
            rb4.TabIndex = 3;
            rb4.TabStop = true;
            rb4.Text = "Depuracion.";
            rb4.UseVisualStyleBackColor = true;
            rb4.CheckedChanged += rb4_CheckedChanged;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(29, 72);
            rb3.Name = "rb3";
            rb3.Size = new Size(91, 19);
            rb3.TabIndex = 2;
            rb3.TabStop = true;
            rb3.Text = "Compilador.";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(31, 47);
            rb2.Name = "rb2";
            rb2.Size = new Size(104, 19);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "Pseudocodigo.";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(31, 22);
            rb1.Name = "rb1";
            rb1.Size = new Size(122, 19);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "Diagrama de flujo.";
            rb1.UseVisualStyleBackColor = true;
            // 
            // lblconcepto
            // 
            lblconcepto.AutoSize = true;
            lblconcepto.BackColor = Color.Transparent;
            lblconcepto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblconcepto.ForeColor = Color.Transparent;
            lblconcepto.Location = new Point(80, 194);
            lblconcepto.Name = "lblconcepto";
            lblconcepto.Size = new Size(232, 17);
            lblconcepto.TabIndex = 4;
            lblconcepto.Text = "¿De que concepto se esta hablando?";
            // 
            // panelpregunta
            // 
            panelpregunta.BackColor = Color.Transparent;
            panelpregunta.Controls.Add(lblpregunta);
            panelpregunta.ForeColor = SystemColors.ButtonFace;
            panelpregunta.Location = new Point(80, 98);
            panelpregunta.Name = "panelpregunta";
            panelpregunta.Size = new Size(518, 84);
            panelpregunta.TabIndex = 3;
            panelpregunta.Paint += panelpregunta_Paint;
            // 
            // lblpregunta
            // 
            lblpregunta.Location = new Point(31, 22);
            lblpregunta.Name = "lblpregunta";
            lblpregunta.Size = new Size(467, 34);
            lblpregunta.TabIndex = 0;
            lblpregunta.Text = "\"Es una forma de escribir los pasos de un algoritmo utilizando lenguaje sencillo, sin depender de un lenguaje de programación.\"";
            lblpregunta.Click += label1_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = SystemColors.ButtonFace;
            lbl.Location = new Point(80, 65);
            lbl.Name = "lbl";
            lbl.Size = new Size(345, 17);
            lbl.TabIndex = 2;
            lbl.Text = "Lee la siguiente descripcion y responde mentalmente :";
            lbl.Click += lbl_Click;
            // 
            // lblenunciado
            // 
            lblenunciado.AutoSize = true;
            lblenunciado.BackColor = Color.Transparent;
            lblenunciado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblenunciado.ForeColor = SystemColors.ButtonFace;
            lblenunciado.Location = new Point(80, 36);
            lblenunciado.Name = "lblenunciado";
            lblenunciado.Size = new Size(65, 17);
            lblenunciado.TabIndex = 1;
            lblenunciado.Text = "responde";
            lblenunciado.Click += lblenunciado_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.BackColor = Color.Transparent;
            lbltitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ButtonFace;
            lbltitulo.Location = new Point(458, 19);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(70, 20);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Ejercicio ";
            lbltitulo.Click += lbltitulo_Click;
            // 
            // estudiante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1188, 642);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "estudiante";
            Text = "estudiante";
            Load += estudiante_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelpregunta.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblejercicio;
        private Label lbldescripcion;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label lbltitulo;
        private Label lbl;
        private Label lblenunciado;
        private Panel panelpregunta;
        private Label lblpregunta;
        private Panel panel3;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3;
        private RadioButton rb4;
        private Label lblconcepto;
        private Button btnanterior;
        private Button btnsiguiente;
        private PictureBox pictureBox3;
    }
}