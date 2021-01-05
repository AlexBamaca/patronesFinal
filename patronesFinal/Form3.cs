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
        public Form3()
        {
            InitializeComponent();
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
    }
}
