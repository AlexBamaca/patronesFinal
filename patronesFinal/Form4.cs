﻿using System;
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
        
        Cuenta cuenta = new Cuenta();
        float saldo = 2500;
        retiros Op = new retiros();

        public Form4()
        {
            InitializeComponent();
           

           lbl_saldo.Text = "$ " + saldo.ToString() + " MXN";
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            Form3 General = new Form3();
            General.Show();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            
            //Codigo para hacer un retiro.
            float retiro = Convert.ToSingle(tbRetirar.Text);
            Op.CantRetiro = Convert.ToSingle(tbRetirar.Text);

            if (retiro <= saldo && retiro > 0)
            {
                float new_saldo = Op.RetOperacion(saldo);
               saldo = new_saldo;
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

        private void Form4_Load(object sender, EventArgs e)
        {
            tbRetirar.Focus();
            float Condicion = saldo;
            if (Condicion <= 0)
            { button1.Enabled = false; }     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbRetirar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
