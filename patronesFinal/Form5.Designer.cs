
namespace patronesFinal
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_return = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1Concepto = new System.Windows.Forms.TextBox();
            this.btEnviar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2Cantidad = new System.Windows.Forms.TextBox();
            this.textBox3Tarjeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "BANCOFY";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-19, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 70);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // bt_return
            // 
            this.bt_return.BackColor = System.Drawing.Color.Transparent;
            this.bt_return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_return.BackgroundImage")));
            this.bt_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_return.Location = new System.Drawing.Point(0, 450);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(252, 36);
            this.bt_return.TabIndex = 11;
            this.bt_return.UseVisualStyleBackColor = false;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-19, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 60);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1Concepto
            // 
            this.textBox1Concepto.Location = new System.Drawing.Point(31, 295);
            this.textBox1Concepto.Multiline = true;
            this.textBox1Concepto.Name = "textBox1Concepto";
            this.textBox1Concepto.Size = new System.Drawing.Size(192, 36);
            this.textBox1Concepto.TabIndex = 15;
            this.textBox1Concepto.TextChanged += new System.EventHandler(this.textBox1Concepto_TextChanged);
            // 
            // btEnviar
            // 
            this.btEnviar.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.Location = new System.Drawing.Point(79, 374);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(100, 35);
            this.btEnviar.TabIndex = 16;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 351);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(232, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Usar Token Movil y aceptar termino de uso.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2Cantidad
            // 
            this.textBox2Cantidad.Location = new System.Drawing.Point(66, 240);
            this.textBox2Cantidad.Name = "textBox2Cantidad";
            this.textBox2Cantidad.Size = new System.Drawing.Size(100, 20);
            this.textBox2Cantidad.TabIndex = 18;
            this.textBox2Cantidad.TextChanged += new System.EventHandler(this.textBox2Cantidad_TextChanged);
            // 
            // textBox3Tarjeta
            // 
            this.textBox3Tarjeta.Location = new System.Drawing.Point(31, 184);
            this.textBox3Tarjeta.Name = "textBox3Tarjeta";
            this.textBox3Tarjeta.Size = new System.Drawing.Size(192, 20);
            this.textBox3Tarjeta.TabIndex = 19;
            this.textBox3Tarjeta.TextChanged += new System.EventHandler(this.textBox3Tarjeta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Concepto (Opcional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Importe en pesos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Numero de tarjeta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Servicio de transferencias interbancario.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tu saldo disponible:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 63);
            this.label7.TabIndex = 25;
            this.label7.Text = "$ ).00 MXN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 486);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3Tarjeta);
            this.Controls.Add(this.textBox2Cantidad);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.textBox1Concepto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1Concepto;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2Cantidad;
        private System.Windows.Forms.TextBox textBox3Tarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}