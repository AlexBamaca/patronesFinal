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
    public partial class Form4 : Form
    {
        Cuenta D = new Cuenta();

        public Form4()
        {
            InitializeComponent();
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            this.Hide();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Codigo para hacer un retiro.
            float retiro = Convert.ToSingle(tbRetirar.Text);
            float saldo = D.Saldo;

            if (retiro <= saldo && retiro > 0)
            {
                float new_saldo = saldo - retiro;
                D.Saldo = new_saldo;
                //imprimir mensaje
                string mens = "Retiro realizado con exito!";
                string title = "Exito - BANCOFY";
                MessageBox.Show(mens, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            float Condicion = D.Saldo;
            if (Condicion <= 0)
            { button1.Enabled = false; }     
        }
    }
}
