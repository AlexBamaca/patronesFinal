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
        //private float Saldo = 2500;

        Cuenta C = new Cuenta();
        retiros Op = new retiros();

        Memento objetoMemento = new Memento();


        public Form3()
        {

            InitializeComponent();
            //lbl_saldo.Text = Saldo.ToString("C2");
            lbl_saldo.Text = C.Saldo.ToString("C2");

            //botones de pantalla de inicio activados
            button4Retirar.Visible = true;
            button5Transferir.Visible = true;
            button6Pagar.Visible = true;
            bt_return_login.Visible = true;

            //iluminando boton principal
            button4Retirar.Focus();

            //boton y cadenas para pantalla de transferencias desactivados
            textBox3Tarjeta.Visible = false;
            textBox2Cantidad.Visible = false;
            textBox1Concepto.Visible = false;
            btEnviar.Visible = false;
            bt_return_general.Visible = false;
            label6NTarjeta.Visible = false;
            label6Cantidad.Visible = false;
            label6Concepto.Visible = false;
            checkBox1TokenMovil.Visible = false;

            //botones para pantalla de retiro desactivados
            label6.Visible = false;
            tbRetirar.Visible = false;
            button4.Visible = false;
            bt_return_retiros_a_inicio.Visible = false;

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
            lbl_saldo.Text = C.Saldo.ToString("C2");
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Close();
            F.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mens = "Encontraste un servicio que se encuentra en mantenimiento, intenta mas tarde.";
            string title = "Oops... I did it again.";
            MessageBox.Show(mens, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //llamando a la forma de retiro de efectivo.
            
        }

        //boton para activar la pantalla de retiro de efectivo.
        private void button4_Click_1(object sender, EventArgs e)
        {
            //haciendo visible los botones para retiro de efectivo
            label6.Visible = true;
            tbRetirar.Visible = true;
            button4.Visible = true;
            bt_return_retiros_a_inicio.Visible = true;

            //desactivando los botones de inicio
            button4Retirar.Visible = false;
            button5Transferir.Visible = false;
            button6Pagar.Visible = false;
            bt_return_login.Visible = false;

            //condicion para desactivar el boton en caso de que no cuente con saldo suficiente
            tbRetirar.Focus();
            float Condicion = C.Saldo;
            if (Condicion <= 0)
            { button4.Enabled = false; }

            //Form4 Retiro = new Form4();
            //Retiro.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form5 Transferir = new Form5();
            //Transferir.Show();

            if (objetoMemento.NTarjeta != "" && objetoMemento.Cantidad == "" && objetoMemento.Concepto == "")
            { MessageBox.Show("Hubo un cierre inesperado, pero se salvaron los siguientes datos:\nNumero de tarjeta : " + objetoMemento.NTarjeta); }

            if (objetoMemento.NTarjeta != "" && objetoMemento.Cantidad != "" && objetoMemento.Concepto == "")
            { MessageBox.Show("Hubo un cierre inesperado, pero se salvaron los siguientes datos:\nNumero de tarjeta : " + objetoMemento.NTarjeta + "\nCantidad : " + objetoMemento.Cantidad); }

            if (objetoMemento.NTarjeta != "" && objetoMemento.Cantidad != "" && objetoMemento.Concepto != "")
            { MessageBox.Show("Hubo un cierre inesperado, pero se salvaron los siguientes datos:\nNumero de tarjeta : " + objetoMemento.NTarjeta + "\nCantidad : " + objetoMemento.Cantidad + "\nConcepto : " + objetoMemento.Concepto); }

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
                transferir Op = new transferir();
                string NTarjeta = textBox3Tarjeta.Text;
                float Cantidad = Convert.ToSingle(textBox2Cantidad.Text);
                Op.Cantidad = Cantidad;
                string Concepto = textBox1Concepto.Text;

                if (Cantidad <= C.Saldo)
                {
                    //el saldo es aceptado.
                    float newsaldo = Op.OpTransferir(C.Saldo);
                    C.Saldo = newsaldo;

                    string mes = "Se ha enviado correctamente el deposito!\n\nSe ha enviado la cantidad de $ " + Cantidad + " MXN a la tarjeta " + NTarjeta + ". \nCon un concepto de: " + Concepto + ". \n\nGracias por tu preferencia!";
                    string title = "Operacion exitosa!";
                    MessageBox.Show(mes, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Te queda un total de $ " + newsaldo.ToString() + " MXN para enviar en otro deposito.");
                    lbl_saldo.Text = "$ " + C.Saldo.ToString() + " MXN";

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

            //codigo que demuestra el funcionamiento de Memento en la forma.
            //MessageBox.Show("Se agrego el " + objetoMemento.NTarjeta);
        }

        private void textBox2Cantidad_TextChanged(object sender, EventArgs e)
        {
            objetoMemento.Cantidad = textBox2Cantidad.Text;
        }

        private void textBox1Concepto_TextChanged(object sender, EventArgs e)
        {
            objetoMemento.Concepto = textBox1Concepto.Text;
        }

        private void lbl_saldo_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //Codigo para hacer un retiro.
            float retiro = Convert.ToSingle(tbRetirar.Text);
            Op.CantRetiro = Convert.ToSingle(tbRetirar.Text);

            if (retiro <= C.Saldo && retiro > 0)
            {
                float new_saldo = Op.RetOperacion(C.Saldo);
                C.Saldo = new_saldo;
                //imprimir mensaje
                string mens = "Retiro realizado con exito!";
                string title = "Exito - BANCOFY";
                MessageBox.Show(mens, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Tu saldo ha bajado a $ " + new_saldo.ToString() + " por el retiro realizado.");
                lbl_saldo.Text = "$ " + new_saldo.ToString() + " MXN";
                tbRetirar.Text = "";
                tbRetirar.Focus();
            }
            else
            {
                //mensaje de error por cantidad demasiado baja o alta.
                string mens = "Error. Introduce la cantidad correcta. Recuerda que debe ser menor a tu saldo actual.";
                string title = "Error - BANCOFY";
                MessageBox.Show(mens, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbRetirar.Focus();
            }
        }

        private void bt_return_retiros_a_inicio_Click(object sender, EventArgs e)
        {
            //activando botones de la pantalla de inicio
            button4Retirar.Visible = true;
            button5Transferir.Visible = true;
            button6Pagar.Visible = true;
            bt_return_login.Visible = true;

            //desactivando botones de la pantalla de retiros
            label6.Visible = false;
            tbRetirar.Visible = false;
            button4.Visible = false;
            bt_return_retiros_a_inicio.Visible = false;

        }
    }
}
