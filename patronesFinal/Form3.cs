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
    public partial class Form3 : Form
    {
        public Form3(string nombre)
        {
            InitializeComponent();

            string Nomb = nombre;
            lbl_saludo_b.Text = "BIENVENIDO DE NUEVO " + Nomb; 

            float saldo = 2500;
            lbl_saldo.Text = "$ " + saldo + " MXN";
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mens = "Encontraste un servicio que se encuentra en mantenimiento, intenta en unas horas mas tarde.";
            string title = "Oops... I did it again.";
            MessageBox.Show(mens, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
