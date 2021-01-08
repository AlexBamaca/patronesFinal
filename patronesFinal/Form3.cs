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
        Cuenta C = new Cuenta();

        public Form3()
        {
            InitializeComponent();

            if ("6642950131" == C.User)
            {
                string Nomb;
                Nomb = C.NombreM.ToUpper();
                lbl_saludo_b.Text = "BIENVENIDO DE NUEVO " + Nomb;
            }
            else if (C.User == "6644156623")
            {
                string Nomb;
                Nomb = C.NombreE.ToUpper();
                lbl_saludo_b.Text = "BIENVENIDO DE NUEVO " + Nomb;
            }
            else
            { MessageBox.Show("Se encontro un error al cargar los datos."); }

            lbl_saldo.Text = C.Saldo.ToString("C2");

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
            button4.Focus();
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

        private void button4_Click(object sender, EventArgs e)
        {
            //llamando a la forma de retiro de efectivo.
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 Retiro = new Form4();
            Retiro.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 Transferir = new Form5();
            Transferir.Show();
        }
    }
}
