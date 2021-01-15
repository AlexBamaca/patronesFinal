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
        private float saldo = 2500;

        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //Cuenta C = new Cuenta();
        Memento objetoMemento = new Memento();

        public Form3()
        {
            InitializeComponent();       
            lbl_saldo.Text = Saldo.ToString("C2");

            button4Retirar.Visible = true;
            button5Transferir.Visible = true;
            button6Pagar.Visible = true;
            bt_return_login.Visible = true;

            button4Retirar.Focus();

            textBox3Tarjeta.Visible = false;
            textBox2Cantidad.Visible = false;
            textBox1Concepto.Visible = false;
            btEnviar.Visible = false;
            bt_return_general.Visible = false;
            label6NTarjeta.Visible = false;
            label6Cantidad.Visible = false;
            label6Concepto.Visible = false;
            checkBox1TokenMovil.Visible = false;

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
            button4Retirar.Focus();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Close();
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
            //Form5 Transferir = new Form5();
            //Transferir.Show();

            MessageBox.Show("Se salvaron los siguientes datos: " + objetoMemento.NTarjeta);

            button4Retirar.Visible = false;
            button5Transferir.Visible = false;
            button6Pagar.Visible = false;
            bt_return_login.Visible = false;

            btEnviar.Focus();



            textBox3Tarjeta.Visible = true;
            textBox2Cantidad.Visible = true;
            textBox1Concepto.Visible = true;

            textBox3Tarjeta.Text = objetoMemento.NTarjeta;
            textBox2Cantidad.Text = objetoMemento.Cantidad;
            textBox1Concepto.Text = objetoMemento.Concepto;

            btEnviar.Visible = true;
            bt_return_general.Visible = true;
            label6NTarjeta.Visible = true;
            label6Cantidad.Visible = true;
            label6Concepto.Visible = true;
            checkBox1TokenMovil.Visible = true;


        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (checkBox1TokenMovil.Checked == true)
            {
                string NTarjeta = textBox3Tarjeta.Text;
                float Cantidad = Convert.ToSingle(textBox2Cantidad.Text);
                string Concepto = textBox1Concepto.Text;

                if (Cantidad <= saldo)
                {
                    //el saldo es aceptado.
                    float newsaldo = saldo - Cantidad;
                    saldo = newsaldo;

                    string mes = "Se ha enviado correctamente el deposito! \nSe ha enviado la cantidad de $ " + Cantidad + " MXN a la tarjeta " + NTarjeta + ", con el concepto de: " + Concepto + ". \n\nGracias por tu preferencia!";
                    string title = "Operacion exitosa!";
                    MessageBox.Show(mes, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show("Te queda un total de $ " + newsaldo.ToString() + " MXN para enviar en otro deposito.");
                    lbl_saldo.Text = "$ " + saldo.ToString() + " MXN";

                    textBox3Tarjeta.Text = "";
                    textBox2Cantidad.Text = "";
                    textBox1Concepto.Text = "";

                    //aqui se borran los datos almacenados en memento
                    objetoMemento.NTarjeta = "";
                    objetoMemento.Cantidad = "";
                    objetoMemento.Concepto = "";
                }
                else
                {
                    string mes = "No cuentas con el saldo suficiente para realizar esta accion.";
                    string title = "Oops...!";
                    MessageBox.Show(mes, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string mes = "Por favor acepta el uso de tu Token Movil";
                string title = "Oops...";
                MessageBox.Show(mes, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bt_return_general_Click(object sender, EventArgs e)
        {
            textBox3Tarjeta.Visible = false;
            textBox2Cantidad.Visible = false;
            textBox1Concepto.Visible = false;
            btEnviar.Visible = false;
            bt_return_general.Visible = false;
            label6NTarjeta.Visible = false;
            label6Cantidad.Visible = false;
            label6Concepto.Visible = false;
            checkBox1TokenMovil.Visible = false;

            button5Transferir.Visible = true;
            button4Retirar.Visible = true;
            button6Pagar.Visible = true;
            bt_return_login.Visible = true;
        }

        private void textBox3Tarjeta_TextChanged(object sender, EventArgs e)
        {
            objetoMemento.NTarjeta = textBox3Tarjeta.Text;
            MessageBox.Show("Se agrego el " + objetoMemento.NTarjeta);
        }

        private void textBox2Cantidad_TextChanged(object sender, EventArgs e)
        {
            objetoMemento.Cantidad = textBox2Cantidad.Text;
        }

        private void textBox1Concepto_TextChanged(object sender, EventArgs e)
        {
            objetoMemento.Concepto = textBox1Concepto.Text;
        }
    }
}
