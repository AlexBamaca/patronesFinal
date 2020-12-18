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
            SqlConnection conecta = new SqlConnection();
            conecta.ConnectionString = "Data Source=(LocalDB)//MSSQLLocalDB;AttachDbFilename=\"C: /Users/DELL CORE I3/Documents/9 - Patrones/patronesFinal/patronesFinal/dbPatrones.mdf\";Integrated Security=True;";
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
            //this.usersTableAdapter.Fill(this.dbPatronesDataSet.Users);
            SqlConnection conecta = new SqlConnection("Data Source=(LocalDB)//MSSQLLocalDB;AttachDbFilename=\"C: /Users/DELL CORE I3/Documents/9 - Patrones/patronesFinal/patronesFinal/dbPatrones.mdf\";Integrated Security=True;");
            //conecta.Open();

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            SqlConnection conecta = new SqlConnection();
            conecta.ConnectionString = "Data Source=(LocalDB)//MSSQLLocalDB;AttachDbFilename=\"C: /Users/DELL CORE I3/Documents/9 - Patrones/patronesFinal/patronesFinal/dbPatrones.mdf\";Integrated Security=True;";
            conecta.Open();

            string user = txb_user.Text;
            string pass = txb_pass.Text;

            SqlCommand com = new SqlCommand("select loginuser, pass from Users where loginuser='" + txb_user.Text + "' and pass='" + txb_pass.Text + "'", conecta);
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0 )
            {
                MessageBox.Show("Sesion iniciada correctamente, esere un momento...");
                System.Diagnostics.Process.Start("https://www.bancoppel.com/banca_personal_bcopp/main.html");
            }
            else
            {
                MessageBox.Show("Error de inicio, intente de nuevo");
            }

            conecta.Close();

        }
    }
}
