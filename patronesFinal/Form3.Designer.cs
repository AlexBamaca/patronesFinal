
namespace patronesFinal
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lb_nombre_banco = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.lb_saludo_bienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nombre_banco
            // 
            this.lb_nombre_banco.AutoSize = true;
            this.lb_nombre_banco.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_banco.Location = new System.Drawing.Point(12, 9);
            this.lb_nombre_banco.Name = "lb_nombre_banco";
            this.lb_nombre_banco.Size = new System.Drawing.Size(143, 32);
            this.lb_nombre_banco.TabIndex = 1;
            this.lb_nombre_banco.Text = "BANCOFY";
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Transparent;
            this.bt_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_close.BackgroundImage")));
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Location = new System.Drawing.Point(0, 451);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(252, 36);
            this.bt_close.TabIndex = 11;
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // lb_saludo_bienvenida
            // 
            this.lb_saludo_bienvenida.AutoSize = true;
            this.lb_saludo_bienvenida.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saludo_bienvenida.Location = new System.Drawing.Point(15, 41);
            this.lb_saludo_bienvenida.Name = "lb_saludo_bienvenida";
            this.lb_saludo_bienvenida.Size = new System.Drawing.Size(157, 16);
            this.lb_saludo_bienvenida.TabIndex = 12;
            this.lb_saludo_bienvenida.Text = "BIENVENIDO DE NUEVO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tu saldo es:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "$ 0.00 MXN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 486);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_saludo_bienvenida);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.lb_nombre_banco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nombre_banco;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Label lb_saludo_bienvenida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}