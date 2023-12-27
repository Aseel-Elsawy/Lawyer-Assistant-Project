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
namespace LawyerAssistant;

public partial class Form6 : Form
{
    public Form6()
    {
        InitializeComponent();
    }

    private void Login_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        foreach (Control txt in this.Controls)
        {
            if (txt is TextBox)
            {
                if (txt.Text == "")
                {
                    MessageBox.Show("please enter correct data", "failure");
                    return;
                }

            }

        }



        SqlConnection cn = new SqlConnection("Data Source=SQLOLEDB.1;Password=samah;Persist Security Info=True;User ID=sa;Initial Catalog=lawyer;Data Source=DESKTOP-678O052\\Aseel");
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "select * from UserAccounts where name='" + nametxt.Text + "' and password='" + passwordtxt.Text + "' ";
        cmd.Connection = cn;
        cn.Open();
        SqlDataReader rd = cmd.ExecuteReader();
        rd.Read();
        if (rd.HasRows)
        {
            Form7 assist = new Form7();
            assist.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("user not found", "user accounts");

        }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
       Form1 add = new Form1();
        add.Show();
        this.Hide();
    }
}

