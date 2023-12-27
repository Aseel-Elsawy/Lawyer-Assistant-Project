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
using System.Linq.Expressions;
//using Microsoft.Data.SqlClient;


namespace LawyerAssistant
{
    public partial class Form2 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=SQLOLEDB.1;Password=samah;Persist Security Info=True;User ID=sa;Initial Catalog=lawyer;Data Source=DESKTOP-678O052\\Aseel");
        string selected;
        public Form2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control txt in this.Controls)
            {

                if (txt is TextBox or MaskedTextBox)
                {
                    if (txt.Text == "")
                    {
                        MessageBox.Show("please enter correct data","clients");
                        return;
                    }

                }

            }
            try
            {
                SqlCommand cm = new SqlCommand("select*from clients");
                SqlDataAdapter ad = new SqlDataAdapter(cm);
                cm.Connection = cn;
                DataSet set = new DataSet();
                ad.Fill(set);
                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {
                    if (set.Tables[0].Rows[i][0].ToString().Trim() == txtname.Text)
                    {
                        MessageBox.Show("this client had been saved before","clients");
                        throw new Exception();
                        cn.Close();
                    }
                }
                cm.CommandText = "insert into clients values ('" + txtname.Text + "','" + txtid.Text + "','" + txtaddr.Text + "','" + txttel.Text +"')";
               
                cn.Open();

                int affected = cm.ExecuteNonQuery();
                if (affected > 0)
                {
                    MessageBox.Show("user saved","clients");
                    cn.Close();
                    fillcombo();
                    foreach (Control txt in this.Controls)
                    {
                        if (txt is TextBox or MaskedTextBox)
                        {
                            txt.Text = "";
                        }

                    }

                }

                else
                {
                    MessageBox.Show(" this is an failure","failed");
                    cn.Close();
                    fillcombo();

                }
            }

            catch { }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fillcombo();

        }

        private void fillcombo()
        {
            namebox.Items.Clear();
            namebox3.Items.Clear();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select * from clients";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                namebox.Items.Add(dr[0]);
                namebox3.Items.Add(dr[0]);
            }

            cn.Close();
        }

        private void namebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = namebox.SelectedItem.ToString();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select* from clients where cname='" + namebox.SelectedItem + "'";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            namebox.Text = dr["cName"].ToString();
            txtadd2.Text = dr["cAddress"].ToString();
            txtid1.Text = dr["cNationalID"].ToString();
            txtphone2.Text = dr["cTel"].ToString();
            cn.Close();


        }

        private void button2_Click(object sender, EventArgs e)

        {
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.CommandText = "UPDATE clients SET cName='" + namebox.Text + "',cAddress='" + txtadd2.Text + "',cNationalID='" + txtid1.Text + "',cTel='" + txtphone2.Text +"' where cName='" + selected + "'";
                cm.Connection = cn;
                cn.Open();
                int affected = cm.ExecuteNonQuery();
                if (affected > 0)
                {
                    MessageBox.Show("client updated","clients");
                    cn.Close();
                    fillcombo();

                }
                else
                {
                    MessageBox.Show(" this is an failure","clients");
                    cn.Close();
                    fillcombo();
                }


            }
            catch { }

        }

        private void Form2_Activated(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select* from clients where cname='" + namebox3.SelectedItem + "'";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            namebox3.Text = dr["cName"].ToString();
            txtadd3.Text = dr["cAddress"].ToString();
            txtid3.Text = dr["cNationalID"].ToString();
            txttel3.Text = dr["cTel"].ToString();
            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "delete from clients where cname='"+namebox3.SelectedItem.ToString()+"'";

         
            cm.Connection = cn;
            cn.Open();
            int affected = cm.ExecuteNonQuery();
            if (affected > 0)
            {
                MessageBox.Show("deleted","clients");
                cn.Close();
                fillcombo();
                foreach (Control txt in this.Controls)
                {
                    if (txt is TextBox or MaskedTextBox or ComboBox)
                    {
                        txt.Text = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("this is an failure","clients");
                cn.Close();
                fillcombo();
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form7 frm = new Form7();
            this.Hide();
            frm.Show();




        }
    }
}



