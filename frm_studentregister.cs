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
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;


namespace frm_CoachingManagement
{
    public partial class frm_studentregister : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        public frm_studentregister()
        {
            InitializeComponent();
        }


        private void frm_studentregister_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select cname from courseinfo", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() != "")
                {
                    comboBox1.Items.Add(dr[0].ToString());
                }
            }
            comboBox1.Text = "";
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sql1 = 100;
            int ind = 0;
            int r;
            string id1 = "select max(sid) from studentinfo";
            con.Open();
            cmd = new SqlCommand(id1, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[0].ToString() != "")
                    ind = Convert.ToInt32(dr[0].ToString());
            }
            ind++;
            dr.Close();
            cmd = new SqlCommand("select cid from courseinfo where cname='" + comboBox1.SelectedItem.ToString() + "';", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sql1 = Convert.ToInt32(dr[0].ToString());

            }
            dr.Close();
            string sql2 = "insert into studentinfo values(" + ind + "," + sql1 + "," + comboBox4.SelectedItem.ToString() + ",'" + textbox1.Text + "','" + textBox2.Text + "','" + comboBox2.SelectedItem.ToString() + "'," + "'" + comboBox3.SelectedItem.ToString() + "'," + textBox3.Text + ");";
            cmd = new SqlCommand(sql2, con);
            r = cmd.ExecuteNonQuery();
            if (r != 0)
            {
                MessageBox.Show("INSERTED!");
            }
            else
            {
                MessageBox.Show("ERROR OCCURED!");
            }
            con.Close();
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = 100;
            string s = "Select cid from courseinfo where cname='" + comboBox1.SelectedItem.ToString() + "';";
            con.Open();
            cmd = new SqlCommand(s, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ind = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            cmd = new SqlCommand("Select bid from batchinfo where cid=" + ind + ";", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}

