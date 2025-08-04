using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_CoachingManagement
{
    public partial class Form1 : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        string pass = "ADMIN123";
        int tid = 0, sid = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            lb1.Visible = false;
            tb1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb1.SelectedItem.ToString() == "ADMIN")
            {
                lb1.Visible = true;
                tb1.Visible = true;
                label1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;

            }
            else if (cb1.SelectedItem.ToString() == "STUDENT")
            {
                label1.Visible = true;
                textBox1.Visible = true;
                lb1.Visible = false;
                tb1.Visible = false;
                label2.Visible = false;
                textBox2.Visible = false;


            }
            else
            {
                label2.Visible = true;
                textBox2.Visible = true;
                lb1.Visible = false;
                tb1.Visible = false;
                label1.Visible = false;
                textBox1.Visible = false;

            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {


            if (tb1.Text == pass && cb1.SelectedItem.ToString() == "ADMIN")
            {
                Form frm_admindashboard = new frm_admindashboard(tid);
                frm_admindashboard.Show();

            }
            else if (textBox1.Text != "0" && cb1.SelectedItem.ToString() == "STUDENT")
            {

                con.Open();
                cmd = new SqlCommand("select * from studentinfo where sid=" + textBox1.Text + ";", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr[0].ToString() != "")
                            sid = Convert.ToInt32(dr[0].ToString());
                    }
                }
                dr.Close();
                con.Close();
                Form frm_studentlogin = new frm_studentlogin(sid);
                frm_studentlogin.Show();

            }
            else if (textBox2.Text != "0" && cb1.SelectedItem.ToString() == "TEACHER")
            {
                con.Open();
                cmd = new SqlCommand("Select tid from teachersinfo where tid=" + textBox2.Text + ";", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr[0].ToString() != "")
                            tid = Convert.ToInt32(dr[0].ToString());
                    }
                }
                dr.Close();
                con.Close();
                Form frm_teacherlogin = new frm_teacherlogin(tid);
                frm_teacherlogin.Show();

            }
            else
                MessageBox.Show("TRY AGAIN!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}