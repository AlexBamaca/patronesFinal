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


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
