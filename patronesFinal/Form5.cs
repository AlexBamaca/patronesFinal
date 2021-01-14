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
        public Form5()
        {
            InitializeComponent();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            Cuenta Ahorros = new Cuenta();
            float Saldo = Ahorros.Saldo;

            if (checkBox1.Checked == true)
            {
                string NTarjeta = textBox3Tarjeta.Text;
                float Cantidad = Convert.ToSingle(textBox2Cantidad.Text);
                string Concepto = textBox1Concepto.Text;

                if (Cantidad >= Saldo)
                {
                    //el saldo es aceptado.
                    float newsaldo = Saldo - Cantidad;
                    Ahorros.Saldo = newsaldo;

                    string mes = "Se ha enviado correctamente el deposito! \n Se ha enviado la cantidad de $ " + Cantidad + " MXN a la tarjeta " + NTarjeta + ". Gracias por tu preferencia!";
                    string title = "Operacion exitosa!";
                    MessageBox.Show(mes, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
    }
}
