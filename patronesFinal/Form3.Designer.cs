
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
            this.bt_return = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_saludo_b = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.bt_return.TabIndex = 0;
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Berlin Sans FB", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo.Location = new System.Drawing.Point(56, 122);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(152, 32);
            this.lbl_saldo.TabIndex = 2;
            this.lbl_saldo.Text = "$ ).00 MXN";
            // 
            // lbl_saludo_b
            // 
            this.lbl_saludo_b.AutoSize = true;
            this.lbl_saludo_b.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saludo_b.Location = new System.Drawing.Point(13, 78);
            this.lbl_saludo_b.Name = "lbl_saludo_b";
            this.lbl_saludo_b.Size = new System.Drawing.Size(45, 16);
            this.lbl_saludo_b.TabIndex = 3;
            this.lbl_saludo_b.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tu saldo en cuenta es:";
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(251, 486);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_saludo_b);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_saludo_b;
        private System.Windows.Forms.Label label3;
    }
}