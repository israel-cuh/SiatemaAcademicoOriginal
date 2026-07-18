namespace SistemaAcademico1
{
    partial class VentanaControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            btnMinimizar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(28, 49, 105);
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderColor = Color.FromArgb(70, 95, 170);
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 78, 255);
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 105, 210);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinimizar.ForeColor = Color.White;
            btnMinimizar.Location = new Point(0, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(36, 28);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.Text = "—";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(160, 45, 65);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(205, 85, 105);
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(110, 25, 40);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 65, 85);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(41, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 28);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // VentanaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnCerrar);
            Controls.Add(btnMinimizar);
            Name = "VentanaControl";
            Size = new Size(77, 28);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMinimizar;
        private Button btnCerrar;
    }
}
