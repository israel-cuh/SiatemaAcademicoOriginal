namespace SistemaAcademico1
{
    partial class FrmTiposDatosCompletado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTiposDatosCompletado));
            pnlSiguienteTema = new Panel();
            pnlRepasar = new Panel();
            SuspendLayout();
            // 
            // pnlSiguienteTema
            // 
            pnlSiguienteTema.BackColor = Color.Transparent;
            pnlSiguienteTema.Cursor = Cursors.Hand;
            pnlSiguienteTema.Location = new Point(664, 655);
            pnlSiguienteTema.Name = "pnlSiguienteTema";
            pnlSiguienteTema.Size = new Size(511, 82);
            pnlSiguienteTema.TabIndex = 0;
            pnlSiguienteTema.Click += pnlSiguienteTema_Click;
            //pnlSiguienteTema.Paint += pnlSiguienteTema_Paint;
            // 
            // pnlRepasar
            // 
            pnlRepasar.BackColor = Color.Transparent;
            pnlRepasar.Cursor = Cursors.Hand;
            pnlRepasar.Location = new Point(59, 655);
            pnlRepasar.Name = "pnlRepasar";
            pnlRepasar.Size = new Size(566, 82);
            pnlRepasar.TabIndex = 1;
            pnlRepasar.Click += pnlRepasar_Click_1;
            // 
            // FrmTiposDatosCompletado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1231, 753);
            Controls.Add(pnlRepasar);
            Controls.Add(pnlSiguienteTema);
            DoubleBuffered = true;
            Name = "FrmTiposDatosCompletado";
            Text = "FrmTiposDatosCompletado";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSiguienteTema;
        private Panel pnlRepasar;
    }
}