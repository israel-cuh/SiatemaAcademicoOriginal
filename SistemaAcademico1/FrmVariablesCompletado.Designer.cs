namespace SistemaAcademico1
{
    partial class FrmVariablesCompletado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVariablesCompletado));
            pnlRepasar = new Panel();
            pnlSiguienteTema = new Panel();
            SuspendLayout();
            // 
            // pnlRepasar
            // 
            pnlRepasar.BackColor = Color.Transparent;
            pnlRepasar.Cursor = Cursors.Hand;
            pnlRepasar.Location = new Point(239, 638);
            pnlRepasar.Name = "pnlRepasar";
            pnlRepasar.Size = new Size(324, 53);
            pnlRepasar.TabIndex = 0;
            pnlRepasar.Click += pnlRepasar_Click;
            // 
            // pnlSiguienteTema
            // 
            pnlSiguienteTema.BackColor = Color.Transparent;
            pnlSiguienteTema.Cursor = Cursors.Hand;
            pnlSiguienteTema.Location = new Point(611, 638);
            pnlSiguienteTema.Name = "pnlSiguienteTema";
            pnlSiguienteTema.Size = new Size(379, 53);
            pnlSiguienteTema.TabIndex = 1;
            pnlSiguienteTema.Click += pnlSiguienteTema_Click;
            // 
            // FrmVariablesCompletado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1231, 753);
            Controls.Add(pnlSiguienteTema);
            Controls.Add(pnlRepasar);
            Name = "FrmVariablesCompletado";
            Text = "FrmVariablesCompletado";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlRepasar;
        private Panel pnlSiguienteTema;
    }
}