namespace SistemaAcademico1
{
    partial class MenuEstudiante
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
            btnCerrar = new Button();
            btnCerrarSesion = new Button();
            btnTema = new Button();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(820, 233);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(168, 92);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "CERRAR";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(277, 370);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(231, 99);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnTema
            // 
            btnTema.Location = new Point(820, 380);
            btnTema.Name = "btnTema";
            btnTema.Size = new Size(212, 125);
            btnTema.TabIndex = 7;
            btnTema.Text = "Tema Ciclo";
            btnTema.UseVisualStyleBackColor = true;
            btnTema.Click += btnTema_Click;
            // 
            // MenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 655);
            Controls.Add(btnTema);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnCerrar);
            Name = "MenuEstudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuEstudiante";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCerrar;
        private Button btnCerrarSesion;
        private Button btnTema;
    }
}