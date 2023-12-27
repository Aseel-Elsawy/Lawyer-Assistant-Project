using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawyerAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=SQLOLEDB.1;Password=samah;Persist Security Info=True;User ID=sa;Initial Catalog=lawyer;Data Source=DESKTOP-678O052\\Aseel");
            DataSet data = new DataSet();
            data.ReadXml("AdminPasswords.xml");
            byte[] decrypted = Convert.FromBase64String(data.Tables[0].Rows[0][0].ToString());
            string decstring = UTF8Encoding.UTF8.GetString(decrypted);
            if (data.Tables[0].Rows[0][0].ToString() != "" && decstring == mangpass.Text)

            {
                SqlCommand cm = new SqlCommand();
                cm.CommandText = "insert into UserAccounts values('" + nametxt.Text + "','" + passwordtxt.Text + "')";
                cm.Connection = cn;
                cn.Open();
                int affected = cm.ExecuteNonQuery();
                if (affected > 0)
                {
                    MessageBox.Show("user saved");
                }
                else
                {
                    MessageBox.Show(" this is an failure");

                }
                cn.Close();
            }
            else
            {
                MessageBox.Show("incorrect password");
            }

            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Text = "";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

