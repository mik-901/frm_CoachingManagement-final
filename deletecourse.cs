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
    public partial class deletecourse : Form
    {
        int sql1 = 0, sql2 = 0, sql3 = 0;
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        public deletecourse()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();
            cmd = new SqlCommand("select cid from courseinfo where cname='" + comboBox1.SelectedItem.ToString() + "';", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sql1 = Convert.ToInt32(dr[0].ToString());
            }
            label3.Text = sql1.ToString();

            dr.Close();
            cmd = new SqlCommand("select sid from studentinfo where cid='" + sql1 + "';", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sql2 = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            cmd = new SqlCommand("select bid from batchinfo where cid='" + sql2 + "';", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sql3 = Convert.ToInt32(dr[0].ToString());
            }

            dr.Close();
            con.Close();
            cmd.Dispose();

        }

        private void deletecourse_Load(object sender, EventArgs e)
        {
            label3.Enabled = false;
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select cname from courseinfo", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
            comboBox1.Text = "";
            con.Close();
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r, aid = 0, ttid = 0;
            int p = 0;
            con.Open();
            cmd = new SqlCommand("select ttid from testinfo, batchinfo where batchinfo.cid=" + sql1 + " and batchinfo.bid=testinfo.bid;", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ttid = Convert.ToInt32(dr[0].ToString());
                cmd = new SqlCommand("delete from tdetails where aid=" + ttid + ";", con);
                r = cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from testinfo where aid=" + ttid + ";", con);
                r = cmd.ExecuteNonQuery();

            }
            dr.Close();
            cmd = new SqlCommand("select aid from attendance, batchinfo where batchinfo.cid=" + sql1 + " and batchinfo.bid=attendance.bid;", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                aid = Convert.ToInt32(dr[0].ToString());
                cmd = new SqlCommand("delete from adetails where aid=" + aid + ";", con);
                r = cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from attendance where aid=" + aid + ";", con);
                r = cmd.ExecuteNonQuery();

            }
            dr.Close();
            cmd = new SqlCommand("delete from studentinfo where cid=" + sql1 + ";", con);
            r = cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from teachersinfo where cid=" + sql1 + ";", con);
            r = cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from batchinfo where cid=" + sql1 + ";", con);
            r = cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from courseinfo where cid=" + sql1 + ";", con);
            r = cmd.ExecuteNonQuery();
            if (r == 0)
                p = -1;
            if (p == -1)
                MessageBox.Show("ERROR OCCURED!");
            else
                MessageBox.Show("DELETED");

            con.Close();
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
