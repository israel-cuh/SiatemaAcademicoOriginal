namespace SistemaAcademico1
{
    partial class FrmJuegoCompletado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuegoCompletado));
            pnlVolverMenu = new Panel();
            SuspendLayout();
            // 
            // pnlVolverMenu
            // 
            pnlVolverMenu.BackColor = Color.Transparent;
            pnlVolverMenu.Cursor = Cursors.Hand;
            pnlVolverMenu.Location = new Point(286, 570);
            pnlVolverMenu.Name = "pnlVolverMenu";
            pnlVolverMenu.Size = new Size(438, 105);
            pnlVolverMenu.TabIndex = 0;
            pnlVolverMenu.Click += pnlVolverMenu_Click;
            // 
            // FrmJuegoCompletado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1012, 700);
            Controls.Add(pnlVolverMenu);
            Name = "FrmJuegoCompletado";
            Text = "FrmJuegoCompletado";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVolverMenu;
    }
}