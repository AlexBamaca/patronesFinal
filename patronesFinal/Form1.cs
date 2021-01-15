using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace patronesFinal
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            

            string user = txb_user.Text;
            string pass = txb_pass.Text;

            Cuenta N = new Cuenta();

            if (user == "6642950131" && pass == "123456")
            {
                N.User = user;
                string mens = "Bienvenido de nuevo " + N.NombreM + "!";
                string title = "Hola de nuevo!";
                MessageBox.Show(mens, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Form3 F = new Form3();
                F.Show();
                
            }
            else if (user == "6644156623" && pass == "654321")
            {
                N.User = user;
                string mens = "Bienvenido de nuevo " + N.NombreE + "!";
                string title = "Hola de nuevo!";
                MessageBox.Show(mens, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Form3 F = new Form3();
                F.Show();
            }
            else
            {
                MessageBox.Show("Error de inicio, verifique sus datos.");
            }

        }
    }
}
