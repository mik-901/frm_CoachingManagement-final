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
    public partial class deletebatch1 : Form
    {
        System.Data.SqlClient.SqlConnection con, con1, con2;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        public deletebatch1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cid = 0;
            cmd = new SqlCommand("select cid from courseinfo where cname='" + comboBox1.SelectedItem.ToString() + "';", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cid = Convert.ToInt32(dr[0].ToString());
            }
            label3.Text = cid.ToString();
            dr.Close();
            cmd = new SqlCommand("Select bid from batchinfo where cid=" + cid + ";", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void deletebatch1_Load(object sender, EventArgs e)
        {
            label3.Enabled = false;
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            con1 = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            con2 = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            cmd = new SqlCommand("Select cname from courseinfo", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
            comboBox1.Text = "";
            dr.Close();
            con.Close();
            cmd.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r, aid = 0, ttid = 0;
            int p = 0;
            con.Open();
            cmd = new SqlCommand("select ttid from testinfo, batchinfo where batchinfo.bid=" + comboBox2.SelectedItem.ToString() + " and batchinfo.bid=testinfo.bid;", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                con1.Open();
                ttid = Convert.ToInt32(dr[0].ToString());
                cmd = new SqlCommand("delete from tdetails where ttid=" + ttid + ";", con1);
                r = cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from testinfo where ttid=" + ttid + ";", con1);
                r = cmd.ExecuteNonQuery();
            }
            dr.Close();
            con1.Close();
            cmd.Dispose();
            cmd = new SqlCommand("select aid from attendance, batchinfo where batchinfo.bid=" + comboBox2.SelectedItem.ToString() + " and batchinfo.bid=attendance.bid;", con);
            dr = cmd.ExecuteReader();
            con2.Open();
            while (dr.Read())
            {

                aid = Convert.ToInt32(dr[0].ToString());
                cmd = new SqlCommand("delete from adetails where aid=" + aid + ";", con2);
                r = cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from attendance where aid=" + aid + ";", con2);
                r = cmd.ExecuteNonQuery();

            }
            dr.Close();
            con2.Close();
            cmd.Dispose();
            cmd = new SqlCommand("delete from studentinfo where bid=" + comboBox2.SelectedItem.ToString() + ";", con);
            r = cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from teachersinfo where bid=" + comboBox2.SelectedItem.ToString() + ";", con);
            r = cmd.ExecuteNonQuery();
            cmd = new SqlCommand("delete from batchinfo where bid=" + comboBox2.SelectedItem.ToString() + ";", con);
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
