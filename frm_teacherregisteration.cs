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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frm_CoachingManagement
{
    public partial class frm_teacherregisteration : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        public frm_teacherregisteration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cid = 100,bid=0;
            int ind = 0;
            int r;
            string id1 = "select max(tid) from teachersinfo";
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
                cid = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            cmd = new SqlCommand("select bid from batchinfo where bid=" + comboBox2.SelectedItem.ToString() + ";", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bid = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            string sql2 = "insert into teachersinfo values(" + ind + ",'" + textbox1.Text + "'," + textBox2.Text + ",'"+textBox5.Text+"'," + cid+ ",'" +bid+ "'); ";
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
        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
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
                comboBox2.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_teacherregisteration_Load(object sender, EventArgs e)
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
    }
}
