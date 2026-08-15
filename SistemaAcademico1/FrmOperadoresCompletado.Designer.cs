namespace SistemaAcademico1
{
    partial class FrmOperadoresCompletado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOperadoresCompletado));
            pnlRepasar = new Panel();
            pnlVolverMenu = new Panel();
            SuspendLayout();
            // 
            // pnlRepasar
            // 
            pnlRepasar.BackColor = Color.Transparent;
            pnlRepasar.Cursor = Cursors.Hand;
            pnlRepasar.Location = new Point(113, 667);
            pnlRepasar.Name = "pnlRepasar";
            pnlRepasar.Size = new Size(481, 74);
            pnlRepasar.TabIndex = 0;
            pnlRepasar.Click += pnlRepasar_Click;
            // 
            // pnlVolverMenu
            // 
            pnlVolverMenu.BackColor = Color.Transparent;
            pnlVolverMenu.Cursor = Cursors.Hand;
            pnlVolverMenu.Location = new Point(617, 667);
            pnlVolverMenu.Name = "pnlVolverMenu";
            pnlVolverMenu.Size = new Size(518, 74);
            pnlVolverMenu.TabIndex = 1;
            pnlVolverMenu.Click += pnlVolverMenu_Click;
            // 
            // FrmOperadoresCompletado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1231, 753);
            Controls.Add(pnlVolverMenu);
            Controls.Add(pnlRepasar);
            Name = "FrmOperadoresCompletado";
            Text = "FrmOperadoresCompletado";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRepasar;
        private Panel pnlVolverMenu;
    }
}