using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace patronesFinal
{
    public partial class Form1 : Form
    {
        SqlConnection conecta = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbPatronesDataSet.Users' Puede moverla o quitarla según sea necesario.
            this.usersTableAdapter.Fill(this.dbPatronesDataSet.Users);

        }
    }
}
