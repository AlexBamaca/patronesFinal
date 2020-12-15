
namespace patronesFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_nombre_banco = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_saludo_bienvenida = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nombre_banco
            // 
            this.lb_nombre_banco.AutoSize = true;
            this.lb_nombre_banco.Font = new System.Drawing.Font("Microsoft PhagsPa", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_banco.Location = new System.Drawing.Point(12, 129);
            this.lb_nombre_banco.Name = "lb_nombre_banco";
            this.lb_nombre_banco.Size = new System.Drawing.Size(152, 38);
            this.lb_nombre_banco.TabIndex = 0;
            this.lb_nombre_banco.Text = "BANCOFY";
            this.lb_nombre_banco.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lb_saludo_bienvenida
            // 
            this.lb_saludo_bienvenida.AutoSize = true;
            this.lb_saludo_bienvenida.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saludo_bienvenida.Location = new System.Drawing.Point(48, 192);
            this.lb_saludo_bienvenida.Name = "lb_saludo_bienvenida";
            this.lb_saludo_bienvenida.Size = new System.Drawing.Size(157, 16);
            this.lb_saludo_bienvenida.TabIndex = 2;
            this.lb_saludo_bienvenida.Text = "BIENVENIDO DE NUEVO";
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_login.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(51, 334);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(144, 38);
            this.bt_login.TabIndex = 3;
            this.bt_login.Text = "INICIAR SESION";
            this.bt_login.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_User.Location = new System.Drawing.Point(33, 221);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(63, 13);
            this.lb_User.TabIndex = 6;
            this.lb_User.Text = "USUARIO";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(33, 274);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(91, 13);
            this.lb_Password.TabIndex = 7;
            this.lb_Password.Text = "CONTRASEÑA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(245, 445);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_User);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_saludo_bienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_nombre_banco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanCOFY";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nombre_banco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_saludo_bienvenida;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_Password;
    }
}

