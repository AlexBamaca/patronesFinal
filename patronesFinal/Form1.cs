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
        //SqlConnection conecta = new SqlConnection();   

        public Form1()
        {
            InitializeComponent();
            //SqlConnection conecta = new SqlConnection();
            //conecta.ConnectionString = "Data Source=CASA-PC\\MSSQLLocalDB;Initial Catalog=[C:\\USERS\\DELL CORE I3\\DOCUMENTS\\9-PATRONES\\PATRONESFINAL\\PATRONESFINAL\\DBPATRONES.MDF];Integrated Security=True;Connect Timeout=30;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbPatronesDataSet.Users' Puede moverla o quitarla según sea necesario.
            //this.usersTableAdapter.Fill(this.dbPatronesDataSet.Users);
            //SqlConnection conecta = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=[C:\\USERS\\DELL CORE I3\\DOCUMENTS\\9-PATRONES\\PATRONESFINAL\\PATRONESFINAL\\DBPATRONES.MDF];Integrated Security=True;Connect Timeout=30;");
            //conecta.Open();

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            //SqlConnection conecta = new SqlConnection();
            //conecta.ConnectionString = "Data Source=CASA-PC\\MSSQLLocalDB;Initial Catalog=[C:\\USERS\\DELL CORE I3\\DOCUMENTS\\9-PATRONES\\PATRONESFINAL\\PATRONESFINAL\\DBPATRONES.MDF];Integrated Security=True;Connect Timeout=30;";
            ////conecta.Open();

            string user = txb_user.Text;
            string pass = txb_pass.Text;

            if (user == "6642950131" && pass == "123456")
            {
                MessageBox.Show("Bienvenido de nuevo.");
                this.Hide();
                Form3 F = new Form3();
                F.Show();
                
            }
            else if (user == "6644156623" && pass == "654321")
            {
                MessageBox.Show("Bienvenido de nuevo.");
            }
            else
            {
                MessageBox.Show("Error de inicio, verifique sus datos.");
            }

            //SqlCommand consulta = new SqlCommand("select loginuser, pass from Users where loginuser='" + txb_user.Text + "' and pass='" + txb_pass.Text + "'", conecta);
            //SqlDataAdapter da = new SqlDataAdapter(consulta);

            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //if (dt.Rows.Count > 0 )
            //{
            //    MessageBox.Show("Sesion iniciada correctamente, esere un momento...");
            //    System.Diagnostics.Process.Start("https://www.bancoppel.com/banca_personal_bcopp/main.html");
            //}
            //else
            //{
            //    MessageBox.Show("Error de inicio, intente de nuevo");
            //}

            //conecta.Close();

        }
    }
}
