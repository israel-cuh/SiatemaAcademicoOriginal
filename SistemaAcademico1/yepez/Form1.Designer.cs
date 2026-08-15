namespace SistemaAcademico1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnsalir = new Button();
            picOjo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOjo).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.BackgroundImageLayout = ImageLayout.Stretch;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(449, 390);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(272, 30);
            btnIngresar.TabIndex = 1;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Navy;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = SystemColors.Info;
            txtUsuario.Location = new Point(449, 229);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(272, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter_1;
            txtUsuario.Leave += txtUsuario_Leave_1;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Navy;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClave.Location = new Point(449, 301);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(272, 27);
            txtClave.TabIndex = 3;
            txtClave.UseSystemPasswordChar = true;
            txtClave.TextChanged += txtClave_TextChanged;
            txtClave.Enter += txtClave_Enter;
            txtClave.Leave += txtClave_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(475, 129);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 4;
            label1.Text = "¡Bienvenido  a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(590, 129);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 5;
            label2.Text = "CodeNova!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(466, 151);
            label3.Name = "label3";
            label3.Size = new Size(125, 16);
            label3.TabIndex = 7;
            label3.Text = "Accede para continuar";
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.Transparent;
            btnsalir.BackgroundImage = (Image)resources.GetObject("btnsalir.BackgroundImage");
            btnsalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnsalir.FlatStyle = FlatStyle.Popup;
            btnsalir.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.ForeColor = Color.OldLace;
            btnsalir.Location = new Point(449, 426);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(272, 30);
            btnsalir.TabIndex = 8;
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // picOjo
            // 
            picOjo.BackColor = Color.Transparent;
            picOjo.BackgroundImage = (Image)resources.GetObject("picOjo.BackgroundImage");
            picOjo.BackgroundImageLayout = ImageLayout.Stretch;
            picOjo.Location = new Point(718, 301);
            picOjo.Name = "picOjo";
            picOjo.Size = new Size(28, 27);
            picOjo.TabIndex = 9;
            picOjo.TabStop = false;
            picOjo.Click += picOjo_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(841, 646);
            Controls.Add(picOjo);
            Controls.Add(btnsalir);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOjo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btnsalir;
        private PictureBox picOjo;
    }
}
