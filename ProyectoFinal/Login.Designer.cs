namespace ProyectoFinal
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contrase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalida = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.claseBoton1 = new ProyectoFinal.Resources.claseBoton();
            this.btnAcceder = new ProyectoFinal.Resources.claseBoton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 461);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources._602ded2e_97cb_4808_8f39_5944f4769b26nk2;
            this.pictureBox1.Location = new System.Drawing.Point(17, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 182);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(526, 1);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(363, 285);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(526, 1);
            this.textBox2.TabIndex = 9;
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usuario.Location = new System.Drawing.Point(363, 154);
            this.usuario.Multiline = true;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(526, 33);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "USUARIO";
            this.usuario.Enter += new System.EventHandler(this.txtusuario);
            this.usuario.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // contrase
            // 
            this.contrase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.contrase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contrase.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrase.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.contrase.Location = new System.Drawing.Point(363, 255);
            this.contrase.Multiline = true;
            this.contrase.Name = "contrase";
            this.contrase.Size = new System.Drawing.Size(526, 33);
            this.contrase.TabIndex = 2;
            this.contrase.Text = "CONTRASEÑA";
            this.contrase.Enter += new System.EventHandler(this.contrase_Enter);
            this.contrase.Leave += new System.EventHandler(this.contrase_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(564, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // btnsalida
            // 
            this.btnsalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsalida.Image = global::ProyectoFinal.Properties.Resources.icons8_x_24_1_;
            this.btnsalida.Location = new System.Drawing.Point(993, 0);
            this.btnsalida.Name = "btnsalida";
            this.btnsalida.Size = new System.Drawing.Size(48, 31);
            this.btnsalida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnsalida.TabIndex = 6;
            this.btnsalida.TabStop = false;
            this.btnsalida.Click += new System.EventHandler(this.pictureBox3_Click);
            this.btnsalida.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.btnsalida.MouseLeave += new System.EventHandler(this.btnsalida_MouseLeave);
            this.btnsalida.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnsalida_MouseMove);
            this.btnsalida.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnsalida_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::ProyectoFinal.Properties.Resources.minus;
            this.pictureBox4.Location = new System.Drawing.Point(950, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(513, 410);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(218, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Has olvidado la contraseña?";
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            this.linkLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseMove);
            // 
            // claseBoton1
            // 
            this.claseBoton1.BackColor = System.Drawing.Color.MediumBlue;
            this.claseBoton1.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.claseBoton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.claseBoton1.BorderRadius = 20;
            this.claseBoton1.BorderSize = 0;
            this.claseBoton1.FlatAppearance.BorderSize = 0;
            this.claseBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.claseBoton1.ForeColor = System.Drawing.Color.White;
            this.claseBoton1.Location = new System.Drawing.Point(349, 340);
            this.claseBoton1.Name = "claseBoton1";
            this.claseBoton1.Size = new System.Drawing.Size(265, 45);
            this.claseBoton1.TabIndex = 5;
            this.claseBoton1.Text = "Crear cuenta";
            this.claseBoton1.TextColor = System.Drawing.Color.White;
            this.claseBoton1.UseVisualStyleBackColor = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAcceder.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.btnAcceder.BorderColor = System.Drawing.Color.Peru;
            this.btnAcceder.BorderRadius = 20;
            this.btnAcceder.BorderSize = 0;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.Location = new System.Drawing.Point(640, 340);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(265, 45);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.TextColor = System.Drawing.Color.White;
            this.btnAcceder.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1041, 461);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.claseBoton1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.contrase);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.btnsalida);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btnsalida;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contrase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Resources.claseBoton btnAcceder;
        private Resources.claseBoton claseBoton1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}