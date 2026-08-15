namespace SistemaAcademico1
{
    partial class LogiFlowLvl1
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEnunciado1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEnunciadoSig = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.btnRegresar23 = new System.Windows.Forms.Button();
            this.flPanelPiezas = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl1Piezas = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fLPanelUnion1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnIniciar1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flPanelPiezas.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.fLPanelUnion1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panel4.Controls.Add(this.lblEnunciado1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.lblEnunciadoSig);
            this.panel4.Location = new System.Drawing.Point(266, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(756, 116);
            this.panel4.TabIndex = 3;
            // 
            // lblEnunciado1
            // 
            this.lblEnunciado1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEnunciado1.Location = new System.Drawing.Point(21, 33);
            this.lblEnunciado1.Name = "lblEnunciado1";
            this.lblEnunciado1.Size = new System.Drawing.Size(732, 68);
            this.lblEnunciado1.TabIndex = 9;
            this.lblEnunciado1.Text = "Crea un diagrama de flujo que lea dos números (a y b), calcule su suma y muestre " +
    "el resultado.";
            this.lblEnunciado1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 74);
            this.panel2.TabIndex = 8;
            // 
            // lblEnunciadoSig
            // 
            this.lblEnunciadoSig.AutoSize = true;
            this.lblEnunciadoSig.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lblEnunciadoSig.ForeColor = System.Drawing.Color.Cyan;
            this.lblEnunciadoSig.Location = new System.Drawing.Point(20, 9);
            this.lblEnunciadoSig.Name = "lblEnunciadoSig";
            this.lblEnunciadoSig.Size = new System.Drawing.Size(122, 30);
            this.lblEnunciadoSig.TabIndex = 0;
            this.lblEnunciadoSig.Text = "Enunciado:";
            this.lblEnunciadoSig.Click += new System.EventHandler(this.lblEnunciadoSig_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnIniciar1);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Controls.Add(this.btnComprobar);
            this.panel1.Location = new System.Drawing.Point(1019, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 439);
            this.panel1.TabIndex = 5;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(36, 349);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(162, 35);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente Nivel → ";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReiniciar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReiniciar.ForeColor = System.Drawing.Color.White;
            this.btnReiniciar.Location = new System.Drawing.Point(36, 254);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(162, 35);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnComprobar
            // 
            this.btnComprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnComprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnComprobar.ForeColor = System.Drawing.Color.White;
            this.btnComprobar.Location = new System.Drawing.Point(36, 172);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(162, 35);
            this.btnComprobar.TabIndex = 2;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // btnRegresar23
            // 
            this.btnRegresar23.AutoSize = true;
            this.btnRegresar23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar23.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar23.ForeColor = System.Drawing.Color.Magenta;
            this.btnRegresar23.Location = new System.Drawing.Point(44, 31);
            this.btnRegresar23.Name = "btnRegresar23";
            this.btnRegresar23.Size = new System.Drawing.Size(162, 35);
            this.btnRegresar23.TabIndex = 1;
            this.btnRegresar23.Text = "← Regresar";
            this.btnRegresar23.UseVisualStyleBackColor = true;
            this.btnRegresar23.Click += new System.EventHandler(this.btnRegresar23_Click);
            // 
            // flPanelPiezas
            // 
            this.flPanelPiezas.AutoScroll = true;
            this.flPanelPiezas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.flPanelPiezas.Controls.Add(this.lbl1Piezas);
            this.flPanelPiezas.Location = new System.Drawing.Point(0, 116);
            this.flPanelPiezas.Name = "flPanelPiezas";
            this.flPanelPiezas.Size = new System.Drawing.Size(268, 439);
            this.flPanelPiezas.TabIndex = 1;
            this.flPanelPiezas.Paint += new System.Windows.Forms.PaintEventHandler(this.flPanelPiezas_Paint);
            // 
            // lbl1Piezas
            // 
            this.lbl1Piezas.AutoSize = true;
            this.lbl1Piezas.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.lbl1Piezas.ForeColor = System.Drawing.Color.Cyan;
            this.lbl1Piezas.Location = new System.Drawing.Point(3, 0);
            this.lbl1Piezas.Name = "lbl1Piezas";
            this.lbl1Piezas.Size = new System.Drawing.Size(73, 30);
            this.lbl1Piezas.TabIndex = 1;
            this.lbl1Piezas.Text = "Piezas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panel5.Controls.Add(this.btnRegresar23);
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 114);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(16)))), ((int)(((byte)(41)))));
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(1019, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 114);
            this.panel6.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time: 30s";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fLPanelUnion1
            // 
            this.fLPanelUnion1.AllowDrop = true;
            this.fLPanelUnion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.fLPanelUnion1.Controls.Add(this.tableLayoutPanel1);
            this.fLPanelUnion1.Location = new System.Drawing.Point(269, 116);
            this.fLPanelUnion1.Name = "fLPanelUnion1";
            this.fLPanelUnion1.Size = new System.Drawing.Size(753, 439);
            this.fLPanelUnion1.TabIndex = 8;
            this.fLPanelUnion1.DragDrop += new System.Windows.Forms.DragEventHandler(this.fLPanelUnion1_DragDrop);
            this.fLPanelUnion1.DragEnter += new System.Windows.Forms.DragEventHandler(this.fLPanelUnion1_DragEnter);
            this.fLPanelUnion1.Paint += new System.Windows.Forms.PaintEventHandler(this.fLPanelUnion1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(151, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tableLayoutPanel1_DragDrop);
            this.tableLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tableLayoutPanel1_DragEnter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnIniciar1
            // 
            this.btnIniciar1.BackColor = System.Drawing.Color.Green;
            this.btnIniciar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar1.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold);
            this.btnIniciar1.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar1.Location = new System.Drawing.Point(36, 93);
            this.btnIniciar1.Name = "btnIniciar1";
            this.btnIniciar1.Size = new System.Drawing.Size(162, 45);
            this.btnIniciar1.TabIndex = 5;
            this.btnIniciar1.Text = "Jugar";
            this.btnIniciar1.UseVisualStyleBackColor = false;
            this.btnIniciar1.Click += new System.EventHandler(this.btnIniciar1_Click);
            // 
            // LogiFlowLvl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1244, 555);
            this.Controls.Add(this.fLPanelUnion1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.flPanelPiezas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "LogiFlowLvl1";
            this.Text = "LogiFlowLvl1";
            this.Load += new System.EventHandler(this.LogiFlowLvl1_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flPanelPiezas.ResumeLayout(false);
            this.flPanelPiezas.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.fLPanelUnion1.ResumeLayout(false);
            this.fLPanelUnion1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEnunciadoSig;
        private System.Windows.Forms.FlowLayoutPanel flPanelPiezas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl1Piezas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel fLPanelUnion1;
        private System.Windows.Forms.Button btnRegresar23;
        private System.Windows.Forms.Label lblEnunciado1;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar1;
    }
}
