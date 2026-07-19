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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaControl));
            btnMinimizar = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.BackgroundImage = (Image)resources.GetObject("btnMinimizar.BackgroundImage");
            btnMinimizar.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.FlatAppearance.BorderColor = Color.FromArgb(70, 95, 170);
            btnMinimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(132, 78, 255);
            btnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 105, 210);
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMinimizar.ForeColor = Color.Transparent;
            btnMinimizar.Location = new Point(0, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(36, 28);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImage = (Image)resources.GetObject("btnCerrar.BackgroundImage");
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(205, 85, 105);
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(110, 25, 40);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 65, 85);
            btnCerrar.FlatStyle = FlatStyle.Popup;
            btnCerrar.Font = new Font("SimSun-ExtG", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Transparent;
            btnCerrar.Location = new Point(41, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 28);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
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
