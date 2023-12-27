using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LawyerAssistant
{
    public partial class Form3 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=SQLOLEDB.1;Password=samah;Persist Security Info=True;User ID=sa;Initial Catalog=lawyer;Data Source=DESKTOP-678O052\\Aseel");
        string selected;
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "delete from opponent where oName='" + namebox3.SelectedItem.ToString() + "'";

            cm.Connection = cn;
            cn.Open();
            int affected = cm.ExecuteNonQuery();
            if (affected > 0)
            {
                MessageBox.Show("deleted", "opponents");
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
                MessageBox.Show("this is an failure", "opponents");
                cn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    if (txt.Text == "")
                    {
                        MessageBox.Show("please enter correct data", "failed");
                        return;
                    }

                }

            }
            try
            {
                SqlCommand cm = new SqlCommand("select * from opponent");
                SqlDataAdapter ad = new SqlDataAdapter(cm);
                cm.Connection = cn;
                DataSet set = new DataSet();
                ad.Fill(set);
                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {
                    if (set.Tables[0].Rows[i][0].ToString().Trim() == txtname.Text)
                    {
                        MessageBox.Show("this opponent had been saved before", "opponent"
                           );
                        throw new Exception();
                        cn.Close();
                    }
                }
                cm.CommandText = "insert into opponent values ('" + txtname.Text + "','" + txtaddr.Text + "','" + txttel.Text + "')";

                cn.Open();
                int affected = cm.ExecuteNonQuery();
                if (affected > 0)
                {
                    MessageBox.Show("opponent saved", "opponent");
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
                    MessageBox.Show(" this is an failure", "failed");
                    cn.Close();
                    fillcombo();
                }




            }

            catch { }


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            fillcombo();
        }
        private void fillcombo()
        {
            namebox.Items.Clear();
            namebox3.Items.Clear();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select * from opponent";
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
            cm.CommandText = "select* from opponent where oName='" + namebox.SelectedItem + "'";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            namebox.Text = dr["oName"].ToString();
            txtadd2.Text = dr["oAddress"].ToString();
            txtphone2.Text = dr["oTel"].ToString();
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cm = new SqlCommand();
                cm.CommandText = "UPDATE opponent SET oName='" + namebox.Text + "',oAddress='" + txtadd2.Text + "',oTel='" + txtphone2.Text + "' where oName='" + selected + "'";
                cm.Connection = cn;

                cn.Open();
                int affected = cm.ExecuteNonQuery();
                if (affected > 0)
                {
                    MessageBox.Show("opponent updated", "opponents");
                    cn.Close();
                    fillcombo();

                }
                else
                {
                    MessageBox.Show(" this is an failure", "opponents");
                    cn.Close();

                }


            }
            catch { }

        }

        private void namebox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select* from opponent where oName='" + namebox3.SelectedItem + "'";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            namebox3.Text = dr["oName"].ToString();
            txtadd3.Text = dr["oAddress"].ToString();

            txttel3.Text = dr["oTel"].ToString();
            cn.Close();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form7 frm = new Form7();
            this.Hide();
            frm.Show();
        }
    }
}
