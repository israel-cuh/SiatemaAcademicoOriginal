using System.Windows.Forms;

namespace SistemaAcademico1
{
    partial class MenuPrinciDiagram
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrinciDiagram));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresarDocenteDiagram = new System.Windows.Forms.Button();
            this.panelDocente = new System.Windows.Forms.Panel();
            this.panelESTUDIANTE = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIngresarEstudianteDiagram = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloPrincip = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnComenzarJuego = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelJuego = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACCEDER DOCENTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresarDocenteDiagram
            // 
            this.btnIngresarDocenteDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.btnIngresarDocenteDiagram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnIngresarDocenteDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarDocenteDiagram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDocenteDiagram.ForeColor = System.Drawing.Color.White;
            this.btnIngresarDocenteDiagram.Location = new System.Drawing.Point(24, 223);
            this.btnIngresarDocenteDiagram.Name = "btnIngresarDocenteDiagram";
            this.btnIngresarDocenteDiagram.Size = new System.Drawing.Size(171, 50);
            this.btnIngresarDocenteDiagram.TabIndex = 1;
            this.btnIngresarDocenteDiagram.Text = "INGRESAR COMO DOCENTE >";
            this.btnIngresarDocenteDiagram.UseVisualStyleBackColor = false;
            this.btnIngresarDocenteDiagram.Click += new System.EventHandler(this.btnIngresarDocenteDiagram_Click);
            // 
            // panelDocente
            // 
            this.panelDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.panelDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDocente.Controls.Add(this.btnIngresarDocenteDiagram);
            this.panelDocente.Controls.Add(this.pictureBox1);
            this.panelDocente.Controls.Add(this.label1);
            this.panelDocente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.panelDocente.Location = new System.Drawing.Point(92, 128);
            this.panelDocente.Name = "panelDocente";
            this.panelDocente.Size = new System.Drawing.Size(220, 330);
            this.panelDocente.TabIndex = 0;
            // 
            // panelESTUDIANTE
            // 
            this.panelESTUDIANTE.AutoSize = true;
            this.panelESTUDIANTE.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelESTUDIANTE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panelESTUDIANTE.Location = new System.Drawing.Point(8, 46);
            this.panelESTUDIANTE.Name = "panelESTUDIANTE";
            this.panelESTUDIANTE.Size = new System.Drawing.Size(207, 25);
            this.panelESTUDIANTE.TabIndex = 1;
            this.panelESTUDIANTE.Text = "ACCEDER ESTUDIANTE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnIngresarEstudianteDiagram
            // 
            this.btnIngresarEstudianteDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.btnIngresarEstudianteDiagram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnIngresarEstudianteDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarEstudianteDiagram.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarEstudianteDiagram.ForeColor = System.Drawing.Color.White;
            this.btnIngresarEstudianteDiagram.Location = new System.Drawing.Point(24, 223);
            this.btnIngresarEstudianteDiagram.Name = "btnIngresarEstudianteDiagram";
            this.btnIngresarEstudianteDiagram.Size = new System.Drawing.Size(171, 50);
            this.btnIngresarEstudianteDiagram.TabIndex = 1;
            this.btnIngresarEstudianteDiagram.Text = "INGRESAR COMO ESTUDIANTE >";
            this.btnIngresarEstudianteDiagram.UseVisualStyleBackColor = false;
            this.btnIngresarEstudianteDiagram.Click += new System.EventHandler(this.btnIngresarEstudianteDiagram_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnIngresarEstudianteDiagram);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panelESTUDIANTE);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.panel1.Location = new System.Drawing.Point(469, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 330);
            this.panel1.TabIndex = 1;
            // 
            // lblTituloPrincip
            // 
            this.lblTituloPrincip.AutoSize = true;
            this.lblTituloPrincip.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincip.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblTituloPrincip.Location = new System.Drawing.Point(336, 36);
            this.lblTituloPrincip.Name = "lblTituloPrincip";
            this.lblTituloPrincip.Size = new System.Drawing.Size(575, 45);
            this.lblTituloPrincip.TabIndex = 3;
            this.lblTituloPrincip.Text = "SISTEMA DE DIAGRAMAS DE FLUJO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(23)))), ((int)(((byte)(38)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnComenzarJuego);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.panelJuego);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.panel2.Location = new System.Drawing.Point(846, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 330);
            this.panel2.TabIndex = 2;
            // 
            // btnComenzarJuego
            // 
            this.btnComenzarJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(34)))), ((int)(((byte)(206)))));
            this.btnComenzarJuego.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.btnComenzarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzarJuego.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzarJuego.ForeColor = System.Drawing.Color.White;
            this.btnComenzarJuego.Location = new System.Drawing.Point(24, 223);
            this.btnComenzarJuego.Name = "btnComenzarJuego";
            this.btnComenzarJuego.Size = new System.Drawing.Size(171, 50);
            this.btnComenzarJuego.TabIndex = 1;
            this.btnComenzarJuego.Text = "COMENZAR EL JUEGO >";
            this.btnComenzarJuego.UseVisualStyleBackColor = false;
            this.btnComenzarJuego.Click += new System.EventHandler(this.btnComenzarJuego_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(171, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panelJuego
            // 
            this.panelJuego.AutoSize = true;
            this.panelJuego.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelJuego.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panelJuego.Location = new System.Drawing.Point(32, 46);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(154, 25);
            this.panelJuego.TabIndex = 1;
            this.panelJuego.Text = "ACCEDER JUEGO";
            // 
            // MenuPrinciDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1244, 555);
            this.Controls.Add(this.lblTituloPrincip);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDocente);
            this.Name = "MenuPrinciDiagram";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDocente.ResumeLayout(false);
            this.panelDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIngresarDocenteDiagram;
        private System.Windows.Forms.Panel panelDocente;
        private System.Windows.Forms.Label panelESTUDIANTE;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIngresarEstudianteDiagram;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloPrincip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnComenzarJuego;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label panelJuego;
    }
}


