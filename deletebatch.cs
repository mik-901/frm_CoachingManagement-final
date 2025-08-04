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
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace frm_CoachingManagement
{
    public partial class deletebatch : Form
    {
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataReader dr;
        System.Data.SqlClient.SqlCommand cmd;
        System.Data.SqlClient.SqlCommand cmd1;
        System.Data.SqlClient.SqlCommand cmd2;
        public deletebatch()
        {
            InitializeComponent();
        }

        private void deletebatch_Load(object sender, EventArgs e)
        {
            label1.Enabled = false;
            con = new SqlConnection("Data Source=LAPTOP-P5QBDL1O\\SQLEXPRESS;Initial Catalog=coaching;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("Select cname from courseinfo", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());

            }
            comboBox1.Text = "";
            dr.Close();
            con.Close();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sql1 = 0;
            con.Open();
            cmd = new SqlCommand("select cid from courseinfo where cname='" + comboBox1.SelectedItem.ToString() + "';", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sql1 = Convert.ToInt32(dr[0].ToString());
            }
            label3.Text = sql1.ToString();
            dr.Close();
            cmd = new SqlCommand("Select bid from batchinfo where cid=" + sql1 + ";", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
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
                ttid = Convert.ToInt32(dr[0].ToString());
                cmd1 = new SqlCommand("delete from tdetails where ttid=" + ttid + ";", con);
                cmd1.ExecuteNonQuery();
                cmd2 = new SqlCommand("delete from testinfo where ttid=" + ttid + ";", con);
                cmd2.ExecuteNonQuery();
            }
            dr.Close();
            cmd = new SqlCommand("select aid from attendance, batchinfo where batchinfo.bid=" + comboBox2.SelectedItem.ToString() + " and batchinfo.bid=attendance.bid;", con);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
