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
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LawyerAssistant
{
    public partial class Form4 : Form
    {
        SqlConnection cn = new SqlConnection("Data Source=SQLOLEDB.1;Password=samah;Persist Security Info=True;User ID=sa;Initial Catalog=lawyer;Data Source=DESKTOP-678O052\\Aseel");
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "insert into sessions values ('" + DateTime.Parse(datetext.Text.ToString()) + "','" + decision.Text + "','" + demand.Text + "','" + casenobox.Text + "')";

            cm.Connection = cn;




            cn.Open();
            int affected = cm.ExecuteNonQuery();
            if (affected > 0)
            {
                MessageBox.Show("session saved");
                cn.Close();
                fillcombobox();
                foreach (Control txt in this.Controls)
                {
                    if (txt is ComboBox or RichTextBox)
                    {
                        txt.Text = "";
                    }

                }

            }
            else
            {
                MessageBox.Show(" this is an failure");
                cn.Close();
                fillcombobox();
            }
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            fillcombobox();
        }

        private void fillcombobox()
        {
            deletebox.Items.Clear();
            casenobox.Items.Clear();
            clientbox.Items.Clear();
            oppobox.Items.Clear();
            opponentbox1.Items.Clear();
            clientbox1.Items.Clear();
            casenoedit.Items.Clear();
            casenobox1.Items.Clear();
            caseno4.Items.Clear();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select * from opponent";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                oppobox.Items.Add(dr[0].ToString());
                opponentbox1.Items.Add(dr[0].ToString());

            }
            dr.Close();

            cm.CommandText = "select * from clients";
            cm.Connection = cn;

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                clientbox.Items.Add(dr[0].ToString());
                clientbox1.Items.Add(dr[0].ToString());
            }
            dr.Close();

            cm.CommandText = "select * from [case]";
            cm.Connection = cn;

            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                casenobox.Items.Add(dr[0].ToString());
                casenoedit.Items.Add(dr[0].ToString());
                deletebox.Items.Add(dr[0].ToString());

            }
            dr.Close();
            cm.CommandText = "select * from sessions";
            cm.Connection = cn;

            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                caseno4.Items.Add(dr[4].ToString());
                casenobox1.Items.Add(dr[4].ToString());

            }
            dr.Close();

            cn.Close();
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
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "insert into [case] (AuthoriziationNo,subject,  CourtName, date, cname, cstatus, copponent, ostatus,CaseNo) " +
                " values ('" + authoNo.Text + "','" + topictxt.Text + "','" + courttxt.Text + "','" + DateTime.Parse(datetxt.Text).ToString() + "','" + clientbox.Text + "'" +
                ",'" + clientstat.Text + "','" + oppobox.Text + "','" + oppostat.Text + "','" + caseno.Text + "') ";
            cm.Connection = cn;
            cn.Open();
            int affected = cm.ExecuteNonQuery();
            if (affected > 0)
            {
                MessageBox.Show("case saved", "cases");
                cn.Close();
                fillcombobox();
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
                fillcombobox();
            }
            
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            button2.Enabled = true;
            groupBox1.Enabled = false;
            groupBox3.Enabled = false;
            button1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            button1.Enabled = true;
            groupBox2.Enabled = false;
            button2.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();


            cm.CommandText = "update [case] set AuthoriziationNo='" + authootxt1.Text + "',subject='" + topictext1.Text + "',CourtName='" + courttxt1.Text + "' , date='" + date1.Value + "',cname='" + clientbox1.Text + "',cstatus='" + clientstatus1.Text + "',  copponent='" + opponentbox1.Text + "',ostatus='" + oppostat1.Text + "' where (CaseNo='" + casenoedit.Text + "')";

            cm.Connection = cn;
            cn.Open();
            int affected = cm.ExecuteNonQuery();
            if (affected > 0)
            {
                MessageBox.Show("case updated","cases");
                cn.Close();
                fillcombobox();

            }
            else
            {
                MessageBox.Show(" this is an failure","cases");
                cn.Close();
                fillcombobox();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "update sessions set dessicions='" + decision1.Text + "',demands='" + demand1.Text + "' where (date='" + datecombo.Text + "') and (caseNo='" + casenobox1.Text + "')";
            cm.Connection = cn;

            cn.Open();
            int affected = cm.ExecuteNonQuery();
            if (affected > 0)
            {
                MessageBox.Show("session updated","sessions");
                cn.Close();
                fillcombobox();


            }
            else
            {
                MessageBox.Show(" this is an failure","sessions");
                cn.Close();
                fillcombobox();
            }
        }

        private void casenoedit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select* from [case] where CaseNo='" + casenoedit.SelectedItem + "'";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            casenoedit.SelectedItem = dr[0].ToString();
            topictext1.Text = dr[1].ToString();
            authootxt1.Text = dr[2].ToString();
            courttxt1.Text = dr[3].ToString();
            date1.Value = DateTime.Parse(dr[4].ToString());
            clientbox1.SelectedItem = dr[5].ToString();
            clientstatus1.SelectedItem = dr[6].ToString();
            opponentbox1.SelectedItem = dr[7].ToString();
            oppostat1.SelectedItem = dr[8].ToString();
            dr.Close();
            cn.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = true;
            groupBox5.Enabled = true;
            button4.Enabled = true;
            groupBox4.Enabled = false;
            button3.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox6.Enabled = false;
            groupBox5.Enabled = false;
            button4.Enabled = false;
            groupBox4.Enabled = true;
            button3.Enabled = true;

        }

        private void casenobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "select *from sessions where caseNo='" + casenobox1.SelectedItem.ToString() + "' ";


            cn.Open();

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {

                datecombo.Items.Add(DateTime.Parse(dr["date"].ToString()));
            }
            dr.Close();
            cn.Close();



        }

        private void casenobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void datetext_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "select *from sessions where caseNo='" + casenobox1.SelectedItem.ToString() + "' and date='" + DateTime.Parse(datecombo.SelectedItem.ToString()) + "'";

            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                decision1.Text = dr[2].ToString();
                demand1.Text = dr[3].ToString();
            }
            dr.Close();
            cn.Close();
        }

        private void deletebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select* from [case] where CaseNo='" + deletebox.SelectedItem + "'";
            cm.Connection = cn;
            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            deletebox.SelectedItem = dr[0].ToString();
            topic3.Text = dr[1].ToString();
            authotxt3.Text = dr[2].ToString();
            court3.Text = dr[3].ToString();
            date3.Value = DateTime.Parse(dr[4].ToString());
            client3.Text = dr[5].ToString();
            clientstatus3.SelectedItem = dr[6].ToString();
            oppo3.Text = dr[7].ToString();
            oppostat3.SelectedItem = dr[8].ToString();
            dr.Close();
            cn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "delete from [case] where (CaseNo='" + deletebox.SelectedItem.ToString() + "')";

            cn.Open();
            int affected = cm.ExecuteNonQuery();
            if (affected > 0)
            {
                MessageBox.Show("case deleted","cases");
                cn.Close();
                fillcombobox();
                foreach (Control txt in this.Controls)
                {
                    if (txt is TextBox or ComboBox)
                    {
                        txt.Text = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("failed","cases");
                cn.Close();
                fillcombobox();
            }
           
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox9.Enabled = true;
            groupBox8.Enabled = true;
            button6.Enabled = true;
            groupBox7.Enabled = false;
            button5.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            groupBox9.Enabled = false;
            groupBox8.Enabled = false;
            button6.Enabled = false;
            groupBox7.Enabled = true;
            button5.Enabled = true;
        }

        private void caseno4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select * from sessions where CaseNo='" + caseno4.SelectedItem.ToString() + "'", cn);

            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            datebox3.Items.Clear();
            while (dr.Read())
            {
                datebox3.Items.Add(DateTime.Parse(dr["date"].ToString()));
            }
            dr.Close();
            cn.Close();
        }

        private void datebox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select * from sessions where (caseNo='" + caseno4.SelectedItem.ToString() + "' and date='" + DateTime.Parse(datebox3.SelectedItem.ToString()) + "')";
            cm.Connection = cn;


            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            dr.Read();
            decision4.Text = dr["dessicions"].ToString();
            demands4.Text = dr["demands"].ToString();
            dr.Close();
            cn.Close();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("delete from sessions where caseNo='" + caseno4.SelectedItem.ToString() + "' and date='" + DateTime.Parse(datebox3.SelectedItem.ToString()) + "'");
            cm.Connection = cn;


            cn.Open();
            int aff = cm.ExecuteNonQuery();
            if (aff > 0)
            {
                MessageBox.Show("deleted","sessions");
                cn.Close();
                fillcombobox();
                foreach (Control txt in this.Controls)
                {
                    if (txt is ComboBox or RichTextBox)
                    {
                        txt.Text = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("failed","sessions");
                cn.Close();
                fillcombobox();
            }
            cn.Close();
           
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form7 frm = new Form7();
            this.Hide();
            frm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
