using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LawyerAssistant
{
    public partial class Form5 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=SQLOLEDB.1;Password=samah;Persist Security Info=True;User ID=sa;Initial Catalog=lawyer;Data Source=DESKTOP-678O052\\Aseel");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            clientbox.Items.Clear();
            SqlCommand cm = new SqlCommand("select cname from clients ", cn);
            cn.Open();
            dataGridView1.Rows.Clear();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                clientbox.Items.Add(dr[0].ToString());


            }
            dr.Close();
            cn.Close();
        }

        private void clientbox_SelectedIndexChanged(object sender, EventArgs e)
        {


            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select * from  [case] where cname='"+ clientbox.SelectedItem.ToString() + "'";
            cm.Connection = cn;
            
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            casenobx.Items.Clear();
            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                casenobx.Items.Add(dr[0].ToString());
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);

            }
            dr.Close();
            cn.Close();

        }

        private void casenobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select*from sessions where caseNo='"+ casenobx.SelectedItem.ToString() + "'", cn);
           
            cn.Open();
            dataGridView2.Rows.Clear();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView2.Rows.Add(dr[1], dr[2], dr[3]);

            }
            dr.Close();
            cn.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form7 frm = new Form7();
            this.Hide();
            frm.Show();
        }
    }
}
