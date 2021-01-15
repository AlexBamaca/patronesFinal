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
    public partial class Form5 : Form
    {
        float saldo = 2500;

        public Form5()
        {
            InitializeComponent();
            label7.Text = "$ " + saldo.ToString() + " MXN";
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            Cuenta Ahorros = new Cuenta();
            //float Saldo = saldo;

            if (checkBox1.Checked == true)
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
                    label7.Text = "$ " + saldo.ToString() + " MXN";

                    //aqui se borran los datos almacenados en memento
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

        private void textBox3Tarjeta_TextChanged(object sender, EventArgs e)
        {
            //aqui PUEDE ir cambiando el memento cuando se introduce texto, por el textchanged.

        }

        private void textBox2Cantidad_TextChanged(object sender, EventArgs e)
        {
            //aqui PUEDE ir cambiando el memento cuando se introduce texto, por el textchanged.

        }

        private void textBox1Concepto_TextChanged(object sender, EventArgs e)
        {
            //aqui PUEDE ir cambiando el memento cuando se introduce texto, por el textchanged.

        }
    }
}
